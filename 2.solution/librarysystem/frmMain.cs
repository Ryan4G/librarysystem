using librarysystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarysystem
{
    public partial class frmMain : Form
    {
        private frmLogin loginDialog = null;
        private frmUser userDialog = null;
        private frmAdmin adminDialog = null;
        private frmBookReturn bookReturnDialog = null;

        private DBHelper dbHelper = new DBHelper();

        public DBHelper DataHelper
        {
            get
            {
                return this.dbHelper;
            }
        }

        public frmMain()
        {
            InitializeComponent();
            loginDialog = new frmLogin(this.DataHelper);
            userDialog = new frmUser(this.DataHelper);
            adminDialog = new frmAdmin(this.DataHelper);
            bookReturnDialog = new frmBookReturn(this.DataHelper);

            // 显示时间
            this.Load += delegate
            {
                Timer timer = new Timer();

                timer.Interval = 500;

                timer.Tick += delegate
                {
                    this.lblSystemTime.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
                };

                timer.Start();
            };
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (this.dbHelper.CurrentUser.isUserLogin)
            {
                bookReturnDialog.ShowDialog();
            }
            else
            {
                if(loginDialog.ShowDialog() == DialogResult.OK)
                {
                    this.dbHelper.CurrentUser.isUserLogin = true;
                    bookReturnDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("还书操作需要先登录账户！", "操作提示");
                }
            }

            lblLoginStatus.Text = string.Format("状态：{0} {1}", this.dbHelper.CurrentUser.isUserLogin ? "已登录" : "未登录",
               this.dbHelper.CurrentUser.isUserLogin ? (this.dbHelper.CurrentUser.isAdminRole ? "（管理员）" : "（用户）") : "");
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            if (!this.dbHelper.CurrentUser.isUserLogin)
            {
                if (loginDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("用户管理需要先登录账户！", "操作提示");
                }
                else
                {
                    this.dbHelper.CurrentUser.isUserLogin = true;
                }
            }
            else
            {
                if (this.dbHelper.CurrentUser.isAdminRole)
                {
                    adminDialog.ShowDialog();
                }
                else
                {
                    userDialog.ShowDialog();
                }
            }

            lblLoginStatus.Text = string.Format("状态：{0} {1}", this.dbHelper.CurrentUser.isUserLogin ? "已登录" : "未登录",
               this.dbHelper.CurrentUser.isUserLogin ? (this.dbHelper.CurrentUser.isAdminRole ? "（管理员）" : "（用户）") : "");
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string keywords = txtSearchKeywords.Text.Trim();
            if (string.IsNullOrEmpty(keywords))
            {
                MessageBox.Show("关键字不能为空", "操作提示");
                return;
            }

            DataSetLibrarySystem.bookDataTable dtBook = new DataSetLibrarySystem.bookDataTable();
            string query = string.Format(" WHERE title LIKE '%{0}%' OR author LIKE '%{0}%' ", keywords);

            if (this.dbHelper.DataSetBookFill(dtBook, query) >= 0)
            {
                this.lblOperateInfo.Text = string.Format("查询结果：符合要求记录共 {0} 条。", dtBook.Count);

                this.btnBorrowBook.Enabled = false;
                this.lblBookInfos.Text = "";
                this.dgvBookList.SuspendLayout();
                this.dgvBookList.ClearSelection();
                this.dgvBookList.Rows.Clear();

                DataSetLibrarySystem.bookRow currentBook = dtBook.NewbookRow();
                for (int i = 0; i < dtBook.Rows.Count; i++)
                {
                    currentBook = (DataSetLibrarySystem.bookRow)dtBook.Rows[i];
                    this.dgvBookList.Rows.Add();
                    this.dgvBookList.Rows[i].Cells["colBID"].Value = currentBook.b_id.ToString();
                    this.dgvBookList.Rows[i].Cells["colTitle"].Value = currentBook.title.ToString();
                    this.dgvBookList.Rows[i].Cells["colAuthor"].Value = currentBook.author.ToString();
                    this.dgvBookList.Rows[i].Cells["colPress"].Value = currentBook.presscompany.ToString();
                    this.dgvBookList.Rows[i].Cells["colCategory"].Value = currentBook.category.ToString();
                    this.dgvBookList.Rows[i].Cells["colPublishDate"].Value = currentBook.publishdate.ToString();
                    this.dgvBookList.Rows[i].Cells["colCount"].Value = currentBook.count.ToString();
                    this.dgvBookList.Rows[i].Cells["colPosition"].Value = currentBook.position.ToString();
                    this.dgvBookList.Rows[i].Cells["colAbstract"].Value = currentBook._abstract.ToString();
                }

                this.dgvBookList.ResumeLayout();
            }
            else
            {
                this.lblOperateInfo.Text = "查询失败，原因：系统操作发生错误。";
            }

        }
        
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            if (!this.dbHelper.CurrentUser.isUserLogin)
            {
                if (loginDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("借书操作需要先登录账户！", "操作提示");
                }
                else
                {
                    this.dbHelper.CurrentUser.isUserLogin = true;
                }

                lblLoginStatus.Text = string.Format("状态：{0} {1}", this.dbHelper.CurrentUser.isUserLogin ? "已登录" : "未登录",
                   this.dbHelper.CurrentUser.isUserLogin ? (this.dbHelper.CurrentUser.isAdminRole ? "（管理员）" : "（用户）") : "");
            }

            if (this.dbHelper.CurrentUser.isUserLogin && this.dgvBookList.SelectedRows.Count > 0)
            {
                string bookId = this.dgvBookList.SelectedRows[0].Cells["colBID"].Value.ToString();
                int bookCount = 0;
                if (!int.TryParse(this.dgvBookList.SelectedRows[0].Cells["colCount"].Value.ToString(), out bookCount))
                {
                    bookCount = 0;
                }

                // 查询书籍是否被借完
                DataSetLibrarySystem.borrow_recordDataTable dtBorrowRecord = new DataSetLibrarySystem.borrow_recordDataTable();
                string query = string.Format(" WHERE b_id = {0} ", bookId);
                if (this.dbHelper.DataSetBorrowRecordFill(dtBorrowRecord, query) >= 0)
                {
                    int borrowOutCount = 0;
                    foreach(DataSetLibrarySystem.borrow_recordRow row in dtBorrowRecord.Rows)
                    {
                        borrowOutCount += row.borrowcount;
                    }

                    if (borrowOutCount >= bookCount)
                    {
                        MessageBox.Show("该书籍在馆藏本均已借出，暂时无法借阅", "操作提示");
                        return;
                    }

                    // 可借阅，查询账户是否欠费
                    query = string.Format(" WHERE uid = {0} ", this.dbHelper.CurrentUser.uid);
                    // 逾期费用
                    float borrowFee = 0;
                    // 是否逾期
                    bool outOfDate = false;
                    // 是否已经借阅该书
                    bool alreadyHave = false;

                    if (this.dbHelper.DataSetBorrowRecordFill(dtBorrowRecord, query) > 0)
                    {
                        foreach(DataSetLibrarySystem.borrow_recordRow row in dtBorrowRecord.Rows)
                        {
                            int outDateCount = (DateTime.Now - row.validdate).Days;
                            if (outDateCount > 0)
                            {
                                outOfDate = true;

                                // 逾期费用：1元/天/本
                                borrowFee += Math.Abs(outDateCount) * 1.0f;
                                // 修改费用
                                row.fee = Convert.ToDecimal(Math.Abs(outDateCount) * 1.0f);
                                row.status = "逾期";
                            }

                            if (row.b_id.ToString() == bookId)
                            {
                                alreadyHave = true;
                            }
                        }
                    }

                    // 逾期提醒
                    if (outOfDate)
                    {
                        MessageBox.Show(string.Format("您的账户内存在逾期费用未结算，共 {0} 元，暂时无法借阅", borrowFee.ToString("F2")), "操作提示");
                        return;
                    }

                    // 已借阅
                    if (alreadyHave)
                    {
                        MessageBox.Show("您的已经借阅了该书，尚未归还，如需续借请前往[用户管理]操作", "操作提示");
                        return;
                    }

                    // 符合借阅条件
                    dtBorrowRecord.Clear();
                    DataSetLibrarySystem.borrow_recordRow newBorrowRecord = dtBorrowRecord.Newborrow_recordRow();
                    newBorrowRecord.uid = this.dbHelper.CurrentUser.uid;
                    newBorrowRecord.b_id = int.Parse(bookId);
                    newBorrowRecord.borrowcount = 1;
                    newBorrowRecord.borrowdate = DateTime.Now;
                    // 借阅期限1个月
                    newBorrowRecord.returndate = newBorrowRecord.validdate = DateTime.Now.AddMonths(1);
                    newBorrowRecord.status = "正常";
                    newBorrowRecord.fee = 0;
                    newBorrowRecord.reborrow = 0;

                    dtBorrowRecord.Rows.Add(newBorrowRecord.ItemArray);

                    if (this.dbHelper.UpdateTableBorrowRecord(dtBorrowRecord) >= 0)
                    {
                        MessageBox.Show("书籍借阅成功！", "操作提示");
                    }
                    else
                    {
                        MessageBox.Show("书籍借阅失败，系统操作存在问题，请联系管理员处理！", "操作提示");
                    }
                }
            }
        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.lblBookInfos.Text = "";
                string bookInfos = "书籍信息\n\n标题：{0}\n作者：{1}\n出版社：{2}\n出版时间：{3}\n所属类别：{4}\n馆藏数量：{5}\n在馆位置：{6}\n摘要：\n{7}";

                this.lblBookInfos.Text = string.Format(bookInfos,
                    this.dgvBookList.Rows[e.RowIndex].Cells["colTitle"].Value,
                    this.dgvBookList.Rows[e.RowIndex].Cells["colAuthor"].Value,
                    this.dgvBookList.Rows[e.RowIndex].Cells["colPress"].Value,
                    this.dgvBookList.Rows[e.RowIndex].Cells["colPublishDate"].Value,
                    this.dgvBookList.Rows[e.RowIndex].Cells["colCategory"].Value,
                    this.dgvBookList.Rows[e.RowIndex].Cells["colCount"].Value,
                    this.dgvBookList.Rows[e.RowIndex].Cells["colPosition"].Value,
                    this.dgvBookList.Rows[e.RowIndex].Cells["colAbstract"].Value);

                this.btnBorrowBook.Enabled = true;
            }
        }
    }
}
