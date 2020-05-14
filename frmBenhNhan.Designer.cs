namespace BTL_QLBenhVien
{
    partial class frmBenhNhan
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbmaBN = new System.Windows.Forms.Label();
            this.lbhotenBN = new System.Windows.Forms.Label();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.txtmaBN = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.dsbenhnhan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbsdt = new System.Windows.Forms.Label();
            this.dpcngaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.lbmak = new System.Windows.Forms.Label();
            this.RBTnu = new System.Windows.Forms.RadioButton();
            this.RBTnam = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new BTL_QLBenhVien.DataSetDSBNTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dsbenhnhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Image = global::BTL_QLBenhVien.Properties.Resources.them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(465, 477);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 38);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Image = global::BTL_QLBenhVien.Properties.Resources.sua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(596, 478);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 38);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimkiem.Image = global::BTL_QLBenhVien.Properties.Resources.tk;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(744, 480);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(87, 35);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::BTL_QLBenhVien.Properties.Resources.thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(879, 478);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 37);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbmaBN
            // 
            this.lbmaBN.AutoSize = true;
            this.lbmaBN.Location = new System.Drawing.Point(26, 25);
            this.lbmaBN.Name = "lbmaBN";
            this.lbmaBN.Size = new System.Drawing.Size(85, 13);
            this.lbmaBN.TabIndex = 18;
            this.lbmaBN.Text = "Mã Bệnh Nhân :";
            // 
            // lbhotenBN
            // 
            this.lbhotenBN.AutoSize = true;
            this.lbhotenBN.Location = new System.Drawing.Point(38, 89);
            this.lbhotenBN.Name = "lbhotenBN";
            this.lbhotenBN.Size = new System.Drawing.Size(64, 13);
            this.lbhotenBN.TabIndex = 22;
            this.lbhotenBN.Text = "Họ và Tên :";
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Location = new System.Drawing.Point(42, 129);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(60, 13);
            this.lbgioitinh.TabIndex = 15;
            this.lbgioitinh.Text = "Giới Tính : ";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(42, 165);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(49, 13);
            this.lbdiachi.TabIndex = 18;
            this.lbdiachi.Text = "Địa chỉ : ";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(42, 267);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(65, 13);
            this.lbngaysinh.TabIndex = 13;
            this.lbngaysinh.Text = "Ngày Sinh : ";
            // 
            // txtmaBN
            // 
            this.txtmaBN.Location = new System.Drawing.Point(147, 53);
            this.txtmaBN.Name = "txtmaBN";
            this.txtmaBN.Size = new System.Drawing.Size(151, 20);
            this.txtmaBN.TabIndex = 0;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(147, 89);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(151, 20);
            this.txtHoten.TabIndex = 1;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(147, 165);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(151, 20);
            this.txtdiachi.TabIndex = 4;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(147, 215);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(151, 20);
            this.txtsdt.TabIndex = 14;
            // 
            // dsbenhnhan
            // 
            this.dsbenhnhan.AllowUserToAddRows = false;
            this.dsbenhnhan.AllowUserToDeleteRows = false;
            this.dsbenhnhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsbenhnhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dsbenhnhan.Location = new System.Drawing.Point(6, 34);
            this.dsbenhnhan.Name = "dsbenhnhan";
            this.dsbenhnhan.ReadOnly = true;
            this.dsbenhnhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsbenhnhan.Size = new System.Drawing.Size(686, 354);
            this.dsbenhnhan.TabIndex = 15;
            this.dsbenhnhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachbenhnhan_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_iBenhNhanID";
            this.Column1.HeaderText = "Mã Bênh Nhân";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PK_iKhoaID";
            this.Column7.HeaderText = "Mã Khoa";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sHoTen";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "bGioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sDiaChi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sSDT";
            this.Column5.HeaderText = "Số Điện Thoại";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dNgaySinh";
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(42, 218);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(76, 13);
            this.lbsdt.TabIndex = 16;
            this.lbsdt.Text = "Số điện thoại :";
            // 
            // dpcngaysinh
            // 
            this.dpcngaysinh.Location = new System.Drawing.Point(147, 267);
            this.dpcngaysinh.Name = "dpcngaysinh";
            this.dpcngaysinh.Size = new System.Drawing.Size(151, 20);
            this.dpcngaysinh.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmakhoa);
            this.groupBox1.Controls.Add(this.lbmak);
            this.groupBox1.Controls.Add(this.RBTnu);
            this.groupBox1.Controls.Add(this.RBTnam);
            this.groupBox1.Controls.Add(this.lbmaBN);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 388);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Nhân Viên";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(135, 290);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(151, 20);
            this.txtmakhoa.TabIndex = 24;
            // 
            // lbmak
            // 
            this.lbmak.AutoSize = true;
            this.lbmak.Location = new System.Drawing.Point(30, 293);
            this.lbmak.Name = "lbmak";
            this.lbmak.Size = new System.Drawing.Size(50, 13);
            this.lbmak.TabIndex = 23;
            this.lbmak.Text = "Mã Khoa";
            // 
            // RBTnu
            // 
            this.RBTnu.AutoSize = true;
            this.RBTnu.Location = new System.Drawing.Point(202, 98);
            this.RBTnu.Name = "RBTnu";
            this.RBTnu.Size = new System.Drawing.Size(39, 17);
            this.RBTnu.TabIndex = 20;
            this.RBTnu.TabStop = true;
            this.RBTnu.Text = "Nữ";
            this.RBTnu.UseVisualStyleBackColor = true;
            // 
            // RBTnam
            // 
            this.RBTnam.AutoSize = true;
            this.RBTnam.Location = new System.Drawing.Point(135, 98);
            this.RBTnam.Name = "RBTnam";
            this.RBTnam.Size = new System.Drawing.Size(47, 17);
            this.RBTnam.TabIndex = 19;
            this.RBTnam.TabStop = true;
            this.RBTnam.Text = "Nam";
            this.RBTnam.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.dsbenhnhan);
            this.groupBox2.Location = new System.Drawing.Point(326, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 401);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bệnh Nhân";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Image = global::BTL_QLBenhVien.Properties.Resources.thoat;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(326, 480);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(91, 35);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tblBenhNhanTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = BTL_QLBenhVien.DataSetDSBNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 535);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.dpcngaysinh);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtmaBN);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbgioitinh);
            this.Controls.Add(this.lbhotenBN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmBenhNhan";
            this.Text = "frmBenhNhan";
            this.Load += new System.EventHandler(this.frmBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsbenhnhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbmaBN;
        private System.Windows.Forms.Label lbhotenBN;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.TextBox txtmaBN;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DataGridView dsbenhnhan;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.DateTimePicker dpcngaysinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.RadioButton RBTnu;
        private System.Windows.Forms.RadioButton RBTnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lbmak;
        private DataSetDSBNTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox txtmakhoa;
    }
}