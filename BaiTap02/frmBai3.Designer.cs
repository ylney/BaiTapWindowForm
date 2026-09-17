namespace BaiTap02
{
    partial class frmBai3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGiaiThua = new System.Windows.Forms.Button();
            this.lblKetQuaGT = new System.Windows.Forms.Label();
            this.lblsoN = new System.Windows.Forms.Label();
            this.lblXemKQGT = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNoiChuoi = new System.Windows.Forms.Button();
            this.lblKetQuaChuoi = new System.Windows.Forms.Label();
            this.lblXemKq = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblHo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGiaiThua);
            this.groupBox2.Controls.Add(this.lblKetQuaGT);
            this.groupBox2.Controls.Add(this.lblsoN);
            this.groupBox2.Controls.Add(this.lblXemKQGT);
            this.groupBox2.Controls.Add(this.txtN);
            this.groupBox2.Location = new System.Drawing.Point(36, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính N giai thừa";
            // 
            // btnGiaiThua
            // 
            this.btnGiaiThua.Location = new System.Drawing.Point(179, 77);
            this.btnGiaiThua.Name = "btnGiaiThua";
            this.btnGiaiThua.Size = new System.Drawing.Size(127, 30);
            this.btnGiaiThua.TabIndex = 13;
            this.btnGiaiThua.Text = "Tính giai thừa";
            this.btnGiaiThua.UseVisualStyleBackColor = true;
            this.btnGiaiThua.Click += new System.EventHandler(this.btnGiaiThua_Click);
            // 
            // lblKetQuaGT
            // 
            this.lblKetQuaGT.AutoSize = true;
            this.lblKetQuaGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaGT.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQuaGT.Location = new System.Drawing.Point(136, 121);
            this.lblKetQuaGT.Name = "lblKetQuaGT";
            this.lblKetQuaGT.Size = new System.Drawing.Size(13, 20);
            this.lblKetQuaGT.TabIndex = 12;
            this.lblKetQuaGT.Text = ".";
            // 
            // lblsoN
            // 
            this.lblsoN.AutoSize = true;
            this.lblsoN.Location = new System.Drawing.Point(34, 39);
            this.lblsoN.Name = "lblsoN";
            this.lblsoN.Size = new System.Drawing.Size(125, 16);
            this.lblsoN.TabIndex = 7;
            this.lblsoN.Text = "Số nguyên dương n:";
            // 
            // lblXemKQGT
            // 
            this.lblXemKQGT.AutoSize = true;
            this.lblXemKQGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemKQGT.Location = new System.Drawing.Point(33, 121);
            this.lblXemKQGT.Name = "lblXemKQGT";
            this.lblXemKQGT.Size = new System.Drawing.Size(71, 20);
            this.lblXemKQGT.TabIndex = 11;
            this.lblXemKQGT.Text = "Kết quả:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(179, 36);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(152, 22);
            this.txtN.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNoiChuoi);
            this.groupBox1.Controls.Add(this.lblKetQuaChuoi);
            this.groupBox1.Controls.Add(this.lblXemKq);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Controls.Add(this.lblHo);
            this.groupBox1.Location = new System.Drawing.Point(36, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nối chuỗi họ tên";
            // 
            // btnNoiChuoi
            // 
            this.btnNoiChuoi.Location = new System.Drawing.Point(74, 113);
            this.btnNoiChuoi.Name = "btnNoiChuoi";
            this.btnNoiChuoi.Size = new System.Drawing.Size(86, 31);
            this.btnNoiChuoi.TabIndex = 6;
            this.btnNoiChuoi.Text = "Nối chuỗi";
            this.btnNoiChuoi.UseVisualStyleBackColor = true;
            this.btnNoiChuoi.Click += new System.EventHandler(this.btnNoiChuoi_Click);
            // 
            // lblKetQuaChuoi
            // 
            this.lblKetQuaChuoi.AutoSize = true;
            this.lblKetQuaChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaChuoi.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQuaChuoi.Location = new System.Drawing.Point(136, 161);
            this.lblKetQuaChuoi.Name = "lblKetQuaChuoi";
            this.lblKetQuaChuoi.Size = new System.Drawing.Size(13, 20);
            this.lblKetQuaChuoi.TabIndex = 5;
            this.lblKetQuaChuoi.Text = ".";
            // 
            // lblXemKq
            // 
            this.lblXemKq.AutoSize = true;
            this.lblXemKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemKq.Location = new System.Drawing.Point(33, 161);
            this.lblXemKq.Name = "lblXemKq";
            this.lblXemKq.Size = new System.Drawing.Size(71, 20);
            this.lblXemKq.TabIndex = 4;
            this.lblXemKq.Text = "Kết quả:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(74, 35);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(152, 22);
            this.txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(74, 75);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(152, 22);
            this.txtTen.TabIndex = 2;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(34, 78);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(34, 16);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên:";
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(34, 38);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(28, 16);
            this.lblHo.TabIndex = 0;
            this.lblHo.Text = "Họ:";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGiaiThua;
        private System.Windows.Forms.Label lblKetQuaGT;
        private System.Windows.Forms.Label lblsoN;
        private System.Windows.Forms.Label lblXemKQGT;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNoiChuoi;
        private System.Windows.Forms.Label lblKetQuaChuoi;
        private System.Windows.Forms.Label lblXemKq;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblHo;
    }
}