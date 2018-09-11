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
    public partial class frmBookReturn : Form
    {
        private DBHelper _dbHelper;

        public frmBookReturn(DBHelper dbHelper)
        {
            InitializeComponent();
            this._dbHelper = dbHelper;
        }

        private void frmBookReturn_Load(object sender, EventArgs e)
        {
            if (this._dbHelper != null && this._dbHelper.CurrentUser.isUserLogin)
            {
                this.txtAccount.Text = this._dbHelper.CurrentUser.account;

                RefreshBorrowRecord();
            }
        }
        
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshBorrowRecord();
        }

        private void RefreshBorrowRecord()
        {
            this.dgvBorrowList.ClearSelection();
            this.btnReturnBook.Enabled = false;

            // 查询借阅书籍
            DataSetLibrarySystem.borrow_recordDataTable dtBorrowRecord = new DataSetLibrarySystem.borrow_recordDataTable();
            string query = string.Format(" WHERE uid = {0} ", this._dbHelper.CurrentUser.uid);
            if (this._dbHelper.DataSetBorrowRecordFill(dtBorrowRecord, query) >= 0)
            {
                this.lblOperateInfo.Text = string.Format("查询结果： 共找到 {0} 条借阅记录。", dtBorrowRecord.Count);
                // 逾期费用
                float borrowFee = 0;
                // 是否逾期
                bool outOfDate = false;
                int bookIndex = 0;

                this.dgvBorrowList.SuspendLayout();
                this.dgvBorrowList.Rows.Clear();
                this.txtBookID.Text = "";
                this.numReturnCount.Value = 0;

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
                    bookIndex++;
                }

                this.dgvBorrowList.ResumeLayout();
            }
            else
            {
                this.lblOperateInfo.Text = "查询失败，原因：系统操作发生错误。";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (this.dgvBorrowList.SelectedRows.Count > 0 && !string.IsNullOrEmpty(this.txtBookID.Text))
            {
                // 确认是否结算了逾期费用
                float fee = Convert.ToSingle(this.dgvBorrowList.SelectedRows[0].Cells["colFee"].Value.ToString());
                
                if (fee > 0)
                {
                    MessageBox.Show("该书已逾期，需先结算费用后才能归还，请联系管理员", "操作提示");
                    return;
                }

                DataSetLibrarySystem.borrow_recordDataTable dtBorrowRecord = new DataSetLibrarySystem.borrow_recordDataTable();
                string query = string.Format(" WHERE uid = {0} AND b_id = {1} ", this._dbHelper.CurrentUser.uid, this.txtBookID.Text.Trim());
                if (this._dbHelper.DataSetBorrowRecordFill(dtBorrowRecord, query) > 0)
                {
                    dtBorrowRecord[0].Delete();

                    if (this._dbHelper.UpdateTableBorrowRecord(dtBorrowRecord) >= 0)
                    {
                        MessageBox.Show("还书成功", "操作提示");
                        RefreshBorrowRecord();
                    }
                    else
                    {
                        MessageBox.Show("还书失败，原因：系统操作存在问题，请联系管理员处理", "操作提示");
                    }
                }
            }
        }

        private void dgvBorrowList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.btnReturnBook.Enabled = true;

                this.txtBookID.Text = this.dgvBorrowList.Rows[e.RowIndex].Cells["colBID"].Value.ToString();
                this.numReturnCount.Value = Convert.ToDecimal(this.dgvBorrowList.Rows[e.RowIndex].Cells["colBorrowCount"].Value.ToString());

            }
        }
    }
}
