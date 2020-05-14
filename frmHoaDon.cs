using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BTL_QLBenhVien
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private static frmHoaDon instance;
        public static frmHoaDon GetInstance()
        {
            if (instance == null)
                instance = new frmHoaDon();
            return instance;
        }

        string constr = "Data Source=HC;Initial Catalog=QLBenhNhan;Integrated Security=True";

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string sqlSelect = "select * from tblHoaDon";
            con.Open();
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsHoaDon.DataSource = dt;
            con.Close();
        }

        private void dsHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dsHoaDon.Rows[e.RowIndex];
            txtmaHD.Text = row.Cells[0].Value.ToString();
            txtmaBA.Text = row.Cells[1].Value.ToString();
            txtmaNV.Text = row.Cells[2].Value.ToString();
            txtmaThuoc.Text = row.Cells[3].Value.ToString();
            txtmaThuoc.Enabled = true;
            dtngaylap.Text = dsHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
          
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsertHoaDon";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("PK_iHoaDonID", txtmaHD.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhAnID", txtmaBA.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iNhanVienID", txtmaNV.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iThuocID", txtmaThuoc.Text));
            string d1 = dtngaylap.Value.ToString("MM/dd/yyyy");  
            cmd.Parameters.Add(new SqlParameter("@dNgayLapHD", d1));
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            string sqlSelect1 = "Select PK_iHoaDonID from tblHoaDon where PK_iHoaDonID='" + txtmaHD.Text + "'";
            string sqlSelect2 = "Select PK_iNhanVienID from tblNhanVien where PK_iNhanVienID = '" + txtmaNV.Text + "'";
            string sqlSelect3 = "Select PK_iBenhAnID from tblBenhAn where PK_iBenhAnID = '" + txtmaBA.Text + "'";
            string sqlSelect4 = "Select PK_iThuocID from tblThuoc where PK_iThuocID = '" + txtmaThuoc.Text + "'";
            //  string sqlSelect4 = "Select iSoTheBHYT tblBenhAn where iSoTheBHYT='" + txtBHYT.Text + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(sqlSelect1, con);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlSelect2, con);
            SqlDataAdapter da3 = new SqlDataAdapter(sqlSelect3, con);
            SqlDataAdapter da4 = new SqlDataAdapter(sqlSelect4, con);
    
            da1.Fill(dt1);
            da2.Fill(dt2);
            da3.Fill(dt3);
            da4.Fill(dt4);
            if (txtmaBA.Text != "" && txtmaNV.Text != "" && txtmaBA.Text != "" && txtmaThuoc.Text != "" && dtngaylap.Text != "")
            {
                if (dt1.Rows.Count > 0 )
                {
                    DialogResult loi = MessageBox.Show("Hóa đơn đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                     
                       txtmaHD.Clear(); txtmaHD.Focus();
                     
                  //    txtmaThuoc.Clear(); txtmaThuoc.Focus();
                }
                else
                {
                    if (dt2.Rows.Count > 0 || dt3.Rows.Count > 0 || dt4.Rows.Count > 0)
                    {
                        DateTime a = new DateTime();
                        int yyyy = dtngaylap.Value.Year;
                        int mm = dtngaylap.Value.Month;
                        int dd = dtngaylap.Value.Day;
                        if (a.Year >= yyyy && a.Month >= mm && a.Day >= dd)
                        {
                            DialogResult loi = MessageBox.Show("Ngày nhập phải nhỏ hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK);
                            if (loi == DialogResult.OK)
                                dtngaylap.ResetText();
                        }
                        else
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            frmHoaDon_Load(sender, e);
                            con.Close();
                        
                        }
                    }
                    else
                    {
                        DialogResult loi = MessageBox.Show("Nhân viên hoặc bệnh nhân hoặc mã thuốc này không tồn tại", "Lỗi", MessageBoxButtons.OK);
                        if (loi == DialogResult.OK)
                                txtmaNV.Clear(); txtmaNV.Focus();
                                txtmaThuoc.Clear(); txtmaThuoc.Focus();
                      txtmaBA.Clear(); txtmaBA.Focus();
                    }
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK);
            }
           
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmaHD.Clear(); txtmaHD.Focus();
            txtmaBA.Clear(); 
            txtmaNV.Clear(); 
            txtmaThuoc.Clear(); 
            dtngaylap.ResetText();
            frmHoaDon_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UpdateHoaDon";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iHoaDonID", txtmaHD.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iNhanVienID", txtmaNV.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhAnID", txtmaBA.Text));
            cmd.Parameters.Add(new SqlParameter("PK_iThhuocID", txtmaThuoc.Text));
            string d = dtngaylap.Value.ToString("MM/dd/yyyy");
            cmd.Parameters.Add(new SqlParameter("@dNgayLapHD", d));
            DateTime a = new DateTime();
            int yyyy = dtngaylap.Value.Year;
            int mm =dtngaylap.Value.Month;
            int dd =dtngaylap.Value.Day;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            string sqlSelect = "Select PK_iHoaDonID from tblHoaDon where PK_iHoaDonID = '" + txtmaHD.Text + "'";
            string sqlSelect1 = "Select PK_iBenhAnID from tblBenhAn where PK_iBenhAnID='" + txtmaBA.Text + "'";
            string sqlSelect2 = "Select PK_iNhanVienID from tblNhanVien where PK_iNhanVienID='" + txtmaNV.Text + "'";
            string sqlSelect3 = "Select PK_iThuocID from tblThuoc where PK_iThuocID='" + txtmaThuoc.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlSelect1, con);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlSelect2, con);
            SqlDataAdapter da3 = new SqlDataAdapter(sqlSelect3, con);
            da.Fill(dt);
            da1.Fill(dt);
            da2.Fill(dt);
            da3.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (a.Year >=yyyy && a.Month >= mm && a.Day >= dd)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    frmHoaDon_Load(sender, e);
                    con.Close();
                }
                else
                {
                    DialogResult loi = MessageBox.Show("Ngày nhập phải nhỏ hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        dtngaylap.ResetText();
                }

            }
            else
            {
                DialogResult loi = MessageBox.Show("Nhân viên này không tồn tại", "Lỗi", MessageBoxButtons.OK);
                if (loi == DialogResult.OK)
                   txtmaNV.Clear();
                txtmaBA.Clear();
                txtmaHD.Clear(); txtmaHD.Focus();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblHoaDon ";
            if (txtmaHD.Text != "")
                sql += "where PK_iHoaDonID like '%" + txtmaHD.Text + "%'";
            else if (txtmaNV.Text != "")
                sql += "where PK_iNhanVienID like '%" + txtmaNV.Text + "%'";
            else if (txtmaBA.Text != "")
                sql += "where PK_iBenhAnID like '%" + txtmaBA.Text + "%'";
            else if (txtmaThuoc.Text != "")
                sql += "where PK_iThuocID like '%" + txtmaThuoc.Text + "%'";
            //   else if (txt.Text != "")
            //  sql += "where dongia like '%" + TxtDT.Text + "%'";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsHoaDon.DataSource = dt;
            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn có muốn hủy không ??", "cancel", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            frmDanhSachbenhNhanTheoTen baocao = new frmDanhSachbenhNhanTheoTen();
            baocao.ShowDialog();
        }

        private void dsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtmaHD.Text = dsHoaDon.Rows[numrow].Cells[0].Value.ToString();
            txtmaBA.Text = dsHoaDon.Rows[numrow].Cells[1].Value.ToString();
            txtmaNV.Text = dsHoaDon.Rows[numrow].Cells[2].Value.ToString();
            txtmaThuoc.Text = dsHoaDon.Rows[numrow].Cells[3].Value.ToString();
            dtngaylap.Text = dsHoaDon.Rows[numrow].Cells[4].Value.ToString();
        }


    }
}
