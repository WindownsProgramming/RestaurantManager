using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DAO
{
    public class ListFoodOfTableDAO
    {
        private static ListFoodOfTableDAO instance;

        public static ListFoodOfTableDAO Instance
        {
            get
            {
                if (instance == null) instance = new ListFoodOfTableDAO();
                return ListFoodOfTableDAO.instance;
            }
            set { ListFoodOfTableDAO.instance = value; }
        }

        private ListFoodOfTableDAO() { }

        public List<CListFoodOfTable> showListFoodOfTable(int idTable)
        {
            List<CListFoodOfTable> listFoodOfTable = new List<CListFoodOfTable>();

            string query = "SELECT dbo.MonAn.TenMonAn , dbo.BillInfo.SoLuong , dbo.MonAn.GiaMonAn ,dbo.BillInfo.SoLuong * dbo.MonAn.GiaMonAn as total FROM dbo.MonAn,dbo.Bill,dbo.BillInfo WHERE dbo.BillInfo.idBill = dbo.Bill.idBill AND dbo.BillInfo.IDMonAn = dbo.MonAn.IDMonAn AND dbo.Bill.TrangThai = 0 AND dbo.Bill.IDBanAn = " + idTable;
            DataTable data = DataProviderDAO.Provider.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CListFoodOfTable lfT = new CListFoodOfTable(item);

                listFoodOfTable.Add(lfT);

            }

            return listFoodOfTable;
        }
    }
}
