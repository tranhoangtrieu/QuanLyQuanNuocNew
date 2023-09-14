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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanNuoc
{
    public partial class Admin : Form
    {
        BindingSource FoodList = new BindingSource();
        BindingSource CategoryList = new BindingSource();
        BindingSource AccountList = new BindingSource();
        BindingSource TableList = new BindingSource();
        private bool isButtonOn = true;
        public Account loginAccount;
        public AccountInfo loginInfo;

        public Admin()
        {

            InitializeComponent();
            datagrv_thucan.DataSource = FoodList;
            datagrv_danhmuc.DataSource = CategoryList;
            datagrv_Account.DataSource = AccountList;
            datagrv_banan.DataSource = TableList;
            loadAccount();
            loadFood();
            AddFoodBinding();
            loadcbCategory(cbb_thuchan);
            loadCategory();
            AddCategoryBinding();
            loadTableFood();
            AddTableFoodBinding();
            AddAcountBinding();
            panel_ThemDoAn.Hide();
            btn_CapNhapLoaiDoAn.Hide();
            btn_CapNhat.Hide();
            offComBoBox();
            panel_MatKhau.Hide();
            panel_ThemBan.Hide();
        }

       

        public void loadAccount()
        {
            string query = "select DisplayName,UserName,Type from Account";
            DataProvider dataProvider = new DataProvider();
            AccountList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        public void loadFood()
        {
            string query = "select * from Food order by id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            FoodList.DataSource = dt;


        }
        void offComBoBox()
        {
            cbb_thuchan.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void loadCategory()
        {
            string query = "select * from FoodCategory";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            CategoryList.DataSource = dt;
        }

        void AddFoodBinding()
        {
            txt_idFood.DataBindings.Add(new Binding("Text", datagrv_thucan.DataSource, "id", true, DataSourceUpdateMode.Never));
            txt_nameFood.DataBindings.Add(new Binding("Text", datagrv_thucan.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txt_price.DataBindings.Add(new Binding("Text", datagrv_thucan.DataSource, "price", true, DataSourceUpdateMode.Never));
        }

        void AddCategoryBinding()
        {
            txt_IdCategory.DataBindings.Add(new Binding("Text", datagrv_danhmuc.DataSource, "id", true, DataSourceUpdateMode.Never));
            txt_nameCategory.DataBindings.Add(new Binding("Text", datagrv_danhmuc.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        void loadcbCategory(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.getlistCategory();
            cbb_thuchan.DisplayMember = "Name";
        }

        void loadTableFood()
        {
            string query = "select * from TableFood order by id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            TableList.DataSource = dt;
        }

        void AddTableFoodBinding()
        {
            txt_idTable.DataBindings.Add(new Binding("Text", datagrv_banan.DataSource, "id", true, DataSourceUpdateMode.Never));
            txt_nameTable.DataBindings.Add(new Binding("Text", datagrv_banan.DataSource, "name", true, DataSourceUpdateMode.Never));

        }

        void AddAcountBinding()
        {
            txt_displayname.DataBindings.Add(new Binding("Text", datagrv_Account.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txt_username.DataBindings.Add(new Binding("Text", datagrv_Account.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            nb_typeAccount.DataBindings.Add(new Binding("Value", datagrv_Account.DataSource, "Type", true, DataSourceUpdateMode.Never));
            
        }

        void TableBinding()
        {
            txt_idTable.DataBindings.Add(new Binding("Text", datagrv_banan.DataSource, "id", true, DataSourceUpdateMode.Never));
            txt_nameTable.DataBindings.Add(new Binding("Text", datagrv_banan.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadListBillDate(dateTimePicker1.Value, dateTimePicker2.Value);

        }// thông kê







        void LoadListBillDate(DateTime? chekIn, DateTime? chekOut)
        {
            datagrv_doanhthu.DataSource = BillDAO.Instance.GetBillListDate(chekIn, chekOut);

        }


        private void txt_idFood_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (datagrv_thucan.SelectedCells.Count > 0)
                {
                    int id = (int)datagrv_thucan.SelectedCells[0].OwningRow.Cells["colIdCategory"].Value;

                    Category category = CategoryDAO.Instance.GetID(id);
                    cbb_thuchan.SelectedItem = category;
                    int intdex = -1;
                    int i = 0;
                    foreach (Category item in cbb_thuchan.Items)
                    {
                        if (item.Id == category.Id)
                        {
                            intdex = i; break;
                        }
                        i++;
                    }
                    cbb_thuchan.SelectedIndex = intdex;
                }

            }
            catch
            {

            }

        }


        private void btn_Xem_Click(object sender, EventArgs e)
        {
            loadFood();
        }


        //private void btn_CTHD_Click(object sender, EventArgs e)
        //{



        //    int rowIndex = datagrv_danhmuc.CurrentRow.Index;
        //    if (rowIndex >= 0)
        //    {
        //        DataGridViewRow select = datagrv_doanhthu.Rows[rowIndex];
        //        int id = (int)select.Cells["id"].Value;
        //        ChiTietHoaDon f = new ChiTietHoaDon(id);
        //        f.Show();
        //    }

        //}
        //  ChiTietHoaDon f = new ChiTietHoaDon();
        //  f.Show();
        // xem chi tiết bill


        private void btn_CTHD_Click(object sender, EventArgs e)
        {
            if (datagrv_doanhthu.CurrentRow != null)
            {
                int rowIndex = datagrv_doanhthu.CurrentRow.Index;
                DataGridViewRow select = datagrv_doanhthu.Rows[rowIndex];
                int id = (int)select.Cells["id"].Value;
                ChiTietHoaDon f = new ChiTietHoaDon(id);
                f.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trước.");
            }
        }


        //------------------------------------------------------------------------------------------------- 


        // Danh mục món ăn

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string Search = textBox_search.Text;
            string query = "SELECT * FROM Food WHERE dbo.non_unicode_convert(name) LIKE  N'%" + Search + "%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            datagrv_thucan.DataSource = dt;
            textBox_search.Clear();

        }


        private void button6_Click(object sender, EventArgs e)// chức năng tìm kiếm món ăm trong Food
        {
            
            
        }




        private void btn_XoaMonAn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(txt_idFood.Text);
                    if (FoodDAO.Instance.DeleteFood(id))
                    {
                        MessageBox.Show("Xóa món thành công ");
                        loadFood();

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa món");
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn không thể xóa món ăn bởi vì \n Món ăn này đã nằm trong Danh mục doanh thu");
                }
            }
            else
            {
                MessageBox.Show("Không có thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }// Xóa món ăn


        private void datagrv_thucan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(txt_idFood.Text);
                        if (FoodDAO.Instance.DeleteFood(id))
                        {
                            MessageBox.Show("Xóa món thành công ");
                            loadFood();

                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi xóa món");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa món ăn bởi vì \n Món ăn này đã nằm trong Danh mục doanh thu");
                    }
                }
                else
                {
                    MessageBox.Show("Không có thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




        //------

        private void btn_SuaMonAn_Click(object sender, EventArgs e)
        {
            if (isButtonOn)
            {
                btn_CapNhat.Show();
            }
            else
            {
                btn_CapNhat.Hide();
            }
            isButtonOn = !isButtonOn;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_idFood.Text);
            string name = txt_nameFood.Text;
            int idCategory = (cbb_thuchan.SelectedItem as Category).Id;
          //  float price = (float.Parse(txt_price.Text));


            float price;
            if (!float.TryParse(txt_price.Text, out price))
            {
                MessageBox.Show("Bảng giá vui lòng chỉ nhập số");
                return;
            }

            if (FoodDAO.Instance.UpdateFood(name, id, price, idCategory))
            {
                MessageBox.Show("Sửa món thành công");
                loadFood();
                btn_CapNhat.Hide();
                isButtonOn = true;
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món !");
            }
        }

        //sửa món ăn
        //-------------------------

       

        


        private void btn_ThemMonAn_Click(object sender, EventArgs e)
        {

            AddFood food = new AddFood();

            food.Show();

        }// Thêm món ăn (trên Form AddFood )




        //-------------------------------------------------------------------------------------------------

        // Danh mục Tài khoản


        private void btn_ThemAccount_Click(object sender, EventArgs e)
        {
        
            AddAccount account = new AddAccount();
            
            account.Show();
          
        }// show Form AddAccount


       // thêm tài khoản



        private void btn_XoaAccont_Click(object sender, EventArgs e)
        {
            string UserName = txt_username.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (loginAccount.UserName1.Equals(UserName))
                {
                    MessageBox.Show("Bạn không thể xóa tài khoản đang sủ dụng");
                    return;
                }

                if (AccountDAO.Instance.DeleteAccount(UserName))
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                    loadAccount();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa tài khoản");
                }

            }
            else
            {
                MessageBox.Show("Không có thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        // xóa tài khoản

        
        // sửa thông tin tài khoản
        


        private void btn_DatLaiMK_Click(object sender, EventArgs e)
        {


            if (isButtonOn)
            {
                panel_MatKhau.Show();

            }
            else
            {
                panel_MatKhau.Hide();

            }
            isButtonOn = !isButtonOn;
        }

        private void btn_DongYMK_Click(object sender, EventArgs e)
        {
            string UserName = txt_username.Text;
            string NewPassWord = txt_Newpassword.Text;
            string CheckNewPass =   txt_checkNewPass.Text;
            if (NewPassWord != "")
            {
                if (NewPassWord == CheckNewPass)
                {
                    if (AccountDAO.Instance.UpdatePassWordAccount(UserName, NewPassWord))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công");
                        txt_Newpassword.Clear();
                        panel_MatKhau.Hide();
                        isButtonOn = true;
                    }
                    else
                    {
                        MessageBox.Show(" Thay đổi mật khẩu thất bại");
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



           

        }// Đổi mật khẩu

        private void btn_SuaAccount_Click(object sender, EventArgs e)
        {
            string UserName = txt_username.Text;
            AccountInfo login = AccountInfoDAO.Instance.GetAccountInfo(UserName);

            UpdateAccount updateAccount = new UpdateAccount(login);
            updateAccount.ShowDialog();
        }




        //-------------------------------------------------------------------------------------------------


        // Danh mục bàn ăn


        private void btn_ThemBan_Click(object sender, EventArgs e)
        {
            if (isButtonOn)
            {
                panel_ThemBan.Show();
                btn_XoaBan.Enabled = false;
            }
            else
            {
                panel_ThemBan.Hide();
                btn_XoaBan.Enabled = true;
            }
            isButtonOn = !isButtonOn;
        }// show panle thêm bàn


        private void btn_DongYThemBan_Click(object sender, EventArgs e)
        {
            string name = txt_DatTenBan.Text;
            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công");
                loadTableFood();
                panel_ThemBan.Hide();
                btn_XoaBan.Enabled = true;
                isButtonOn = true;

            }
        }// chức năng thêm bàn


        private void btn_XoaBan_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_idTable.Text);
                if (TableDAO.Instance.DeleteTable(id))
                {
                    MessageBox.Show("Xóa bàn thành công");
                    loadTableFood();

                }
            }
            catch { MessageBox.Show("      Bạn không thể xóa bàn này \n Bởi vì bàn này đã nằm trong Danh mục doanh thu"); }

        }

        // xóa bàn thành công
        

        private void datagrv_banan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    int id = Convert.ToInt32(txt_idTable.Text);
                    if (TableDAO.Instance.DeleteTable(id))
                    {
                        MessageBox.Show("Xóa bàn thành công");
                        loadTableFood();
                    }
                }
                catch { MessageBox.Show("  Bạn không thể xóa bàn này \n Bởi vì bàn này đã nằm trong Danh mục doanh thu"); }
            }
        }

        //-------------------------------------------------------------------------------------------------

        //Danh mục loại đồ ăn


        private void btn_XoaLoaiDoAn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_IdCategory.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (CategoryDAO.Instance.DeleteCategory(id))
                    {
                        MessageBox.Show("Xóa loại đồ ăn thành công");
                        loadCategory();
                        loadcbCategory(cbb_thuchan);


                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa loại đồ ăn");
                    }
                }
                catch
                {
                    MessageBox.Show("  Bạn không thể xóa loại đồ ăn này \n Bởi vì món ăn của loại đồ ăn đã nằm trong Danh mục doanh thu");
                }
            }
            else
            {
                MessageBox.Show("Không có thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }// xóa loại đồ ăn


        private void btn_CapNhapLoaiDoAn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_IdCategory.Text);
            string name = txt_nameCategory.Text;
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa loại đồ ăn thành công");
                loadCategory();
                loadcbCategory(cbb_thuchan);
                btn_CapNhapLoaiDoAn.Hide();
                isButtonOn = true;
                btn_ThemLoaiDoAn.Enabled = true;

            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa loại đồ ăn");
            }
        }// sửa loại đồ ăn

       
        private void btn_ThemLoaiDoAn_Click(object sender, EventArgs e)
        {
            if (isButtonOn)
            {
                panel_ThemDoAn.Show();
                btn_SuaLoaiDoAn.Enabled = false;

            }
            else
            {
                panel_ThemDoAn.Hide();
                btn_SuaLoaiDoAn.Enabled = true;
            }
            isButtonOn = !isButtonOn;
        }

        private void btn_LuuLoaiDoAn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm loại đồ ăn thành công");
                loadCategory();
                loadcbCategory(cbb_thuchan);
                textBox1.Clear();
                panel_ThemDoAn.Hide();
                isButtonOn = true;
                btn_SuaLoaiDoAn.Enabled = true;
       
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm loại đồ ăn");
            }
        }// Thêm loại đồ ăn

        private void btn_SuaLoaiDoAn_Click(object sender, EventArgs e)
        {
            if (isButtonOn)
            {
                btn_CapNhapLoaiDoAn.Show();
                btn_ThemLoaiDoAn.Enabled = false;
            }
            else
            {
                btn_CapNhapLoaiDoAn.Hide();
                btn_ThemLoaiDoAn.Enabled = true;
            }
            isButtonOn = !isButtonOn;
        }


        private void datagrv_danhmuc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int id = Convert.ToInt32(txt_IdCategory.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (CategoryDAO.Instance.DeleteCategory(id))
                        {
                            MessageBox.Show("Xóa loại đồ ăn thành công");
                            loadCategory();
                            loadcbCategory(cbb_thuchan);


                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi xóa loại đồ ăn");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("  Bạn không thể xóa loại đồ ăn này \n Bởi vì món ăn của loại đồ ăn đã nằm trong Danh mục doanh thu");
                    }
                }
                else
                {
                    MessageBox.Show("Không có thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        //  delete loại đồ ăn


        // ===========================================  Thoongs ke

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void datagrv_doanhthu_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow select = datagrv_doanhthu.Rows[e.RowIndex];
                int id = (int)select.Cells["id"].Value;
                ChiTietHoaDon f = new ChiTietHoaDon(id);
                f.Show();
            }
        }

        
    }
}
