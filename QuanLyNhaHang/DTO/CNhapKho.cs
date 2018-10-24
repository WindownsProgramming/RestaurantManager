using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CNhapKho
    {
        /*IDNhap INT IDENTITY PRIMARY KEY,
	IDNhanVien INT,
	NgayNhap DATE,
	TongTien FLOAT*/
        int iDNhap;

        public int IDNhap
        {
            get { return iDNhap; }
            set { iDNhap = value; }
        }
        int iDNhanVien;

        public int IDNhanVien
        {
            get { return iDNhanVien; }
            set { iDNhanVien = value; }
        }
        DateTime? ngayNhap;

        public DateTime? NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        float tongTien;

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public CNhapKho()
        { }
        public CNhapKho(int iDNhap, int iDNhanVien, DateTime? ngayNhap, float tongTien)
        {
            this.iDNhap = iDNhap;
            this.iDNhanVien = iDNhanVien;
            this.ngayNhap = ngayNhap;
            this.tongTien = tongTien;
        }
    
        public CNhapKho(DataRow row)
        {
            this.iDNhap = (int)row["IDNhap"];
            this.iDNhanVien = (int)row["IDNhanVien"];
            var temp = (DateTime?)row["NgayNhap"];
            if (temp.ToString() != "") this.ngayNhap = (DateTime?)row["NgayNhap"]; 
            this.tongTien = (float)row["TongTien"];
        }
    }
}
