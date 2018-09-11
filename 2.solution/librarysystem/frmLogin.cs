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
    public partial class frmLogin : Form
    {
        private DBHelper _dbHelper;

        public frmLogin(DBHelper dbHelper)
        {
            InitializeComponent();
            this._dbHelper = dbHelper;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("用户名或密码不能为空", "操作提示");
            }
            else
            {
                string md5Str = "";
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] data = Encoding.UTF8.GetBytes(password);
                byte[] md5data = md5.ComputeHash(data);
                md5.Clear();
                for (int i = 0; i < md5data.Length; i++)
                {
                    md5Str += md5data[i].ToString("x2");
                }

                string query = string.Format(" WHERE account = '{0}' AND password = '{1}' ", account, md5Str);
                DataSetLibrarySystem.userDataTable dtUser = new DataSetLibrarySystem.userDataTable();
                if (this._dbHelper.DataSetUserFill(dtUser, query) > 0)
                {
                    DataSetLibrarySystem.userRow userRow = (DataSetLibrarySystem.userRow)dtUser[0];
                    this.DialogResult = DialogResult.OK;
                    this._dbHelper.CurrentUser.uid = userRow.uid;
                    this._dbHelper.CurrentUser.name = userRow.name;
                    this._dbHelper.CurrentUser.account = userRow.account;
                    this._dbHelper.CurrentUser.isUserLogin = true;
                    this._dbHelper.CurrentUser.isAdminRole = (dtUser[0]["permission"].ToString() == "管理员");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "操作提示");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtAccount.Text = "";
            this.txtPassword.Text = "";
            this.txtAccount.Focus();
        }
    }
}
