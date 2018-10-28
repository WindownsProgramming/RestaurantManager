using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DAO
{
    public class BillInfoDAO
    {
         private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get {
                if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance;
            }
            set { BillInfoDAO.instance = value; }
        }

        public BillInfoDAO() { }
        public List<CBillInfo> ListInfoBill(int idBill)
        {
            List<CBillInfo> listInfoBill = new List<CBillInfo>();

            DataTable data = DataProviderDAO.Provider.ExcuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill = "+ idBill);
            foreach (DataRow item in data.Rows)
            {
                CBillInfo infoBill = new CBillInfo(item);
                listInfoBill.Add(infoBill);

            }     

            
            return listInfoBill;
        }

        //thêm bill info
        public void insertBillInfo(int idBill, int idFood, int count)
        {
            /*	INSERT INTO dbo.BillInfo
        ( IDBill, IDMonAn, SoLuong )
VALUES  ( 0, -- IDBill - int
          0, -- IDMonAn - int
          0  -- SoLuong - int
          )   
	          )*/
            string query = " EXEC insertInfoBill " +idBill+" , "+idFood+ " , "+count ;
            DataProviderDAO.Provider.ExcuteQuery(query);
        }
    }
}
