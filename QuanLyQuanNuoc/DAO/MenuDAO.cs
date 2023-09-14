using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNuoc.DAO
{
    public class MenuDAO
    {
        public static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (MenuDAO.instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        public MenuDAO()
        {
        }
        public List<DTO.Menu> GetListMenu(int id)
        {
            List<DTO.Menu> list = new List<DTO.Menu>();
            string query = ("SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id);
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dataTable.Rows)
            {
                DTO.Menu memu = new DTO.Menu(dr);
                list.Add(memu);
            }
            return list;
        }


    }
}
