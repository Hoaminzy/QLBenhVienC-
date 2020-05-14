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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private static frmNhanVien instance;
        public static frmNhanVien GetInstance()
        {
            if (instance == null)
                instance = new frmNhanVien();
            return instance;
        }
        string constr = "Data Source=HC;Initial Catalog=QLBenhNhan;Integrated Security=True";

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string sq = "Select *from tblNhanVien";
            con.Open();
            SqlCommand cmd = new SqlCommand(sq, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsnhanvien.DataSource = dt;
            con.Close();
        }

        private void dsnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          DataGridViewRow row = new DataGridViewRow();
            row = dsnhanvien.Rows[e.RowIndex];
            txtmaNV.Text = row.Cells[0].Value.ToString();
            txtmaNV.Enabled = true;
            txthoten.Text = row.Cells[1].Value.ToString();
           string gt = this.dsnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (gt.Trim() == "Nam" || gt.Trim() == "nam")
                RBTnam.Checked = true;
            else
                RBTnu.Checked = true;
            dtngaysinh.Text = dsnhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtdiachi.Text = row.Cells[4].Value.ToString();
            txtluong.Text = row.Cells[5].Value.ToString();
            txtchucvu.Text=row.Cells[6].Value.ToString();
            txtchuyenmon.Text=row.Cells[7].Value.ToString();
            txttrinhdo.Text=row.Cells[8].Value.ToString();
            txtkhoa.Text = row.Cells[9].Value.ToString();

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            
            txtmaNV.Clear(); txthoten.Clear(); RBTnam.Checked = false; RBTnu.Checked = false;  txtluong.Clear(); txtdiachi.Clear();
            txtchucvu.Clear(); txtchuyenmon.Clear(); txttrinhdo.Clear();
            dtngaysinh.ResetText();
            txtmaNV.Enabled = true;
            txtmaNV.Focus(); txtkhoa.Clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UpdateNhanVien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iNhanVienID", txtmaNV.Text));
            cmd.Parameters.Add(new SqlParameter("@sHoTen", txthoten.Text));
            string gt;
            if (RBTnam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
           
            cmd.Parameters.Add(new SqlParameter("@bGioiTinh", gt));
             cmd.Parameters.Add(new SqlParameter("@fLuong", txtluong.Text));
            cmd.Parameters.Add(new SqlParameter("@sDiaChi", txtdiachi.Text));
            cmd.Parameters.Add(new SqlParameter("@sChucVu", txtchucvu.Text));
            cmd.Parameters.Add(new SqlParameter("@sChuyenMon", txtchuyenmon.Text));
            cmd.Parameters.Add(new SqlParameter("@sTrinhDo", txttrinhdo.Text));
            string d = dtngaysinh.Value.ToString("MM/dd/yyyy");
            cmd.Parameters.Add(new SqlParameter("@dNgaySinh", d));
            cmd.Parameters.Add(new SqlParameter("@PK_iKhoaID", txtkhoa.Text));
            int nam = DateTime.Now.Year;
            int thang = DateTime.Now.Month;
            int ngay = DateTime.Now.Day;
            int y =dtngaysinh.Value.Year;
            int m = dtngaysinh.Value.Month;
            int day = dtngaysinh.Value.Day;
            if (nam - y >= 18)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                frmNhanVien_Load(sender, e);
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
                    dtngaysinh.ResetText();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsertNhanVien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iNhanVienID", txtmaNV.Text));

            cmd.Parameters.Add(new SqlParameter("@sHoTen", txthoten.Text));
           string gt;
            if (RBTnam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            cmd.Parameters.Add(new SqlParameter("@bGioiTinh", gt));
            cmd.Parameters.Add(new SqlParameter("@sDiaChi", txtdiachi.Text));
            cmd.Parameters.Add(new SqlParameter("@fLuong", txtluong.Text));
            cmd.Parameters.Add(new SqlParameter("@sChucVu", txtchucvu.Text));
            cmd.Parameters.Add(new SqlParameter("@sChuyenMon", txtchuyenmon.Text));
            cmd.Parameters.Add(new SqlParameter("@sTrinhDo", txttrinhdo.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iKhoaID", txtkhoa.Text));
            string d = dtngaysinh.Value.ToString("MM/dd/yyyy");
            cmd.Parameters.Add(new SqlParameter("@dNgaySinh", d));
      
            DataTable dt = new DataTable();
            string sqlSelect = "Select PK_iNhanVienID from tblNhanVien where PK_iNhanVienID ='" + txtmaNV.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmaNV.Text != "" && txthoten.Text != "" && txtdiachi.Text != "" && txtluong.Text != "" && (RBTnam.Checked || RBTnu.Checked) && txtkhoa.Text != ""/*&& txtchucvu.Text!=""&&txtchuyenmon.Text!=""&&txttrinhdo.Text!=""*/)
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtmaNV.Clear(); txtmaNV.Focus();
                }
                else
                {
                    int nam = DateTime.Now.Year;
                    int thang = DateTime.Now.Month;
                    int ngay = DateTime.Now.Day;
                    int y = dtngaysinh.Value.Year;
                    int m = dtngaysinh.Value.Month;
                    int day = dtngaysinh.Value.Day;
                    //TimeSpan ts = DateTime.Now - DTPNS.Value;
                   if (nam - y > 18)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        frmNhanVien_Load(sender, e);
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
                            dtngaysinh.ResetText();
                    }
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
                string sql = "Select * from tblNhanVien ";
            if (txtmaNV.Text != "")
                sql += "where PK_iNhanVienID like '%" + txtmaNV.Text + "%'";
            else if (txthoten.Text != "")
                sql += "where sHoTen like N'%" + txthoten.Text + "%'";
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
           dsnhanvien.DataSource = dt;
            con.Close();
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

        private void dsnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtmaNV.Text = dsnhanvien.Rows[numrow].Cells[0].Value.ToString();
            txthoten.Text = dsnhanvien.Rows[numrow].Cells[1].Value.ToString();
            if (dsnhanvien.CurrentRow.Cells[2].Value.ToString() == "True")
            {
                RBTnam.Checked = true;
            }
            else
                if (dsnhanvien.CurrentRow.Cells[2].Value.ToString() == "False")
                {
                    RBTnu.Checked = true;
                }
            //dtngaysinh.Text = dsnhanvien.Rows[numrow].Cells[2].Value.ToString();
            txtdiachi.Text = dsnhanvien.Rows[numrow].Cells[3].Value.ToString();
            txtluong.Text = dsnhanvien.Rows[numrow].Cells[4].Value.ToString();
            txtchucvu.Text = dsnhanvien.Rows[numrow].Cells[5].Value.ToString();
            txtchuyenmon.Text = dsnhanvien.Rows[numrow].Cells[6].Value.ToString();
            txttrinhdo.Text = dsnhanvien.Rows[numrow].Cells[7].Value.ToString();
            txtkhoa.Text = dsnhanvien.Rows[numrow].Cells[8].Value.ToString();
        }


        private void frmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }



        }

       
    }

