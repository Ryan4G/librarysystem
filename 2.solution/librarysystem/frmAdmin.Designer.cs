namespace librarysystem
{
    partial class frmAdmin
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblBreak = new System.Windows.Forms.Label();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnBookModify = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblBreak2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPress = new System.Windows.Forms.Label();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.lblInlabDate = new System.Windows.Forms.Label();
            this.dtpInlabDate = new System.Windows.Forms.DateTimePicker();
            this.lblCount = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.lblAbstract = new System.Windows.Forms.Label();
            this.txtAbstract = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.colBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInlabDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbstract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblUserInfo);
            this.flowLayoutPanel1.Controls.Add(this.lblBreak);
            this.flowLayoutPanel1.Controls.Add(this.btnBookAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnBookModify);
            this.flowLayoutPanel1.Controls.Add(this.btnBookDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnRefreshList);
            this.flowLayoutPanel1.Controls.Add(this.lblBreak2);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("宋体", 12F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 525);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserInfo.Location = new System.Drawing.Point(3, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(252, 250);
            this.lblUserInfo.TabIndex = 0;
            this.lblUserInfo.Text = "管理员信息";
            // 
            // lblBreak
            // 
            this.lblBreak.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBreak.Location = new System.Drawing.Point(3, 250);
            this.lblBreak.Name = "lblBreak";
            this.lblBreak.Size = new System.Drawing.Size(252, 24);
            this.lblBreak.TabIndex = 1;
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(3, 277);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(252, 31);
            this.btnBookAdd.TabIndex = 3;
            this.btnBookAdd.Text = "新增书籍";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnBookModify
            // 
            this.btnBookModify.Enabled = false;
            this.btnBookModify.Location = new System.Drawing.Point(3, 314);
            this.btnBookModify.Name = "btnBookModify";
            this.btnBookModify.Size = new System.Drawing.Size(252, 31);
            this.btnBookModify.TabIndex = 4;
            this.btnBookModify.Text = "修改书籍";
            this.btnBookModify.UseVisualStyleBackColor = true;
            this.btnBookModify.Click += new System.EventHandler(this.btnBookModify_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Enabled = false;
            this.btnBookDelete.Location = new System.Drawing.Point(3, 351);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(252, 31);
            this.btnBookDelete.TabIndex = 5;
            this.btnBookDelete.Text = "删除书籍";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(3, 388);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(252, 31);
            this.btnRefreshList.TabIndex = 6;
            this.btnRefreshList.Text = "刷新列表";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // lblBreak2
            // 
            this.lblBreak2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBreak2.Location = new System.Drawing.Point(3, 422);
            this.lblBreak2.Name = "lblBreak2";
            this.lblBreak2.Size = new System.Drawing.Size(252, 24);
            this.lblBreak2.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 449);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(252, 31);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblTitle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTitle, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAuthor, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAuthor, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPress, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtPress, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCategory, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCategory, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPublishDate, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpPublishDate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblInlabDate, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpInlabDate, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblCount, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.numCount, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.dgvBookList, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblAbstract, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtAbstract, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblPosition, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtPosition, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblISBN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtISBN, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(264, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(517, 525);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(3, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "书籍标题(*)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(132, 31);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(123, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Location = new System.Drawing.Point(261, 28);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(123, 28);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "作者(*)";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAuthor.Location = new System.Drawing.Point(390, 31);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(124, 21);
            this.txtAuthor.TabIndex = 3;
            // 
            // lblPress
            // 
            this.lblPress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPress.Location = new System.Drawing.Point(3, 56);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(123, 28);
            this.lblPress.TabIndex = 4;
            this.lblPress.Text = "出版社(*)";
            this.lblPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPress
            // 
            this.txtPress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPress.Location = new System.Drawing.Point(132, 59);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(123, 21);
            this.txtPress.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Location = new System.Drawing.Point(261, 56);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(123, 28);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "类别(*)";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCategory
            // 
            this.txtCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCategory.Location = new System.Drawing.Point(390, 59);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(124, 21);
            this.txtCategory.TabIndex = 7;
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublishDate.Location = new System.Drawing.Point(3, 84);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(123, 28);
            this.lblPublishDate.TabIndex = 8;
            this.lblPublishDate.Text = "出版时间";
            this.lblPublishDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpPublishDate.Location = new System.Drawing.Point(132, 87);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(123, 21);
            this.dtpPublishDate.TabIndex = 9;
            // 
            // lblInlabDate
            // 
            this.lblInlabDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInlabDate.Location = new System.Drawing.Point(261, 84);
            this.lblInlabDate.Name = "lblInlabDate";
            this.lblInlabDate.Size = new System.Drawing.Size(123, 28);
            this.lblInlabDate.TabIndex = 10;
            this.lblInlabDate.Text = "入库时间";
            this.lblInlabDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpInlabDate
            // 
            this.dtpInlabDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInlabDate.Location = new System.Drawing.Point(390, 87);
            this.dtpInlabDate.Name = "dtpInlabDate";
            this.dtpInlabDate.Size = new System.Drawing.Size(124, 21);
            this.dtpInlabDate.TabIndex = 11;
            // 
            // lblCount
            // 
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCount.Location = new System.Drawing.Point(3, 112);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(123, 28);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "数量";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numCount
            // 
            this.numCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCount.Location = new System.Drawing.Point(132, 115);
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(123, 21);
            this.numCount.TabIndex = 13;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.colISBN,
            this.colCategory,
            this.colPublishDate,
            this.colInlabDate,
            this.colCount,
            this.colPosition,
            this.colAbstract,
            this.colImageUrl});
            this.tableLayoutPanel2.SetColumnSpan(this.dgvBookList, 4);
            this.dgvBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookList.Location = new System.Drawing.Point(3, 223);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.RowTemplate.Height = 23;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(511, 299);
            this.dgvBookList.TabIndex = 14;
            this.dgvBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellClick);
            // 
            // lblAbstract
            // 
            this.lblAbstract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAbstract.Location = new System.Drawing.Point(3, 140);
            this.lblAbstract.Name = "lblAbstract";
            this.lblAbstract.Size = new System.Drawing.Size(123, 80);
            this.lblAbstract.TabIndex = 15;
            this.lblAbstract.Text = "摘要(*)";
            this.lblAbstract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAbstract
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtAbstract, 3);
            this.txtAbstract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAbstract.Location = new System.Drawing.Point(132, 143);
            this.txtAbstract.Multiline = true;
            this.txtAbstract.Name = "txtAbstract";
            this.txtAbstract.Size = new System.Drawing.Size(382, 74);
            this.txtAbstract.TabIndex = 16;
            // 
            // lblPosition
            // 
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosition.Location = new System.Drawing.Point(261, 112);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(123, 28);
            this.lblPosition.TabIndex = 17;
            this.lblPosition.Text = "馆藏位置(*)";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPosition
            // 
            this.txtPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosition.Location = new System.Drawing.Point(390, 115);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(124, 21);
            this.txtPosition.TabIndex = 18;
            // 
            // lblISBN
            // 
            this.lblISBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblISBN.Location = new System.Drawing.Point(3, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(123, 28);
            this.lblISBN.TabIndex = 19;
            this.lblISBN.Text = "ISBN(*)";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtISBN
            // 
            this.txtISBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtISBN.Location = new System.Drawing.Point(132, 3);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(123, 21);
            this.txtISBN.TabIndex = 20;
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
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
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
            // colInlabDate
            // 
            this.colInlabDate.HeaderText = "入库时间";
            this.colInlabDate.Name = "colInlabDate";
            this.colInlabDate.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "数量";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "馆藏位置";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colAbstract
            // 
            this.colAbstract.HeaderText = "摘要";
            this.colAbstract.Name = "colAbstract";
            this.colAbstract.ReadOnly = true;
            // 
            // colImageUrl
            // 
            this.colImageUrl.HeaderText = "图片路径";
            this.colImageUrl.Name = "colImageUrl";
            this.colImageUrl.ReadOnly = true;
            this.colImageUrl.Visible = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "管理员操作";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblBreak;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label lblInlabDate;
        private System.Windows.Forms.DateTimePicker dtpInlabDate;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Label lblAbstract;
        private System.Windows.Forms.TextBox txtAbstract;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnBookModify;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label lblBreak2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInlabDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbstract;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImageUrl;
    }
}

