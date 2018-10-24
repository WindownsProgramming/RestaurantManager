namespace QuanLyNhaHang
{
    partial class frmChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_TimLoaiNV = new System.Windows.Forms.Button();
            this.txt_TimLoaiNV = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ThemChamCong = new System.Windows.Forms.Button();
            this.btn_XoaChamCong = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_GhiChu = new System.Windows.Forms.RichTextBox();
            this.qLNhaHangDataSet = new QuanLyNhaHang.QLNhaHangDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QuanLyNhaHang.QLNhaHangDataSetTableAdapters.NhanVienTableAdapter();
            this.chamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamCongTableAdapter = new QuanLyNhaHang.QLNhaHangDataSetTableAdapters.ChamCongTableAdapter();
            this.caLamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caLamTableAdapter = new QuanLyNhaHang.QLNhaHangDataSetTableAdapters.CaLamTableAdapter();
            this.cb_CaLam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cb_MaNV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDChamCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lbid = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caLamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.btn_ThemChamCong);
            this.groupBox3.Controls.Add(this.btn_XoaChamCong);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(68, 344);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(394, 157);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHỨC NĂNG";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.panel13);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(9, 79);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(367, 66);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel13.Controls.Add(this.btn_TimLoaiNV);
            this.panel13.Controls.Add(this.txt_TimLoaiNV);
            this.panel13.Location = new System.Drawing.Point(7, 24);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(292, 32);
            this.panel13.TabIndex = 28;
            // 
            // btn_TimLoaiNV
            // 
            this.btn_TimLoaiNV.BackColor = System.Drawing.Color.Maroon;
            this.btn_TimLoaiNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TimLoaiNV.BackgroundImage")));
            this.btn_TimLoaiNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TimLoaiNV.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TimLoaiNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimLoaiNV.Location = new System.Drawing.Point(257, 0);
            this.btn_TimLoaiNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimLoaiNV.Name = "btn_TimLoaiNV";
            this.btn_TimLoaiNV.Size = new System.Drawing.Size(35, 32);
            this.btn_TimLoaiNV.TabIndex = 1;
            this.btn_TimLoaiNV.UseVisualStyleBackColor = false;
            // 
            // txt_TimLoaiNV
            // 
            this.txt_TimLoaiNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_TimLoaiNV.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimLoaiNV.Location = new System.Drawing.Point(0, 0);
            this.txt_TimLoaiNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimLoaiNV.Multiline = true;
            this.txt_TimLoaiNV.Name = "txt_TimLoaiNV";
            this.txt_TimLoaiNV.Size = new System.Drawing.Size(260, 32);
            this.txt_TimLoaiNV.TabIndex = 0;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Green;
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(308, 25);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 32);
            this.button15.TabIndex = 27;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(96, 69);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 16);
            this.labelControl3.TabIndex = 1;
            // 
            // btn_ThemChamCong
            // 
            this.btn_ThemChamCong.BackColor = System.Drawing.Color.Green;
            this.btn_ThemChamCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ThemChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemChamCong.ForeColor = System.Drawing.Color.White;
            this.btn_ThemChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemChamCong.Image")));
            this.btn_ThemChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemChamCong.Location = new System.Drawing.Point(58, 22);
            this.btn_ThemChamCong.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ThemChamCong.Name = "btn_ThemChamCong";
            this.btn_ThemChamCong.Size = new System.Drawing.Size(119, 49);
            this.btn_ThemChamCong.TabIndex = 13;
            this.btn_ThemChamCong.Text = "Thêm";
            this.btn_ThemChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemChamCong.UseVisualStyleBackColor = false;
            this.btn_ThemChamCong.Click += new System.EventHandler(this.btn_ThemChamCong_Click);
            // 
            // btn_XoaChamCong
            // 
            this.btn_XoaChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XoaChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaChamCong.ForeColor = System.Drawing.Color.White;
            this.btn_XoaChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaChamCong.Image")));
            this.btn_XoaChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaChamCong.Location = new System.Drawing.Point(218, 22);
            this.btn_XoaChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaChamCong.Name = "btn_XoaChamCong";
            this.btn_XoaChamCong.Size = new System.Drawing.Size(117, 49);
            this.btn_XoaChamCong.TabIndex = 13;
            this.btn_XoaChamCong.Text = "Xóa";
            this.btn_XoaChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaChamCong.UseVisualStyleBackColor = false;
            this.btn_XoaChamCong.Click += new System.EventHandler(this.btn_XoaChamCong_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(96, 69);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(68, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(394, 305);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chấm công";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_MaNV);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã Nhân Viên";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_CaLam);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(37, 112);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 71);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ca làm";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_GhiChu);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(38, 191);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 107);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ghi chú";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(7, 29);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(326, 72);
            this.txt_GhiChu.TabIndex = 0;
            this.txt_GhiChu.Text = "";
            // 
            // qLNhaHangDataSet
            // 
            this.qLNhaHangDataSet.DataSetName = "QLNhaHangDataSet";
            this.qLNhaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLNhaHangDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // chamCongBindingSource
            // 
            this.chamCongBindingSource.DataMember = "ChamCong";
            this.chamCongBindingSource.DataSource = this.qLNhaHangDataSet;
            // 
            // chamCongTableAdapter
            // 
            this.chamCongTableAdapter.ClearBeforeFill = true;
            // 
            // caLamBindingSource
            // 
            this.caLamBindingSource.DataMember = "CaLam";
            this.caLamBindingSource.DataSource = this.qLNhaHangDataSet;
            // 
            // caLamTableAdapter
            // 
            this.caLamTableAdapter.ClearBeforeFill = true;
            // 
            // cb_CaLam
            // 
            this.cb_CaLam.DataSource = this.caLamBindingSource;
            this.cb_CaLam.DisplayMember = "TenCa";
            this.cb_CaLam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_CaLam.FormattingEnabled = true;
            this.cb_CaLam.ItemHeight = 23;
            this.cb_CaLam.Location = new System.Drawing.Point(76, 29);
            this.cb_CaLam.Name = "cb_CaLam";
            this.cb_CaLam.Size = new System.Drawing.Size(258, 29);
            this.cb_CaLam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_CaLam.TabIndex = 1;
            this.cb_CaLam.ValueMember = "IDCa";
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.DataSource = this.nhanVienBindingSource;
            this.cb_MaNV.DisplayMember = "IDNhanVien";
            this.cb_MaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_MaNV.FormattingEnabled = true;
            this.cb_MaNV.ItemHeight = 23;
            this.cb_MaNV.Location = new System.Drawing.Point(76, 27);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(258, 29);
            this.cb_MaNV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_MaNV.TabIndex = 0;
            this.cb_MaNV.ValueMember = "IDNhanVien";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayLamDataGridViewTextBoxColumn
            // 
            this.ngayLamDataGridViewTextBoxColumn.DataPropertyName = "NgayLam";
            this.ngayLamDataGridViewTextBoxColumn.HeaderText = "Ngay Làm";
            this.ngayLamDataGridViewTextBoxColumn.Name = "ngayLamDataGridViewTextBoxColumn";
            this.ngayLamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCaDataGridViewTextBoxColumn
            // 
            this.iDCaDataGridViewTextBoxColumn.DataPropertyName = "IDCa";
            this.iDCaDataGridViewTextBoxColumn.HeaderText = "Mã Ca";
            this.iDCaDataGridViewTextBoxColumn.Name = "iDCaDataGridViewTextBoxColumn";
            this.iDCaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCaDataGridViewTextBoxColumn.Width = 70;
            // 
            // iDNhanVienDataGridViewTextBoxColumn
            // 
            this.iDNhanVienDataGridViewTextBoxColumn.DataPropertyName = "IDNhanVien";
            this.iDNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.iDNhanVienDataGridViewTextBoxColumn.Name = "iDNhanVienDataGridViewTextBoxColumn";
            this.iDNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNhanVienDataGridViewTextBoxColumn.Width = 70;
            // 
            // iDChamCongDataGridViewTextBoxColumn
            // 
            this.iDChamCongDataGridViewTextBoxColumn.DataPropertyName = "IDChamCong";
            this.iDChamCongDataGridViewTextBoxColumn.HeaderText = "IDChamCong";
            this.iDChamCongDataGridViewTextBoxColumn.Name = "iDChamCongDataGridViewTextBoxColumn";
            this.iDChamCongDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDChamCongDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDChamCongDataGridViewTextBoxColumn,
            this.iDNhanVienDataGridViewTextBoxColumn,
            this.iDCaDataGridViewTextBoxColumn,
            this.ngayLamDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.chamCongBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(493, 31);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(630, 470);
            this.dataGridViewX1.TabIndex = 26;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chamCongBindingSource, "IDChamCong", true));
            this.lbid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbid.Location = new System.Drawing.Point(416, 331);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(46, 17);
            this.lbid.TabIndex = 27;
            this.lbid.Text = "label1";
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1155, 567);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChamCong";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caLamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_TimLoaiNV;
        private System.Windows.Forms.TextBox txt_TimLoaiNV;
        private System.Windows.Forms.Button button15;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btn_ThemChamCong;
        private System.Windows.Forms.Button btn_XoaChamCong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox txt_GhiChu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLNhaHangDataSet qLNhaHangDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLNhaHangDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource chamCongBindingSource;
        private QLNhaHangDataSetTableAdapters.ChamCongTableAdapter chamCongTableAdapter;
        private System.Windows.Forms.BindingSource caLamBindingSource;
        private QLNhaHangDataSetTableAdapters.CaLamTableAdapter caLamTableAdapter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_CaLam;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDChamCongDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.Label lbid;
    }
}