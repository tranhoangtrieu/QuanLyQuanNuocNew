using QuanLyQuanNuoc.DAO;
using QuanLyQuanNuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanNuoc
{
    public partial class UpdateAccount : Form

    {
        private AccountInfo loginaccount;

        public UpdateAccount(AccountInfo Acc)
        {
            InitializeComponent();
            this.loginaccount = Acc;
            BindingAccountInfo();
            LoadGioiTinh();
            offCombobox();

        }
        void BindingAccountInfo()
        {
            txt_Hoten.Text = loginaccount.Name1.ToString();
            txt_sdt.Text = loginaccount.Phone1.ToString();
            txt_DiaChi.Text = loginaccount.Address1.ToString();
            dtp_NgaySinh.Text = loginaccount.DateOfBirth1.ToString();
            cbb_gioiTinh.Text = loginaccount.Sex1.ToString();
        }

        void LoadGioiTinh()
        {
            List<string> list = new List<string>();
            list.Add("Nam");
            list.Add("Nữ");
            cbb_gioiTinh.DataSource = list;
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txt_Hoten.Text;
                //  string Phone = txt_sdt.Text;
                double Phone;
                string Address = txt_DiaChi.Text;
                string Sex = cbb_gioiTinh.SelectedValue.ToString();
                string UserName = loginaccount.UserName1.ToString();
                DateTime? DateOfBirth = dtp_NgaySinh.Value;
                if (txt_Hoten.Text == "" || txt_DiaChi.Text == "" || txt_sdt.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống thông tin !!");
                    return;
                }
                if (!double.TryParse(txt_sdt.Text, out Phone))
                {
                    MessageBox.Show("Bảng giá vui lòng chỉ nhập số");
                    return;
                }
                string sPhone = Phone.ToString();



                if (AccountInfoDAO.Instance.UpdateAccountInfo(Name, Sex, DateOfBirth, Address, sPhone, UserName))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật tài khoản");
                }
            }
            catch {

                MessageBox.Show("Có lỗi ");
            }

            
        }

        void offCombobox()
        {
            cbb_gioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
