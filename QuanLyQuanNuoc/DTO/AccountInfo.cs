using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNuoc.DTO
{
    public class AccountInfo
    {
        private string UserName;
        private string Name;
        private string Sex;
        private DateTime? DateOfBirth;
        private string Address;
        private string Phone;
        private string question;
        private string Answer;

        public AccountInfo(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.Name = row["Name"].ToString();
            this.Sex = row["Sex"].ToString();
            this.DateOfBirth = (DateTime?)row["DateOfBirth"];
            this.Address = row["Address"].ToString();
            this.Phone = row["PHONE"].ToString() ;
            this.Question = row["Question"].ToString();
            this.Answer1 = row["Answer"].ToString();
        }


        public string UserName1 { get => UserName; set => UserName = value; }
        public string Name1 { get => Name; set => Name = value; }
        public DateTime? DateOfBirth1 { get => DateOfBirth; set => DateOfBirth = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Sex1 { get => Sex; set => Sex = value; }
        public string Question { get => question; set => question = value; }
        public string Answer1 { get => Answer; set => Answer = value; }
    }
}
