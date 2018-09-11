namespace librarysystem
{
    partial class frmUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBorrowList = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblBreak = new System.Windows.Forms.Label();
            this.btnBorrowAgain = new System.Windows.Forms.Button();
            this.lblBreak2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.colBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReborrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
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
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.dgvBorrowList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(264, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 4);
            this.panel1.Size = new System.Drawing.Size(517, 525);
            this.panel1.TabIndex = 4;
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
            this.colFee,
            this.colReborrow});
            this.dgvBorrowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowList.Location = new System.Drawing.Point(0, 0);
            this.dgvBorrowList.Name = "dgvBorrowList";
            this.dgvBorrowList.ReadOnly = true;
            this.dgvBorrowList.RowTemplate.Height = 23;
            this.dgvBorrowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowList.Size = new System.Drawing.Size(517, 525);
            this.dgvBorrowList.TabIndex = 15;
            this.dgvBorrowList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowList_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblUserInfo);
            this.flowLayoutPanel1.Controls.Add(this.lblBreak);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrowAgain);
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
            this.lblUserInfo.Text = "用户信息";
            // 
            // lblBreak
            // 
            this.lblBreak.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBreak.Location = new System.Drawing.Point(3, 250);
            this.lblBreak.Name = "lblBreak";
            this.lblBreak.Size = new System.Drawing.Size(252, 24);
            this.lblBreak.TabIndex = 1;
            // 
            // btnBorrowAgain
            // 
            this.btnBorrowAgain.Enabled = false;
            this.btnBorrowAgain.Location = new System.Drawing.Point(3, 277);
            this.btnBorrowAgain.Name = "btnBorrowAgain";
            this.btnBorrowAgain.Size = new System.Drawing.Size(252, 31);
            this.btnBorrowAgain.TabIndex = 3;
            this.btnBorrowAgain.Text = "续借";
            this.btnBorrowAgain.UseVisualStyleBackColor = true;
            this.btnBorrowAgain.Click += new System.EventHandler(this.btnBorrowAgain_Click);
            // 
            // lblBreak2
            // 
            this.lblBreak2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBreak2.Location = new System.Drawing.Point(3, 311);
            this.lblBreak2.Name = "lblBreak2";
            this.lblBreak2.Size = new System.Drawing.Size(252, 24);
            this.lblBreak2.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 338);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(252, 31);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            // colReborrow
            // 
            this.colReborrow.HeaderText = "续借次数";
            this.colReborrow.Name = "colReborrow";
            this.colReborrow.ReadOnly = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblBreak;
        private System.Windows.Forms.Button btnBorrowAgain;
        private System.Windows.Forms.DataGridView dgvBorrowList;
        private System.Windows.Forms.Label lblBreak2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReborrow;
    }
}

