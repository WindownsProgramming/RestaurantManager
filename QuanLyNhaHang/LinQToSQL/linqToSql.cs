using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.Linq
{
    public class linqToSql
    {
        private static linqToSql instance;
        public qlNhaHangDataContext db = new qlNhaHangDataContext();
        public static linqToSql Instance
        {
            get { if (instance == null) instance = new linqToSql(); return linqToSql.instance; }
            set { linqToSql.instance = value; }
        }
        public linqToSql() { }


        //load danh sách bàn trống
        public List<BanAn> listBanAnTrong()
        {
            
            return (from tableFood in db.BanAns where tableFood.TinhTrangBan == 0 select tableFood).ToList<BanAn>();
        }

        //kiểm tra đăng nhập
        public Boolean ktraDN(String tk, String mk)
        {
            var kq = (from acc in db.Accounts
                    where acc.TenTaiKhoan.Equals(tk) == true && acc.MatKhau.Equals(mk) == true
                    select acc);
            if (kq.Count() == 0)
            { return false; }
            else
            { return true; }
        }

        //load loại nhân viên
        public List<LoaiNV> loadLoaiNv()
        {
            return (from l in db.LoaiNVs select l).ToList<LoaiNV>();
        }

        //thêm loại NHÂN VIÊN
        //ktra có Loại NV đó chưa
        public bool ktraLoaiNV(String tenL)
        {
            var kq =(from l in db.LoaiNVs
                     where l.TenLoaiNV.Equals(tenL) == true
                     select l);
            if (kq.Count() == 0)
                return true;
            else return false;
        }
        //thêm LOẠI Nhân Viên
        public void ThemLoaiNV(String tenL,int hs)
        {
                LoaiNV loai = new LoaiNV() { TenLoaiNV = tenL,HeSo = hs };
                db.LoaiNVs.InsertOnSubmit(loai);
                db.SubmitChanges();      
        }



        //kiểm tra khóa ngoại LOAI NHÂN VIÊN
        public bool ktraKhoaNgoaiLoaiLV(int idLoai)
        {
            var kq = (from nv in db.NhanViens
                      where nv.IDLoaiNV == idLoai
                      select nv);
            if (kq.Count() == 0)
                return true;
            return false;             
        }
        //xóa  LOAI nhân viên
        public void xoaLoaiNhanVien(int idLoai)
        {
            LoaiNV nv = (db.LoaiNVs.Where(p => p.IDLoaiNV == idLoai)).SingleOrDefault();
            db.LoaiNVs.DeleteOnSubmit(nv);
            db.SubmitChanges();
        }
        //sửa Loại Nhân viên
        public void SuaLoaiNV(int idLoai,String tenL,int hs)
        {
            LoaiNV nv = (from a in db.LoaiNVs where a.IDLoaiNV==idLoai select a).SingleOrDefault();
            nv.TenLoaiNV = tenL;
            nv.HeSo = hs;
            db.SubmitChanges();
        }


        //Thêm NHAN VIÊN
        public void ThemNV(NhanVien nv)
        {
            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();
        }

        //Sửa NHÂN VIÊN
        public void SuaNV(NhanVien nv)
        {
            NhanVien n = (db.NhanViens.Where(p => p.IDNhanVien == nv.IDNhanVien)).SingleOrDefault();
            n.TenNV = nv.TenNV;
            n.IDLoaiNV = nv.IDLoaiNV;
            n.SDT = nv.SDT;
            n.DiaChi = nv.DiaChi;
            n.GhiChu = nv.GhiChu;

            db.SubmitChanges();
        }


        //kiểm tra khóa ngoại ID NHÂN VIÊN
        public bool ktraKhoaNgoaiNV(int idNV)
        {
            //kiểm tra trong bảng chấm công có nhân viên đó k ?
            var kq1 = (from cc in db.ChamCongs
                      where cc.IDNhanVien == idNV
                      select cc);
            //ktra trong bản nhập kho có nv đó k ?
            var kq2 = (from nk in db.NhapKhos
                       where nk.IDNhanVien == idNV
                       select nk);
            var kq3 = (from bill in db.Bills
                       where bill.IDNhanVien == idNV
                       select bill);
            var kq4 = (from dban in db.DatBans
                       where dban.IDNhanVien == idNV
                       select dban);
            var kq5 = (from acc in db.Accounts
                       where acc.IDNhanVien == idNV
                       select acc);
            if ((kq1.Count() + kq2.Count() + kq3.Count() + kq4.Count()+kq5.Count()) == 0)
                return true;
            return false;
        }
        //xóa Nhân viên
        public void xoaNhanVien(int idNV)
        {
            if (ktraKhoaNgoaiNV(idNV))
            {
                NhanVien nv = (db.NhanViens.Where(p => p.IDNhanVien == idNV)).SingleOrDefault();
                db.NhanViens.DeleteOnSubmit(nv);
                db.SubmitChanges();

            }
 
        }

        #region Them/ Xóa/ Sửa CA LÀM
        //Thêm ca
        public bool ThemCa(CaLam ca)
        {
            try 
            {

                db.CaLams.InsertOnSubmit(ca);
                db.SubmitChanges();

                return true;
            }
            catch {
                return false;
            }
        }
        //xóa ca
        public void XoaCa(int id)
        {
            CaLam ca = (from l in db.CaLams
                        where l.IDCa == id
                        select l).SingleOrDefault();
            db.CaLams.DeleteOnSubmit(ca);
            db.SubmitChanges();
        }
        //sửa ca
        public bool SuaCa(CaLam ca)
        {
            try
            {
                CaLam cl = (from c in db.CaLams
                            where c.IDCa == ca.IDCa
                            select c).SingleOrDefault();
                cl.GioBDCa = ca.GioBDCa;
                cl.GioHetCa = ca.GioHetCa;
                cl.TenCa = ca.TenCa;
                cl.TienCong = ca.TienCong;
                
                db.SubmitChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        #endregion


        #region Them/Xoa/Sua ChamCong
        public bool ThemChamCong(ChamCong cc)
        {
            try
            {
                db.ChamCongs.InsertOnSubmit(cc);
                db.SubmitChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool XoaChamCong(int id)
        {
            try
            {
                ChamCong cc = (from c in db.ChamCongs where c.IDChamCong == id select c).SingleOrDefault(); ;
                db.ChamCongs.DeleteOnSubmit(cc);
                return true;
                
            }
            catch
            {
                return false;
            }
        }
        
        #endregion

    }
}
