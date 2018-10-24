using QuanLyNhaHang.DAO;
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
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
           loadData();

        }
        private void loadData()
        {
             // TODO: This line of code loads data into the 'qLNhaHangDataSet.CaLam' table. You can move, or remove it, as needed.
            this.caLamTableAdapter.Fill(this.qLNhaHangDataSet.CaLam);
            // TODO: This line of code loads data into the 'qLNhaHangDataSet.ChamCong' table. You can move, or remove it, as needed.
            this.chamCongTableAdapter.Fill(this.qLNhaHangDataSet.ChamCong);
            // TODO: This line of code loads data into the 'qLNhaHangDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNhaHangDataSet.NhanVien);
        }
        private void btn_ThemChamCong_Click(object sender, EventArgs e)
        {
            int idnv = Int32.Parse(cb_MaNV.SelectedValue.ToString());
            int idca = Int32.Parse(cb_CaLam.SelectedValue.ToString());
            String ghichu = txt_GhiChu.Text.ToString();
            ChamCongDAO.Instance.ThemChamCong(idnv,idca,ghichu);
            loadData();
        }

        private void btn_XoaChamCong_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbid.Text.ToString());
            if (ChamCongDAO.Instance.XoaChamCong(id))
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            
            loadData();
        }

    }
}
