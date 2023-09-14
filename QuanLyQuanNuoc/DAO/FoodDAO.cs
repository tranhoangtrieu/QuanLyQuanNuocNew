using QuanLyQuanNuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNuoc.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (FoodDAO.instance == null) instance = new FoodDAO(); return instance; }
            private set { FoodDAO.instance = value; }
        }

        public FoodDAO() { }
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from \"Food\" where \"idCategory\" = " + id;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }
            return list;

        }
      

        public bool InsertFood(string name, int idCategory, float price)
        {

            string query = string.Format("INSERT dbo.Food ( name, idCategory, price )VALUES  ( N'{0}', {1}, {2})", name, idCategory, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int id)
        {
            string query = "delete from Food where id=" + id;

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateFood(string name, int id, float price, int idCategory)
        {
            string query = "UPDATE Food SET name=N'" + name + "',idCategory =" + idCategory + ",price =" + price + " WHERE id= " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }




        public Food getName(string name)
        {
            Food food = null;
            string query = " select * from \"Food\" where Name =N'"+name+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                food = new Food(dr);
                return food;
            }
            return food;
        }
    }

    }
