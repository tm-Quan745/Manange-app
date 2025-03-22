namespace Bai1Tuan6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaPB = new System.Windows.Forms.TextBox();
            this.txt_TenPB = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.rtx_MoTa = new System.Windows.Forms.RichTextBox();
            this.dgr_PhongBan = new System.Windows.Forms.DataGridView();
            this.col_MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_PhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng Ban:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phòng Ban:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // txt_MaPB
            // 
            this.txt_MaPB.Location = new System.Drawing.Point(183, 89);
            this.txt_MaPB.Name = "txt_MaPB";
            this.txt_MaPB.Size = new System.Drawing.Size(230, 22);
            this.txt_MaPB.TabIndex = 3;
            // 
            // txt_TenPB
            // 
            this.txt_TenPB.Location = new System.Drawing.Point(183, 139);
            this.txt_TenPB.Name = "txt_TenPB";
            this.txt_TenPB.Size = new System.Drawing.Size(230, 22);
            this.txt_TenPB.TabIndex = 4;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(547, 37);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(93, 28);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(547, 105);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(93, 28);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(547, 146);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(93, 28);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(547, 215);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(93, 28);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(547, 249);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(93, 28);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(183, 37);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(324, 22);
            this.txt_TimKiem.TabIndex = 10;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // rtx_MoTa
            // 
            this.rtx_MoTa.Location = new System.Drawing.Point(183, 202);
            this.rtx_MoTa.Name = "rtx_MoTa";
            this.rtx_MoTa.Size = new System.Drawing.Size(324, 84);
            this.rtx_MoTa.TabIndex = 11;
            this.rtx_MoTa.Text = "";
            // 
            // dgr_PhongBan
            // 
            this.dgr_PhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_PhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaPhong,
            this.col_TenPhong,
            this.col_MoTa});
            this.dgr_PhongBan.Location = new System.Drawing.Point(31, 314);
            this.dgr_PhongBan.Name = "dgr_PhongBan";
            this.dgr_PhongBan.RowHeadersWidth = 51;
            this.dgr_PhongBan.RowTemplate.Height = 24;
            this.dgr_PhongBan.Size = new System.Drawing.Size(681, 150);
            this.dgr_PhongBan.TabIndex = 12;
            this.dgr_PhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_PhongBan_CellContentClick);
            // 
            // col_MaPhong
            // 
            this.col_MaPhong.DataPropertyName = "MaPB";
            this.col_MaPhong.HeaderText = "Mã phòng";
            this.col_MaPhong.MinimumWidth = 6;
            this.col_MaPhong.Name = "col_MaPhong";
            this.col_MaPhong.Width = 125;
            // 
            // col_TenPhong
            // 
            this.col_TenPhong.DataPropertyName = "TenPB";
            this.col_TenPhong.HeaderText = "Tên phòng";
            this.col_TenPhong.MinimumWidth = 6;
            this.col_TenPhong.Name = "col_TenPhong";
            this.col_TenPhong.Width = 125;
            // 
            // col_MoTa
            // 
            this.col_MoTa.DataPropertyName = "MoTa";
            this.col_MoTa.HeaderText = "Mô tả";
            this.col_MoTa.MinimumWidth = 6;
            this.col_MoTa.Name = "col_MoTa";
            this.col_MoTa.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 487);
            this.Controls.Add(this.dgr_PhongBan);
            this.Controls.Add(this.rtx_MoTa);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TenPB);
            this.Controls.Add(this.txt_MaPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_PhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaPB;
        private System.Windows.Forms.TextBox txt_TenPB;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.RichTextBox rtx_MoTa;
        private System.Windows.Forms.DataGridView dgr_PhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MoTa;
    }
}

