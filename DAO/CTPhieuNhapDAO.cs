using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DAO
{
    public class CTPhieuNhapDAO
    {
        private static CTPhieuNhapDAO instance;

        public static CTPhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new CTPhieuNhapDAO(); return CTPhieuNhapDAO.instance; }
            set { CTPhieuNhapDAO.instance = value; }
        }
        public CTPhieuNhapDAO() { }
        public List<CCTNhapKho> showListCTNKho(int idPn)
        {
            List<CCTNhapKho> list = new List<CCTNhapKho>();

            string query = "SELECT dbo.NguyenLieu.TenNguyenLieu, SoLuongNhap, GiaNhap FROM dbo.CTNhapKho, dbo.NguyenLieu WHERE  NguyenLieu.IDNguyenLieu = dbo.CTNhapKho.IDNguyenLieu AND IDNhap ="+idPn;
            DataTable data = DataProviderDAO.Provider.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CCTNhapKho lfT = new CCTNhapKho(item);

                list.Add(lfT);

            }

            return list;
        }

    }
}
