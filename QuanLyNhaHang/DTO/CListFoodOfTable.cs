using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CListFoodOfTable
    {
        private string nameFood;

        public string NameFood
        {
            get { return nameFood; }
            set { nameFood = value; }
        }
        private int countFood;

        public int CountFood
        {
            get { return countFood; }
            set { countFood = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        public CListFoodOfTable(string nameFood, int countFood, float price, float total = 0)
        {
            this.nameFood = nameFood;
            this.countFood = countFood;
            this.price = price;
            this.total = total;
        }
        public CListFoodOfTable(DataRow row)
        {
            this.nameFood = row["TenMonAn"].ToString();
            this.countFood = (int)row["SoLuong"];
            this.price = (float)Convert.ToDouble(row["GiaMonAn"].ToString());
            this.total = (float)Convert.ToDouble(row["total"].ToString());
        }
    }
}
