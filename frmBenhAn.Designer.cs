namespace BTL_QLBenhVien
{
    partial class frmBenhAn
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
            this.txtmaBA = new System.Windows.Forms.TextBox();
            this.txtTTBA = new System.Windows.Forms.TextBox();
            this.txtBHYT = new System.Windows.Forms.TextBox();
            this.txtieusu = new System.Windows.Forms.TextBox();
            this.dtnhap = new System.Windows.Forms.DateTimePicker();
            this.dtxuat = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.dsBenhAn = new System.Windows.Forms.DataGridView();
            this.lbmaBA = new System.Windows.Forms.Label();
            this.lbmaNV = new System.Windows.Forms.Label();
            this.lbmaBN = new System.Windows.Forms.Label();
            this.lbTTBA = new System.Windows.Forms.Label();
            this.lbBHYT = new System.Windows.Forms.Label();
            this.lbtieusu = new System.Windows.Forms.Label();
            this.lbnhap = new System.Windows.Forms.Label();
            this.lbxuat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmaBN = new System.Windows.Forms.TextBox();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsBenhAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmaBA
            // 
            this.txtmaBA.Location = new System.Drawing.Point(141, 77);
            this.txtmaBA.Name = "txtmaBA";
            this.txtmaBA.Size = new System.Drawing.Size(121, 20);
            this.txtmaBA.TabIndex = 0;
            // 
            // txtTTBA
            // 
            this.txtTTBA.Location = new System.Drawing.Point(141, 194);
            this.txtTTBA.Name = "txtTTBA";
            this.txtTTBA.Size = new System.Drawing.Size(121, 20);
            this.txtTTBA.TabIndex = 3;
            // 
            // txtBHYT
            // 
            this.txtBHYT.Location = new System.Drawing.Point(141, 228);
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.Size = new System.Drawing.Size(121, 20);
            this.txtBHYT.TabIndex = 4;
            // 
            // txtieusu
            // 
            this.txtieusu.Location = new System.Drawing.Point(141, 264);
            this.txtieusu.Name = "txtieusu";
            this.txtieusu.Size = new System.Drawing.Size(121, 20);
            this.txtieusu.TabIndex = 5;
            // 
            // dtnhap
            // 
            this.dtnhap.Location = new System.Drawing.Point(141, 297);
            this.dtnhap.Name = "dtnhap";
            this.dtnhap.Size = new System.Drawing.Size(121, 20);
            this.dtnhap.TabIndex = 6;
            // 
            // dtxuat
            // 
            this.dtxuat.Location = new System.Drawing.Point(141, 337);
            this.dtxuat.Name = "dtxuat";
            this.dtxuat.Size = new System.Drawing.Size(121, 20);
            this.dtxuat.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Image = global::BTL_QLBenhVien.Properties.Resources.them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(413, 446);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 35);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Image = global::BTL_QLBenhVien.Properties.Resources.sua;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(540, 447);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 35);
            this.btnsua.TabIndex = 9;
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
            this.btntimkiem.Location = new System.Drawing.Point(657, 447);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(85, 35);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Image = global::BTL_QLBenhVien.Properties.Resources.thoat;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(800, 447);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 35);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Image = global::BTL_QLBenhVien.Properties.Resources.reset;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(280, 444);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(85, 38);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // dsBenhAn
            // 
            this.dsBenhAn.AllowUserToAddRows = false;
            this.dsBenhAn.AllowUserToDeleteRows = false;
            this.dsBenhAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsBenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsBenhAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dsBenhAn.Location = new System.Drawing.Point(303, 68);
            this.dsBenhAn.Name = "dsBenhAn";
            this.dsBenhAn.ReadOnly = true;
            this.dsBenhAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsBenhAn.Size = new System.Drawing.Size(647, 335);
            this.dsBenhAn.TabIndex = 14;
            this.dsBenhAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsBenhAn_CellClick);
            this.dsBenhAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsBenhAn_CellContentClick);
            // 
            // lbmaBA
            // 
            this.lbmaBA.AutoSize = true;
            this.lbmaBA.Location = new System.Drawing.Point(34, 77);
            this.lbmaBA.Name = "lbmaBA";
            this.lbmaBA.Size = new System.Drawing.Size(66, 13);
            this.lbmaBA.TabIndex = 15;
            this.lbmaBA.Text = "Mã Bệnh Án";
            // 
            // lbmaNV
            // 
            this.lbmaNV.AutoSize = true;
            this.lbmaNV.Location = new System.Drawing.Point(34, 116);
            this.lbmaNV.Name = "lbmaNV";
            this.lbmaNV.Size = new System.Drawing.Size(75, 13);
            this.lbmaNV.TabIndex = 16;
            this.lbmaNV.Text = "Mã Nhân Viên";
            // 
            // lbmaBN
            // 
            this.lbmaBN.AutoSize = true;
            this.lbmaBN.Location = new System.Drawing.Point(34, 157);
            this.lbmaBN.Name = "lbmaBN";
            this.lbmaBN.Size = new System.Drawing.Size(79, 13);
            this.lbmaBN.TabIndex = 17;
            this.lbmaBN.Text = "Mã Bênh Nhân";
            // 
            // lbTTBA
            // 
            this.lbTTBA.AutoSize = true;
            this.lbTTBA.Location = new System.Drawing.Point(34, 194);
            this.lbTTBA.Name = "lbTTBA";
            this.lbTTBA.Size = new System.Drawing.Size(100, 13);
            this.lbTTBA.TabIndex = 18;
            this.lbTTBA.Text = "Thông Tin Bệnh Án";
            // 
            // lbBHYT
            // 
            this.lbBHYT.AutoSize = true;
            this.lbBHYT.Location = new System.Drawing.Point(35, 228);
            this.lbBHYT.Name = "lbBHYT";
            this.lbBHYT.Size = new System.Drawing.Size(52, 13);
            this.lbBHYT.TabIndex = 19;
            this.lbBHYT.Text = "Số BHYT";
            // 
            // lbtieusu
            // 
            this.lbtieusu.AutoSize = true;
            this.lbtieusu.Location = new System.Drawing.Point(35, 264);
            this.lbtieusu.Name = "lbtieusu";
            this.lbtieusu.Size = new System.Drawing.Size(44, 13);
            this.lbtieusu.TabIndex = 20;
            this.lbtieusu.Text = "Tiểu Sử";
            // 
            // lbnhap
            // 
            this.lbnhap.AutoSize = true;
            this.lbnhap.Location = new System.Drawing.Point(34, 304);
            this.lbnhap.Name = "lbnhap";
            this.lbnhap.Size = new System.Drawing.Size(61, 13);
            this.lbnhap.TabIndex = 21;
            this.lbnhap.Text = "Ngày Nhập";
            // 
            // lbxuat
            // 
            this.lbxuat.AutoSize = true;
            this.lbxuat.Location = new System.Drawing.Point(34, 337);
            this.lbxuat.Name = "lbxuat";
            this.lbxuat.Size = new System.Drawing.Size(57, 13);
            this.lbxuat.TabIndex = 22;
            this.lbxuat.Text = "Ngày Xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmaBN);
            this.groupBox1.Controls.Add(this.txtmaNV);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 387);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liêu";
            // 
            // txtmaBN
            // 
            this.txtmaBN.Location = new System.Drawing.Point(129, 121);
            this.txtmaBN.Name = "txtmaBN";
            this.txtmaBN.Size = new System.Drawing.Size(121, 20);
            this.txtmaBN.TabIndex = 2;
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(129, 80);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(121, 20);
            this.txtmaNV.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(290, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 387);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bênh Án";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_iBenhAnID";
            this.Column1.HeaderText = "Mã Bệnh Án";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PK_iNhanVienID";
            this.Column2.HeaderText = "Mã Nhân Viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PK_iBenhNhanID";
            this.Column3.HeaderText = "Mã Bệnh Nhân";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sTTBenhAn";
            this.Column4.HeaderText = "Thông Tin Bệnh Án";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "iSoTheBHYT";
            this.Column5.HeaderText = "Số BHYT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sTieuSu";
            this.Column6.HeaderText = "Tiểu Sử";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "dNgayVao";
            this.Column7.HeaderText = "Ngày Nhập Viện";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "dNgayRa";
            this.Column8.HeaderText = "Ngày Xuất Viện";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // frmBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 494);
            this.Controls.Add(this.lbxuat);
            this.Controls.Add(this.lbnhap);
            this.Controls.Add(this.lbtieusu);
            this.Controls.Add(this.lbBHYT);
            this.Controls.Add(this.lbTTBA);
            this.Controls.Add(this.lbmaBN);
            this.Controls.Add(this.lbmaNV);
            this.Controls.Add(this.lbmaBA);
            this.Controls.Add(this.dsBenhAn);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtxuat);
            this.Controls.Add(this.dtnhap);
            this.Controls.Add(this.txtieusu);
            this.Controls.Add(this.txtBHYT);
            this.Controls.Add(this.txtTTBA);
            this.Controls.Add(this.txtmaBA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmBenhAn";
            this.Text = "Hồ Sơ Bệnh Án";
            this.Load += new System.EventHandler(this.frmBenhAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBenhAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaBA;
        private System.Windows.Forms.TextBox txtTTBA;
        private System.Windows.Forms.TextBox txtBHYT;
        private System.Windows.Forms.TextBox txtieusu;
        private System.Windows.Forms.DateTimePicker dtnhap;
        private System.Windows.Forms.DateTimePicker dtxuat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DataGridView dsBenhAn;
        private System.Windows.Forms.Label lbmaBA;
        private System.Windows.Forms.Label lbmaNV;
        private System.Windows.Forms.Label lbmaBN;
        private System.Windows.Forms.Label lbTTBA;
        private System.Windows.Forms.Label lbBHYT;
        private System.Windows.Forms.Label lbtieusu;
        private System.Windows.Forms.Label lbnhap;
        private System.Windows.Forms.Label lbxuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmaBN;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}