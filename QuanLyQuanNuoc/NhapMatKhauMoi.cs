using QuanLyQuanNuoc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNuoc
{
    public partial class NhapMatKhauMoi : Form
    {
        public string UserName;
        public NhapMatKhauMoi(string username)
        {
            InitializeComponent();
            this.UserName = username;
           
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            string NewPass = txt_newPassWord.Text;
            string CheckPass = txt_checkPassWord.Text;
            if(NewPass != "")
            {
                if(NewPass == CheckPass)
                {
                   if (AccountDAO.Instance.UpdatePassWordAccount(UserName, NewPass))
                    {
                        MessageBox.Show("Cấp lại mật khẩu thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cấp lại mật khẩu thất bại");
                    }

                }
                else
                {
                    MessageBox.Show("Mật khẩu không giống nhau vui lòng kiểm tra lại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống mật khẩu");
            }
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
