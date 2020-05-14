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
    public partial class frmCTDichVu : Form
    {
        public frmCTDichVu()
        {
            InitializeComponent();
        }
      
        private static frmCTDichVu instance;
        public static frmCTDichVu GetInstance()
        {
            if (instance == null)
                instance = new frmCTDichVu();
            return instance;
        }
        string constr = "Data Source=HC;Initial Catalog=QLBenhNhan;Integrated Security=True";

        private void frmCTDichVu_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string sq = "select *from  tblThongTinChiTietDichvu";
            con.Open();
            SqlCommand cmd = new SqlCommand(sq, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsTTCTDV.DataSource = dt;
            con.Close();
        }

        private void dsTTCTDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dsTTCTDV.Rows[e.RowIndex];
            txtmaTTDV.Text = row.Cells[0].Value.ToString();
            txtmaTTDV.Enabled = true;
            txtmaBA.Text = row.Cells[1].Value.ToString();
            txtmaBN.Text = row.Cells[2].Value.ToString();
            txtmaDV.Text = row.Cells[3].Value.ToString();
            txtSL.Text = row.Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insertTTCTDV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iTTDichVuID", txtmaTTDV.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhNhanID", txtmaBN.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhAnID", txtmaBA.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iDichVuID", txtmaDV.Text));
            cmd.Parameters.Add(new SqlParameter("@iSoLuong", txtSL.Text));    
            DataTable dt = new DataTable();
            string sqlSelect = "Select PK_iTTDichVuID from tblThongTinChiTietDichVu where PK_iTTDichVuID='" +txtmaTTDV.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmaTTDV.Text != "" && @txtmaBN.Text != "" && txtmaBA.Text != "" && txtmaDV.Text != "" && txtSL.Text != "" )
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã Thông tin sịch vụ đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtmaTTDV.Clear(); txtmaTTDV.Focus();
                       // txtmaBA.Clear();
                        //txtmaDV.Clear();
                       
                }
                else
                {         
                        int solg = int.Parse(txtSL.Text);
                        
                            if (solg > 0)
                            {

                                con.Open();
                                cmd.ExecuteNonQuery();
                                DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                                frmCTDichVu_Load(sender, e);
                                con.Close();
                            }                         
                           else if(solg<0)
                          {
                              DialogResult loi = MessageBox.Show("Bạn phải nhập vào một số nguyên dương", "Lỗi", MessageBoxButtons.OK);
                             if (loi == DialogResult.OK)
                            txtSL.Clear();
                         }
                            else
                            {
                                DialogResult loi = MessageBox.Show("Phải nhập 1 số", "Lỗi", MessageBoxButtons.OK);
                                if (loi == DialogResult.OK)
                                    txtSL.Clear();
                            }
                }
            }
         
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtmaTTDV.Clear(); txtmaTTDV.Focus();
            txtmaDV.Clear(); txtmaBN.Clear(); txtmaBA.Clear();
            txtSL.Clear();
            frmCTDichVu_Load(sender, e);
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "updateTTCTDV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iTTDichVuID", txtmaTTDV.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhNhanID", txtmaBN.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhAnID", txtmaBA.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iDichVuID", txtmaDV.Text));
            cmd.Parameters.Add(new SqlParameter("@iSoLuong", txtSL.Text));  
            try
            {
                int solg = int.Parse(txtSL.Text);
                if (solg > 0)
                {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                            frmCTDichVu_Load(sender, e);
                            con.Close();
                
                }
                else
                {
                    DialogResult loi = MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtSL.Clear(); txtSL.Focus();
                }
            }
            catch (Exception)
            {
                DialogResult loi = MessageBox.Show("Bạn phải nhập vào một số nguyên dương", "Lỗi", MessageBoxButtons.OK);
                if (loi == DialogResult.OK)
                    txtSL.Clear(); txtSL.Focus();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblThongTinChiTietDichVu ";
            if (txtmaTTDV.Text != "")
                sql += "where  PK_iTTDichVuID like '%" + txtmaTTDV.Text + "%'";
          
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable db = new DataTable();
            ad.Fill(db);
            dsTTCTDV.DataSource = db;
            con.Close();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            frmDSDV dv = new frmDSDV();
            dv.ShowDialog();
        }

        private void dsTTCTDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtmaTTDV.Text = dsTTCTDV.Rows[numrow].Cells[0].Value.ToString();
            txtmaBA.Text = dsTTCTDV.Rows[numrow].Cells[1].Value.ToString();
            txtmaBN.Text = dsTTCTDV.Rows[numrow].Cells[2].Value.ToString();
            txtmaDV.Text = dsTTCTDV.Rows[numrow].Cells[3].Value.ToString();
            txtSL.Text = dsTTCTDV.Rows[numrow].Cells[4].Value.ToString();
        }


    }
}
