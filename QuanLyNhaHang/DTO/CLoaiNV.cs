using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    /*CREATE TABLE LoaiNV
(
	IDLoaiNV INT IDENTITY PRIMARY KEY,
	TenLoaiNV NVARCHAR(30)
)*/
    public class CLoaiNV
    {
        int iDLoaiiNV;

        public int IDLoaiiNV
        {
            get { return iDLoaiiNV; }
            set { iDLoaiiNV = value; }
        }

        String tenLoaiNV;

        public String TenLoaiNV
        {
            get { return tenLoaiNV; }
            set { tenLoaiNV = value; }
        }
        public CLoaiNV() { }
        public CLoaiNV(int IDLoaiiNV, String TenLoaiNV) 
        {
            this.iDLoaiiNV = IDLoaiiNV;
            this.tenLoaiNV = TenLoaiNV;
        }
        public CLoaiNV(DataRow row) 
        {
            this.iDLoaiiNV = (int)row["IDLoaiiNV"];
            this.tenLoaiNV = row["TenLoaiNV"].ToString();
        }



    }
}
