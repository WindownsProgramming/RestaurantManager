using QuanLyNhaHang.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmCaLam : Form
    {
        public frmCaLam()
        {
            InitializeComponent();
        }

        private void frmCaLam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaHangDataSet.CaLam' table. You can move, or remove it, as needed.
            this.caLamTableAdapter.Fill(this.qLNhaHangDataSet.CaLam);

            loadData();
        }
        private void loadData()
        {
             // TODO: This line of code loads data into the 'qLNhaHangDataSet.CaLam' table. You can move, or remove it, as needed.
            this.caLamTableAdapter.Fill(this.qLNhaHangDataSet.CaLam);
        }
        #region THÊM / XÓA / SỬA CaLÀM
        int them = 0;
        private void btn_ThemLoaiNV_Click(object sender, EventArgs e)
        {
            if (them == 0)
            {
                txt_MaCa.Text = "";
                txt_TenCa.Text = "";
                txt_MaCa.Text = "";
                txt_GioBD.Text = "";
                txt_GioKT.Text = "";
                
                txt_TenCa.Enabled = true;
                txt_TienCong.Enabled = true;
                txt_GioBD.Enabled = true;
                txt_GioKT.Enabled = true;

                btn_ThemCa.Text = "Lưu";
                btn_SuaCa.Enabled = false;
                btn_XoaCa.Enabled = false;
                them = 1;
                return;
            }
            if (them == 1)
            {
                TimeSpan gioBD,gioKT;
                String tenCa = txt_TenCa.Text;
                try
                {
                    gioBD = TimeSpan.Parse(txt_GioBD.Text);
                }
                catch 
                {
                    MessageBox.Show("Thêm không thành công !");
                    them = 0;
                    btn_ThemCa.Text = "Thêm";
                    return;
                }

                try
                {
                    gioKT = TimeSpan.Parse(txt_GioBD.Text);
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công !");
                    them = 0;
                    btn_ThemCa.Text = "Thêm";
                    return;
                }
                int tienCong;
                if (txt_TienCong.Text == "") tienCong = 0;
                 tienCong= Int32.Parse(txt_TienCong.Text);
                if (tienCong < 0) tienCong = 0;
                CaLam cl = new CaLam() {TenCa=tenCa,GioBDCa=gioBD,GioHetCa=gioKT,TienCong=tienCong };
                if (linqToSql.Instance.ThemCa(cl))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
                    
                them = 0;
                btn_ThemCa.Text = "Thêm";
                btn_XoaCa.Enabled = true;
                btn_SuaCa.Enabled = true;
                loadData();
                return;
                
 
            }
        }

        private void btn_XoaLoaiNV_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_MaCa.Text);
            linqToSql.Instance.XoaCa(id);
            loadData();
        }


        int sua = 0;
        private void btn_SuaLoaiNV_Click(object sender, EventArgs e)
        {
            if (sua == 0)
            {
                
                
                txt_TenCa.Enabled = true;
                txt_TienCong.Enabled = true;
                txt_GioBD.Enabled = true;
                txt_GioKT.Enabled = true;

                btn_SuaCa.Text = "Lưu";
                btn_ThemCa.Enabled = false;
                btn_XoaCa.Enabled = false;
                sua = 1;
                return;
            }
            if (sua == 1)
            {
                int id = Int32.Parse(txt_MaCa.Text);
                TimeSpan gioBD, gioKT;
                String tenCa = txt_TenCa.Text;
                try
                {
                    gioBD = TimeSpan.Parse(txt_GioBD.Text);
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công !");
                    sua = 0;
                    btn_SuaCa.Text = "Sửa";
                    return;
                }

                try
                {
                    gioKT = TimeSpan.Parse(txt_GioBD.Text);
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công !");
                    sua = 0;
                    btn_SuaCa.Text = "Sửa";
                    return;
                }
                int tienCong;
                if (txt_TienCong.Text == "") tienCong = 0;
                try{
                    tienCong = Int32.Parse(txt_TienCong.Text);
                }
                catch { tienCong = 0; }
                
                if (tienCong < 0) tienCong = 0;
                CaLam cl = new CaLam() { TenCa = tenCa, GioBDCa = gioBD, GioHetCa = gioKT, TienCong = tienCong, IDCa = id };
                if (linqToSql.Instance.SuaCa(cl))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");

                sua = 0;
                btn_SuaCa.Text = "Sửa";
                btn_XoaCa.Enabled = true;
                btn_ThemCa.Enabled = true;
                loadData();
                return;
            }
                
        }
        #endregion
    }
}
