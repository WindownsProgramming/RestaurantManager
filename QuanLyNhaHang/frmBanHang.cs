using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using QuanLyNhaHang.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmBanHang : DevComponents.DotNetBar.Office2007Form
    {
        qlNhaHangDataContext db = new qlNhaHangDataContext();
        public frmBanHang()
        {
            InitializeComponent();         
            loadData();
        }
        private void loadData()
        {
            //load loại món
            loadLoaiMonAn();
            //load bàn ăn
            loadTableFood();
            //load danh sách bàn trống
            loadBanTrong();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            
            
            //var a = from tableFood in db.BanAns where tableFood.TinhTrangBan == 0 select tableFood;
            //cb_ChuyenBan.DataSource = a;
            

        }
        

        //load bàn trống vào cb Chuyển bàn
        private void loadBanTrong()
        {
            List<BanAn> dsBanTrong = linqToSql.Instance.listBanAnTrong();
            cb_ChuyenBan.DataSource = dsBanTrong.ToList();
            cb_ChuyenBan.DisplayMember = "IDBanAn";
            cb_ChuyenBan.ValueMember = "IDBanAn";
        }


        // Load Loại Món ăn vào combox
        private void loadLoaiMonAn()
        {
             this.loaiMonAnTableAdapter.Fill(this.qLNhaHangDataSet.LoaiMonAn);
        }
        
        
        //Load thức ăn Theo Loại Món Ăn
        void load_ThucAnTheoLoaiThucAn(int IDLoaiMon)
        {
            List<CMonAn> dsMonAn = MonAnDAO.Instance.showListFoodByCategory(IDLoaiMon);
            cb_MonAn.DataSource = dsMonAn;
            cb_MonAn.DisplayMember = "TenMonAn";
        }
        
        
        //sự kiện cb_LoaiMonAn_SelectedIndexChanged
        private void cb_LoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idLoaiMon = 0;
            if (cb_LoaiMonAn.SelectedItem == null)
                return;
            idLoaiMon = Int16.Parse(cb_LoaiMonAn.SelectedValue.ToString());
            load_ThucAnTheoLoaiThucAn(idLoaiMon);
        }


        //load danh sách bàn ăn vaò flowLayoutPanel
        void loadTableFood()
        {
            flowLayoutPanel1.Controls.Clear();
            List<CBanAn> listBanAn = BanAnDAO.Instance.loadListTableFood();//lấy ra được danh sách table
            foreach (CBanAn item in listBanAn)
            {
                Button btn = new Button() { Width = 226, Height = 170 };
                btn.Text = "Bàn "+item.IDBanAn + Environment.NewLine + item.TinhTrangBan;
                //setting event cho nó
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.TinhTrangBan)
                {
                    case 0:
                        btn.BackColor = Color.AliceBlue;
                        break;
                    default:
                        btn.BackColor = Color.Yellow;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }


        //sự kiện cho mõi khi click vào 1 bàn ăn ====> Show ra cái Hóa đơn tương ứng
        void btn_Click(object sender, EventArgs e)
        {
            int idBanAn = ((sender as Button).Tag as CBanAn).IDBanAn;
            lv_HoaDon.Tag = (sender as Button).Tag;
            showBill(idBanAn);
        }


        // hiển thị hóa đơn
        void showBill(int idTable)
        {
            lv_HoaDon.Items.Clear();
            List<CListFoodOfTable> listInfoBill = ListFoodOfTableDAO.Instance.showListFoodOfTable(idTable);
            float total = 0;//thành tiền
            foreach (CListFoodOfTable item in listInfoBill)
            {
                ListViewItem lv = new ListViewItem(item.NameFood.ToString());
                lv.SubItems.Add(item.CountFood.ToString());
                lv.SubItems.Add(item.Price.ToString());
                lv.SubItems.Add(item.Total.ToString());

                total += item.Total;

                lv_HoaDon.Items.Add(lv);

            }
            total -= total * (int)nbr_GiamGia.Value / (float)100;
            txt_TongTien.Text = total.ToString();
        }


        //thêm món ăn vào bill
        private void btn_ThemMonAn_Click(object sender, EventArgs e)
        {
            
            //lấy ra cái table hiện tại
            CBanAn tbf = lv_HoaDon.Tag as CBanAn;
            if (tbf == null) return;
            //lấy cái idFood 
            if (cb_MonAn.Text == "") return;
            int idFood = (cb_MonAn.SelectedItem as CMonAn).IDMonAn;
            
            //lấy số lượng
            int count = (int)nbr_SoLuongMon.Value;
            //lấy ra cái idbill
            int idBill = BillDAO.Instance.iDBill(tbf.IDBanAn);
            if (idBill == -1)//chưa có cái bill nào
            {
                //thêm bill mới
                BillDAO.Instance.insertBill(tbf.IDBanAn,1);///////// chưa Bk thằng NHÂN VIÊN NÀO nên cho là 1 để DEMO
                //lấy ra cái IdBill vừa mới thêm vào
                int idNewBill;
                try
                {
                    string query = " SELECT Max(dbo.Bill.IDBill) FROM dbo.Bill ";
                    idNewBill = (int)DataProviderDAO.Provider.ExcuteScalar(query);
                }
                catch
                {
                    idNewBill = -1;
                }
                BillInfoDAO.Instance.insertBillInfo(idNewBill, idFood, count);
                //load lại bàn
                loadTableFood();
                loadBanTrong();
            }
            else //bill đã tồn tại
            {
                BillInfoDAO.Instance.insertBillInfo(idBill, idFood, count);
                
            }
            showBill(tbf.IDBanAn);
            

        }


        //Thanh toán bill
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            /*
             * Bill hiện tại không có (-1) 
             * bill thanh toán rồi  --> không làm gì hết
             * bill chưa thành toán bắt đầu thanh toán -- > hỏi trước khi thanh toán 
             */
            //lấy ra cái bàn hiện tại
            CBanAn tbf = lv_HoaDon.Tag as CBanAn;
            if(tbf==null) return;
            if (tbf.TinhTrangBan == 0) return;
            //lấy idbill
            int idBill = BillDAO.Instance.iDBill(tbf.IDBanAn);
            int tongtien = Int32.Parse(txt_TongTien.Text.ToString());
            int giamgia = (int)nbr_GiamGia.Value;
            if (idBill != -1)//tồn tại cái bill
            {
                if (MessageBox.Show("Bạn có muốn thanh toán cho bàn " + tbf.TenBanAn, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.payBill(idBill,tongtien,giamgia);
                    showBill(tbf.IDBanAn);
                    loadTableFood();
                }
            }
            
          
        }
        

        //chuyển bàn
        private void btn_OKChuyenBan_Click(object sender, EventArgs e)
        {
            int idNhanVien = 1;
            int id1 = (lv_HoaDon.Tag as CBanAn).IDBanAn;

            int id2 = Int32.Parse(cb_ChuyenBan.SelectedValue.ToString());
            
                BanAnDAO.Instance.ChuyenBan(id1, id2,idNhanVien);
                loadTableFood();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
     
        //thêm bàn
        private void btn_OKThemBan_Click(object sender, EventArgs e)
        {
            int sl = (int)nbr_ThemBan.Value;
            if (sl < 1) return;
            else
            {
                BanAnDAO.Instance.ThemBan(sl);
                loadTableFood();
            }

        }

       

    
    }
}
