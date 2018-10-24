using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DTO
{
    /*IDLuong INT IDENTITY PRIMARY KEY,
	IDLoaiNV INT,
	IDCa INT,
	Tien FLOAT,
	FOREIGN KEY(IDCa) REFERENCES dbo.CaLam(IDCa),
	FOREIGN KEY(IDLoaiNV) REFERENCES dbo.LoaiNV(IDLoaiNV)*/
    public class CBangLuong
    {
        private int iDLuong;

        public int IDLuong
        {
            get { return iDLuong; }
            set { iDLuong = value; }
        }
        private int iDLoaiNV;

        public int IDLoaiNV
        {
            get { return iDLoaiNV; }
            set { iDLoaiNV = value; }
        }
        private int idCa;

        public int IdCa
        {
            get { return idCa; }
            set { idCa = value; }
        }
        private float tienLuong;

        public float TienLuong
        {
            get { return tienLuong; }
            set { tienLuong = value; }
        }
        public CBangLuong() { }
        public CBangLuong(int IDLuong, int IDLoaiNV, int IdCa, float TienLuong)
        {
            this.iDLuong = IDLuong;
            this.iDLoaiNV = IDLoaiNV;
            this.idCa = IdCa;
            this.tienLuong = TienLuong;
        }
        public CBangLuong(DataRow row) 
        {
            this.iDLuong = (int)row["IDLuong"];
            this.iDLoaiNV = (int)row["IDLoaiNV"];
            this.idCa = (int)row["IDCa"];
            this.tienLuong = (float)row["TienLuong"];
        }
    }
}
