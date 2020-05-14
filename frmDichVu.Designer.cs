namespace BTL_QLBenhVien
{
    partial class frmDichVu
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
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.txtendv = new System.Windows.Forms.TextBox();
            this.txtgiadv = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dsDichVu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmadv = new System.Windows.Forms.Label();
            this.lbtendv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(122, 77);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(118, 20);
            this.txtmadv.TabIndex = 0;
            this.txtmadv.Validating += new System.ComponentModel.CancelEventHandler(this.txtmadv_Validating);
            // 
            // txtendv
            // 
            this.txtendv.Location = new System.Drawing.Point(122, 123);
            this.txtendv.Name = "txtendv";
            this.txtendv.Size = new System.Drawing.Size(118, 20);
            this.txtendv.TabIndex = 1;
            // 
            // txtgiadv
            // 
            this.txtgiadv.Location = new System.Drawing.Point(122, 168);
            this.txtgiadv.Name = "txtgiadv";
            this.txtgiadv.Size = new System.Drawing.Size(118, 20);
            this.txtgiadv.TabIndex = 2;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Image = global::BTL_QLBenhVien.Properties.Resources.reset;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(169, 244);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(88, 39);
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
            this.btnThem.Location = new System.Drawing.Point(301, 419);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 38);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Image = global::BTL_QLBenhVien.Properties.Resources.sua;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(417, 419);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(84, 38);
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
            this.btntimkiem.Location = new System.Drawing.Point(523, 419);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(89, 38);
            this.btntimkiem.TabIndex = 6;
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
            this.btnThoat.Location = new System.Drawing.Point(644, 419);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 38);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dsDichVu
            // 
            this.dsDichVu.AllowUserToAddRows = false;
            this.dsDichVu.AllowUserToDeleteRows = false;
            this.dsDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dsDichVu.Location = new System.Drawing.Point(301, 61);
            this.dsDichVu.Name = "dsDichVu";
            this.dsDichVu.ReadOnly = true;
            this.dsDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsDichVu.Size = new System.Drawing.Size(465, 315);
            this.dsDichVu.TabIndex = 8;
            this.dsDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsDichVu_CellClick);
            this.dsDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsDichVu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_iDichVuID";
            this.Column1.HeaderText = "Mã Dịch Vụ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenDV";
            this.Column2.HeaderText = "Tên Dich Vụ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 92;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fDonGia";
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 71;
            // 
            // lbmadv
            // 
            this.lbmadv.AutoSize = true;
            this.lbmadv.Location = new System.Drawing.Point(32, 84);
            this.lbmadv.Name = "lbmadv";
            this.lbmadv.Size = new System.Drawing.Size(63, 13);
            this.lbmadv.TabIndex = 9;
            this.lbmadv.Text = "Mã Dịch Vụ";
            // 
            // lbtendv
            // 
            this.lbtendv.AutoSize = true;
            this.lbtendv.Location = new System.Drawing.Point(28, 126);
            this.lbtendv.Name = "lbtendv";
            this.lbtendv.Size = new System.Drawing.Size(67, 13);
            this.lbtendv.TabIndex = 10;
            this.lbtendv.Text = "Tên Dich Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Đơn Giá";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 184);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(280, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 363);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Dịch Vụ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbtendv);
            this.Controls.Add(this.lbmadv);
            this.Controls.Add(this.dsDichVu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtgiadv);
            this.Controls.Add(this.txtendv);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmDichVu";
            this.Text = "1";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.TextBox txtendv;
        private System.Windows.Forms.TextBox txtgiadv;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dsDichVu;
        private System.Windows.Forms.Label lbmadv;
        private System.Windows.Forms.Label lbtendv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}