using QuanLyQuanNuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNuoc.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO(); return instance;
            }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string query = "select * from Account where UserName COLLATE SQL_Latin1_General_Cp850_CS_AS like '"+username+ "' COLLATE SQL_Latin1_General_Cp850_CS_AS AND PassWord COLLATE SQL_Latin1_General_Cp850_CS_AS like N'" + password+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public Account GetAccount(string username)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Account where UserName = '" + username + "'");
            foreach (DataRow dr in dt.Rows)
            {
                return new Account(dr);
            }
            return null;

        }

        public bool checkAccount(string username)
        {
            string query = "select* from Account where UserName = N'"+username+"' ";
            var result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool InsertAccount(string DisplayName, string Username, string Password, int Type)
        {
            string query = "insert Account (DisplayName,UserName,PassWord,Type) values(N'" + DisplayName + "',N'" + Username + "',N'" + Password + "'," + Type + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string UserName)
        {
            string query = "EXEC sp_DeleteAccount @UserName  = N'"+UserName+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string DisplayName, string Username, string Password, int Type)
        {

            string query = "UPDATE dbo.Account SET DisplayName = N'"+DisplayName+"', Type = "+Type+" , PassWord = N"+Password+" WHERE UserName = N'"+Username+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdatePassWordAccount(string UserName,string Password)
        {
            string query = "update Account Set PassWord = N'"+Password+"' where UserName = N'"+UserName+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
