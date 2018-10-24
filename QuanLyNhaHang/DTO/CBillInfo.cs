using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    public class CBillInfo
    {
        /*IDBillInfo INT IDENTITY PRIMARY KEY,
	IDBill INT,
	IDMonAn INT,
	SoLuong INT,*/
        int iDBillInfo;

        public int IDBillInfo
        {
            get { return iDBillInfo; }
            set { iDBillInfo = value; }
        }
        int iDBill;

        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }
        int iDMonAn;

        public int IDMonAn
        {
            get { return iDMonAn; }
            set { iDMonAn = value; }
        }
        int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public CBillInfo()
        { 

        }
        public CBillInfo(int IDBillInfo, int IDBill, int IDMonAn, int SoLuong)
        {
            this.iDBillInfo = IDBillInfo;
            this.iDBill = IDBill;
            this.iDMonAn = IDMonAn;
            this.soLuong = SoLuong;
        }
        public CBillInfo(DataRow row)
        {
            this.iDBillInfo = (int)row["IDBillInfo"];
            this.iDBill = (int)row["IDBill"];
            this.iDMonAn = (int)row["IDMonAn"];
            this.soLuong = (int)row["SoLuong"];
        }
    }
}
