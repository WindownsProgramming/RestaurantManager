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
    public partial class frmQLNhanVien : Form
    {
        qlNhaHangDataContext db = new qlNhaHangDataContext();
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            loadDuLieu();

        }

        #region Load dữ liệu
        
        private void loadDuLieu()
        {
            loadDanhSachLoaiNV();
            loadDanhSachNhanVien();
            loadLoaiNV();

            Addbindding();

            btn_SuaNV.Enabled = true;
            btn_XoaNV.Enabled = true;

            
        }

        //load danh sachs LOẠI NV
        public void loadDanhSachLoaiNV()
        {
            String query = "SELECT * FROM dbo.LoaiNV";
            dataGridViewX1.DataSource = DataProviderDAO.Provider.ExcuteQuery(query);
        }
        
        //add bindding
        public void Addbindding()
        {
            txt_MaLoaiNV.DataBindings.Clear();
            txt_TenLoaiNV.DataBindings.Clear();
            txt_hsl.DataBindings.Clear();
            txt_TenNV.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            txt_DiaChi.DataBindings.Clear();
            txt_GhiChu.DataBindings.Clear();

            lbid.DataBindings.Clear();

            txt_MaLoaiNV.DataBindings.Add(new Binding("Text", dataGridViewX1.DataSource, "IDLoaiNV"));
            txt_TenLoaiNV.DataBindings.Add(new Binding("Text", dataGridViewX1.DataSource, "TenLoaiNV"));
            txt_hsl.DataBindings.Add(new Binding("Text", dataGridViewX1.DataSource, "HeSo"));
            txt_TenNV.DataBindings.Add(new Binding("Text", dataGridViewX2.DataSource, "TenNV"));
            txt_SDT.DataBindings.Add(new Binding("Text", dataGridViewX2.DataSource, "SDT"));
            txt_DiaChi.DataBindings.Add(new Binding("Text", dataGridViewX2.DataSource, "DiaChi"));
            txt_GhiChu.DataBindings.Add(new Binding("Text", dataGridViewX2.DataSource, "GhiChu"));
            lbid.DataBindings.Add(new Binding("Text", dataGridViewX2.DataSource, "IDNhanVien"));
            
        }
        //load danh sách NhanVien
        public void loadDanhSachNhanVien()
        {
            String query = "SELECT * FROM dbo.NhanVien ";
            dataGridViewX2.DataSource = DataProviderDAO.Provider.ExcuteQuery(query);
        }
        
        //load loaiNV vào combobox
        public void loadLoaiNV()
        {
            List<LoaiNV> danhsach = linqToSql.Instance.loadLoaiNv();
            comboBox1.DataSource = danhsach;
            comboBox1.DisplayMember = "TenLoaiNV";
            comboBox1.ValueMember = "IDLoaiNV";
        }
        #endregion
        
        #region INSERT/UPDATE/DELETE LOẠI NHÂN VIÊN
        
        
        //thêm Loại NHÂN VIÊN
        int them = 0;     
        private void btn_ThemLoaiNV_Click(object sender, EventArgs e)
        {
            if (them == 0)
            {
                btn_SuaLoaiNV.Enabled = false;
                btn_XoaLoaiNV.Enabled = false;
                txt_MaLoaiNV.Text = "";
                txt_TenLoaiNV.Enabled = true;
                txt_TenLoaiNV.Text = "";
                txt_hsl.Enabled = true;
                txt_hsl.Text = "";

                btn_ThemLoaiNV.Text = "Lưu";
                txt_TenLoaiNV.Focus();
                them = 1;
                return;

            }
            if(them==1) // là lưu lại
            {
                btn_ThemLoaiNV.Text = "Thêm";
                if (linqToSql.Instance.ktraLoaiNV(txt_TenLoaiNV.Text) == true && txt_TenLoaiNV.Text.Length != 0)
                {
                    int hs =0;
                    if(txt_hsl.Text=="") hs = 0;
                    try 
                    {
                        hs = Int32.Parse(txt_hsl.Text.ToString());
                    }
                    catch 
                    {
                        hs = 0;
                    }
                    if (hs < 0) hs = 0;
                    linqToSql.Instance.ThemLoaiNV(txt_TenLoaiNV.Text,hs);
                    btn_SuaLoaiNV.Enabled = true;
                    btn_XoaLoaiNV.Enabled = true;
                    them = 0;
                    txt_TenLoaiNV.Enabled = false;
                    loadDuLieu();  
                    return;
                }
                else 
                {
                    MessageBox.Show("Thêm Không thành công");                                    
                    them = 0;
                    loadDuLieu();  
                    return;
                }

                
            }
        }
        
        
        //xóa Loại NHÂN VIÊN
        private void btn_XoaLoaiNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Bạn có chắc xóa Loại Nhân viên này ?"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = linqToSql.Instance.ktraKhoaNgoaiLoaiLV(Int32.Parse(txt_MaLoaiNV.Text.ToString()));
                if (kq == true)
                {
                    linqToSql.Instance.xoaLoaiNhanVien(Int32.Parse(txt_MaLoaiNV.Text.ToString()));
                    loadDuLieu();
                }
                else
                {
                    MessageBox.Show("Không được xóa Loại NV này");
                    loadDuLieu();
                }
            }
        }
        
        
        // sửa LOẠI NHÂN VIÊN
        int sua = 0;
        private void btn_SuaLoaiNV_Click(object sender, EventArgs e)
        {
            if (sua == 0)
            {
                btn_ThemLoaiNV.Enabled = false;
                btn_XoaLoaiNV.Enabled = false;
                txt_TenLoaiNV.Enabled = true;
                
                btn_SuaLoaiNV.Text = "Lưu";
                txt_hsl.Enabled = true;
                
                sua = 1;
                return;

            }
            if (sua == 1) // là lưu lại
            {



                if ( txt_TenLoaiNV.Text.Length != 0)
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc Sửa LoạiNhânviên này ?"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        int hs = 0;
                        if (txt_hsl.Text == "") hs = 0;
                        try
                        {
                            hs = Int32.Parse(txt_hsl.Text.ToString());
                        }
                        catch
                        {
                            hs = 0;
                        }
                        if (hs < 0) hs = 0;
                        linqToSql.Instance.SuaLoaiNV(Int32.Parse(txt_MaLoaiNV.Text.ToString()), txt_TenLoaiNV.Text,hs);
                    
                    }

                }
                btn_SuaLoaiNV.Text = "Sửa";
                loadDuLieu();
                sua = 0;
                txt_TenLoaiNV.Enabled = false;
                return;
            }
        }
        
        #endregion 


        int themnv = 0;
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {

            if (themnv == 0)
            {
                btn_ThemNV.Text = "Lưu";

                btn_SuaNV.Enabled = false;
                btn_XoaNV.Enabled = false;

                txt_GhiChu.Text = "";
                txt_SDT.Text = "";
                txt_TenNV.Text = "";
                txt_DiaChi.Text = "";

                txt_TenNV.Focus();

                themnv = 1;
                return;

            }
            if (themnv == 1) // là lưu lại
            {
                btn_ThemLoaiNV.Text = "Thêm";

                NhanVien a = new NhanVien() { TenNV = txt_TenNV.Text, IDLoaiNV = (int)comboBox1.SelectedValue ,SDT = txt_SDT.Text.ToString(), DiaChi = txt_DiaChi.Text, GhiChu = txt_GhiChu.Text };

                linqToSql.Instance.ThemNV(a);
                loadDuLieu();
                themnv = 0;
                txt_TenLoaiNV.Enabled = false;
                return;
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Bạn có chắc xóa Nhân viên này ?"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int id = Int32.Parse(lbid.Text.ToString());
                if (linqToSql.Instance.ktraKhoaNgoaiNV(id))
                    linqToSql.Instance.xoaNhanVien(Int32.Parse(lbid.Text.ToString()));
                else
                    MessageBox.Show("Xóa không thành công !");
                loadDuLieu();
               
               
                // MessageBox.Show("Không được xóa Loại NV này");
                //loadDuLieu();
                
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            int loai = (int)comboBox1.SelectedValue;
            NhanVien c = new NhanVien() { IDNhanVien = Int32.Parse(lbid.Text.ToString()), TenNV = txt_TenNV.Text, IDLoaiNV = loai, SDT = txt_SDT.Text.ToString(), DiaChi = txt_DiaChi.Text, GhiChu = txt_GhiChu.Text };
            linqToSql.Instance.SuaNV(c);
            loadDuLieu();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

     



    }
}
