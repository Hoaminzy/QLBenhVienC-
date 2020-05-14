namespace BTL_QLBenhVien
{
    partial class frmDSBenhNhanTheoKhoa
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
            this.rpdsBNtheoKhoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpdsBNtheoKhoa
            // 
            this.rpdsBNtheoKhoa.ActiveViewIndex = -1;
            this.rpdsBNtheoKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpdsBNtheoKhoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpdsBNtheoKhoa.Location = new System.Drawing.Point(12, 3);
            this.rpdsBNtheoKhoa.Name = "rpdsBNtheoKhoa";
            this.rpdsBNtheoKhoa.Size = new System.Drawing.Size(864, 502);
            this.rpdsBNtheoKhoa.TabIndex = 0;
            // 
            // frmDSBenhNhanTheoKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 517);
            this.Controls.Add(this.rpdsBNtheoKhoa);
            this.Name = "frmDSBenhNhanTheoKhoa";
            this.Text = "frmDSBenhNhanTheoKhoa";
            this.Load += new System.EventHandler(this.frmDSBenhNhanTheoKhoa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpdsBNtheoKhoa;
    }
}