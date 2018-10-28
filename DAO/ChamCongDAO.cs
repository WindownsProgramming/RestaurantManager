using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.DAO
{
    public class ChamCongDAO
    {
        private static ChamCongDAO instance;

        public static ChamCongDAO Instance
        {
            get { if (instance == null) instance = new ChamCongDAO(); return ChamCongDAO.instance; }
            set { ChamCongDAO.instance = value; }
        }
        public ChamCongDAO() { }

        public void ThemChamCong(int idNV,int idCa,String ghichu)
        {
            String que = " INSERT INTO dbo.ChamCong ( IDNhanVien, IDCa, GhiChu ) VALUES  ("+ idNV+ ","+ idCa+ ",'"+ghichu+" ')" ;

            DataProviderDAO.Provider.ExcuteQuery(que);
        }
        public bool XoaChamCong(int id)
        {
            try
            {
                String que = "  DELETE dbo.ChamCong WHERE IDChamCong = " + id;
                DataProviderDAO.Provider.ExcuteQuery(que);
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
