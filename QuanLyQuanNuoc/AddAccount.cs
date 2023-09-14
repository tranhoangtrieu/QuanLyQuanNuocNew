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
    public partial class AddAccount : Form
    {

      
        public AddAccount()
        {
            InitializeComponent();
            LoadQuestion();
            LoadGioiTinh();
            offComBoBox();



        }

        void offComBoBox()
        {
            cbb_CauHoi1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_gioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void LoadQuestion()
        {
            List<string> list = new List<string>();
            list.Add("Bạn thích quyển sách nào ?");
            list.Add("Nhà bạn ở đâu ?");
            list.Add("Con chó bạn tên gì ?");
            list.Add("Bạn thích ai nhất ?");
            cbb_CauHoi1.DataSource = list;
            

        }
        void LoadGioiTinh()
        {
            List<string> list = new List<string>();
            list.Add("Nam");
            list.Add("Nữ");
            cbb_gioiTinh.DataSource = list;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string DisplayName = txt_Hoten.Text;
                string sdt = txt_sdt.Text;
                string Address = txt_DiaChi.Text;
                string Question = cbb_CauHoi1.SelectedValue.ToString();
                string Answer = txt_CauTraLoi.Text;
                string UserName = txt_TaiKhoan.Text;
                string PassWord = txt_MatKhau.Text;
                int Type = (int)nb_typeAccount.Value;
                DateTime? DateOfBirth = dtp_NgaySinh.Value;
                string Sex = cbb_gioiTinh.SelectedValue.ToString();


                string query = "EXEC sp_InsertAccountWithInfo   @DisplayName = '" + DisplayName + "', @UserName = '" + UserName + "', @PassWord = '" + PassWord + "', @Type = " + Type + ",@Sex = N'" + Sex + "', @DateOfBirth = '" + DateOfBirth + "',  @Address = '" + Address + "',@PHONE = '" + sdt + "',@Question = N'" + Question + "',@Answer = N'" + Answer + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                if (result > 1)
                {
                    MessageBox.Show("Thêm tài khoản thành công");

                    var mainForm = Application.OpenForms.OfType<Admin>().Single();
                    mainForm.loadAccount();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Co loi");
            }

        }

        private void btn_LamLai_Click(object sender, EventArgs e)
        {
            txt_Hoten.Clear();
            txt_sdt.Clear();
            txt_DiaChi.Clear();
            txt_CauTraLoi.Clear();
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
           
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
