using QuanLyNhaHang.QLNhaHangDataSetTableAdapters;
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
    public partial class frmLuong : Form
    {
        public frmLuong()
        {
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {
            DataTable1TableAdapter a = new DataTable1TableAdapter();
            dataGridViewX1.DataSource = a.GetData();
        }


    }
}
