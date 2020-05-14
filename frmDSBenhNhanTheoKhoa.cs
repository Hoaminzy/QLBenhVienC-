using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_QLBenhVien
{
    public partial class frmDSBenhNhanTheoKhoa : Form
    {
        public frmDSBenhNhanTheoKhoa()
        {
            InitializeComponent();
        }

        private void frmDSBenhNhanTheoKhoa_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            KetNoi kn = new KetNoi();
            // dt = kn.laybang("SELECT tblBenhnhan.PK_iBenhnhanID, tblBenhnhan.sHoten, tblBenhnhan.bGioitinh, tblBenhnhan.sDiachi, tblBenhnhan.iSDT, tblBenhnhan.dNgaysinh, tblKhoa.PK_iKhoaID, tblKhoa.sTenKhoa FROM     tblBenhnhan INNER JOIN  tblKhoa ON tblBenhnhan.PK_iBenhnhanID = tblKhoa.PK_iBenhNhanID");
            dt = kn.laybang("SELECT tblBenhNhan.PK_iBenhNhanID, tblBenhNhan.sHoTen, tblBenhNhan.bGioiTinh, tblBenhNhan.sDiaChi, tblBenhNhan.sSDT, tblBenhNhan.dNgaySinh, tblKhoa.PK_iKhoaID, tblKhoa.sTenKhoa FROM tblBenhNhan INNER JOIN tblKhoa ON tblBenhNhan.PK_iKhoaID = tblKhoa.PK_iKhoaID");
            CRBenhNhanTheoKhoa rp = new CRBenhNhanTheoKhoa();
            rp.SetDataSource(dt);
            rpdsBNtheoKhoa.ReportSource = rp;
        }
    }
}
