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
    public partial class QuenThongTinTaiKhoan : Form
    {
        public QuenThongTinTaiKhoan()
        {
            InitializeComponent();
            LoadQuestion();
            offCombobox();
        }

        void offCombobox()
        {
            cbb_CauHoi.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        void LoadQuestion()
        {
            List<string> list = new List<string>();
            list.Add("Bạn thích quyển sách nào ?");
            list.Add("Nhà bạn ở đâu ?");
            list.Add("Con chó bạn tên gì ?");
            list.Add("Bạn thích ai nhất ?");
            cbb_CauHoi.DataSource = list;


        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string question = cbb_CauHoi.SelectedValue.ToString();
            string answer  =  txt_answer.Text;
            if (AccountDAO.Instance.checkAccount(username))
            {

                
                if (AccountInfoDAO.Instance.checkAccountInfo(username, question, answer))
                {
                    NhapMatKhauMoi NewPassWord = new NhapMatKhauMoi(username);

                    this.Hide();
                    NewPassWord.ShowDialog();
                    this.Close();



                }
                else
                {
                    MessageBox.Show("Câu hỏi bảo mật không đúng");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !");
            }
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private bool isButtonOn = true;
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (isButtonOn)
            {
                button2.Image = Properties.Resources.icons8_eyes_32__1_;

                txt_answer.UseSystemPasswordChar = false;
            }
            else
            {

                button2.Image = Properties.Resources.icons8_eyes_32;
                txt_answer.UseSystemPasswordChar = true;
            }
            isButtonOn = !isButtonOn;
        }
    }
}
