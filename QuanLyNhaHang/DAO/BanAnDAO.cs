using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyNhaHang.DAO
{
    public class BanAnDAO
    {
        private static BanAnDAO instance;

        public static BanAnDAO Instance
        {
            get {
                if (instance == null) instance = new BanAnDAO();
                return BanAnDAO.instance; }
            set { BanAnDAO.instance = value; }
        }
        private BanAnDAO() { }

        //hàm load Danh sách bàn
        public List<CBanAn> loadListTableFood()
        {
            List<CBanAn> listTableFood = new List<CBanAn>();

            DataTable data = DataProviderDAO.Provider.ExcuteQuery("SELECT * FROM dbo.BanAn");

            foreach( DataRow item in data.Rows)
            {
                CBanAn tableFood = new CBanAn(item);
                listTableFood.Add(tableFood); 
            }

            return listTableFood;
        }
        //RESET lại trạng thái bàn ăn
        public void resetTable(int idTable)
        {

            string query = "UPDATE dbo.BanAn SET TinhTrangBan = 0 WHERE IDBanAn = " + idTable;
            DataProviderDAO.Provider.ExcuteQuery(query);
        }
        //chuyển bàn
        public void ChuyenBan(int id1, int id2,int idNV)
        {
            String que = "EXEC gopBanAn "+id1+","+id2+","+idNV;
            DataProviderDAO.Provider.ExcuteQuery(que);
        }

        //Create bàn ăn
        public void ThemBan(int sl)
        {
            String que = "EXEC ThemBanAn " + sl;
            DataProviderDAO.Provider.ExcuteQuery(que);
        }
    }
}
