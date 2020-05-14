namespace BTL_QLBenhVien
{
    partial class frmThuoc
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
            this.txtmaThuoc = new System.Windows.Forms.TextBox();
            this.txtenthuoc = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.lbmathuoc = new System.Windows.Forms.Label();
            this.lbtenT = new System.Windows.Forms.Label();
            this.lbgia = new System.Windows.Forms.Label();
            this.dsThuoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grnhapdl = new System.Windows.Forms.GroupBox();
            this.grthuoc = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsThuoc)).BeginInit();
            this.grnhapdl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmaThuoc
            // 
            this.txtmaThuoc.Location = new System.Drawing.Point(106, 39);
            this.txtmaThuoc.Name = "txtmaThuoc";
            this.txtmaThuoc.Size = new System.Drawing.Size(100, 20);
            this.txtmaThuoc.TabIndex = 0;
            // 
            // txtenthuoc
            // 
            this.txtenthuoc.Location = new System.Drawing.Point(130, 109);
            this.txtenthuoc.Name = "txtenthuoc";
            this.txtenthuoc.Size = new System.Drawing.Size(100, 20);
            this.txtenthuoc.TabIndex = 1;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(130, 153);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(100, 20);
            this.txtgia.TabIndex = 2;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Image = global::BTL_QLBenhVien.Properties.Resources.reset;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(156, 243);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(87, 37);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Image = global::BTL_QLBenhVien.Properties.Resources.them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(298, 417);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 33);
            this.btnThem.TabIndex = 4;
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
            this.btnsua.Location = new System.Drawing.Point(415, 417);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(80, 33);
            this.btnsua.TabIndex = 5;
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
            this.btntimkiem.Location = new System.Drawing.Point(530, 417);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(80, 33);
            this.btntimkiem.TabIndex = 6;
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
            this.btnthoat.Location = new System.Drawing.Point(640, 417);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(83, 33);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lbmathuoc
            // 
            this.lbmathuoc.AutoSize = true;
            this.lbmathuoc.Location = new System.Drawing.Point(27, 42);
            this.lbmathuoc.Name = "lbmathuoc";
            this.lbmathuoc.Size = new System.Drawing.Size(56, 13);
            this.lbmathuoc.TabIndex = 8;
            this.lbmathuoc.Text = "Mã Thuốc";
            // 
            // lbtenT
            // 
            this.lbtenT.AutoSize = true;
            this.lbtenT.Location = new System.Drawing.Point(23, 83);
            this.lbtenT.Name = "lbtenT";
            this.lbtenT.Size = new System.Drawing.Size(60, 13);
            this.lbtenT.TabIndex = 9;
            this.lbtenT.Text = "Tên Thuốc";
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.Location = new System.Drawing.Point(27, 124);
            this.lbgia.Name = "lbgia";
            this.lbgia.Size = new System.Drawing.Size(49, 13);
            this.lbgia.TabIndex = 10;
            this.lbgia.Text = "Đơn Giá ";
            // 
            // dsThuoc
            // 
            this.dsThuoc.AllowUserToAddRows = false;
            this.dsThuoc.AllowUserToDeleteRows = false;
            this.dsThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dsThuoc.Location = new System.Drawing.Point(298, 64);
            this.dsThuoc.Name = "dsThuoc";
            this.dsThuoc.ReadOnly = true;
            this.dsThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsThuoc.Size = new System.Drawing.Size(447, 328);
            this.dsThuoc.TabIndex = 11;
         
            this.dsThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsThuoc_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_iThuocID";
            this.Column1.HeaderText = "Mã Thuốc";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 81;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenThuoc";
            this.Column2.HeaderText = "Tên Thuốc";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fDonGia";
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 71;
            // 
            // grnhapdl
            // 
            this.grnhapdl.Controls.Add(this.lbmathuoc);
            this.grnhapdl.Controls.Add(this.lbtenT);
            this.grnhapdl.Controls.Add(this.lbgia);
            this.grnhapdl.Controls.Add(this.txtmaThuoc);
            this.grnhapdl.Location = new System.Drawing.Point(24, 29);
            this.grnhapdl.Name = "grnhapdl";
            this.grnhapdl.Size = new System.Drawing.Size(244, 198);
            this.grnhapdl.TabIndex = 12;
            this.grnhapdl.TabStop = false;
            this.grnhapdl.Text = "Nhập dữ liệu";
            // 
            // grthuoc
            // 
            this.grthuoc.Location = new System.Drawing.Point(286, 29);
            this.grthuoc.Name = "grthuoc";
            this.grthuoc.Size = new System.Drawing.Size(476, 370);
            this.grthuoc.TabIndex = 13;
            this.grthuoc.TabStop = false;
            this.grthuoc.Text = "Danh Sách Thuốc";
            // 
            // frmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 471);
            this.Controls.Add(this.dsThuoc);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtenthuoc);
            this.Controls.Add(this.grnhapdl);
            this.Controls.Add(this.grthuoc);
            this.Name = "frmThuoc";
            this.Text = "THUỐC";
            this.Load += new System.EventHandler(this.frmThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsThuoc)).EndInit();
            this.grnhapdl.ResumeLayout(false);
            this.grnhapdl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaThuoc;
        private System.Windows.Forms.TextBox txtenthuoc;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label lbmathuoc;
        private System.Windows.Forms.Label lbtenT;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.DataGridView dsThuoc;
        private System.Windows.Forms.GroupBox grnhapdl;
        private System.Windows.Forms.GroupBox grthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}