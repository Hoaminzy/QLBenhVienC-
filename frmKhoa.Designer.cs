namespace BTL_QLBenhVien
{
    partial class frmKhoa
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
            this.txtmaKhoa = new System.Windows.Forms.TextBox();
            this.txtenkhoa = new System.Windows.Forms.TextBox();
            this.dsKhoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmaK = new System.Windows.Forms.Label();
            this.lbtenK = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmaKhoa
            // 
            this.txtmaKhoa.Location = new System.Drawing.Point(121, 74);
            this.txtmaKhoa.Name = "txtmaKhoa";
            this.txtmaKhoa.Size = new System.Drawing.Size(121, 20);
            this.txtmaKhoa.TabIndex = 0;
            // 
            // txtenkhoa
            // 
            this.txtenkhoa.Location = new System.Drawing.Point(121, 118);
            this.txtenkhoa.Name = "txtenkhoa";
            this.txtenkhoa.Size = new System.Drawing.Size(121, 20);
            this.txtenkhoa.TabIndex = 1;
            // 
            // dsKhoa
            // 
            this.dsKhoa.AllowUserToAddRows = false;
            this.dsKhoa.AllowUserToDeleteRows = false;
            this.dsKhoa.AllowUserToResizeColumns = false;
            this.dsKhoa.AllowUserToResizeRows = false;
            this.dsKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dsKhoa.Location = new System.Drawing.Point(316, 74);
            this.dsKhoa.Name = "dsKhoa";
            this.dsKhoa.ReadOnly = true;
            this.dsKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsKhoa.Size = new System.Drawing.Size(477, 247);
            this.dsKhoa.TabIndex = 9;
            this.dsKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsKhoa_CellClick);
            this.dsKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsKhoa_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_iKhoaID";
            this.Column1.HeaderText = "Mã Khoa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenKhoa";
            this.Column2.HeaderText = "Tên Khoa";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // lbmaK
            // 
            this.lbmaK.AutoSize = true;
            this.lbmaK.Location = new System.Drawing.Point(39, 77);
            this.lbmaK.Name = "lbmaK";
            this.lbmaK.Size = new System.Drawing.Size(50, 13);
            this.lbmaK.TabIndex = 10;
            this.lbmaK.Text = "Mã Khoa";
            // 
            // lbtenK
            // 
            this.lbtenK.AutoSize = true;
            this.lbtenK.Location = new System.Drawing.Point(39, 121);
            this.lbtenK.Name = "lbtenK";
            this.lbtenK.Size = new System.Drawing.Size(54, 13);
            this.lbtenK.TabIndex = 11;
            this.lbtenK.Text = "Tên Khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(25, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 234);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(286, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 300);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH KHOA";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntimkiem.Image = global::BTL_QLBenhVien.Properties.Resources.tk;
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(612, 355);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(84, 40);
            this.btntimkiem.TabIndex = 16;
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
            this.btnthoat.Location = new System.Drawing.Point(725, 355);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(79, 40);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Image = global::BTL_QLBenhVien.Properties.Resources.xoa;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(501, 355);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(78, 40);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Image = global::BTL_QLBenhVien.Properties.Resources.sua;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(393, 355);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(77, 40);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Image = global::BTL_QLBenhVien.Properties.Resources.them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(286, 355);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Image = global::BTL_QLBenhVien.Properties.Resources.reset;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(167, 355);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 40);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 428);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.lbtenK);
            this.Controls.Add(this.lbmaK);
            this.Controls.Add(this.dsKhoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtenkhoa);
            this.Controls.Add(this.txtmaKhoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmKhoa";
            this.Text = "frmKhoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaKhoa;
        private System.Windows.Forms.TextBox txtenkhoa;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dsKhoa;
        private System.Windows.Forms.Label lbmaK;
        private System.Windows.Forms.Label lbtenK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}