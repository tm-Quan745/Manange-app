using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Tuan8bai1
{
    public partial class Form1 : Form
    {
        DMNVDataContext context = new DMNVDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Loaddata()
        {
            List<DanhMucNV> dmnv = context.DanhMucNVs.ToList();
            dgv_ThongTin.DataSource = dmnv;
            txt_HoTen.Text = "";
            dtp_NgaySinh.Value = DateTime.Now;
            txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
            cbb_BangCap.Text = "";
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Them.Enabled = false;
            txt_HoTen.Text = "";
            dtp_NgaySinh.Value = DateTime.Now;
            txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
            cbb_BangCap.Text = "";
            txt_HoTen.Focus();

        }

        private void dgv_ThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không bấm vào tiêu đề cột
            {
                DataGridViewRow row = dgv_ThongTin.Rows[e.RowIndex];

                txt_HoTen.Text = row.Cells["col_HoTen"].Value.ToString();
                txt_DiaChi.Text = row.Cells["col_DiaChi"].Value.ToString();
                txt_DienThoai.Text = row.Cells["col_DienThoai"].Value.ToString();
                cbb_BangCap.Text = row.Cells["col_BangCap"].Value.ToString();

                dtp_NgaySinh.Value = Convert.ToDateTime(row.Cells["col_NgaySinh"].Value);

                btn_Huy.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_HoTen.Text) ||
                    string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txt_DienThoai.Text) ||
                    string.IsNullOrWhiteSpace(cbb_BangCap.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo nhân viên mới
                DanhMucNV nv = new DanhMucNV();
                nv.MaNV = context.DanhMucNVs.Any() ? context.DanhMucNVs.Max(x => x.MaNV) + 1 : 1;
                nv.HoTen = txt_HoTen.Text;
                nv.NgaySinh = dtp_NgaySinh.Value;
                nv.DiaChi = txt_DiaChi.Text;
                nv.DienThoai = txt_DienThoai.Text;
                nv.BangCap = cbb_BangCap.Text;

                // Thêm vào database
                context.DanhMucNVs.InsertOnSubmit(nv);
                context.SubmitChanges();

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_HoTen.Text = "";
            dtp_NgaySinh.Value = DateTime.Now;
            txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
            cbb_BangCap.Text = "";
            Loaddata();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_ThongTin.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ma = dgv_ThongTin.CurrentRow.Cells["col_MaNV"].Value?.ToString();

            if (string.IsNullOrEmpty(ma) || !int.TryParse(ma, out int maNV))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            DanhMucNV nv = context.DanhMucNVs.FirstOrDefault(x => x.MaNV == maNV);

            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            context.DanhMucNVs.DeleteOnSubmit(nv);
            context.SubmitChanges();

            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Loaddata();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_ThongTin.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string ma = dgv_ThongTin.CurrentRow.Cells["col_MaNV"].Value?.ToString();

            if (string.IsNullOrEmpty(ma) || !int.TryParse(ma, out int maNV))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DanhMucNV nv = context.DanhMucNVs.FirstOrDefault(x => x.MaNV == maNV);

            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            nv.HoTen = txt_HoTen.Text;
            nv.NgaySinh = dtp_NgaySinh.Value;
            nv.DiaChi = txt_DiaChi.Text;
            nv.DienThoai = txt_DienThoai.Text;
            nv.BangCap = cbb_BangCap.Text;

            context.SubmitChanges();

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Loaddata();
        }
    }
}