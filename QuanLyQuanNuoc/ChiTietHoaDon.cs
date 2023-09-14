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
    public partial class ChiTietHoaDon : Form
    {
         int Id;
        public ChiTietHoaDon(int id)
        {
            InitializeComponent();
             Id = id;
            BillDetail();
        }

        void BillDetail()
        {
            string query = "select b.name as N'Tên món',c.name as N'Loại',price as N'Giá' ,a.count as N'Số lượng' from BillInfo a, Food b, FoodCategory c where a.idBill = "+Id+" and idCategory =  c.id and a.idFood = b.id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            datagrv_chitiethoadon.DataSource = dt;
        }
    }
}
