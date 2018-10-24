using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CBill
    {
        /*IDBill INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE,
	DateCheckOut DATE,
	IDBanAn INT,
	TrangThai INT, ----0 : chưa thanh toán, 1- đã thanh toán
	IDNhanVien INT,
	TongTien INT DEFAULT 0,*/
        private int iDBill;

        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }
        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        private int iDBanAn;

        public int IDBanAn
        {
            get { return iDBanAn; }
            set { iDBanAn = value; }
        }
        private int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        int iDNhanVien;

        public int IDNhanVien
        {
            get { return iDNhanVien; }
            set { iDNhanVien = value; }
        }
        int tongTien;

        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public CBill() {}
        public CBill(int IDBill, DateTime? DateCheckIn, DateTime? DateCheckOut, int IDBanAn, int TrangThai, int IDNhanVien, int TongTien)
        {
            this.iDBill = IDBill;
            this.dateCheckIn = DateCheckIn;
            this.dateCheckOut = DateCheckOut;
            this.iDBanAn = IDBanAn;
            this.trangThai = TrangThai;
            this.iDNhanVien = IDNhanVien;
            this.tongTien = TongTien;
            
        }
        public CBill(DataRow row) 
        {
            this.iDBill = (int)row["IDBill"];
            this.dateCheckIn = (DateTime?)row["DateCheckIn"];
            this.dateCheckOut = (DateTime?)row["DateCheckOut"];
            this.iDBanAn = (int)row["IDBanAn"];
            this.trangThai = (int)row["TrangThai"];
            this.iDNhanVien = (int)row["IDNhanVien"];
            this.tongTien = (int)row["TongTien"];
        }
    }
}
