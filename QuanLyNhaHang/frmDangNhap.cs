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
    public partial class frmDangNhap : Form
    {
        qlNhaHangDataContext db = new qlNhaHangDataContext();
        public frmDangNhap()
        {
            InitializeComponent();
            
        }

       

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền vào TenTaiKhoan");
                return;
            }
            if (txt_MatKhau.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền Mật Khẩu");
                return;
            }
            String tenDN = txt_TaiKhoan.Text;
            String mk = txt_MatKhau.Text;
            if (checkLogin(tenDN,mk))
            {
                frmBanHang f = new frmBanHang();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else 
            {
                MessageBox.Show("Vui lòng kiểm tra lại đăng nhập !");
            }
        }
        //kiểm tra đăng nhập
        bool checkLogin(String tenDN, String matkhau)
        {

            return linqToSql.Instance.ktraDN(tenDN, matkhau);
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
