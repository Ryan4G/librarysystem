namespace librarysystem
{
    partial class frmMain
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.colBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbstract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBookInfos = new System.Windows.Forms.Label();
            this.lblSystemLogo = new System.Windows.Forms.Label();
            this.lblOperateInfo = new System.Windows.Forms.Label();
            this.lblLoginStatus = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMain.Controls.Add(this.btnBorrowBook, 0, 4);
            this.tlpMain.Controls.Add(this.btnReturnBook, 1, 4);
            this.tlpMain.Controls.Add(this.btnUserInfo, 2, 4);
            this.tlpMain.Controls.Add(this.lblSystemTime, 2, 5);
            this.tlpMain.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tlpMain.Controls.Add(this.dgvBookList, 0, 3);
            this.tlpMain.Controls.Add(this.lblBookInfos, 2, 3);
            this.tlpMain.Controls.Add(this.lblSystemLogo, 0, 0);
            this.tlpMain.Controls.Add(this.lblOperateInfo, 0, 2);
            this.tlpMain.Controls.Add(this.lblLoginStatus, 0, 5);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Size = new System.Drawing.Size(784, 561);
            this.tlpMain.TabIndex = 0;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrowBook.Enabled = false;
            this.btnBorrowBook.Location = new System.Drawing.Point(3, 494);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(255, 34);
            this.btnBorrowBook.TabIndex = 1;
            this.btnBorrowBook.Text = "借书";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnBook.Location = new System.Drawing.Point(264, 494);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(255, 34);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "还书";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserInfo.Location = new System.Drawing.Point(525, 494);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(256, 34);
            this.btnUserInfo.TabIndex = 3;
            this.btnUserInfo.Text = "用户管理";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSystemTime.Location = new System.Drawing.Point(525, 531);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(256, 30);
            this.lblSystemTime.TabIndex = 0;
            this.lblSystemTime.Text = "2018年9月10日 17点47分";
            this.lblSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.tlpMain.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtSearchKeywords);
            this.flowLayoutPanel1.Controls.Add(this.btnSearchBook);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 30);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入书籍关键字：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(198, 3);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(368, 21);
            this.txtSearchKeywords.TabIndex = 1;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(572, 3);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "查询书籍";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBID,
            this.colTitle,
            this.colAuthor,
            this.colPress,
            this.colCategory,
            this.colPublishDate,
            this.colCount,
            this.colPosition,
            this.colAbstract});
            this.tlpMain.SetColumnSpan(this.dgvBookList, 2);
            this.dgvBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookList.Location = new System.Drawing.Point(3, 123);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.RowTemplate.Height = 23;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(516, 365);
            this.dgvBookList.TabIndex = 16;
            this.dgvBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellClick);
            // 
            // colBID
            // 
            this.colBID.HeaderText = "书籍 ID";
            this.colBID.Name = "colBID";
            this.colBID.ReadOnly = true;
            this.colBID.Visible = false;
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
            // colPress
            // 
            this.colPress.HeaderText = "出版社";
            this.colPress.Name = "colPress";
            this.colPress.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "类别";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colPublishDate
            // 
            this.colPublishDate.HeaderText = "出版时间";
            this.colPublishDate.Name = "colPublishDate";
            this.colPublishDate.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "数量";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "在馆位置";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colAbstract
            // 
            this.colAbstract.HeaderText = "摘要";
            this.colAbstract.Name = "colAbstract";
            this.colAbstract.ReadOnly = true;
            // 
            // lblBookInfos
            // 
            this.lblBookInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookInfos.Location = new System.Drawing.Point(525, 120);
            this.lblBookInfos.Name = "lblBookInfos";
            this.lblBookInfos.Size = new System.Drawing.Size(256, 371);
            this.lblBookInfos.TabIndex = 17;
            // 
            // lblSystemLogo
            // 
            this.tlpMain.SetColumnSpan(this.lblSystemLogo, 3);
            this.lblSystemLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSystemLogo.Font = new System.Drawing.Font("宋体", 18F);
            this.lblSystemLogo.Location = new System.Drawing.Point(3, 0);
            this.lblSystemLogo.Name = "lblSystemLogo";
            this.lblSystemLogo.Size = new System.Drawing.Size(778, 60);
            this.lblSystemLogo.TabIndex = 18;
            this.lblSystemLogo.Text = "图书馆书籍借还管理系统";
            this.lblSystemLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperateInfo
            // 
            this.tlpMain.SetColumnSpan(this.lblOperateInfo, 3);
            this.lblOperateInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperateInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOperateInfo.Location = new System.Drawing.Point(3, 90);
            this.lblOperateInfo.Name = "lblOperateInfo";
            this.lblOperateInfo.Size = new System.Drawing.Size(778, 30);
            this.lblOperateInfo.TabIndex = 19;
            this.lblOperateInfo.Text = "查询结果：";
            this.lblOperateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoginStatus.Location = new System.Drawing.Point(3, 531);
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.Size = new System.Drawing.Size(255, 30);
            this.lblLoginStatus.TabIndex = 20;
            this.lblLoginStatus.Text = "状态：未登录";
            this.lblLoginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tlpMain);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书馆书籍借还管理系统";
            this.tlpMain.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Label lblBookInfos;
        private System.Windows.Forms.Label lblSystemLogo;
        private System.Windows.Forms.Label lblOperateInfo;
        private System.Windows.Forms.Label lblLoginStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbstract;
    }
}

