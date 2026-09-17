namespace BaiTap03
{
    partial class frmBai1
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
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblXemKetQua = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQua.Location = new System.Drawing.Point(254, 343);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(365, 118);
            this.lblKetQua.TabIndex = 25;
            this.lblKetQua.Text = ".";
            // 
            // lblXemKetQua
            // 
            this.lblXemKetQua.AutoSize = true;
            this.lblXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemKetQua.Location = new System.Drawing.Point(45, 343);
            this.lblXemKetQua.Name = "lblXemKetQua";
            this.lblXemKetQua.Size = new System.Drawing.Size(177, 20);
            this.lblXemKetQua.TabIndex = 24;
            this.lblXemKetQua.Text = "Thông tin nhân viên là:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(258, 260);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(143, 35);
            this.btnHienThi.TabIndex = 23;
            this.btnHienThi.Text = "Hiển thị thông tin";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(258, 118);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(257, 22);
            this.dtpNgaySinh.TabIndex = 22;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(258, 31);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(257, 22);
            this.txtMaNV.TabIndex = 21;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(258, 73);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(257, 22);
            this.txtHoTen.TabIndex = 20;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(258, 164);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(257, 22);
            this.txtLuong.TabIndex = 19;
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(258, 211);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(257, 22);
            this.txtPhuCap.TabIndex = 18;
            // 
            // lblPhuCap
            // 
            this.lblPhuCap.AutoSize = true;
            this.lblPhuCap.Location = new System.Drawing.Point(139, 214);
            this.lblPhuCap.Name = "lblPhuCap";
            this.lblPhuCap.Size = new System.Drawing.Size(97, 16);
            this.lblPhuCap.TabIndex = 17;
            this.lblPhuCap.Text = "Hệ số phụ cấp:";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(139, 167);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(82, 16);
            this.lblLuong.TabIndex = 16;
            this.lblLuong.Text = "Hệ số lương:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(139, 123);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 15;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(139, 76);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 14;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(139, 34);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(89, 16);
            this.lblMaNV.TabIndex = 13;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 502);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblXemKetQua);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtPhuCap);
            this.Controls.Add(this.lblPhuCap);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaNV);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblXemKetQua;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaNV;
    }
}