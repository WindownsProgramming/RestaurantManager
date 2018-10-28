using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DAO
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;

        public static PhieuNhapDAO Instance
        {
            get {
                if (instance == null) instance = new PhieuNhapDAO();
                return PhieuNhapDAO.instance; }
            set { PhieuNhapDAO.instance = value; }
        }


        private PhieuNhapDAO() { }
        public List<CNhapKho> showListNhapKhp()
        {
            List<CNhapKho> list = new List<CNhapKho>();
            string query = " SELECT * FROM dbo.NhapKho";
            DataTable data = DataProviderDAO.Provider.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CNhapKho pn= new CNhapKho(item);
                list.Add(pn);

            }
            return list;
        }
        public void insertPhieuNhap(int idNV)
        {
            string query = "INSERT INTO dbo.NhapKho( IDNhanVien, NgayNhap, TongTien ) VALUES  ("+ idNV+", GETDATE(), 0 )" ;
            DataProviderDAO.Provider.ExcuteQuery(query);
        }

        public bool insertCTPhieuNhap(int maPN, int maNL, int sl,int gia)
        {
            
                string query = "EXEC insertCTNhapKho " + maPN + "," + maNL + "," + sl + "," + gia;
                try
                {
                    DataProviderDAO.Provider.ExcuteQuery(query);
                    return true;
                }
                catch 
                {
                    return false;
                }
        }
    }
}
