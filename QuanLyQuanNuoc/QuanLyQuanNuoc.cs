using QuanLyQuanNuoc.DAO;
using QuanLyQuanNuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QuanLyQuanNuoc
{
    public partial class QuanLyQuanNuoc : Form
    {
        private Account loginaccount;
        BindingSource Menu = new BindingSource();
       
        public QuanLyQuanNuoc(Account acc)
        {
            InitializeComponent();
            this.Loginaccount = acc;
            LoadTable();
            loadCategory();
            offCombobox();
            loadFodd();
            lv_showbill.FullRowSelect = true;
           datagrv_menu.DataSource = Menu;
            bindingMenu();

        }


        void bindingMenu()
        {
            cbb_loaidoan.DataBindings.Add(new Binding("Text", datagrv_menu.DataSource,"Loại đồ ăn", true, DataSourceUpdateMode.Never));
            cbb_monan.DataBindings.Add(new Binding("Text", datagrv_menu.DataSource,"Tên Món", true, DataSourceUpdateMode.Never));
        }



        public Account Loginaccount
        {
            get { return loginaccount; }
            set { loginaccount = value; ChangeAccount(loginaccount.Type); }
        }



        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1; // kiem tra nếu như type bằng 1 thì sẽ bật admin còn không thì sẽ tắt
        }

        void loadFodd()
        {
            string query = "select a.name as N'Tên Món', price as N'Giá',b.name as N'Loại đồ ăn' from Food a, FoodCategory b where idCategory =b.id \r\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            Menu.DataSource = dt;
        }


        void offCombobox()
        {
            cbb_loaidoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_monan.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void loadCategory() // 
        {
            List<Category> list = CategoryDAO.Instance.getlistCategory();
            cbb_loaidoan.DataSource = list;
            cbb_loaidoan.DisplayMember = "Name";

        }
        void loadDsCategoryId(int id)
        {

            List<Food> foods = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbb_monan.DataSource = foods;
            cbb_monan.DisplayMember = "name";

        }


        void LoadTable()
        {
            fLP_banan.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            foreach (Table table in tablelist)
            {
                //  System.Windows.Forms.Button btn = new System.Windows.Forms.Button() { Width = TableDAO.chieurong, Height = TableDAO.chieudai };

                System.Windows.Forms.Button btn = new System.Windows.Forms.Button() { Width = TableDAO.chieurong, Height = TableDAO.chieudai };
                btn.Region = new Region(new GraphicsPath());
                RectangleF circleBounds = new RectangleF(0, 0, btn.Width, btn.Height);
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(circleBounds);
                btn.Region = new Region(path);

                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.Click += Btn_Click;
                btn.Tag = table;

                
                switch (table.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    case "":
                        btn.BackColor = Color.White;
                        break;
                    case null: btn.BackColor = Color.White; break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }

                fLP_banan.Controls.Add(btn);

            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as System.Windows.Forms.Button).Tag as Table).ID;
            lv_showbill.Tag = (sender as System.Windows.Forms.Button).Tag;
            showBill(tableID);
        }

        public void showBill(int id)
        {
            lv_showbill.Items.Clear();
            List<DTO.Menu> List = MenuDAO.Instance.GetListMenu(id); // lấy danh sách từ Menu           
            float sum = 0;

            
         
            foreach (DTO.Menu item in List)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                
        
               
                sum += item.TotalPrice;
                lv_showbill.Items.Add(listViewItem);
               
              

            }

            textBox_giatien.Text = sum.ToString();
        }
        private void btn_themmon_Click(object sender, EventArgs e)
        {
            Table table = lv_showbill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }


            int idBill = BillDAO.Instance.GetBillByTableID(table.ID);
            int foodID = (cbb_monan.SelectedItem as Food).Id;
            int count = (int)numUD_slmon.Value;

            if (lv_showbill.Items.Count <= 0)
            {
                if (count < 0)
                {
                    MessageBox.Show("Lỗi !!");
                    return;
                }
            }
            if (count < 0)
            {
                foreach(ListViewItem  item in lv_showbill.Items)
                {
                    if (item.SubItems[0].Text != cbb_monan.Text)
                    {
                        MessageBox.Show("có lỗi");
                        return;
                    }
                }
            }
            

            if (idBill == -1)
            {
                BillDAO.Instance.insertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);

            }

            showBill(table.ID);
            LoadTable();
        }

        private void comboBox_loaidoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;
            if (cb.SelectedItem == null || !(cb.SelectedItem is Category))
                return;
            Category select = cb.SelectedItem as Category;
            id = select.Id;
            loadDsCategoryId(id);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.loginAccount = loginaccount;
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadTable();
            loadCategory();
            loadFodd();

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            Table table = lv_showbill.Tag as Table;
            int idBIll = BillDAO.Instance.GetBillByTableID(table.ID);
            int discount = (int)numUD_giamgia.Value;
            double totalPrice = Convert.ToDouble(textBox_giatien.Text);
            double finalTotal = totalPrice - (totalPrice * discount / 100);
            if (idBIll != -1)
            {
                if (discount > 0)
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán bàn {0} ?\n Số tiền sau khi giảm giá là {1}", table.Name, finalTotal), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.checkout(idBIll, discount, (float)finalTotal);
                        showBill(table.ID);

                        LoadTable();
                        numUD_giamgia.Value = 0;
                    }
                }

                else
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán bàn {0} ?", table.Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.checkout(idBIll, discount, (float)finalTotal);
                        showBill(table.ID);

                        LoadTable();
                    }

                }


            }
        }

        

        

        private void btn_XoaMon_Click(object sender, EventArgs e)
        {

            try
            {
                Table table = lv_showbill.Tag as Table;
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn");
                    return;
                }
              
                int idBill = BillDAO.Instance.GetBillByTableID(table.ID);
                string selectedValue = lv_showbill.SelectedItems[0].SubItems[0].Text;
                Food food = FoodDAO.Instance.getName(selectedValue);
                BillInfoDAO.Instance.DeleteFoodBillInfo(idBill, food.Id);
                showBill(table.ID);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn món bạn muốn xóa !");
            }


            

        }

        private void btn_huyBan_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lv_showbill.Tag as Table;
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn");
                    return;
                }

                int idBill = BillDAO.Instance.GetBillByTableID(table.ID);
                BillDAO.Instance.DeleteBill(idBill);
                LoadTable();
                showBill(table.ID);
            }
            catch
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
