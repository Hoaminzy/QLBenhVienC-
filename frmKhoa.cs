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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        private static frmKhoa instance;
        public static frmKhoa GetInstance()
        {
            if (instance == null)
                instance = new frmKhoa();
            return instance;
        }
        string constr = "Data Source=HC;Initial Catalog=QLBenhNhan;Integrated Security=True";

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string sq = "select *from  tblKhoa";
            con.Open();
            SqlCommand cmd = new SqlCommand(sq, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsKhoa.DataSource = dt;
            con.Close();

        }

        private void dsKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dsKhoa.Rows[e.RowIndex];
            txtmaKhoa.Text = row.Cells[0].Value.ToString();
            txtmaKhoa.Enabled = true;
            txtenkhoa.Text = row.Cells[1].Value.ToString();
     
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmaKhoa.Clear(); txtmaKhoa.Focus();
            txtenkhoa.Clear();
            frmKhoa_Load(sender, e);
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsertKhoa";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iKhoaID", txtmaKhoa.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenKhoa", txtenkhoa.Text));
        
            DataTable dt = new DataTable();
            string sqlSelect = "Select PK_iThuocID from tblThuoc where PK_iThuocID='" + txtmaKhoa.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmaKhoa.Text != "" && txtenkhoa.Text != "" )
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã loại hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtmaKhoa.Clear();
                
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult them = MessageBox.Show("Thêm thành công", "Thêm", MessageBoxButtons.OK);
                    frmKhoa_Load(sender, e);
                    con.Close();
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "updateKhoa";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iKhoaID", txtmaKhoa.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenKhoa", txtenkhoa.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            frmKhoa_Load(sender, e);
            con.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            /*string sql = "Select * from tblKhoa ";
            if (txtmaKhoa.Text != "")
                sql += "where  PK_iKhoaID like '%" + txtmaKhoa.Text + "%'";
            else if (txtenkhoa.Text!= "")
                sql += "where sTenKhoa like N'%" + txtenkhoa.Text + "%'";
            else if (txtmaNV.Text != "")
                sql += "where PK_iNhanVienID like '%" + txtmaNV.Text + "%'";
            else if (txtmaBN.Text != "")
                sql += "where PK_iBenhNhanID like '%" + txtmaBN.Text + "%'";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable db = new DataTable();
            ad.Fill(db);
            dsKhoa.DataSource = db;
            con.Close();*/
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delKhoa";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iKhoaID",txtmaKhoa.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenKhoa", txtenkhoa.Text));
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                frmKhoa_Load(sender, e);
                con.Close();
            }
            btnreset_Click(sender, e);
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblKhoa ";
            if (txtmaKhoa.Text != "")
                sql += "where  PK_iKhoaID like '%" + txtmaKhoa.Text + "%'";
            else if (txtenkhoa.Text != "")
                sql += "where sTenKhoa like N'%" + txtenkhoa.Text + "%'";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable db = new DataTable();
            ad.Fill(db);
            dsKhoa.DataSource = db;
            con.Close();
        }

        private void dsKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtmaKhoa.Text = dsKhoa.Rows[numrow].Cells[0].Value.ToString();
            txtenkhoa.Text = dsKhoa.Rows[numrow].Cells[1].Value.ToString();
        }






    }
}
