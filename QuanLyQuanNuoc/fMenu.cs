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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
            loadFodd();
        }

        void loadFodd()
        {
            string query = "select a.name as N'Tên Món', price as N'Giá',b.name as N'Loại đồ ăn' from Food a, FoodCategory b where idCategory =b.id \r\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            datagrv_menu.DataSource = dt;
        }

    }
}
