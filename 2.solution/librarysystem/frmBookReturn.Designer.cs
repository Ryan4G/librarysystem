namespace librarysystem
{
    partial class frmBookReturn
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBorrowList = new System.Windows.Forms.DataGridView();
            this.colBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblOperateInfo = new System.Windows.Forms.Label();
            this.numReturnCount = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReturnCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.dgvBorrowList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvBorrowList
            // 
            this.dgvBorrowList.AllowUserToAddRows = false;
            this.dgvBorrowList.AllowUserToDeleteRows = false;
            this.dgvBorrowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBID,
            this.colTitle,
            this.colAuthor,
            this.colBorrowCount,
            this.colBorrowDate,
            this.colValidDate,
            this.colFee});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvBorrowList, 3);
            this.dgvBorrowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowList.Location = new System.Drawing.Point(3, 103);
            this.dgvBorrowList.Name = "dgvBorrowList";
            this.dgvBorrowList.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvBorrowList, 2);
            this.dgvBorrowList.RowTemplate.Height = 23;
            this.dgvBorrowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowList.Size = new System.Drawing.Size(778, 385);
            this.dgvBorrowList.TabIndex = 16;
            this.dgvBorrowList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowList_CellClick);
            // 
            // colBID
            // 
            this.colBID.HeaderText = "书籍编号";
            this.colBID.Name = "colBID";
            this.colBID.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "书籍标题";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colAuthor
            // 
            this.colAuthor.HeaderText = "作者";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            // 
            // colBorrowCount
            // 
            this.colBorrowCount.HeaderText = "借出数量";
            this.colBorrowCount.Name = "colBorrowCount";
            this.colBorrowCount.ReadOnly = true;
            // 
            // colBorrowDate
            // 
            this.colBorrowDate.HeaderText = "借出时间";
            this.colBorrowDate.Name = "colBorrowDate";
            this.colBorrowDate.ReadOnly = true;
            // 
            // colValidDate
            // 
            this.colValidDate.HeaderText = "应还时间";
            this.colValidDate.Name = "colValidDate";
            this.colValidDate.ReadOnly = true;
            // 
            // colFee
            // 
            this.colFee.HeaderText = "逾期费用";
            this.colFee.Name = "colFee";
            this.colFee.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(525, 494);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(256, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBookID, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAccount, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAccount, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBookID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnReturnBook, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnRefreshList, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblOperateInfo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numReturnCount, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 100);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(523, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "归还数量";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookID
            // 
            this.txtBookID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBookID.Location = new System.Drawing.Point(393, 31);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(124, 21);
            this.txtBookID.TabIndex = 3;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccount.Location = new System.Drawing.Point(3, 28);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(124, 30);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "借书账户";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAccount
            // 
            this.txtAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAccount.Location = new System.Drawing.Point(133, 31);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(124, 21);
            this.txtAccount.TabIndex = 1;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookID.Location = new System.Drawing.Point(263, 28);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(124, 30);
            this.lblBookID.TabIndex = 2;
            this.lblBookID.Text = "书籍编号";
            this.lblBookID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnBook.Enabled = false;
            this.btnReturnBook.Location = new System.Drawing.Point(523, 61);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(124, 36);
            this.btnReturnBook.TabIndex = 6;
            this.btnReturnBook.Text = "还书";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefreshList.Location = new System.Drawing.Point(653, 61);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(128, 36);
            this.btnRefreshList.TabIndex = 7;
            this.btnRefreshList.Text = "刷新";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // lblOperateInfo
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lblOperateInfo, 4);
            this.lblOperateInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperateInfo.Font = new System.Drawing.Font("宋体", 12F);
            this.lblOperateInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOperateInfo.Location = new System.Drawing.Point(3, 58);
            this.lblOperateInfo.Name = "lblOperateInfo";
            this.lblOperateInfo.Size = new System.Drawing.Size(514, 42);
            this.lblOperateInfo.TabIndex = 8;
            this.lblOperateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numReturnCount
            // 
            this.numReturnCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numReturnCount.Location = new System.Drawing.Point(653, 33);
            this.numReturnCount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numReturnCount.Name = "numReturnCount";
            this.numReturnCount.ReadOnly = true;
            this.numReturnCount.Size = new System.Drawing.Size(128, 21);
            this.numReturnCount.TabIndex = 9;
            // 
            // frmBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmBookReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "还书操作";
            this.Load += new System.EventHandler(this.frmBookReturn_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReturnCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label lblOperateInfo;
        private System.Windows.Forms.NumericUpDown numReturnCount;
        private System.Windows.Forms.DataGridView dgvBorrowList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee;
    }
}

