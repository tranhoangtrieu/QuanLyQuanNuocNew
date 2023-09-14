using QuanLyQuanNuoc.DAO;
using QuanLyQuanNuoc.DTO;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string userName = this.txb_taikhoan.Text;
            string passWord = this.txb_matkhau.Text;
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Chưa nhập tài khoản hoặc mật khẩu");
            }
            else

            if (Login(userName, passWord))
            {
                Account login = AccountDAO.Instance.GetAccount(userName);
                QuanLyQuanNuoc f = new QuanLyQuanNuoc(login);  // Chuyền thông tin tài khoản form quanly
                txb_taikhoan.Clear();
                txb_matkhau.Clear();
                this.Hide();

                f.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
            }

        }

        bool Login(string userName, string PassWord)
        {
            return AccountDAO.Instance.Login(userName, PassWord);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn có thực sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            QuenThongTinTaiKhoan taikhoan =  new QuenThongTinTaiKhoan();
            this.Hide();

            taikhoan.ShowDialog();
            this.Show();
        }
    }
}
