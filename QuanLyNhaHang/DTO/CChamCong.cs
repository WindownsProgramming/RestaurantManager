using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CChamCong
    {
        /*IDChamCong INT IDENTITY PRIMARY KEY,
	IDNhanVien INT,
	IDCa INT,
	GhiChu NVARCHAR(50),
	NgayLam DATE,*/
        int iDChamCong;

        public int IDChamCong
        {
            get { return iDChamCong; }
            set { iDChamCong = value; }
        }
        int iDNhanVien;

        public int IDNhanVien
        {
            get { return iDNhanVien; }
            set { iDNhanVien = value; }
        }
        int iDCa;

        public int IDCa
        {
            get { return iDCa; }
            set { iDCa = value; }
        }
        String ghiChu;

        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        DateTime? ngayLam;

        public DateTime? NgayLam
        {
            get { return ngayLam; }
            set { ngayLam = value; }
        }
        public CChamCong() { }
        public CChamCong(int IDChamCong, int IDNhanVien, int IDCa, String GhiChu, DateTime? NgayLam) 
        {
            this.iDChamCong = IDChamCong;
            this.iDNhanVien = IDNhanVien;
            this.IDCa = IDCa;
            this.ghiChu = GhiChu;
            this.ngayLam = NgayLam;
        }
        public CChamCong(DataRow row)
        {
            this.iDChamCong = (int)row["IDChamCong"];
            this.iDNhanVien = (int)row["IDNhanVien"];
            this.IDCa = (int)row["IDCa"];
            this.ghiChu = row["GhiChu"].ToString();
            this.ngayLam = (DateTime?)row["NgayLam"];
        }

    }
}
