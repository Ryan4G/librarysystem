using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using librarysystem.DataSetLibrarySystemTableAdapters;
using System.Data;

namespace librarysystem.Common
{
    public class DBHelper
    {
        #region [私有字段]

        private SqlConnection conn = null;

        private userTableAdapter dataAdapterUser = new userTableAdapter();
        private bookTableAdapter dataAdapterBook = new bookTableAdapter();
        private borrow_recordTableAdapter dataAdapterBorrow_Record = new borrow_recordTableAdapter();

        private SqlDataAdapter dataAdapterUserSelect = new SqlDataAdapter();
        private SqlDataAdapter dataAdapterBookSelect = new SqlDataAdapter();
        private SqlDataAdapter dataAdapterBorrow_RecordSelect = new SqlDataAdapter();

        private UserInfo userInfo = new UserInfo();

        #endregion

        #region [公有属性]
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["LibrarySystemDB"].ToString();
            }
        }

        public SqlConnection DBConnection
        {
            get
            {
                if (this.conn == null)
                {
                    this.conn = new SqlConnection(this.ConnectString);
                }
                return this.conn;
            }
        }

        public UserInfo CurrentUser
        {
            get
            {
                return userInfo;
            }
        }

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public DBHelper()
        {
            this.conn = new SqlConnection(this.ConnectString);
            dataAdapterUser.Connection = this.conn;
            dataAdapterUserSelect.SelectCommand = this.conn.CreateCommand();
            dataAdapterBook.Connection = this.conn;
            dataAdapterBookSelect.SelectCommand = this.conn.CreateCommand();
            dataAdapterBorrow_Record.Connection = this.conn;
            dataAdapterBorrow_RecordSelect.SelectCommand = this.conn.CreateCommand();


            this.userInfo.isUserLogin = false;
            this.userInfo.isAdminRole = false;
        }

        /// <summary>
        /// 填充数据表[User]。
        /// </summary>
        /// <param name="dataTable">填充数据表</param>
        /// <param name="where">查询条件</param>
        /// <param name="top">前多少行</param>
        /// <param name="clearBeforeFill">是否填充前清空</param>
        /// <returns>查询记录数目</returns>
        public int DataSetUserFill(DataSetLibrarySystem.userDataTable dataTable, string where = "", int top = 1000, bool clearBeforeFill = true)
        {
            int returnValue = 0;
            bool success = false;
            try
            {
                dataAdapterUserSelect.SelectCommand.CommandText = string.Format("SELECT TOP {0} uid, name, account, password, permission, "
                    + "createdate, lastlogin, userremark, user_status FROM dbo.[user] {1} ", top, where);

                if (clearBeforeFill)
                {
                    dataTable.Clear();
                }

                returnValue = dataAdapterUserSelect.Fill(dataTable);
                success = true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (success ? returnValue : -1);
        }

        /// <summary>
        /// 填充数据表[Book]。
        /// </summary>
        /// <param name="dataTable">填充数据表</param>
        /// <param name="where">查询条件</param>
        /// <param name="top">前多少行</param>
        /// <param name="clearBeforeFill">是否填充前清空</param>
        /// <returns>查询记录数目</returns>
        public int DataSetBookFill(DataSetLibrarySystem.bookDataTable dataTable, string where = "", int top = 1000, bool clearBeforeFill = true)
        {
            int returnValue = 0;
            bool success = false;
            try
            {
                dataAdapterBookSelect.SelectCommand.CommandText = string.Format("SELECT TOP {0} b_id, title, author, isbn, abstract, category, " 
                    + "imageurl, presscompany, count, publishdate, inlibdate, position, bookremark FROM dbo.[book] {1} ", top, where);

                if (clearBeforeFill)
                {
                    dataTable.Clear();
                }

                returnValue = dataAdapterBookSelect.Fill(dataTable);
                success = true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (success ? returnValue : -1);
        }

        /// <summary>
        /// 填充数据表[Borrow_Record]。
        /// </summary>
        /// <param name="dataTable">填充数据表</param>
        /// <param name="where">查询条件</param>
        /// <param name="top">前多少行</param>
        /// <param name="clearBeforeFill">是否填充前清空</param>
        /// <returns>查询记录数目</returns>
        public int DataSetBorrowRecordFill(DataSetLibrarySystem.borrow_recordDataTable dataTable, string where = "", int top = 1000, bool clearBeforeFill = true)
        {
            int returnValue = 0;
            bool success = false;
            try
            {
                dataAdapterBorrow_RecordSelect.SelectCommand.CommandText = string.Format("SELECT TOP {0} uid, b_id, borrowcount, borrowdate, returndate, " +
                "validdate, status, fee, reborrow FROM dbo.borrow_record {1} ", top, where);

                if (clearBeforeFill)
                {
                    dataTable.Clear();
                }

                returnValue = dataAdapterBorrow_RecordSelect.Fill(dataTable);
                success = true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (success ? returnValue : -1);
        }

        /// <summary>
        /// 更新用户表
        /// </summary>
        /// <param name="table">需更新的用户表数据</param>
        /// <returns>影响记录条数，-1表示操作失败</returns>
        public int UpdateTableUser(DataTable table)
        {
            int returnValue = 0;
            bool success = false;
            try
            {
                if (table.GetChanges() != null)
                {
                    returnValue = dataAdapterUser.Update((DataSetLibrarySystem.userDataTable)table);
                }

                success = true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (success ? returnValue : -1);
        }

        /// <summary>
        /// 更新书籍表
        /// </summary>
        /// <param name="table">需更新的书籍表数据</param>
        /// <returns>影响记录条数，-1表示操作失败</returns>
        public int UpdateTableBook(DataTable table)
        {
            int returnValue = 0;
            bool success = false;
            try
            {
                if (table.GetChanges() != null)
                {
                    returnValue = dataAdapterBook.Update((DataSetLibrarySystem.bookDataTable)table);
                }

                success = true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (success ? returnValue : -1);
        }

        /// <summary>
        /// 更新借阅记录表
        /// </summary>
        /// <param name="table">需更新的借阅记录表数据</param>
        /// <returns>影响记录条数，-1表示操作失败</returns>
        public int UpdateTableBorrowRecord(DataTable table)
        {
            int returnValue = 0;
            bool success = false;
            try
            {
                if (table.GetChanges() != null)
                {
                    returnValue = dataAdapterBorrow_Record.Update((DataSetLibrarySystem.borrow_recordDataTable)table);
                }

                success = true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (success ? returnValue : -1);
        }
    }
    
    public class UserInfo
    {
        public long uid { set; get; }
        public string name { set; get; }
        public string account { set; get; }
        public bool isUserLogin { set; get; }
        public bool isAdminRole { set; get; }
    }

}
