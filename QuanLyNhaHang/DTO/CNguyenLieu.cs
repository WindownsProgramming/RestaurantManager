using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CNguyenLieu
    {
        /*IDNguyenLieu INT IDENTITY PRIMARY KEY,
	IDLoaiNL INT,
	TenNguyenLieu NVARCHAR(30),
	DVT NVARCHAR(20),
	SoLuongTon INT*/
        int iDNguyenLieu;

        public int IDNguyenLieu
        {
            get { return iDNguyenLieu; }
            set { iDNguyenLieu = value; }
        }
        int iDLoaiNL;

        public int IDLoaiNL
        {
            get { return iDLoaiNL; }
            set { iDLoaiNL = value; }
        }
        String tenNguyenLieu;

        public String TenNguyenLieu
        {
            get { return tenNguyenLieu; }
            set { tenNguyenLieu = value; }
        }
        String dVT;

        public String DVT
        {
            get { return dVT; }
            set { dVT = value; }
        }
        int soLuongTon;

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }
        public CNguyenLieu()
        { }
        public CNguyenLieu(int IDNguyenLieu, String TenNguyenLieu, String DVT, int SoLuongTon)
        {
            this.iDNguyenLieu = IDNguyenLieu;
            this.tenNguyenLieu = TenNguyenLieu;
            this.dVT = DVT;
            this.soLuongTon = SoLuongTon;
        }
        public CNguyenLieu(DataRow row)
        {
            this.iDNguyenLieu =(int)row["IDNguyenLieu"];
            this.tenNguyenLieu = row["TenNguyenLieu"].ToString();
            this.dVT = row["DVT"].ToString();
            this.soLuongTon = (int)row["SoLuongTon"];
        }
    }
}
