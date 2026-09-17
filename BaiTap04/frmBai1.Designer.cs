namespace BaiTap04
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
            this.lblXemKQ = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblNgaySX = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQua.Location = new System.Drawing.Point(356, 283);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(448, 112);
            this.lblKetQua.TabIndex = 21;
            this.lblKetQua.Text = ".";
            // 
            // lblXemKQ
            // 
            this.lblXemKQ.AutoSize = true;
            this.lblXemKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemKQ.Location = new System.Drawing.Point(147, 283);
            this.lblXemKQ.Name = "lblXemKQ";
            this.lblXemKQ.Size = new System.Drawing.Size(179, 20);
            this.lblXemKQ.TabIndex = 20;
            this.lblXemKQ.Text = "Thông tin sản phẩm là:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(151, 208);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(106, 33);
            this.btnHienThi.TabIndex = 19;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.Location = new System.Drawing.Point(151, 160);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(254, 22);
            this.dtpNgaySX.TabIndex = 18;
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(151, 118);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(254, 22);
            this.txtLoaiSP.TabIndex = 17;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(151, 77);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(254, 22);
            this.txtTenSP.TabIndex = 16;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(151, 41);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(254, 22);
            this.txtMaSP.TabIndex = 15;
            // 
            // lblNgaySX
            // 
            this.lblNgaySX.AutoSize = true;
            this.lblNgaySX.Location = new System.Drawing.Point(27, 165);
            this.lblNgaySX.Name = "lblNgaySX";
            this.lblNgaySX.Size = new System.Drawing.Size(95, 16);
            this.lblNgaySX.TabIndex = 14;
            this.lblNgaySX.Text = "Ngày sản xuất:";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Location = new System.Drawing.Point(27, 121);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(98, 16);
            this.lblLoaiSP.TabIndex = 13;
            this.lblLoaiSP.Text = "Loại sản phẩm:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(27, 80);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(96, 16);
            this.lblTenSP.TabIndex = 12;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(27, 41);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(91, 16);
            this.lblMaSP.TabIndex = 11;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 437);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblXemKQ);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.dtpNgaySX);
            this.Controls.Add(this.txtLoaiSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblNgaySX);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblXemKQ;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblNgaySX;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
    }
}