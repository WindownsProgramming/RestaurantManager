using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    /*CREATE TABLE NhanVien
(
	IDNhanVien INT IDENTITY PRIMARY KEY,
	IDLoaiNV INT,
	TenNV NVARCHAR(30),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(12),
	MK NVARCHAR(50),
	FOREIGN KEY(IDLoaiNV) REFERENCES dbo.LoaiNV(IDLoaiNV)
)*/
    public class CNhanVien
    {
        int iDNhanVien;

        public int IDNhanVien
        {
            get { return iDNhanVien; }
            set { iDNhanVien = value; }
        }
        int idLoaiNV;

        public int IdLoaiNV
        {
            get { return idLoaiNV; }
            set { idLoaiNV = value; }
        }
        String tenNV;

        public String TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        String diaChi;

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        int sdt;

        public int Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        String mK;

        public String MK
        {
            get { return mK; }
            set { mK = value; }
        }
        public CNhanVien()
        { }
        public CNhanVien(int IDNhanVien, int IdLoaiNV, String TenNV, int SDT, String MK)
        {
            this.iDNhanVien = IDNhanVien;
            this.idLoaiNV = IdLoaiNV;
            this.tenNV = TenNV;
            this.sdt = SDT;
            this.mK = MK;
        }
        public CNhanVien(DataRow row)
        {
            this.iDNhanVien = (int)row["IDNhanVien"];
            this.idLoaiNV = (int)row["IDLoaiNV"];
            this.tenNV = row["TenNV"].ToString();
            this.sdt = (int)row["SDT"];
            this.mK = row["MK"].ToString();
        }
    }
}
