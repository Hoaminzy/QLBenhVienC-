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
    public partial class frmBenhNhan : Form
    {
        public frmBenhNhan()
        {
            InitializeComponent();
        }
        private static frmBenhNhan instance;
        public static frmBenhNhan GetInstance()
          {
              if (instance == null)
                  instance = new frmBenhNhan();
              return instance;
         }
        string constr = "Data Source=HC;Initial Catalog=QLBenhNhan;Integrated Security=True";

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(constr);
            string sq="Select *from tblBenhNhan";
            con.Open();
            SqlCommand cmd = new SqlCommand(sq, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsbenhnhan.DataSource = dt;
            con.Close();
            
        }

        private void danhsachbenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dsbenhnhan.Rows[e.RowIndex];
            txtmaBN.Text = row.Cells[0].Value.ToString();
            txtmaBN.Enabled = true;
            txtHoten.Text = row.Cells[1].Value.ToString();
           string gt = this.dsbenhnhan.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (gt.Trim() == "Nam" || gt.Trim() == "nam")
                RBTnam.Checked = true;
            else
                RBTnu.Checked = true;
         //   gt.Text = row.Cells[2].Value.ToString();
            txtsdt.Text = row.Cells[3].Value.ToString();
            txtdiachi.Text = row.Cells[4].Value.ToString();
            dpcngaysinh.Text = dsbenhnhan.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtmakhoa.Text = row.Cells[6].Value.ToString();
            
            
        }
        
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmaBN.Clear(); txtHoten.Clear(); RBTnam.Checked = false; RBTnu.Checked = false;  txtsdt.Clear(); txtdiachi.Clear();
            dpcngaysinh.ResetText();
            txtmaBN.Enabled = true;
            txtmakhoa.Clear(); txtmaBN.Focus();
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
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsertBenhNhan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhNhanID", txtmaBN.Text));

            cmd.Parameters.Add(new SqlParameter("@sHoTen", txtHoten.Text));
           string gt;
            if (RBTnam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            cmd.Parameters.Add(new SqlParameter("@bGioiTinh", gt));
            cmd.Parameters.Add(new SqlParameter("@sSDT", txtsdt.Text));
            cmd.Parameters.Add(new SqlParameter("@sDiaChi", txtdiachi.Text));
            string d = dpcngaysinh.Value.ToString("MM/dd/yyyy");
            cmd.Parameters.Add(new SqlParameter("@dNgaySinh", d));
            cmd.Parameters.Add(new SqlParameter("@PK_iKhoaID", txtmakhoa.Text));
            DataTable dt = new DataTable();
            string sqlSelect = "Select PK_iBenhNhanID from tblBenhNhan where PK_iBenhNhanID ='" + txtmaBN.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmaBN.Text != "" && txtHoten.Text != "" && txtdiachi.Text != "" && txtsdt.Text != "" && (RBTnam.Checked || RBTnu.Checked)&& txtmakhoa.Text!="")
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã bệnh nhân đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtmaBN.Clear();
                }
                else
                {
                    int nam = DateTime.Now.Year;
                    int thang = DateTime.Now.Month;
                    int ngay = DateTime.Now.Day;
                    int y = dpcngaysinh.Value.Year;
                    int m = dpcngaysinh.Value.Month;
                    int day = dpcngaysinh.Value.Day;
                    //TimeSpan ts = DateTime.Now - DTPNS.Value;
                   if (nam - y > 18)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        frmBenhNhan_Load(sender, e);
                        con.Close();
                    }
                    /*else if (nam - y ==18)
                    {
                        if (thang  - m > 0)
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            NhanVien_Load(sender, e);
                            cnn.Close();
                        }
                        else if (thang == m)
                        {
                            if (ngay - day > 0)
                            {
                                cnn.Open();
                                cmd.ExecuteNonQuery();
                                DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                                NhanVien_Load(sender, e);
                                cnn.Close();
                            }
                            else
                            {
                                DialogResult loi = MessageBox.Show("Tuổi của nhân viên phải lớn hơn 18", "Lỗi", MessageBoxButtons.OK);
                                if (loi == DialogResult.OK)
                                    DTPNS.ResetText();
                            }
                        }
                        else
                        {
                            DialogResult loi = MessageBox.Show("Tuổi của nhân viên phải lớn hơn 18", "Lỗi", MessageBoxButtons.OK);
                            if (loi == DialogResult.OK)
                                DTPNS.ResetText();
                        }
                    }*/
                    else
                    {
                        DialogResult loi = MessageBox.Show("Tuổi của nhân viên phải lớn hơn 18", "Lỗi", MessageBoxButtons.OK);
                        if (loi == DialogResult.OK)
                            dpcngaysinh.ResetText();
                    }
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK);
            }
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UpdateBenhNhan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhNhanID", txtmaBN.Text));
            cmd.Parameters.Add(new SqlParameter("@sHoTen", txtHoten.Text));
            string gt;
            if (RBTnam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
           
            cmd.Parameters.Add(new SqlParameter("@bGioiTinh", gt));
            cmd.Parameters.Add(new SqlParameter("@sSDT", txtsdt.Text));
            cmd.Parameters.Add(new SqlParameter("@sDiaChi", txtdiachi.Text));
            string d = dpcngaysinh.Value.ToString("MM/dd/yyyy");
            cmd.Parameters.Add(new SqlParameter("@dNgaySinh", d));
            cmd.Parameters.Add(new SqlParameter("@PK_iKhoaID", txtmakhoa.Text));
            int nam = DateTime.Now.Year;
            int thang = DateTime.Now.Month;
            int ngay = DateTime.Now.Day;
            int y = dpcngaysinh.Value.Year;
            int m = dpcngaysinh.Value.Month;
            int day = dpcngaysinh.Value.Day;
            if (nam - y >= 18)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                frmBenhNhan_Load(sender, e);
                con.Close();
            }
            /*else if (nam - y == 18)
            {
                if (thang - m > 0)
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    NhanVien_Load(sender, e);
                    cnn.Close();
                }
                else if (thang == m)
                {
                    if (ngay - day > 0)
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        NhanVien_Load(sender, e);
                        cnn.Close();
                    }
                    else
                    {
                        DialogResult loi = MessageBox.Show("Tuổi của nhân viên phải lớn hơn 18", "Lỗi", MessageBoxButtons.OK);
                        if (loi == DialogResult.OK)
                            DTPNS.ResetText();
                    }
                }
                else
                {
                    DialogResult loi = MessageBox.Show("Tuổi của nhân viên phải lớn hơn 18", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        DTPNS.ResetText();
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Tuổi của nhân viên phải lớn hơn 18", "Lỗi", MessageBoxButtons.OK);
                if (loi == DialogResult.OK)
                    DTPNS.ResetText();
            } */
            else
            {
                DialogResult loi = MessageBox.Show("Tuổi của nhân viên phải lớn hơn 18", "Lỗi", MessageBoxButtons.OK);
                if (loi == DialogResult.OK)
                    dpcngaysinh.ResetText();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblBenhNhan ";
            if (txtmaBN.Text != "")
                sql += "where PK_iBenhNhanID like N'%" + txtmaBN.Text + "%'";
            else if (txtHoten.Text != "")
                sql += "where sHoTen like N'%" + txtHoten.Text + "%'";
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
           dsbenhnhan.DataSource = dt;
            con.Close();
        }


     

    }
}
