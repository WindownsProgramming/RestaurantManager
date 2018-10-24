using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CThanhPhanMonAn
    {
        /*IDMonAn INT,
	IDNguyenLieu INT,
	SoLuongNL FLOAT,*/
        int iDMonAn;

        public int IDMonAn
        {
            get { return iDMonAn; }
            set { iDMonAn = value; }
        }
        int iDNguyenLieu;

        public int IDNguyenLieu
        {
            get { return iDNguyenLieu; }
            set { iDNguyenLieu = value; }
        }
        float soLuongNL;

        public float SoLuongNL
        {
            get { return soLuongNL; }
            set { soLuongNL = value; }
        }

        public CThanhPhanMonAn() { }

        public CThanhPhanMonAn(int iDMonAn,int iDNguyenLieu,float soLuongNL) 
        {
            this.IDMonAn = iDMonAn;
            this.iDNguyenLieu = iDNguyenLieu;
            this.soLuongNL = soLuongNL;
        }
      
        public CThanhPhanMonAn(DataRow row)
        {
            this.IDMonAn = (int)row["IDMonAn"];
            this.iDNguyenLieu = (int)row["IDNguyenLieu"];
            this.soLuongNL = (int)row["SoLuongNL"];
        }
    }
}
