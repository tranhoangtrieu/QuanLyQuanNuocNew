using QuanLyQuanNuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNuoc.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;


        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        public int GetBillByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }
        public void insertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }




        public int GetMaxBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(id) from \"Bill\"");
            }
            catch
            {
                return -1;
            }
        }
        // select MAX(id) from "Bill"
        // UPDATE "Bill" SET status = 1, DateCheckOut = CURRENT_TIMESTAMP,   discount = 20,  TotalPrice = 10000  WHERE id = 3;

        public void checkout(int id, int discount, float totalprice)
        {

            string query = "UPDATE dbo.Bill SET dateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice = " + totalprice + " WHERE id = " + id;

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListDate(DateTime? checkIn, DateTime? checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillDate @checkIn , @checkOut", new object[] { checkIn, checkOut });

        }

        public bool DeleteBill(int id)
        {
            string query = "exec USP_deleteBill @id =" + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
