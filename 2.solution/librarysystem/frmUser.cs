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
    public partial class frmUser : Form
    {
        private DBHelper _dbHelper;
        public frmUser(DBHelper dbHelper)
        {
            InitializeComponent();
            this._dbHelper = dbHelper;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this._dbHelper.CurrentUser.uid = 0;
            this._dbHelper.CurrentUser.name = "";
            this._dbHelper.CurrentUser.account = "";
            this._dbHelper.CurrentUser.isUserLogin = false;
            this._dbHelper.CurrentUser.isAdminRole = false;

            this.Close();
        }

        private void btnBorrowAgain_Click(object sender, EventArgs e)
        {
            if (this.dgvBorrowList.SelectedRows.Count > 0)
            {
                float fee = Convert.ToSingle(this.dgvBorrowList.SelectedRows[0].Cells["colFee"].Value.ToString());

                if (fee > 0)
                {
                    MessageBox.Show("该书已逾期，需先结算费用后才能续借，请联系管理员", "操作提示");
                    return;
                }

                int reborrow = 0;
                if (!int.TryParse(this.dgvBorrowList.SelectedRows[0].Cells["colReborrow"].Value.ToString(), out reborrow))
                {
                    reborrow = 0;
                }

                // 仅允许续借一次
                if (reborrow >= 1)
                {
                    MessageBox.Show("该书已续借一次，请先归还后再借出", "操作提示");
                    return;
                }

                string bookID = this.dgvBorrowList.SelectedRows[0].Cells["colBID"].Value.ToString();
                DataSetLibrarySystem.borrow_recordDataTable dtBorrowRecord = new DataSetLibrarySystem.borrow_recordDataTable();
                string query = string.Format(" WHERE b_id = {0} ", bookID);

                if (this._dbHelper.DataSetBorrowRecordFill(dtBorrowRecord, query) > 0)
                {
                    // 续借1个月
                    dtBorrowRecord[0].returndate = dtBorrowRecord[0].validdate = dtBorrowRecord[0].validdate.AddMonths(1);
                    dtBorrowRecord[0].reborrow += 1;

                    if (this._dbHelper.UpdateTableBorrowRecord(dtBorrowRecord) >= 0)
                    {
                        MessageBox.Show("续借成功", "操作提示");
                        RefreshBorrowRecord();
                    }
                    else
                    {
                        MessageBox.Show("续借失败，原因：系统操作存在问题，请联系管理员处理", "操作提示");
                    }
                }
            }
        }

        private void dgvBorrowList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.btnBorrowAgain.Enabled = true;
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            if (this._dbHelper != null && this._dbHelper.CurrentUser.isUserLogin)
            {
                RefreshBorrowRecord();
            }

        }

        private void RefreshBorrowRecord()
        {
            this.dgvBorrowList.ClearSelection();
            this.btnBorrowAgain.Enabled = false;

            string userInfo = "用户信息\n\n欢迎您，{0}\n账户：{1}\n待还书籍：{2} 本\n逾期费用：共 {3} 元";

            // 查询借阅书籍
            DataSetLibrarySystem.borrow_recordDataTable dtBorrowRecord = new DataSetLibrarySystem.borrow_recordDataTable();
            string query = string.Format(" WHERE uid = {0} ", this._dbHelper.CurrentUser.uid);
            // 逾期费用
            float borrowFee = 0;
            // 是否逾期
            bool outOfDate = false;
            if (this._dbHelper.DataSetBorrowRecordFill(dtBorrowRecord, query) >= 0)
            {
                //this.lblOperateInfo.Text = string.Format("查询结果： 共找到 {0} 条借阅记录。", dtBorrowRecord.Count);
                int bookIndex = 0;

                this.dgvBorrowList.SuspendLayout();
                this.dgvBorrowList.Rows.Clear();

                foreach (DataSetLibrarySystem.borrow_recordRow row in dtBorrowRecord.Rows)
                {
                    this.dgvBorrowList.Rows.Add();

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

                    this.dgvBorrowList.Rows[bookIndex].Cells["colBID"].Value = row.b_id;

                    // 书籍信息
                    DataSetLibrarySystem.bookDataTable dtCurrentBook = new DataSetLibrarySystem.bookDataTable();
                    query = string.Format(" WHERE b_id = {0} ", row.b_id);
                    if (this._dbHelper.DataSetBookFill(dtCurrentBook, query) > 0)
                    {
                        this.dgvBorrowList.Rows[bookIndex].Cells["colTitle"].Value = dtCurrentBook[0].title;
                        this.dgvBorrowList.Rows[bookIndex].Cells["colAuthor"].Value = dtCurrentBook[0].author;
                    }
                    else
                    {
                        this.dgvBorrowList.Rows[bookIndex].Cells["colTitle"].Value = "未知";
                        this.dgvBorrowList.Rows[bookIndex].Cells["colAuthor"].Value = "未知";
                    }

                    this.dgvBorrowList.Rows[bookIndex].Cells["colBorrowCount"].Value = row.borrowcount;
                    this.dgvBorrowList.Rows[bookIndex].Cells["colBorrowDate"].Value = row.borrowdate.ToString("yyyy-MM-dd");
                    this.dgvBorrowList.Rows[bookIndex].Cells["colValidDate"].Value = row.validdate.ToString("yyyy-MM-dd");
                    this.dgvBorrowList.Rows[bookIndex].Cells["colFee"].Value = row.fee.ToString("F2");
                    this.dgvBorrowList.Rows[bookIndex].Cells["colReborrow"].Value = row.reborrow;

                    bookIndex++;
                }

                this.dgvBorrowList.ResumeLayout();
            }
            else
            {
                //this.lblOperateInfo.Text = "查询失败，原因：系统操作发生错误。";
            }

            lblUserInfo.Text = string.Format(userInfo,
                this._dbHelper.CurrentUser.name,
                this._dbHelper.CurrentUser.account,
                dtBorrowRecord.Count,
                borrowFee.ToString("F2"));
        }
    }
}
