namespace BaiTap04
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
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.txtDiemTH = new System.Windows.Forms.TextBox();
            this.txtDiemLT = new System.Windows.Forms.TextBox();
            this.lblNhapDiemTH = new System.Windows.Forms.Label();
            this.lblNhapDiemLT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQua.Location = new System.Drawing.Point(365, 195);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(13, 20);
            this.lblKetQua.TabIndex = 13;
            this.lblKetQua.Text = ".";
            // 
            // lblXemKQ
            // 
            this.lblXemKQ.AutoSize = true;
            this.lblXemKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemKQ.Location = new System.Drawing.Point(204, 195);
            this.lblXemKQ.Name = "lblXemKQ";
            this.lblXemKQ.Size = new System.Drawing.Size(129, 20);
            this.lblXemKQ.TabIndex = 12;
            this.lblXemKQ.Text = "Kết quả xét loại:";
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Location = new System.Drawing.Point(207, 129);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(89, 32);
            this.btnXepLoai.TabIndex = 11;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // txtDiemTH
            // 
            this.txtDiemTH.Location = new System.Drawing.Point(207, 83);
            this.txtDiemTH.Name = "txtDiemTH";
            this.txtDiemTH.Size = new System.Drawing.Size(225, 22);
            this.txtDiemTH.TabIndex = 10;
            // 
            // txtDiemLT
            // 
            this.txtDiemLT.Location = new System.Drawing.Point(207, 36);
            this.txtDiemLT.Name = "txtDiemLT";
            this.txtDiemLT.Size = new System.Drawing.Size(225, 22);
            this.txtDiemLT.TabIndex = 9;
            // 
            // lblNhapDiemTH
            // 
            this.lblNhapDiemTH.AutoSize = true;
            this.lblNhapDiemTH.Location = new System.Drawing.Point(47, 86);
            this.lblNhapDiemTH.Name = "lblNhapDiemTH";
            this.lblNhapDiemTH.Size = new System.Drawing.Size(135, 16);
            this.lblNhapDiemTH.TabIndex = 8;
            this.lblNhapDiemTH.Text = "Nhập điểm thực hành:";
            // 
            // lblNhapDiemLT
            // 
            this.lblNhapDiemLT.AutoSize = true;
            this.lblNhapDiemLT.Location = new System.Drawing.Point(47, 39);
            this.lblNhapDiemLT.Name = "lblNhapDiemLT";
            this.lblNhapDiemLT.Size = new System.Drawing.Size(127, 16);
            this.lblNhapDiemLT.TabIndex = 7;
            this.lblNhapDiemLT.Text = "Nhập điểm lý thuyết:";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 249);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblXemKQ);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.txtDiemTH);
            this.Controls.Add(this.txtDiemLT);
            this.Controls.Add(this.lblNhapDiemTH);
            this.Controls.Add(this.lblNhapDiemLT);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblXemKQ;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.TextBox txtDiemTH;
        private System.Windows.Forms.TextBox txtDiemLT;
        private System.Windows.Forms.Label lblNhapDiemTH;
        private System.Windows.Forms.Label lblNhapDiemLT;
    }
}