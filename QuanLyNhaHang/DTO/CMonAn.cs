using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CMonAn
    {
        /*IDMonAn INT IDENTITY PRIMARY KEY,
	TenMonAn NVARCHAR(50),
	IDLoaiMon INT,
	GiaMonAn FLOAT,
	TrangThai INT,--1 CÒN , 2 hết*/
        int iDMonAn;

        public int IDMonAn
        {
            get { return iDMonAn; }
            set { iDMonAn = value; }
        }
        String tenMonAn;

        public String TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }
        int iDLoaiMon;

        public int IDLoaiMon
        {
            get { return iDLoaiMon; }
            set { iDLoaiMon = value; }
        }
        int giaMonAn;

        public int GiaMonAn
        {
            get { return giaMonAn; }
            set { giaMonAn = value; }
        }
        int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public CMonAn()
        { }
        public CMonAn(int IDMonAn, String TenMonAn, int IDLoaiMon, int GiaMonAn, int TrangThai)
        {
            this.iDMonAn = IDMonAn;
            this.tenMonAn = TenMonAn;
            this.iDLoaiMon = IDLoaiMon;
            this.giaMonAn = GiaMonAn;
            this.trangThai = TrangThai;
        }
        public CMonAn(DataRow row)
        {
            this.iDMonAn = (int)row["IDMonAn"];
            this.tenMonAn = row["TenMonAn"].ToString();
            this.iDLoaiMon = (int)row["IDLoaiMon"];
            this.giaMonAn = (int)row["GiaMonAn"];
            this.trangThai = (int)row["TrangThai"];
        }
    }
}
