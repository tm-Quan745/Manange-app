using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1Tuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        KetNoiDuLieu kn = new KetNoiDuLieu();

        public void LoadData()
        {
            string sql = "SELECT * FROM PhongBan";
            dgr_PhongBan.DataSource = kn.TaoBang(sql);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kn.MyConnect();
            txt_MaPB.ResetText();
            txt_TenPB.ResetText();
            rtx_MoTa.ResetText();
            LoadData();
        }

        private void dgr_PhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgr_PhongBan.DataSource;
            chiso = dgr_PhongBan.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];

            txt_MaPB.Text = hang["MaPB"].ToString().Trim();
            txt_TenPB.Text = hang["TenPB"].ToString().Trim();
            rtx_MoTa.Text = hang["MoTa"].ToString().Trim();
            LoadData();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            kn.MyDisconnect();
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string s = "SELECT * FROM PhongBan where MaPB='" + txt_MaPB.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.TaoBang(s);
            if (dt.Rows.Count == 0)
            {
                kn.them(txt_MaPB.Text,txt_TenPB.Text,rtx_MoTa.Text);
                txt_MaPB.Focus();
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Mã số sinh viên đã có, vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txt_MaPB.ResetText();
            txt_TenPB.ResetText();
            rtx_MoTa.ResetText();
            txt_MaPB.Focus();
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string s = "SELECT * FROM PhongBan where MaPB='" + txt_MaPB.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.TaoBang(s);
            if (dt.Rows.Count != 0)
            {
                kn.sua(txt_MaPB.Text, txt_TenPB.Text, rtx_MoTa.Text);
                MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaPB.ResetText();
                txt_TenPB.ResetText();
                rtx_MoTa.ResetText();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string s = "SELECT * FROM PhongBan where MaPB='" + txt_MaPB.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.TaoBang(s);
            if (dt.Rows.Count != 0)
            {
                kn.xoa(txt_MaPB.Text, txt_TenPB.Text, rtx_MoTa.Text);
                MessageBox.Show("Xoá thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaPB.ResetText();
                txt_TenPB.ResetText();
                rtx_MoTa.ResetText();

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PhongBan WHERE TenPB = @TenPB"; // Use parameter instead of direct concatenation
            dgr_PhongBan.DataSource = kn.TimKiemPhongBan(sql, txt_TimKiem.Text);
        }
        
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
public class KetNoiDuLieu
{
    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Quanlinhanvien;Integrated Security=True;TrustServerCertificate=True");
    public void MyConnect()
    {
        conn.Open();
    }
    public void MyDisconnect()
    {
        conn.Close();
    }
    public DataTable TaoBang(string sql)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter ds = new SqlDataAdapter(sql, conn);
        ds.Fill(dt);
        return dt;

    }
    public void them(string maPB, string tenPB, string moTa)
    {
        string sql = "INSERT INTO PhongBan(MaPB,TenPB,MoTa)" +
            "values('" + maPB + "',N'" + tenPB + "',N'" + moTa + "')";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }
    public void sua(string maPB, string tenPB, string moTa)
    {
        string sql = "UPDATE PhongBan SET TenPB=N'" + tenPB + "',MoTa=N'" + moTa + "' WHERE MaPB='" + maPB + "'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }
    public void xoa(string maPB, string tenPB, string moTa)
    {
        string sql = "DELETE FROM PhongBan WHERE MaPB ='" + maPB + "'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }
    public DataTable TimKiemPhongBan(string sql, string tenPB)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TenPB", tenPB);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }
}


   