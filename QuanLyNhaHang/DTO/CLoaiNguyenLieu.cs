using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CLoaiNguyenLieu
    {
        /*
	IDLoaiNL INT IDENTITY PRIMARY KEY,
	TenLoaiNL NVARCHAR(30),*/
        int iDLoaiNL;

        public int IDLoaiNL
        {
            get { return iDLoaiNL; }
            set { iDLoaiNL = value; }
        }
        String tenLoaiNL;

        public String TenLoaiNL
        {
            get { return tenLoaiNL; }
            set { tenLoaiNL = value; }
        }
        public CLoaiNguyenLieu() { }
        public CLoaiNguyenLieu(int IDLoaiNL, String TenLoaiNL) 
        {
            this.iDLoaiNL = IDLoaiNL;
            this.tenLoaiNL = TenLoaiNL;
        }
        public CLoaiNguyenLieu(DataRow row)
        {
            this.iDLoaiNL = (int)row["IDLoaiNL"];
            this.tenLoaiNL = row["TenLoaiNL"].ToString();
        }
    }
}
