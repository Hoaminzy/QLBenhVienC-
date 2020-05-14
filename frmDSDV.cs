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
    public partial class frmDSDV : Form
    {
        public frmDSDV()
        {
            InitializeComponent();
        }

        private void frmDSDV_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            KetNoi kn = new KetNoi();
            // dt = kn.laybang("SELECT tblBenhnhan.PK_iBenhnhanID, tblBenhnhan.sHoten, tblBenhnhan.bGioitinh, tblBenhnhan.sDiachi, tblBenhnhan.iSDT, tblBenhnhan.dNgaysinh, tblKhoa.PK_iKhoaID, tblKhoa.sTenKhoa FROM     tblBenhnhan INNER JOIN  tblKhoa ON tblBenhnhan.PK_iBenhnhanID = tblKhoa.PK_iBenhNhanID");
            dt = kn.laybang("select tblDichVu.PK_iDichVuID, tblDichVu.sTenDV, tblDichVu.fDonGia, tblThongTinChiTietDichVu.iSoLuong from tblDichVu inner join tblThongTinChiTietDichVu on tblDichVu.PK_iDichVuID=tblThongTinChiTietDichVu.PK_iDichVuID");
            rpDSDV rp = new rpDSDV();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
