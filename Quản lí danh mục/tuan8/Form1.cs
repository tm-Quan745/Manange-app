using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan8
{
    public partial class Form1 : Form
    {
        QLSPDataContext context = new QLSPDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        bool dautien = false;
        private void LoadData()
        {
            List<DanhMuc> dsdm = context.DanhMucs.ToList();
            lb_DM.DataSource = dsdm;
            lb_DM.ValueMember = "MaDM";
            lb_DM.DisplayMember = "TenDM";
            txt_MaDM.Text = "";
            txt_TenDM.Text = "";
            txt_MaDM.Focus();
            dautien = true;

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_MaDM.Text) || string.IsNullOrWhiteSpace(txt_TenDM.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DanhMuc dm = new DanhMuc();
                dm.MaDM = txt_MaDM.Text;
                dm.TenDM = txt_TenDM.Text;

                context.DanhMucs.InsertOnSubmit(dm);
                context.SubmitChanges();
                MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lb_DM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dautien || lb_DM.SelectedValue == null)
            {
                return;
            }

            // Lấy MaDM từ SelectedValue
            string maDM = lb_DM.SelectedValue.ToString();

            // Tìm đối tượng DanhMuc tương ứng
            DanhMuc dm = context.DanhMucs.FirstOrDefault(x => x.MaDM == maDM);

            if (dm != null)
            {
                txt_MaDM.Text = dm.MaDM;
                txt_TenDM.Text = dm.TenDM;
                txt_MaDM.ReadOnly = true;
                txt_TenDM.Focus();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(lb_DM.SelectedValue == null)
            {
                return;
            }
            try
            {
                string ma = txt_MaDM.Text;
                DanhMuc dm = context.DanhMucs.FirstOrDefault(x => x.MaDM == ma);
                dm.TenDM = txt_TenDM.Text;
                context.SubmitChanges();
                MessageBox.Show("Sửa danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lb_DM.SelectedValue == null)
            {
                return;
            }
            try
            {
                string ma = txt_MaDM.Text;
                DanhMuc dm = context.DanhMucs.FirstOrDefault(x => x.MaDM == ma);
                if (dm != null)
                {
                    context.DanhMucs.DeleteOnSubmit(dm);
                    context.SubmitChanges();
                    MessageBox.Show("Xoá danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy danh mục cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {


        }
    }

}
