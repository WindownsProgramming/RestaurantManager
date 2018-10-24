using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CHoaDon
    {
        /*IDHoaDon INT IDENTITY PRIMARY KEY,
	IDDatBan INT,
	IDKhachHang INT,
	TrangThai INT DEFAULT 0, -- 1 Đã thành toán, 0 Chưa thanh Toán
	GhiChu NVARCHAR(100),
	GiamGia FLOAT DEFAULT 0,
	TongTien FLOAT DEFAULT 0,*/
        int iDHoaDon;

        public int IDHoaDon
        {
            get { return iDHoaDon; }
            set { iDHoaDon = value; }
        }
        int iDDatBan;

        public int IDDatBan
        {
            get { return iDDatBan; }
            set { iDDatBan = value; }
        }
        int iDKhachHang;

        public int IDKhachHang
        {
            get { return iDKhachHang; }
            set { iDKhachHang = value; }
        }
        int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        String ghiChu;

        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        float giamGia;

        public float GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }
        float tongTien;

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public CHoaDon() { }
        public CHoaDon(int IDHoaDon, int IDDatBan, int IDKhachHang, int TrangThai, String GhiChu, float GiamGia, float TongTien) 
        {
            this.iDHoaDon = IDHoaDon;
            this.iDDatBan = IDDatBan;
            this.iDKhachHang = IDKhachHang;
            this.trangThai = TrangThai;
            this.ghiChu = GhiChu;
            this.giamGia = GiamGia;
            this.tongTien = TongTien;
        }
        public CHoaDon(DataRow row) 
        {
            this.iDHoaDon = (int)row["IDHoaDon"];
            this.iDDatBan = (int)row["IDDatBan"];
            this.iDKhachHang = (int)row["IDKhachHang"];
            this.trangThai = (int)row["TrangThai"];
            this.ghiChu = row["GhiChu"].ToString();
            this.giamGia = (float)row["GiamGia"];
            this.tongTien = (float)row["TongTien"];
        }
    }
}
