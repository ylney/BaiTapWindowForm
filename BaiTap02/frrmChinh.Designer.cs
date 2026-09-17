namespace BaiTap02
{
    partial class frrmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frrmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bàiKiểmTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiKiểmTraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bàiKiểmTraToolStripMenuItem
            // 
            this.bàiKiểmTraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBai1,
            this.tsmBai2,
            this.tsmBai3});
            this.bàiKiểmTraToolStripMenuItem.Name = "bàiKiểmTraToolStripMenuItem";
            this.bàiKiểmTraToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.bàiKiểmTraToolStripMenuItem.Text = "Bài kiểm tra";
            // 
            // tsmBai1
            // 
            this.tsmBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsmBai1.Image")));
            this.tsmBai1.Name = "tsmBai1";
            this.tsmBai1.Size = new System.Drawing.Size(224, 26);
            this.tsmBai1.Text = "Bài số 1";
            this.tsmBai1.Click += new System.EventHandler(this.tsmBai1_Click);
            // 
            // tsmBai2
            // 
            this.tsmBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsmBai2.Image")));
            this.tsmBai2.Name = "tsmBai2";
            this.tsmBai2.Size = new System.Drawing.Size(224, 26);
            this.tsmBai2.Text = "Bài số 2";
            this.tsmBai2.Click += new System.EventHandler(this.tsmBai2_Click);
            // 
            // tsmBai3
            // 
            this.tsmBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsmBai3.Image")));
            this.tsmBai3.Name = "tsmBai3";
            this.tsmBai3.Size = new System.Drawing.Size(224, 26);
            this.tsmBai3.Text = "Bài số 3";
            this.tsmBai3.Click += new System.EventHandler(this.tsmBai3_Click);
            // 
            // frrmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 173);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frrmChinh";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bàiKiểmTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBai1;
        private System.Windows.Forms.ToolStripMenuItem tsmBai2;
        private System.Windows.Forms.ToolStripMenuItem tsmBai3;
    }
}

