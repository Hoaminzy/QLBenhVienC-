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
    public partial class frmThuoc : Form
    {
        public frmThuoc()
        {
            InitializeComponent();
            //binding();
        }
        private static frmThuoc instance;
        public static frmThuoc GetInstance()
        {
            if (instance == null)
                instance = new frmThuoc();
            return instance;
        }
        string constr = "Data Source=HC;Initial Catalog=QLBenhNhan;Integrated Security=True";
        private void frmThuoc_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string sq = "select *from  tblThuoc";
            con.Open();
            SqlCommand cmd = new SqlCommand(sq, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsThuoc.DataSource = dt;
            con.Close();

        }


        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmaThuoc.Clear(); txtenthuoc.Clear();
            txtgia.Clear();
            txtmaThuoc.Enabled = true;
        }

        private void dsThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dsThuoc.Rows[e.RowIndex];
            txtmaThuoc.Text = row.Cells[0].Value.ToString();
            txtmaThuoc.Enabled = true;
            txtenthuoc.Text = row.Cells[1].Value.ToString();
            txtgia.Text = row.Cells[2].Value.ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insertThuoc";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iThuocID", txtmaThuoc.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenThuoc", txtenthuoc.Text));
            cmd.Parameters.Add(new SqlParameter("@fDonGia", txtgia.Text));
            DataTable dt = new DataTable();
            string sqlSelect = "Select PK_iThuocID from tblThuoc where PK_iThuocID='" + txtmaThuoc.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmaThuoc.Text != "" && txtenthuoc.Text != "" &&txtgia.Text!="")
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã loại hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtmaThuoc.Clear();
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult them = MessageBox.Show("Thêm thành công", "Thêm", MessageBoxButtons.OK);
                    frmThuoc_Load(sender, e);
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
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "updateThuoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iThuocID", txtmaThuoc.Text));
                cmd.Parameters.Add(new SqlParameter("@sTenThuoc", txtenthuoc.Text));
                cmd.Parameters.Add(new SqlParameter("@fDonGia", txtgia.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                frmThuoc_Load(sender, e);
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Không có trường nào đc sửa");
            }
        
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
            string sql = "Select * from tblThuoc ";
            if (txtmaThuoc.Text != "")
                sql += "where  PK_iThuocID like '%" + txtmaThuoc.Text + "%'";
            else if (txtenthuoc.Text != "")
                sql += "where sTenThuoc like N'%" + txtenthuoc.Text + "%'";
           
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable db = new DataTable();
            ad.Fill(db);
           dsThuoc.DataSource = db;
            con.Close();
        }
        public void binding()
        {
           txtmaThuoc.DataBindings.Clear();
            txtmaThuoc.DataBindings.Add("text", dsThuoc.DataSource, "PK_iThuocID");
            txtenthuoc.DataBindings.Clear();
            txtenthuoc.DataBindings.Add("text", dsThuoc.DataSource, "sTenThuoc");
           txtgia.DataBindings.Clear();
            txtgia.DataBindings.Add("text", dsThuoc.DataSource, "fDonGia");
        }




    }
}
