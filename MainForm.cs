using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLBenhVien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          
        }



        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn có muốn hủy không ??", "cancel", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void thuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuoc thuoc = new frmThuoc();
           thuoc.ShowDialog();
          
        }

        private void dichvuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVu dv = new frmDichVu();
            dv.ShowDialog();
        }

        private void TTCT_Click(object sender, EventArgs e)
        {
            frmCTDichVu ttdv = new frmCTDichVu();
            ttdv.ShowDialog();
        }

        private void HosoBN_Click(object sender, EventArgs e)
        {
            frmBenhNhan benhnhan = new frmBenhNhan();
            benhnhan.ShowDialog();
        }

        private void BAn_Click(object sender, EventArgs e)
        {
            frmBenhAn BA = new frmBenhAn();
            BA.ShowDialog();
        }

        private void NVien_Click(object sender, EventArgs e)
        {
            frmNhanVien NV = new frmNhanVien();
            NV.ShowDialog();
        }

        private void BCBenhNhan_Click(object sender, EventArgs e)
        {
           

            frmDanhSachbenhNhanTheoTen dsBN = new frmDanhSachbenhNhanTheoTen();
            dsBN.ShowDialog();
        }

        private void BCBenhNHanTheoKhoa_Click(object sender, EventArgs e)
        {
            frmDSBenhNhanTheoKhoa dsbnKhoa = new frmDSBenhNhanTheoKhoa();
            dsbnKhoa.ShowDialog();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa khoa = new frmKhoa();
            khoa.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon HD = new frmHoaDon();
            HD.ShowDialog();
        }


        
        
      
    }
}
