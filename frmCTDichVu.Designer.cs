namespace BTL_QLBenhVien
{
    partial class frmCTDichVu
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
            this.txtmaTTDV = new System.Windows.Forms.TextBox();
            this.txtmaBA = new System.Windows.Forms.TextBox();
            this.txtmaBN = new System.Windows.Forms.TextBox();
            this.txtmaDV = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dsTTCTDV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmaTTDV = new System.Windows.Forms.Label();
            this.lnmaBN = new System.Windows.Forms.Label();
            this.lbmaBA = new System.Windows.Forms.Label();
            this.lbmaDV = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataSetDSBN1 = new BTL_QLBenhVien.DataSetDSBN();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsTTCTDV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDSBN1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmaTTDV
            // 
            this.txtmaTTDV.Location = new System.Drawing.Point(126, 54);
            this.txtmaTTDV.Name = "txtmaTTDV";
            this.txtmaTTDV.Size = new System.Drawing.Size(112, 20);
            this.txtmaTTDV.TabIndex = 0;
            // 
            // txtmaBA
            // 
            this.txtmaBA.Location = new System.Drawing.Point(126, 101);
            this.txtmaBA.Name = "txtmaBA";
            this.txtmaBA.Size = new System.Drawing.Size(112, 20);
            this.txtmaBA.TabIndex = 1;
            // 
            // txtmaBN
            // 
            this.txtmaBN.Location = new System.Drawing.Point(126, 150);
            this.txtmaBN.Name = "txtmaBN";
            this.txtmaBN.Size = new System.Drawing.Size(112, 20);
            this.txtmaBN.TabIndex = 2;
            // 
            // txtmaDV
            // 
            this.txtmaDV.Location = new System.Drawing.Point(126, 198);
            this.txtmaDV.Name = "txtmaDV";
            this.txtmaDV.Size = new System.Drawing.Size(112, 20);
            this.txtmaDV.TabIndex = 3;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(126, 247);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(112, 20);
            this.txtSL.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Image = global::BTL_QLBenhVien.Properties.Resources.them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(373, 407);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 37);
            this.btnThem.TabIndex = 6;
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
            this.btnsua.Location = new System.Drawing.Point(517, 407);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(86, 37);
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
            this.btntimkiem.Location = new System.Drawing.Point(660, 407);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(87, 37);
            this.btntimkiem.TabIndex = 8;
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
            this.btnthoat.Location = new System.Drawing.Point(797, 407);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(91, 37);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dsTTCTDV
            // 
            this.dsTTCTDV.AllowUserToAddRows = false;
            this.dsTTCTDV.AllowUserToDeleteRows = false;
            this.dsTTCTDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsTTCTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTTCTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dsTTCTDV.Location = new System.Drawing.Point(6, 42);
            this.dsTTCTDV.Name = "dsTTCTDV";
            this.dsTTCTDV.ReadOnly = true;
            this.dsTTCTDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsTTCTDV.Size = new System.Drawing.Size(606, 320);
            this.dsTTCTDV.TabIndex = 11;
            this.dsTTCTDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTTCTDV_CellClick);
            this.dsTTCTDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTTCTDV_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_iTTDichVuID";
            this.Column1.HeaderText = "Mã TTCT DV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PK_iBenhAnID";
            this.Column2.HeaderText = "Mã Bệnh Án";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 113;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PK_iBenhNhanID";
            this.Column3.HeaderText = "Mã Bệnh Nhân";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 131;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PK_iDichVuID";
            this.Column4.HeaderText = "Mã Dịch Vụ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 109;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "iSoLuong";
            this.Column5.HeaderText = "Số Lương";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 97;
            // 
            // lbmaTTDV
            // 
            this.lbmaTTDV.AutoSize = true;
            this.lbmaTTDV.Location = new System.Drawing.Point(32, 54);
            this.lbmaTTDV.Name = "lbmaTTDV";
            this.lbmaTTDV.Size = new System.Drawing.Size(54, 13);
            this.lbmaTTDV.TabIndex = 12;
            this.lbmaTTDV.Text = "Mã TTDV";
            // 
            // lnmaBN
            // 
            this.lnmaBN.AutoSize = true;
            this.lnmaBN.Location = new System.Drawing.Point(32, 150);
            this.lnmaBN.Name = "lnmaBN";
            this.lnmaBN.Size = new System.Drawing.Size(79, 13);
            this.lnmaBN.TabIndex = 13;
            this.lnmaBN.Text = "Mã Bệnh Nhân";
            // 
            // lbmaBA
            // 
            this.lbmaBA.AutoSize = true;
            this.lbmaBA.Location = new System.Drawing.Point(32, 101);
            this.lbmaBA.Name = "lbmaBA";
            this.lbmaBA.Size = new System.Drawing.Size(66, 13);
            this.lbmaBA.TabIndex = 14;
            this.lbmaBA.Text = "Mã Bệnh Án";
            // 
            // lbmaDV
            // 
            this.lbmaDV.AutoSize = true;
            this.lbmaDV.Location = new System.Drawing.Point(32, 198);
            this.lbmaDV.Name = "lbmaDV";
            this.lbmaDV.Size = new System.Drawing.Size(63, 13);
            this.lbmaDV.TabIndex = 15;
            this.lbmaDV.Text = "Mã Dịch Vụ";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(32, 247);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(53, 13);
            this.lbSL.TabIndex = 16;
            this.lbSL.Text = "Số Lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 297);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dsTTCTDV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 368);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN CHI TIẾT DỊCH VỤ";
            // 
            // dataSetDSBN1
            // 
            this.dataSetDSBN1.DataSetName = "DataSetDSBN";
            this.dataSetDSBN1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnbaocao
            // 
            this.btnbaocao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbaocao.Image = global::BTL_QLBenhVien.Properties.Resources.bc;
            this.btnbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbaocao.Location = new System.Drawing.Point(194, 407);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(126, 37);
            this.btnbaocao.TabIndex = 19;
            this.btnbaocao.Text = "Hóa Đơn Dịch Vụ";
            this.btnbaocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbaocao.UseVisualStyleBackColor = false;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Image = global::BTL_QLBenhVien.Properties.Resources.reset;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(145, 333);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 41);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmCTDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 456);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbmaDV);
            this.Controls.Add(this.lbmaBA);
            this.Controls.Add(this.lnmaBN);
            this.Controls.Add(this.lbmaTTDV);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtmaDV);
            this.Controls.Add(this.txtmaBN);
            this.Controls.Add(this.txtmaBA);
            this.Controls.Add(this.txtmaTTDV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCTDichVu";
            this.Text = "frmCTDichVu";
            this.Load += new System.EventHandler(this.frmCTDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTTCTDV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDSBN1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaTTDV;
        private System.Windows.Forms.TextBox txtmaBA;
        private System.Windows.Forms.TextBox txtmaBN;
        private System.Windows.Forms.TextBox txtmaDV;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dsTTCTDV;
        private System.Windows.Forms.Label lbmaTTDV;
        private System.Windows.Forms.Label lnmaBN;
        private System.Windows.Forms.Label lbmaBA;
        private System.Windows.Forms.Label lbmaDV;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private DataSetDSBN dataSetDSBN1;
        private System.Windows.Forms.Button btnbaocao;
    }
}