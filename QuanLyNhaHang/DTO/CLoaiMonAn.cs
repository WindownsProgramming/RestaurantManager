using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CLoaiMonAn
    {
        /*IDLoaiMon INT IDENTITY PRIMARY KEY,
	TenLoaiMon NVARCHAR(30)
         */
        int iDLoaiMon;

        public int IDLoaiMon
        {
            get { return iDLoaiMon; }
            set { iDLoaiMon = value; }
        }
        String tenLoaiMon;

        public String TenLoaiMon
        {
            get { return tenLoaiMon; }
            set { tenLoaiMon = value; }
        }
        public CLoaiMonAn() { }
        public CLoaiMonAn(int IDLoaiMon, String TenLoaiMon) 
        {
            this.iDLoaiMon = IDLoaiMon;
            this.tenLoaiMon = TenLoaiMon;

        }
        public CLoaiMonAn(DataRow row) 
        {
            this.iDLoaiMon = (int)row["IDLoaiMon"];
            this.tenLoaiMon = row["TenLoaiMon"].ToString();
        }

    }
}
