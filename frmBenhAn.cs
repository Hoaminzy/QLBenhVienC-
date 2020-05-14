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
    public partial class frmBenhAn : Form
    {
        public frmBenhAn()
        {
            InitializeComponent();
          //  bindings();
        }

        private static frmBenhAn instance;
        public static frmBenhAn GetInstance()
        {
            if (instance == null)
                instance = new frmBenhAn();
            return instance;
        }

        string constr = "Data Source=HC;Initial Catalog=QLBenhNhan;Integrated Security=True";


        private void frmBenhAn_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string sqlSelect = "select * from tblBenhAn";
            con.Open();
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsBenhAn.DataSource = dt;
            con.Close();
        }
    /*    public void bindings()
        {
            txtmaBA.DataBindings.Clear();
            txtmaBA.DataBindings.Add("text", dsBenhAn.DataSource, "Mã Bênh Án");
            txtmaNV.DataBindings.Clear();
            txtmaNV.DataBindings.Add("text", dsBenhAn.DataSource, "Mã Nhân Viên");
            txtmaBN.DataBindings.Clear();
            txtmaBN.DataBindings.Add("text", dsBenhAn.DataSource, "Mã Bênh Nhân");
            txtTTBA.DataBindings.Clear();
            txtTTBA.DataBindings.Add("text", dsBenhAn.DataSource, "Thông Tin Bệnh Án");
            txtBHYT.DataBindings.Clear();
            txtBHYT.DataBindings.Add("text", dsBenhAn.DataSource, "Số BHYT");
            txtieusu.DataBindings.Clear();
            txtieusu.DataBindings.Add("text", dsBenhAn.DataSource, "Tiểu Sử");
            dtnhap.DataBindings.Clear();
            dtnhap.DataBindings.Add("text", dsBenhAn.DataSource, "Ngày Nhập Viện");
            dtxuat.DataBindings.Clear();
            dtxuat.DataBindings.Add("text", dsBenhAn.DataSource, "Ngày Xuất Viện");
        }*/

        private void dsBenhAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dsBenhAn.Rows[e.RowIndex];
            txtmaBA.Text = row.Cells[0].Value.ToString();
            txtmaBA.Enabled = true;
            txtmaNV.Text = row.Cells[1].Value.ToString();
            txtmaBN.Text = row.Cells[2].Value.ToString();
            txtTTBA.Text = row.Cells[3].Value.ToString();
            txtBHYT.Text = row.Cells[4].Value.ToString();
            txtieusu.Text = row.Cells[5].Value.ToString();
            dtnhap.Text = dsBenhAn.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtxuat.Text = dsBenhAn.Rows[e.RowIndex].Cells[7].Value.ToString();
        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsertBenhAn";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhAnID", txtmaBA.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iNhanVienID",txtmaNV.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhNhanID",txtmaBN.Text));
            cmd.Parameters.Add(new SqlParameter("@sTTBenhAn", txtTTBA.Text));
            cmd.Parameters.Add(new SqlParameter("@iSoTheBHYT", txtBHYT.Text));
            cmd.Parameters.Add(new SqlParameter("@sTieuSu", txtieusu.Text));     
            string d1 = dtnhap.Value.ToString("MM/dd/yyyy");
            string d2 = dtxuat.Value.ToString("MM/dd/yyyy");
            cmd.Parameters.Add(new SqlParameter("@dNgayvao", d1));
            cmd.Parameters.Add(new SqlParameter("@dNgayRa", d2));         
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            string sqlSelect1 = "Select PK_iBenhAnID from tblBenhAn where PK_iBenhAnID='" + txtmaBA.Text + "'";
            string sqlSelect2 = "Select PK_iNhanVienID from tblNhanVien where PK_iNhanVienID = '" + txtmaNV.Text + "'";
            string sqlSelect3 = "Select PK_iBenhNhanID from tblBenhNhan where PK_iBenhNhanID = '" + txtmaBN.Text + "'";
          //  string sqlSelect4 = "Select iSoTheBHYT tblBenhAn where iSoTheBHYT='" + txtBHYT.Text + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(sqlSelect1, con);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlSelect2, con);
            SqlDataAdapter da3 = new SqlDataAdapter(sqlSelect3, con);
           // SqlDataAdapter da4 = new SqlDataAdapter(sqlSelect4, con);
            da1.Fill(dt1);
            da2.Fill(dt2);
            da3.Fill(dt3);
           // da3.Fill(dt4);
            if (txtmaBA.Text != "" && txtmaNV.Text != "" && txtmaBN.Text != "" && txtBHYT.Text != "")
            {
                if (dt1.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Bệnh Án đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                        txtmaBA.Clear(); txtmaBA.Focus();
                }
                 
                else
                {
                    if (dt2.Rows.Count > 0 && dt3.Rows.Count > 0)
                    {
                        int nam = DateTime.Now.Year;
                        int thang = DateTime.Now.Month;
                        int ngay = DateTime.Now.Day;
                        int a = dtnhap.Value.Year;
                        int b = dtnhap.Value.Month;
                        int c = dtnhap.Value.Day;
                        int aa = dtxuat.Value.Year;
                        int bb = dtxuat.Value.Month; 
                        int cc = dtxuat.Value.Day;

                        if (bb > b)
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            frmBenhAn_Load(sender, e);
                            con.Close();
                        }
                        else if (bb == b)
                        {
                            if (cc >= c)
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                                frmBenhAn_Load(sender, e);
                                con.Close();
                            }
                            else
                            {
                                DialogResult loi = MessageBox.Show("Ngày đặt phải nhỏ hơn ngày hiện tại và ngày giao phải lớn hơn ngày đặt", "Lỗi", MessageBoxButtons.OK);
                                if (loi == DialogResult.OK)
                                {
                                    dtxuat.ResetText(); dtxuat.Focus();
                                    dtnhap.ResetText(); dtnhap.Focus();
                                }
                            }
                        }
                        else
                        {
                            DialogResult loi = MessageBox.Show("Ngày đặt phải nhỏ hơn ngày hiện tại và ngày giao phải lớn hơn ngày đặt", "Lỗi", MessageBoxButtons.OK);
                            if (loi == DialogResult.OK)
                            {
                                dtxuat.ResetText(); dtnhap.Focus();
                                dtnhap.ResetText(); dtnhap.Focus();
                            }
                        }
                    }
                 /*   else if (dt4.Rows.Count > 0)
                    {
                        DialogResult loi = MessageBox.Show("Số thẻ BHYT đã tồn tại!!! NHập lại", "Lỗi", MessageBoxButtons.OK);
                        if (loi == DialogResult.OK)
                            txtBHYT.Clear(); txtBHYT.Focus();
                    }
                    */
                    else
                    {
                        DialogResult loi = MessageBox.Show("Nhân viên hoặc Bệnh nhân không tồn tại", "Lỗi", MessageBoxButtons.OK);
                        if (loi == DialogResult.OK)
                        {
                            txtmaNV.Clear(); txtmaNV.Focus();
                            txtmaBN.Clear(); txtmaBN.Focus();
                        }
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
            txtmaBA.Clear(); txtmaBN.Clear(); txtmaNV.Clear(); txtTTBA.Clear(); txtieusu.Clear(); txtBHYT.Clear();
            dtnhap.ResetText(); dtxuat.ResetText();
            txtmaBA.Focus(); txtmaBA.Enabled = true;
            frmBenhAn_Load(sender, e);
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
            cmd.CommandText = "UpdateBenhAn";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhAnID", txtmaBA.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iNhanVienID", txtmaNV.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_iBenhNhanID", txtmaBN.Text));
            cmd.Parameters.Add(new SqlParameter("@sTTBenhAn", txtTTBA.Text));
            cmd.Parameters.Add(new SqlParameter("@iSoTheBHYT", txtBHYT.Text));
            cmd.Parameters.Add(new SqlParameter("@sTieuSu", txtieusu.Text));
            string d1 = dtnhap.Value.ToString("MM/dd/yyyy");
            string d2 = dtxuat.Value.ToString("MM/dd/yyyy");
            cmd.Parameters.Add(new SqlParameter("@dNgayvao", d1));
            cmd.Parameters.Add(new SqlParameter("@dNgayRa", d2));
            //DataTable dt1 = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
           // DataTable dt4 = new DataTable();
            string sqlSelect1 = "Select PK_iBenhAnID from tblBenhAn where PK_iBenhAnID='" + txtmaBA.Text + "'";
            string sqlSelect2 = "Select PK_iNhanVienID from tblNhanVien where PK_iNhanVienID = '" + txtmaNV.Text + "'";
            string sqlSelect3 = "Select PK_iBenhNhanID from tblBenhNhan where PK_iBenhNhanID = '" + txtmaBN.Text + "'";
            //  string sqlSelect4 = "Select iSoTheBHYT tblBenhAn where iSoTheBHYT='" + txtBHYT.Text + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(sqlSelect1, con);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlSelect2, con);
            SqlDataAdapter da3 = new SqlDataAdapter(sqlSelect3, con);
            // SqlDataAdapter da4 = new SqlDataAdapter(sqlSelect4, con);
            da1.Fill(dt1);
            da2.Fill(dt2);
            da3.Fill(dt3);
            if (dt2.Rows.Count > 0 && dt3.Rows.Count > 0 && dt1.Rows.Count > 0)
            {
                int nam = DateTime.Now.Year;
                int thang = DateTime.Now.Month;
                int ngay = DateTime.Now.Day;
                int a = dtnhap.Value.Year;
                int b = dtnhap.Value.Month;
                int c = dtnhap.Value.Day;
                int aa = dtxuat.Value.Year;
                int bb = dtxuat.Value.Month;
                int cc = dtxuat.Value.Day;

                if (bb > b)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    frmBenhAn_Load(sender, e);
                    con.Close();
                }
                else if (bb == b)
                {
                    if (cc >= c)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        frmBenhAn_Load(sender, e);
                        con.Close();
                    }
                    else
                    {
                        DialogResult loi = MessageBox.Show("Ngày đặt phải nhỏ hơn ngày giao", "Lỗi", MessageBoxButtons.OK);
                        if (loi == DialogResult.OK)
                        {
                            dtnhap.ResetText();
                            dtxuat.ResetText();
                        }
                    }
                }
                else
                {
                    DialogResult loi = MessageBox.Show("Ngày đặt phải nhỏ hơn ngày giao", "Lỗi", MessageBoxButtons.OK);
                    if (loi == DialogResult.OK)
                    {
                        dtnhap.ResetText();
                        dtxuat.ResetText();
                    }
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Nhân viên hoặc Bênh Nhân không tồn tại", "Lỗi", MessageBoxButtons.OK);
                if (loi == DialogResult.OK)
                {
                    txtmaNV.Clear();
                    txtmaBN.Clear();
                }
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            string sql = "Select * from tblBenhAn ";
            if (txtmaBA.Text != "")
                sql += "where PK_iBenhAnID like '%" + txtmaBA.Text + "%'";
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
            dsBenhAn.DataSource = db;
            con.Close();
        }

        private void dsBenhAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int numrow;
            numrow = e.RowIndex;
            txtmaBA.Text = dsBenhAn.Rows[numrow].Cells[0].Value.ToString();
            txtmaNV.Text = dsBenhAn.Rows[numrow].Cells[1].Value.ToString();
            txtmaBN.Text = dsBenhAn.Rows[numrow].Cells[2].Value.ToString();
            txtTTBA.Text = dsBenhAn.Rows[numrow].Cells[3].Value.ToString();
            txtBHYT.Text = dsBenhAn.Rows[numrow].Cells[4].Value.ToString();
            txtieusu.Text = dsBenhAn.Rows[numrow].Cells[5].Value.ToString();
            dtnhap.Text = dsBenhAn.Rows[numrow].Cells[6].Value.ToString();
            dtxuat.Text = dsBenhAn.Rows[numrow].Cells[7].Value.ToString();


        }

      /*  private void txtmaBA_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmaBA.Text))
            {
                e.Cancel = true;
                txtmaBA.Focus();

                errorProvider1.SetError(txtmaBA, "Hãy nhập đầy đủ thông tin!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtmaBA, string.Empty);
            }
        }*/

     /*   private void txtmaNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmaNV.Text))
            {
                e.Cancel = true;
                txtmaNV.Focus();

                errorProvider1.SetError(txtmaNV, "Hãy nhập đầy đủ thông tin!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtmaNV, string.Empty);
            }
        }
        */
   /*     private void txtmaBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmaBN.Text))
            {
                e.Cancel = true;
                txtmaBN.Focus();

                errorProvider1.SetError(txtmaBN, "Hãy nhập đầy đủ thông tin!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtmaBN, string.Empty);
            }
        }*/
    

    }
}
