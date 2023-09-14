using QuanLyQuanNuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNuoc.DAO
{
    public class BillInfoDAO
    {
        public static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        public BillInfoDAO() { }
        public List<BillInfro> GetListBillInfor(int id)
        {
            List<BillInfro> list = new List<BillInfro>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill= " + id);
            foreach (DataRow row in data.Rows)
            {
                BillInfro info = new BillInfro(row);
                list.Add(info);
            }

            return list;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }


        public bool DeleteFoodBillInfo(int idBill, int idFodd) 
        {
            string query = "delete from BillInfo where idBill="+idBill+" and  idFood = "+idFodd+"";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;


        }

       
    }
}
