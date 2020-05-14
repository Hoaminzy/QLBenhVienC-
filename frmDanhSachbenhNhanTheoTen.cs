using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BTL_QLBenhVien
{
    public partial class frmDanhSachbenhNhanTheoTen : Form
    {
        public frmDanhSachbenhNhanTheoTen()
        {
            InitializeComponent();
        }
       
        private void frmDanhSachbenhNhanTheoTen_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            KetNoi kn = new KetNoi();
           // dt = kn.laybang("SELECT tblBenhnhan.PK_iBenhnhanID, tblBenhnhan.sHoten, tblBenhnhan.bGioitinh, tblBenhnhan.sDiachi, tblBenhnhan.iSDT, tblBenhnhan.dNgaysinh, tblKhoa.PK_iKhoaID, tblKhoa.sTenKhoa FROM     tblBenhnhan INNER JOIN  tblKhoa ON tblBenhnhan.PK_iBenhnhanID = tblKhoa.PK_iBenhNhanID");
          dt=kn.laybang("select * from tblBenhNhan");
          rpDSBenhNhan rp = new rpDSBenhNhan();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;

        }

 
   private void btnbaocao_Click_1(object sender, EventArgs e)
   {
       if (txtenBN.Text == "")
       {
           MessageBox.Show("Bạn chưa nhập tên bệnh nhân!!!");
       }
       else
       {
           DataTable dt = new DataTable();
           KetNoi kn = new KetNoi();
           dt = kn.laybang("select * from tblBenhNhan where sHoten ='" + txtenBN.Text + "'");
           rpDSBenhNhan rp = new rpDSBenhNhan();
           rp.SetDataSource(dt);
           crystalReportViewer1.ReportSource = rp;
       }
       txtenBN.Clear();
       
   }

   private void btnreset_Click(object sender, EventArgs e)
   {
       frmDanhSachbenhNhanTheoTen_Load(sender, e);
   }

   private void btnthoat_Click(object sender, EventArgs e)
   {
       DialogResult tl;
       tl = MessageBox.Show("Bạn có muốn hủy không ??", "cancel", MessageBoxButtons.YesNo);
       if (tl == DialogResult.Yes)
       {
           this.Close();
       }
   }
    }
}
