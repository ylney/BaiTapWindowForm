namespace BaiTap03
{
    partial class frmBai2
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
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.grbCongViec = new System.Windows.Forms.GroupBox();
            this.rdbGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdbTinhTong = new System.Windows.Forms.RadioButton();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.grbCongViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQua.Location = new System.Drawing.Point(302, 293);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(13, 20);
            this.lblKetQua.TabIndex = 10;
            this.lblKetQua.Text = ".";
            // 
            // lblXemKQ
            // 
            this.lblXemKQ.AutoSize = true;
            this.lblXemKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemKQ.Location = new System.Drawing.Point(167, 293);
            this.lblXemKQ.Name = "lblXemKQ";
            this.lblXemKQ.Size = new System.Drawing.Size(89, 20);
            this.lblXemKQ.TabIndex = 9;
            this.lblXemKQ.Text = "Kết quả là:";
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Location = new System.Drawing.Point(170, 227);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(118, 30);
            this.btnXemKQ.TabIndex = 7;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // grbCongViec
            // 
            this.grbCongViec.Controls.Add(this.rdbGiaiThua);
            this.grbCongViec.Controls.Add(this.rdbTinhTong);
            this.grbCongViec.Location = new System.Drawing.Point(170, 88);
            this.grbCongViec.Name = "grbCongViec";
            this.grbCongViec.Size = new System.Drawing.Size(221, 111);
            this.grbCongViec.TabIndex = 8;
            this.grbCongViec.TabStop = false;
            this.grbCongViec.Text = "Chọn công việc:";
            // 
            // rdbGiaiThua
            // 
            this.rdbGiaiThua.AutoSize = true;
            this.rdbGiaiThua.Location = new System.Drawing.Point(30, 69);
            this.rdbGiaiThua.Name = "rdbGiaiThua";
            this.rdbGiaiThua.Size = new System.Drawing.Size(144, 20);
            this.rdbGiaiThua.TabIndex = 1;
            this.rdbGiaiThua.Text = "Tính N giai thừa (N!)";
            this.rdbGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdbTinhTong
            // 
            this.rdbTinhTong.AutoSize = true;
            this.rdbTinhTong.Checked = true;
            this.rdbTinhTong.Location = new System.Drawing.Point(30, 32);
            this.rdbTinhTong.Name = "rdbTinhTong";
            this.rdbTinhTong.Size = new System.Drawing.Size(140, 20);
            this.rdbTinhTong.TabIndex = 0;
            this.rdbTinhTong.TabStop = true;
            this.rdbTinhTong.Text = "Tính tổng 1+2+...+N";
            this.rdbTinhTong.UseVisualStyleBackColor = true;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(251, 34);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(164, 22);
            this.txtN.TabIndex = 6;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(35, 37);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(187, 16);
            this.lblN.TabIndex = 5;
            this.lblN.Text = "Nhập một số nguyên dương N:";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 358);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblXemKQ);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.grbCongViec);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.grbCongViec.ResumeLayout(false);
            this.grbCongViec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblXemKQ;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.GroupBox grbCongViec;
        private System.Windows.Forms.RadioButton rdbGiaiThua;
        private System.Windows.Forms.RadioButton rdbTinhTong;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblN;
    }
}