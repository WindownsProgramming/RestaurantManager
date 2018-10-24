using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DAO
{
    public class MonAnDAO
    {
        private static MonAnDAO instance;

        public static MonAnDAO Instance
        {
            get {
                if (instance == null) instance = new MonAnDAO();
                return MonAnDAO.instance; }
            set { MonAnDAO.instance = value; }
        }


        private MonAnDAO() { }

        public List<CMonAn> showListFoodByCategory(int idMonAn)
        {
            List<CMonAn> list = new List<CMonAn>();
            string query = " SELECT * FROM dbo.MonAn WHERE IDLoaiMon = " + idMonAn;
            DataTable data = DataProviderDAO.Provider.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CMonAn food = new CMonAn(item);
                list.Add(food); 

            }

            return list;
        }
    }
}
