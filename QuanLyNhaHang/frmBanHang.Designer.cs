namespace QuanLyNhaHang
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.cb_ChuyenBan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_OKChuyenBan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_GhepBan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.banAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaHangDataSet = new QuanLyNhaHang.QLNhaHangDataSet();
            this.nbr_GiamGia = new System.Windows.Forms.NumericUpDown();
            this.button8 = new System.Windows.Forms.Button();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_TongTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_ThanhToan = new DevComponents.DotNetBar.ButtonX();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lv_HoaDon = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.btn_ThemMonAn = new DevComponents.DotNetBar.ButtonX();
            this.nbr_SoLuongMon = new System.Windows.Forms.NumericUpDown();
            this.cb_MonAn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cb_LoaiMonAn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.loaiMonAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banAnBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loaiMonAnTableAdapter = new QuanLyNhaHang.QLNhaHangDataSetTableAdapters.LoaiMonAnTableAdapter();
            this.billInfoTableAdapter1 = new QuanLyNhaHang.QLNhaHangDataSetTableAdapters.BillInfoTableAdapter();
            this.banAnTableAdapter = new QuanLyNhaHang.QLNhaHangDataSetTableAdapters.BanAnTableAdapter();
            this.nbr_ThemBan = new System.Windows.Forms.NumericUpDown();
            this.btn_OKThemBan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelEx5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_GiamGia)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuongMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiMonAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banAnBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_ThemBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelEx5);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panelEx2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 692);
            this.panel1.TabIndex = 5;
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx5.Controls.Add(this.btn_OKThemBan);
            this.panelEx5.Controls.Add(this.nbr_ThemBan);
            this.panelEx5.Controls.Add(this.cb_ChuyenBan);
            this.panelEx5.Controls.Add(this.btn_OKChuyenBan);
            this.panelEx5.Controls.Add(this.button2);
            this.panelEx5.Controls.Add(this.cb_GhepBan);
            this.panelEx5.Controls.Add(this.nbr_GiamGia);
            this.panelEx5.Controls.Add(this.button8);
            this.panelEx5.Controls.Add(this.panelEx3);
            this.panelEx5.Controls.Add(this.button10);
            this.panelEx5.Controls.Add(this.button1);
            this.panelEx5.Controls.Add(this.button12);
            this.panelEx5.Location = new System.Drawing.Point(4, 599);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(1460, 88);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 19;
            this.panelEx5.Text = "panelEx5";
            // 
            // cb_ChuyenBan
            // 
            this.cb_ChuyenBan.DisplayMember = "Text";
            this.cb_ChuyenBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ChuyenBan.FormattingEnabled = true;
            this.cb_ChuyenBan.ItemHeight = 24;
            this.cb_ChuyenBan.Location = new System.Drawing.Point(351, 47);
            this.cb_ChuyenBan.Name = "cb_ChuyenBan";
            this.cb_ChuyenBan.Size = new System.Drawing.Size(121, 30);
            this.cb_ChuyenBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_ChuyenBan.TabIndex = 24;
            // 
            // btn_OKChuyenBan
            // 
            this.btn_OKChuyenBan.Location = new System.Drawing.Point(310, 45);
            this.btn_OKChuyenBan.Name = "btn_OKChuyenBan";
            this.btn_OKChuyenBan.Size = new System.Drawing.Size(42, 30);
            this.btn_OKChuyenBan.TabIndex = 23;
            this.btn_OKChuyenBan.Text = "OK";
            this.btn_OKChuyenBan.UseVisualStyleBackColor = true;
            this.btn_OKChuyenBan.Click += new System.EventHandler(this.btn_OKChuyenBan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cb_GhepBan
            // 
            this.cb_GhepBan.DataSource = this.banAnBindingSource;
            this.cb_GhepBan.DisplayMember = "TenBanAn";
            this.cb_GhepBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_GhepBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_GhepBan.FormattingEnabled = true;
            this.cb_GhepBan.ItemHeight = 24;
            this.cb_GhepBan.Location = new System.Drawing.Point(607, 44);
            this.cb_GhepBan.Name = "cb_GhepBan";
            this.cb_GhepBan.Size = new System.Drawing.Size(121, 30);
            this.cb_GhepBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_GhepBan.TabIndex = 20;
            this.cb_GhepBan.ValueMember = "IDBanAn";
            // 
            // banAnBindingSource
            // 
            this.banAnBindingSource.DataMember = "BanAn";
            this.banAnBindingSource.DataSource = this.qLNhaHangDataSet;
            // 
            // qLNhaHangDataSet
            // 
            this.qLNhaHangDataSet.DataSetName = "QLNhaHangDataSet";
            this.qLNhaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nbr_GiamGia
            // 
            this.nbr_GiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_GiamGia.Location = new System.Drawing.Point(840, 43);
            this.nbr_GiamGia.Name = "nbr_GiamGia";
            this.nbr_GiamGia.Size = new System.Drawing.Size(106, 34);
            this.nbr_GiamGia.TabIndex = 10;
            this.nbr_GiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(2, 2);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(222, 85);
            this.button8.TabIndex = 13;
            this.button8.Text = "Thêm bàn";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.panel2);
            this.panelEx3.Controls.Add(this.btn_ThanhToan);
            this.panelEx3.Location = new System.Drawing.Point(961, 3);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(494, 82);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Controls.Add(this.txt_TongTien);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 75);
            this.panel2.TabIndex = 4;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(146, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            // 
            // 
            // 
            this.txt_TongTien.Border.Class = "TextBoxBorder";
            this.txt_TongTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(4, 37);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(249, 34);
            this.txt_TongTien.TabIndex = 10;
            this.txt_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThanhToan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(273, 0);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_ThanhToan.Size = new System.Drawing.Size(226, 77);
            this.btn_ThanhToan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ThanhToan.TabIndex = 3;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Purple;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(221, 2);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(255, 85);
            this.button10.TabIndex = 8;
            this.button10.Text = "Chuyển bàn";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(734, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 85);
            this.button1.TabIndex = 19;
            this.button1.Text = "Giảm giá";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(479, 2);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(255, 85);
            this.button12.TabIndex = 13;
            this.button12.Text = "Ghép bàn";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(955, 590);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.panelEx1);
            this.panelEx2.Controls.Add(this.panelEx4);
            this.panelEx2.Location = new System.Drawing.Point(965, 3);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(499, 591);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 16;
            this.panelEx2.Text = "panelEx2";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lv_HoaDon);
            this.panelEx1.Location = new System.Drawing.Point(3, 90);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(490, 501);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 17;
            this.panelEx1.Text = "panelEx1";
            // 
            // lv_HoaDon
            // 
            this.lv_HoaDon.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.lv_HoaDon.Border.Class = "ListViewBorder";
            this.lv_HoaDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_HoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_HoaDon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_HoaDon.GridLines = true;
            this.lv_HoaDon.Location = new System.Drawing.Point(5, 3);
            this.lv_HoaDon.Name = "lv_HoaDon";
            this.lv_HoaDon.Size = new System.Drawing.Size(482, 484);
            this.lv_HoaDon.TabIndex = 0;
            this.lv_HoaDon.UseCompatibleStateImageBehavior = false;
            this.lv_HoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 100;
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.btn_ThemMonAn);
            this.panelEx4.Controls.Add(this.nbr_SoLuongMon);
            this.panelEx4.Controls.Add(this.cb_MonAn);
            this.panelEx4.Controls.Add(this.cb_LoaiMonAn);
            this.panelEx4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelEx4.Location = new System.Drawing.Point(3, 3);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(490, 81);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 15;
            // 
            // btn_ThemMonAn
            // 
            this.btn_ThemMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ThemMonAn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMonAn.Location = new System.Drawing.Point(358, 6);
            this.btn_ThemMonAn.Name = "btn_ThemMonAn";
            this.btn_ThemMonAn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_ThemMonAn.Size = new System.Drawing.Size(129, 63);
            this.btn_ThemMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ThemMonAn.TabIndex = 2;
            this.btn_ThemMonAn.Text = "Thêm món";
            this.btn_ThemMonAn.Click += new System.EventHandler(this.btn_ThemMonAn_Click);
            // 
            // nbr_SoLuongMon
            // 
            this.nbr_SoLuongMon.Location = new System.Drawing.Point(300, 47);
            this.nbr_SoLuongMon.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.nbr_SoLuongMon.Name = "nbr_SoLuongMon";
            this.nbr_SoLuongMon.Size = new System.Drawing.Size(52, 22);
            this.nbr_SoLuongMon.TabIndex = 3;
            this.nbr_SoLuongMon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_MonAn
            // 
            this.cb_MonAn.DisplayMember = "Text";
            this.cb_MonAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_MonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MonAn.FormattingEnabled = true;
            this.cb_MonAn.ItemHeight = 24;
            this.cb_MonAn.Location = new System.Drawing.Point(3, 41);
            this.cb_MonAn.Name = "cb_MonAn";
            this.cb_MonAn.Size = new System.Drawing.Size(291, 30);
            this.cb_MonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_MonAn.TabIndex = 1;
            // 
            // cb_LoaiMonAn
            // 
            this.cb_LoaiMonAn.DataSource = this.loaiMonAnBindingSource;
            this.cb_LoaiMonAn.DisplayMember = "TenLoaiMon";
            this.cb_LoaiMonAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_LoaiMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiMonAn.FormattingEnabled = true;
            this.cb_LoaiMonAn.ItemHeight = 24;
            this.cb_LoaiMonAn.Location = new System.Drawing.Point(3, 6);
            this.cb_LoaiMonAn.Name = "cb_LoaiMonAn";
            this.cb_LoaiMonAn.Size = new System.Drawing.Size(291, 30);
            this.cb_LoaiMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_LoaiMonAn.TabIndex = 0;
            this.cb_LoaiMonAn.ValueMember = "IDLoaiMon";
            this.cb_LoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiMonAn_SelectedIndexChanged);
            // 
            // loaiMonAnBindingSource
            // 
            this.loaiMonAnBindingSource.DataMember = "LoaiMonAn";
            this.loaiMonAnBindingSource.DataSource = this.qLNhaHangDataSet;
            // 
            // banAnBindingSource1
            // 
            this.banAnBindingSource1.DataMember = "BanAn";
            this.banAnBindingSource1.DataSource = this.qLNhaHangDataSet;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button9.Location = new System.Drawing.Point(4, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 46);
            this.button9.TabIndex = 16;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(635, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quản lý bàn ăn";
            // 
            // loaiMonAnTableAdapter
            // 
            this.loaiMonAnTableAdapter.ClearBeforeFill = true;
            // 
            // billInfoTableAdapter1
            // 
            this.billInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // banAnTableAdapter
            // 
            this.banAnTableAdapter.ClearBeforeFill = true;
            // 
            // nbr_ThemBan
            // 
            this.nbr_ThemBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_ThemBan.Location = new System.Drawing.Point(110, 40);
            this.nbr_ThemBan.Name = "nbr_ThemBan";
            this.nbr_ThemBan.Size = new System.Drawing.Size(106, 34);
            this.nbr_ThemBan.TabIndex = 25;
            this.nbr_ThemBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_OKThemBan
            // 
            this.btn_OKThemBan.Location = new System.Drawing.Point(68, 41);
            this.btn_OKThemBan.Name = "btn_OKThemBan";
            this.btn_OKThemBan.Size = new System.Drawing.Size(42, 30);
            this.btn_OKThemBan.TabIndex = 26;
            this.btn_OKThemBan.Text = "OK";
            this.btn_OKThemBan.UseVisualStyleBackColor = true;
            this.btn_OKThemBan.Click += new System.EventHandler(this.btn_OKThemBan_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1467, 738);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panelEx5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.banAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_GiamGia)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuongMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiMonAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banAnBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_ThemBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ButtonX btn_ThanhToan;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.ButtonX btn_ThemMonAn;
        private System.Windows.Forms.NumericUpDown nbr_SoLuongMon;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_MonAn;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_LoaiMonAn;
        private QLNhaHangDataSet qLNhaHangDataSet;
        private System.Windows.Forms.BindingSource loaiMonAnBindingSource;
        private QLNhaHangDataSetTableAdapters.LoaiMonAnTableAdapter loaiMonAnTableAdapter;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_HoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.PanelEx panelEx5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_GhepBan;
        private System.Windows.Forms.NumericUpDown nbr_GiamGia;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TongTien;
        private QLNhaHangDataSetTableAdapters.BillInfoTableAdapter billInfoTableAdapter1;
        private System.Windows.Forms.BindingSource banAnBindingSource;
        private QLNhaHangDataSetTableAdapters.BanAnTableAdapter banAnTableAdapter;
        private System.Windows.Forms.BindingSource banAnBindingSource1;
        private System.Windows.Forms.Button btn_OKChuyenBan;
        private System.Windows.Forms.Button button2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_ChuyenBan;
        private System.Windows.Forms.Button btn_OKThemBan;
        private System.Windows.Forms.NumericUpDown nbr_ThemBan;
    }
}