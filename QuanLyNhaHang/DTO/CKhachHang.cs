using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CKhachHang
    {
        /*IDKhachHang INT IDENTITY PRIMARY KEY,
	CMND INT,
	TenKhachHang NVARCHAR(30),
	SDTKhachHang NCHAR(12),
	SoTienTichLuy FLOAT DEFAULT 0*/
        int iDKhachHang;

        public int IDKhachHang
        {
            get { return iDKhachHang; }
            set { iDKhachHang = value; }
        }
        int cMND;

        public int CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }
        String tenKhachHang;

        public String TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }
        String sDTKhachHang;

        public String SDTKhachHang
        {
            get { return sDTKhachHang; }
            set { sDTKhachHang = value; }
        }
        float soTienTichLuy;

        public float SoTienTichLuy
        {
            get { return soTienTichLuy; }
            set { soTienTichLuy = value; }
        }
        public CKhachHang() { }
        public CKhachHang(int IDKhachHang, int CMND, String TenKhachHang, String SDTKhachHang,float SoTienTichLuy) 
        {
            this.iDKhachHang = IDKhachHang;
            this.cMND = CMND;
            this.tenKhachHang = TenKhachHang;
            this.sDTKhachHang = SDTKhachHang;
            this.soTienTichLuy = SoTienTichLuy;
        }
        public CKhachHang(DataRow row)
        {
            this.iDKhachHang = (int)row["IDKhachHang"];
            this.cMND = (int)row["CMND"];
            this.tenKhachHang = row["TenKhachHang"].ToString();
            this.sDTKhachHang = row["SDTKhachHang"].ToString();
            this.soTienTichLuy = (float)row["SoTienTichLuy"];
        }
    }
}
