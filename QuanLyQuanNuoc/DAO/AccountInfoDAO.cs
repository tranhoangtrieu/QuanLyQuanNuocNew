using QuanLyQuanNuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace QuanLyQuanNuoc.DAO
{
    public class AccountInfoDAO
    {
        private static AccountInfoDAO instance;
        public static AccountInfoDAO Instance {
            get
            {
                if (instance == null) instance = new AccountInfoDAO(); return instance;
            }
            private set { instance = value; }
        }
        private AccountInfoDAO() { }

        public AccountInfo GetAccountInfo(string username)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from AccountInfo where UserName = '" + username + "'");
            foreach (DataRow dr in dt.Rows)
            {
                return new AccountInfo(dr);
            }
            return null;
        }
        public bool UpdateAccountInfo(string Name, string Sex, DateTime? DateOfBirth, string Address, string Phone, string UserName)
        {
            string query = "update AccountInfo set Name=N'" + Name + "',Sex = N'" + Sex + "', DateOfBirth = '" + DateOfBirth + "', Address =N'" + Address + "' ,PHONE = '" + Phone + "'  where UserName =N'" + UserName + "'";
            int result =  DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool checkAccountInfo(string username,string question, string answer)
        {
            string query = "select * from AccountInfo where Question = N'"+question+"' and Answer = N'"+answer+"' and UserName = N'"+username+"'   ";
            var result = DataProvider.Instance.ExecuteQuery(query);
            if(result.Rows.Count > 0) 
            {
                return true;    
            }
            return false;
        }




    }
}
