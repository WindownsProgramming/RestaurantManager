using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    /*CREATE TABLE CaLam
(
	IDCa INT IDENTITY PRIMARY KEY,
	TenCa NVARCHAR(20),
	GioBDCa TIME,
	GioHetCa TIME
)*/
    public class CCaLam
    {
        private int iDCa;

        public int IDCa
        {
            get { return iDCa; }
            set { iDCa = value; }
        }
        private String tenCa;

        public String TenCa
        {
            get { return tenCa; }
            set { tenCa = value; }
        }
        private DateTime? gioBDCa;

        public DateTime? GioBDCa
        {
            get { return gioBDCa; }
            set { gioBDCa = value; }
        }
        private DateTime? gioHetCa;

        public DateTime? GioHetCa
        {
            get { return gioHetCa; }
            set { gioHetCa = value; }
        }
        public CCaLam() { }
        public CCaLam(int IDCa, String TenCa, DateTime? GioBDCa, DateTime? GioHetCa) 
        {
            this.iDCa = IDCa;
            this.tenCa = TenCa;
            this.gioBDCa = GioBDCa;
            this.gioHetCa = GioHetCa;
        }
        public CCaLam(DataRow row) 
        {
            this.iDCa = (int)row["IDCa"];
            this.tenCa = row["TenCa"].ToString();
            this.gioBDCa = (DateTime?)row["GioBDCa"];
            this.gioHetCa = (DateTime?)row["GioHetCa"];
        }

    }
    
}
