using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            set { BillDAO.instance = value; }
        }
        public BillDAO() { }

        //trả ra cái idBill
        public int iDBill(int idTable)
        {
            string query = " SELECT * FROM dbo.Bill WHERE TrangThai = 0 AND IDBanAn = " + idTable;
            DataTable data = DataProviderDAO.Provider.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                CBill bill = new CBill(data.Rows[0]);
                return bill.IDBill;
            }
            else return -1;//id = -1 ---> k có cái bill nào hết

        }
        //thêm bill
        public void insertBill(int idTable,int idNhanVien)
        {
            /*idBill INT IDENTITY PRIMARY KEY,
	            DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	            DateCheckOut DATE,
	            idTable INT NOT NULL,
	            status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán , 0: chưa thanh toán*/
            string query = " EXEC insertBill " + idTable+","+idNhanVien;
            DataProviderDAO.Provider.ExcuteQuery(query);
        }


        public void payBill(int idBill,int tongtien, int giamgia)
        {

            string query = "UPDATE dbo.Bill SET TrangThai = 1 , DateCheckOut=GETDATE(),"+" TongTien ="+tongtien+", GiamGia= "+giamgia+ "WHERE idBill = " + idBill;
            DataProviderDAO.Provider.ExcuteQuery(query);
        }
    }
}
