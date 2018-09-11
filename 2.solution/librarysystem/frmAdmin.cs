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
    public partial class frmAdmin : Form
    {
        private DBHelper _dbHelper;
        public frmAdmin(DBHelper dbHelper)
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

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            if (this.dgvBookList.SelectedRows.Count > 0)
            {
                // 检查是否漏填信息
                if (!CheckPanelTextBoxFill())
                {
                    MessageBox.Show("请填写完整书籍信息", "操作提示");
                    return;
                }

                DataSetLibrarySystem.bookDataTable dtBooks = new DataSetLibrarySystem.bookDataTable();
                DataSetLibrarySystem.bookRow newBook = dtBooks.NewbookRow();

                newBook.b_id = -1;
                newBook.title = this.txtTitle.Text.Trim();
                newBook.author = this.txtAuthor.Text.Trim();
                newBook.presscompany = this.txtPress.Text.Trim();
                newBook.category = this.txtCategory.Text.Trim();
                newBook.publishdate = this.dtpPublishDate.Value;
                newBook.inlibdate = this.dtpInlabDate.Value;
                newBook.count = Convert.ToInt32(this.numCount.Value);
                newBook.position = this.txtPosition.Text.Trim();
                newBook._abstract = this.txtAbstract.Text.Trim();
                newBook.isbn = this.txtISBN.Text.Trim();
                newBook.imageurl = "";
                newBook.bookremark = "";

                dtBooks.Rows.Add(newBook.ItemArray);

                if (this._dbHelper.UpdateTableBook(dtBooks) > 0)
                {
                    MessageBox.Show("书籍新增成功", "操作提示");
                    RefreshBookList();
                    EmptyPanelTextBox();
                }
                else
                {
                    MessageBox.Show("书籍新增失败，原因：系统操作存在问题", "操作提示");
                }
            }
        }

        private void btnBookModify_Click(object sender, EventArgs e)
        {
            if (this.dgvBookList.SelectedRows.Count > 0)
            {
                // 检查是否漏填信息
                if (!CheckPanelTextBoxFill())
                {
                    MessageBox.Show("请填写完整书籍信息", "操作提示");
                    return;
                }

                string bookID = this.dgvBookList.SelectedRows[0].Cells["colBID"].Value.ToString();

                DataSetLibrarySystem.bookDataTable dtBooks = new DataSetLibrarySystem.bookDataTable();
                string query = string.Format(" WHERE b_id = {0} ", bookID);
                if (this._dbHelper.DataSetBookFill(dtBooks, query) >= 0)
                {
                    dtBooks[0].title = this.txtTitle.Text.Trim();
                    dtBooks[0].author = this.txtAuthor.Text.Trim();
                    dtBooks[0].presscompany = this.txtPress.Text.Trim();
                    dtBooks[0].category = this.txtCategory.Text.Trim();
                    dtBooks[0].publishdate = this.dtpPublishDate.Value;
                    dtBooks[0].inlibdate = this.dtpInlabDate.Value;
                    dtBooks[0].count = Convert.ToInt32(this.numCount.Value);
                    dtBooks[0].position = this.txtPosition.Text.Trim();
                    dtBooks[0]._abstract = this.txtAbstract.Text.Trim();
                    dtBooks[0].isbn = this.txtISBN.Text.Trim();

                    if (this._dbHelper.UpdateTableBook(dtBooks) > 0)
                    {
                        MessageBox.Show("书籍修改成功", "操作提示");
                        RefreshBookList();
                    }
                    else
                    {
                        MessageBox.Show("书籍修改失败，原因：系统操作存在问题", "操作提示");
                    }
                }
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvBookList.SelectedRows.Count > 0)
            {
                string bookID = this.dgvBookList.SelectedRows[0].Cells["colBID"].Value.ToString();

                DataSetLibrarySystem.bookDataTable dtBooks = new DataSetLibrarySystem.bookDataTable();
                string query = string.Format(" WHERE b_id = {0} ", bookID);
                if (this._dbHelper.DataSetBookFill(dtBooks, query) >= 0)
                {
                    dtBooks[0].Delete();

                    if (this._dbHelper.UpdateTableBook(dtBooks) >= 0)
                    {
                        MessageBox.Show("书籍删除成功", "操作提示");
                        RefreshBookList();
                        EmptyPanelTextBox();
                    }
                    else
                    {
                        MessageBox.Show("书籍删除失败，原因：系统操作存在问题", "操作提示");
                    }
                }
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshBookList();
            EmptyPanelTextBox();
        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.btnBookDelete.Enabled = true;
                this.btnBookModify.Enabled = true;
                
                this.txtISBN.Text = this.dgvBookList.Rows[e.RowIndex].Cells["colISBN"].Value.ToString().Trim();
                this.txtTitle.Text = this.dgvBookList.Rows[e.RowIndex].Cells["colTitle"].Value.ToString().Trim();
                this.txtAuthor.Text = this.dgvBookList.Rows[e.RowIndex].Cells["colAuthor"].Value.ToString().Trim();
                this.txtPress.Text = this.dgvBookList.Rows[e.RowIndex].Cells["colPress"].Value.ToString().Trim();
                this.txtCategory.Text = this.dgvBookList.Rows[e.RowIndex].Cells["colCategory"].Value.ToString().Trim();
                this.dtpPublishDate.Value = DateTime.Parse(this.dgvBookList.Rows[e.RowIndex].Cells["colPublishDate"].Value.ToString());
                this.dtpInlabDate.Value = DateTime.Parse(this.dgvBookList.Rows[e.RowIndex].Cells["colInlabDate"].Value.ToString());
                this.numCount.Value = Convert.ToDecimal(this.dgvBookList.Rows[e.RowIndex].Cells["colCount"].Value.ToString());
                this.txtPosition.Text = this.dgvBookList.Rows[e.RowIndex].Cells["colPosition"].Value.ToString().Trim();
                this.txtAbstract.Text = this.dgvBookList.Rows[e.RowIndex].Cells["colAbstract"].Value.ToString().Trim();
            }
        }
        private void RefreshBookList()
        {
            string userInfo = "管理员信息\n\n欢迎您，{0}\n账户：{1}\n馆藏书籍：{2} 本\n已借出书籍：{3} 本";

            this.dgvBookList.ClearSelection();
            this.btnBookDelete.Enabled = false;
            this.btnBookModify.Enabled = false;

            int booksCount = 0;
            int borrowedCount = 0;

            // 查询借阅书籍
            DataSetLibrarySystem.bookDataTable dtBooks = new DataSetLibrarySystem.bookDataTable();
            string query = "";
            if (this._dbHelper.DataSetBookFill(dtBooks, query) >= 0)
            {
                //this.lblOperateInfo.Text = string.Format("查询结果： 共找到 {0} 条借阅记录。", dtBorrowRecord.Count);
                int bookIndex = 0;

                this.dgvBookList.SuspendLayout();
                this.dgvBookList.Rows.Clear();

                foreach (DataSetLibrarySystem.bookRow row in dtBooks.Rows)
                {
                    this.dgvBookList.Rows.Add();
                    this.dgvBookList.Rows[bookIndex].Cells["colBID"].Value = row.b_id;
                    this.dgvBookList.Rows[bookIndex].Cells["colTitle"].Value = row.title;
                    this.dgvBookList.Rows[bookIndex].Cells["colAuthor"].Value = row.author;
                    this.dgvBookList.Rows[bookIndex].Cells["colPress"].Value = row.presscompany;
                    this.dgvBookList.Rows[bookIndex].Cells["colCategory"].Value = row.category;
                    this.dgvBookList.Rows[bookIndex].Cells["colPublishDate"].Value = row.publishdate.ToString("yyyy-MM-dd");
                    this.dgvBookList.Rows[bookIndex].Cells["colInlabDate"].Value = row.inlibdate.ToString("yyyy-MM-dd");
                    this.dgvBookList.Rows[bookIndex].Cells["colCount"].Value = row.count;
                    this.dgvBookList.Rows[bookIndex].Cells["colPosition"].Value = row.position;
                    this.dgvBookList.Rows[bookIndex].Cells["colAbstract"].Value = row._abstract;
                    this.dgvBookList.Rows[bookIndex].Cells["colImageUrl"].Value = row.imageurl;
                    this.dgvBookList.Rows[bookIndex].Cells["colISBN"].Value = row.isbn;
                    bookIndex++;

                    // 书籍总量
                    booksCount += row.count;
                }

                this.dgvBookList.ResumeLayout();
            }
            else
            {
                //this.lblOperateInfo.Text = "查询失败，原因：系统操作发生错误。";
            }

            DataSetLibrarySystem.borrow_recordDataTable dtBorrowed = new DataSetLibrarySystem.borrow_recordDataTable();
            this._dbHelper.DataSetBorrowRecordFill(dtBorrowed);
            borrowedCount = dtBorrowed.Count;

            lblUserInfo.Text = string.Format(userInfo,
                this._dbHelper.CurrentUser.name,
                this._dbHelper.CurrentUser.account,
                booksCount,
                borrowedCount);
        }

        private void EmptyPanelTextBox()
        {
            foreach (Control ctl in this.tableLayoutPanel2.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctl).Text = "";
                }
            }
        }
        private bool CheckPanelTextBoxFill()
        {
            bool allFilled = true;
            foreach (Control ctl in this.tableLayoutPanel2.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrEmpty(((TextBox)ctl).Text))
                    {
                        allFilled = false;
                        ctl.Focus();
                        break;
                    }
                }
            }
            
            return allFilled;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            RefreshBookList();
        }
    }
}
