using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CCTNhapKho
    {
     /*   IDCTNhap INT IDENTITY PRIMARY KEY,
	IDNhap INT,
	IDNguyenLieu INT,
	SoLuongNhap INT,
	GiaNhap FLOAT,*/
        int iDCTNhap;

        public int IDCTNhap
        {
            get { return iDCTNhap; }
            set { iDCTNhap = value; }
        }
        int iDNhap;

        public int IDNhap
        {
            get { return iDNhap; }
            set { iDNhap = value; }
        }
        int iDNguyenLieu;

        public int IDNguyenLieu
        {
            get { return iDNguyenLieu; }
            set { iDNguyenLieu = value; }
        }
        int soLuongNhap;

        public int SoLuongNhap
        {
            get { return soLuongNhap; }
            set { soLuongNhap = value; }
        }
        float giaNhap;

        public float GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }
        public CCTNhapKho() { }
        public CCTNhapKho(int IDCTNhap, int IDNhap, int IDNguyenLieu, int SoLuongNhap, float GiaNhap) {
            this.iDCTNhap = IDCTNhap;
            this.iDNhap = IDNhap;
            this.iDNguyenLieu = IDNguyenLieu;
            this.soLuongNhap = SoLuongNhap;
            this.giaNhap = GiaNhap;
        }
        public CCTNhapKho(DataRow row) 
        {
            this.iDCTNhap = (int)row["IDCTNhap"];
            this.iDNhap = (int)row["IDNhap"];
            this.iDNguyenLieu = (int)row["IDNguyenLieu"];
            this.soLuongNhap = (int)row["SoLuongNhap"];
            this.giaNhap = (float)row["GiaNhap"];
        }
    }
}
