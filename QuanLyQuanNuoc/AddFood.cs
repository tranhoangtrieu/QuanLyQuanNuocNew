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
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();

            loadCategory();
            offComBoBox();

        }

        void offComBoBox()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        

        
        void loadCategory() // 
        {
            List<Category> list = CategoryDAO.Instance.getlistCategory();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";

        }

        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
             if (txt_nameFood.Text == "" || txt_price.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin món ăn");
                return;
            }
            string name = txt_nameFood.Text;
            int idCategory = (comboBox1.SelectedItem as Category).Id;



            float price;
            if (!float.TryParse(txt_price.Text, out price))
            {
                MessageBox.Show("Bảng giá vui lòng chỉ nhập số");
                return;
            }



            try
            {
                if (FoodDAO.Instance.InsertFood(name, idCategory, price))
                {

                    MessageBox.Show(" Thêm món thành công !");
                    var mainForm = Application.OpenForms.OfType<Admin>().Single();
                    mainForm.loadFood();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Có lỗi khi thêm thức ăn !");
                    return;
                }
            }
            catch
            {
                MessageBox.Show(" Có lỗi khi thêm thức ăn !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
