﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNuoc.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;
        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;

        }

        public Menu(DataRow row)
        {
            this.foodName = row["name"].ToString();
            this.count = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }



        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }



        public float Price
        {
            get { return price; }
            set { price = value; }
        }



        public int Count
        {
            get { return count; }
            set { count = value; }
        }



        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
    }
}
