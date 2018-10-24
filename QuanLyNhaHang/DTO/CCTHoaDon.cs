using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CCTHoaDon
    {
        /*IDCTHoaDon INT IDENTITY PRIMARY KEY,
	IDHoaDon INT,
	IDMonAn INT,
	SoLuong INT DEFAULT 0,*/
        int iDCTHoaDon;

        public int IDCTHoaDon
        {
            get { return iDCTHoaDon; }
            set { iDCTHoaDon = value; }
        }
        int iDHoaDon;

        public int IDHoaDon
        {
            get { return iDHoaDon; }
            set { iDHoaDon = value; }
        }
        int iDMonAn;

        public int IDMonAn
        {
            get { return iDMonAn; }
            set { iDMonAn = value; }
        }
        int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public CCTHoaDon() { }
        public CCTHoaDon(int IDCTHoaDon, int IDHoaDon, int IDMonAn, int SoLuong) 
        {
            this.iDCTHoaDon = IDCTHoaDon;
            this.iDHoaDon = IDHoaDon;
            this.iDMonAn = IDMonAn;
            this.soLuong = SoLuong;
        }
        public CCTHoaDon(DataRow row) 
        {
            this.iDCTHoaDon = (int)row["IDCTHoaDon"];
            this.iDHoaDon = (int)row["IDHoaDon"];
            this.iDMonAn = (int)row["IDMonAn"];
            this.soLuong = (int)row["SoLuong"];
        }
    }
}
