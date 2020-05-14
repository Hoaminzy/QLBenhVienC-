namespace BTL_QLBenhVien
{
    partial class frmHoaDon
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
            this.txtmaHD = new System.Windows.Forms.TextBox();
            this.txtmaBA = new System.Windows.Forms.TextBox();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.txtmaThuoc = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbmahoadon = new System.Windows.Forms.Label();
            this.lbmaBA = new System.Windows.Forms.Label();
            this.lbmaNV = new System.Windows.Forms.Label();
            this.lbmaThuoc = new System.Windows.Forms.Label();
            this.lbngaylap = new System.Windows.Forms.Label();
            this.dsHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtngaylap = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbaocao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmaHD
            // 
            this.txtmaHD.Location = new System.Drawing.Point(108, 55);
            this.txtmaHD.Name = "txtmaHD";
            this.txtmaHD.Size = new System.Drawing.Size(100, 20);
            this.txtmaHD.TabIndex = 0;
            // 
            // txtmaBA
            // 
            this.txtmaBA.Location = new System.Drawing.Point(108, 101);
            this.txtmaBA.Name = "txtmaBA";
            this.txtmaBA.Size = new System.Drawing.Size(100, 20);
            this.txtmaBA.TabIndex = 1;
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(108, 146);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(100, 20);
            this.txtmaNV.TabIndex = 2;
            // 
            // txtmaThuoc
            // 
            this.txtmaThuoc.Location = new System.Drawing.Point(108, 194);
            this.txtmaThuoc.Name = "txtmaThuoc";
            this.txtmaThuoc.Size = new System.Drawing.Size(100, 20);
            this.txtmaThuoc.TabIndex = 3;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Image = global::BTL_QLBenhVien.Properties.Resources.reset;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(67, 431);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(89, 35);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.Image = global::BTL_QLBenhVien.Properties.Resources.them;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(330, 432);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 34);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Image = global::BTL_QLBenhVien.Properties.Resources.sua;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(465, 432);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(80, 34);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntimkiem.Image = global::BTL_QLBenhVien.Properties.Resources.tk;
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(605, 432);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(87, 34);
            this.btntimkiem.TabIndex = 8;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Image = global::BTL_QLBenhVien.Properties.Resources.thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(735, 432);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 34);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbmahoadon
            // 
            this.lbmahoadon.AutoSize = true;
            this.lbmahoadon.Location = new System.Drawing.Point(27, 58);
            this.lbmahoadon.Name = "lbmahoadon";
            this.lbmahoadon.Size = new System.Drawing.Size(68, 13);
            this.lbmahoadon.TabIndex = 10;
            this.lbmahoadon.Text = "Mã Hóa Đơn";
            // 
            // lbmaBA
            // 
            this.lbmaBA.AutoSize = true;
            this.lbmaBA.Location = new System.Drawing.Point(27, 104);
            this.lbmaBA.Name = "lbmaBA";
            this.lbmaBA.Size = new System.Drawing.Size(66, 13);
            this.lbmaBA.TabIndex = 11;
            this.lbmaBA.Text = "Mã Bệnh Án";
            // 
            // lbmaNV
            // 
            this.lbmaNV.AutoSize = true;
            this.lbmaNV.Location = new System.Drawing.Point(27, 149);
            this.lbmaNV.Name = "lbmaNV";
            this.lbmaNV.Size = new System.Drawing.Size(75, 13);
            this.lbmaNV.TabIndex = 12;
            this.lbmaNV.Text = "Mã Nhân Viên";
            // 
            // lbmaThuoc
            // 
            this.lbmaThuoc.AutoSize = true;
            this.lbmaThuoc.Location = new System.Drawing.Point(27, 197);
            this.lbmaThuoc.Name = "lbmaThuoc";
            this.lbmaThuoc.Size = new System.Drawing.Size(56, 13);
            this.lbmaThuoc.TabIndex = 13;
            this.lbmaThuoc.Text = "Mã Thuốc";
            // 
            // lbngaylap
            // 
            this.lbngaylap.AutoSize = true;
            this.lbngaylap.Location = new System.Drawing.Point(27, 240);
            this.lbngaylap.Name = "lbngaylap";
            this.lbngaylap.Size = new System.Drawing.Size(72, 13);
            this.lbngaylap.TabIndex = 14;
            this.lbngaylap.Text = "Ngày Lập HD";
            // 
            // dsHoaDon
            // 
            this.dsHoaDon.AllowUserToAddRows = false;
            this.dsHoaDon.AllowUserToDeleteRows = false;
            this.dsHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dsHoaDon.Location = new System.Drawing.Point(307, 66);
            this.dsHoaDon.Name = "dsHoaDon";
            this.dsHoaDon.ReadOnly = true;
            this.dsHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsHoaDon.Size = new System.Drawing.Size(563, 310);
            this.dsHoaDon.TabIndex = 15;
            this.dsHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsHoaDon_CellClick);
            this.dsHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsHoaDon_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_iHoaDonID";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 93;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PK_iBenhAnID";
            this.Column2.HeaderText = "Mã Bệnh Án";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 91;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PK_iNhanVienID";
            this.Column3.HeaderText = "Mã Nhân Viên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PK_iThuocID";
            this.Column4.HeaderText = "Mã Thuốc";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 81;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dNgayLapHD";
            this.Column5.HeaderText = "Ngày Lập HD";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 97;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngaylap);
            this.groupBox1.Controls.Add(this.lbngaylap);
            this.groupBox1.Controls.Add(this.txtmaThuoc);
            this.groupBox1.Controls.Add(this.lbmaThuoc);
            this.groupBox1.Controls.Add(this.txtmaNV);
            this.groupBox1.Controls.Add(this.lbmaNV);
            this.groupBox1.Controls.Add(this.txtmaBA);
            this.groupBox1.Controls.Add(this.lbmaBA);
            this.groupBox1.Controls.Add(this.txtmaHD);
            this.groupBox1.Controls.Add(this.lbmahoadon);
            this.groupBox1.Location = new System.Drawing.Point(23, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 310);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // dtngaylap
            // 
            this.dtngaylap.Location = new System.Drawing.Point(108, 240);
            this.dtngaylap.Name = "dtngaylap";
            this.dtngaylap.Size = new System.Drawing.Size(100, 20);
            this.dtngaylap.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(281, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 368);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH HÓA ĐƠN ";
            // 
            // btnbaocao
            // 
            this.btnbaocao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbaocao.Image = global::BTL_QLBenhVien.Properties.Resources.bc;
            this.btnbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbaocao.Location = new System.Drawing.Point(180, 432);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(102, 34);
            this.btnbaocao.TabIndex = 18;
            this.btnbaocao.Text = "Báo Cáo";
            this.btnbaocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbaocao.UseVisualStyleBackColor = false;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 478);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.dsHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaHD;
        private System.Windows.Forms.TextBox txtmaBA;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.TextBox txtmaThuoc;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbmahoadon;
        private System.Windows.Forms.Label lbmaBA;
        private System.Windows.Forms.Label lbmaNV;
        private System.Windows.Forms.Label lbmaThuoc;
        private System.Windows.Forms.Label lbngaylap;
        private System.Windows.Forms.DataGridView dsHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtngaylap;
        private System.Windows.Forms.Button btnbaocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}