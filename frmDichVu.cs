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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }
        private static frmDichVu instance;
        public static frmDichVu GetInstance()
        {
            if (instance == null)
                instance = new frmDichVu();
            return instance;
        }
        string constr = "Data Source=HC;Initial Catalog=QLBenhNhan;Integrated Security=True";

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string sq = "select *from  tblDichVu";
            con.Open();
            SqlCommand cmd = new SqlCommand(sq, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsDichVu.DataSource = dt;
            con.Close();

        }

        private void dsDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dsDichVu.Rows[e.RowIndex];
            txtmadv.Text = row.Cells[0].Value.ToString();
            txtmadv.Enabled = true;
            txtendv.Text = row.Cells[1].Value.ToString();
            txtgiadv.Text = row.Cells[2].Value.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmadv.Clear(); txtendv.Clear(); txtgiadv.Clear();
            txtmadv.Enabled = true; txtmadv.Focus();
            frmDichVu_Load(sender, e);
        }

   
        private void btnsua_Click(object sender, EventArgs e)
        {
          /*  try {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UpdateDichVu";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iDichVuID", txtmadv.Text));
                cmd.Parameters.Add(new SqlParameter("@sTenDV", txtendv.Text));
                cmd.Parameters.Add(new SqlParameter("@fDonGia", txtgiadv.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                frmDichVu_Load(sender, e);
                con.Close();
            }
           catch(Exception)
            {
                MessageBox.Show("Không có trường hợp nào được sửa");
            }*/
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UpdateDichVu";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iDichVuID", txtmadv.Text));
                cmd.Parameters.Add(new SqlParameter("@sTenDV", txtendv.Text));
                cmd.Parameters.Add(new SqlParameter("@fDonGia", txtgiadv.Text));

                float dongia = float.Parse(txtgiadv.Text);
                if (dongia >= 0)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    frmDichVu_Load(sender, e);
                    con.Close();
                }
                else if (dongia < 0)
                {
                    DialogResult loi = MessageBox.Show("Đơn giá phải lớn hơn 0 ", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtgiadv.Clear(); txtgiadv.Focus();
                }
                else
                {

                    DialogResult loi = MessageBox.Show("hãy nhập giá ", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtgiadv.Clear(); txtgiadv.Focus();
                }

            }
            catch(Exception)
            {
                MessageBox.Show("KHông có trường hợp nào đc sửa");
            }
      
                   
          
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblDichVu ";
            if (txtmadv.Text != "")
                sql += "where PK_iDichVuID like '%" + txtmadv.Text + "%'";
            else if (txtendv.Text != "")
                sql += "where sTenDV like N'%" + txtendv.Text + "%'";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable db = new DataTable();
            ad.Fill(db);
            dsDichVu.DataSource = db;
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
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsertDichVu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iDichVuID", txtmadv.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenDV", txtendv.Text));
            cmd.Parameters.Add(new SqlParameter("@DonGia", txtgiadv.Text));
            DataTable dt = new DataTable();
            string sqlSelect = "Select PK_iDichVuID from tblDichVu where PK_iDichVuID='" + txtmadv.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmadv.Text != "" && txtendv.Text != "" && txtgiadv.Text != "")
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã dịch vụ đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtmadv.Clear(); txtmadv.Focus();
                }
                else
                {
                                float dongia = float.Parse(txtgiadv.Text);
                                if (dongia > 0)
                                {
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                                    frmDichVu_Load(sender, e);
                                    con.Close();
                                }
                                else if (dongia < 0)
                                {
                                    DialogResult loi = MessageBox.Show("Đơn giá phải lớn hơn 0 ", "Lỗi", MessageBoxButtons.OK);
                                    if (loi == DialogResult.OK)
                                        txtgiadv.Clear(); txtgiadv.Focus();
                                }
                                else
                                {

                                    DialogResult loi = MessageBox.Show("hãy nhập giá ", "Lỗi", MessageBoxButtons.OK);
                                    if (loi == DialogResult.OK)
                                        txtgiadv.Clear(); txtgiadv.Focus();
                                }

                            }
                            
            }
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void dsDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                    int numrow;
            numrow = e.RowIndex;
            txtmadv.Text = dsDichVu.Rows[numrow].Cells[0].Value.ToString();
            txtendv.Text = dsDichVu.Rows[numrow].Cells[1].Value.ToString();
            txtgiadv.Text = dsDichVu.Rows[numrow].Cells[2].Value.ToString();
        }

        private void txtmadv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmadv.Text))
            {
                e.Cancel = true;
                txtmadv.Focus();

                errorProvider1.SetError(txtmadv, "Hãy nhập đầy đủ thông tin!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtmadv, string.Empty);
            }
        }

        /*private void dsDichVu_SelectionChanged(object sender, EventArgs e)
        {


            if (dsDichVu.SelectedRows[0].Cells["txtmadv"].Value != null && dsDichVu.SelectedRows[1].Cells["txtendv"].Value != null && dsDichVu.SelectedRows[2].Cells["txtgiadv"].Value != null)
            {
                txtmadv.Text = dsDichVu.SelectedRows[0].Cells["txtmadv"].Value.ToString();
                txtendv.Text = dsDichVu.SelectedRows[0].Cells["txtendv"].Value.ToString();
                txtgiadv.Text = dsDichVu.SelectedRows[0].Cells["txtgiadv"].Value.ToString();
            }
            else
            {
                MessageBox.Show("hịi");
            }
            
        }*/

    }
}
