using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CBanAn
    {
        /*IDBanAn INT IDENTITY PRIMARY KEY,
	TenBanAn NVARCHAR(30),
	TinhTrangBan INT -- 0 : chưa có chỗ, 1 có chỗ rồi, 2 -- đã được đặt trc*/
        private int iDBanAn;

        public int IDBanAn
        {
            get { return iDBanAn; }
            set { iDBanAn = value; }
        }
        private String tenBanAn;

        public String TenBanAn
        {
            get { return tenBanAn; }
            set { tenBanAn = value; }
        }
        private int tinhTrangBan;

        public int TinhTrangBan
        {
            get { return tinhTrangBan; }
            set { tinhTrangBan = value; }
        }
        public CBanAn() { }
        public CBanAn(int IDBanAn, String TenBanAn, int TinhTrangBan) 
        {
            this.iDBanAn = IDBanAn;
            this.tenBanAn = TenBanAn;
            this.tinhTrangBan = TinhTrangBan;
        }
        public CBanAn(DataRow row) 
        {
            this.iDBanAn = (int)row["IDBanAn"];
            this.tenBanAn = row["TenBanAn"].ToString();
            this.tinhTrangBan = (int)row["TinhTrangBan"];
        }

    }
}
