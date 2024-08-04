namespace Net
{
    partial class doimatkhau
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
            this.dmk_mkm = new System.Windows.Forms.TextBox();
            this.dmk_mkm_xn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sdt_dmk = new System.Windows.Forms.Label();
            this.mk_cu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dmk_mkm
            // 
            this.dmk_mkm.Location = new System.Drawing.Point(233, 138);
            this.dmk_mkm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dmk_mkm.Name = "dmk_mkm";
            this.dmk_mkm.Size = new System.Drawing.Size(296, 22);
            this.dmk_mkm.TabIndex = 1;
            // 
            // dmk_mkm_xn
            // 
            this.dmk_mkm_xn.Location = new System.Drawing.Point(233, 189);
            this.dmk_mkm_xn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dmk_mkm_xn.Name = "dmk_mkm_xn";
            this.dmk_mkm_xn.Size = new System.Drawing.Size(296, 22);
            this.dmk_mkm_xn.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(233, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "XÁC NHẬN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sdt_dmk
            // 
            this.sdt_dmk.AutoSize = true;
            this.sdt_dmk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt_dmk.Location = new System.Drawing.Point(140, 259);
            this.sdt_dmk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sdt_dmk.Name = "sdt_dmk";
            this.sdt_dmk.Size = new System.Drawing.Size(26, 20);
            this.sdt_dmk.TabIndex = 6;
            this.sdt_dmk.Text = "{?}";
            this.sdt_dmk.Visible = false;
            this.sdt_dmk.Click += new System.EventHandler(this.tk_Click);
            // 
            // mk_cu
            // 
            this.mk_cu.Location = new System.Drawing.Point(233, 97);
            this.mk_cu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mk_cu.Name = "mk_cu";
            this.mk_cu.Size = new System.Drawing.Size(296, 22);
            this.mk_cu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đổi Mật Khẩu";
            // 
            // doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mk_cu);
            this.Controls.Add(this.sdt_dmk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dmk_mkm_xn);
            this.Controls.Add(this.dmk_mkm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(707, 439);
            this.MinimumSize = new System.Drawing.Size(707, 439);
            this.Name = "doimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.doimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dmk_mkm;
        private System.Windows.Forms.TextBox dmk_mkm_xn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sdt_dmk;
        private System.Windows.Forms.TextBox mk_cu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}