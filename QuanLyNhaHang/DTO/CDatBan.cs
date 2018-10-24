using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CDatBan
    {
        /*IDDatBan INT IDENTITY PRIMARY KEY,
	NgayDat DATE,
	IDNhanVien INT,
	IDKhachHang INT,
	IDBanAn INT,
	TrangThai INT DEFAULT 0,-- 0: Chưa đến, 1--đã đến, 2-- bị hủy*/
        int iDDatBan;

        public int IDDatBan
        {
            get { return iDDatBan; }
            set { iDDatBan = value; }
        }
        DateTime? ngayDat;

        public DateTime? NgayDat
        {
            get { return ngayDat; }
            set { ngayDat = value; }
        }
        int iDNhanVien;

        public int IDNhanVien
        {
            get { return iDNhanVien; }
            set { iDNhanVien = value; }
        }
        int iDKhachHang;

        public int IDKhachHang
        {
            get { return iDKhachHang; }
            set { iDKhachHang = value; }
        }
        int iDBanAn;

        public int IDBanAn
        {
            get { return iDBanAn; }
            set { iDBanAn = value; }
        }
        int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public CDatBan() { }
        public CDatBan(int IDDatBan, DateTime? NgayDat, int IDNhanVien, int IDKhachHang, int IDBanAn, int TrangThai) 
        {
            this.iDDatBan = IDDatBan;
            this.ngayDat = NgayDat;
            this.iDNhanVien = IDNhanVien;
            this.iDKhachHang = IDKhachHang;
            this.iDBanAn = IDBanAn;
            this.trangThai = TrangThai;
        }
        public CDatBan(DataRow row) 
        {
            this.iDDatBan = (int)row["IDDatBan"];
            this.ngayDat = (DateTime?)row["NgayDat"];
            this.iDNhanVien = (int)row["IDNhanVien"];
            this.iDKhachHang = (int)row["IDKhachHang"];
            this.iDBanAn = (int)row["IDBanAn"];
            this.trangThai = (int)row["TrangThai"];
        }

    }
}
