namespace Net
{
    partial class themNguoiChoi
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
            this.tenKH = new System.Windows.Forms.TextBox();
            this.emailKH = new System.Windows.Forms.TextBox();
            this.sdtKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.themNV = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tenKH
            // 
            this.tenKH.Location = new System.Drawing.Point(150, 126);
            this.tenKH.Margin = new System.Windows.Forms.Padding(2);
            this.tenKH.Name = "tenKH";
            this.tenKH.Size = new System.Drawing.Size(199, 22);
            this.tenKH.TabIndex = 54;
            // 
            // emailKH
            // 
            this.emailKH.Location = new System.Drawing.Point(150, 168);
            this.emailKH.Margin = new System.Windows.Forms.Padding(2);
            this.emailKH.Name = "emailKH";
            this.emailKH.Size = new System.Drawing.Size(199, 22);
            this.emailKH.TabIndex = 53;
            // 
            // sdtKH
            // 
            this.sdtKH.Location = new System.Drawing.Point(150, 84);
            this.sdtKH.Margin = new System.Windows.Forms.Padding(2);
            this.sdtKH.Name = "sdtKH";
            this.sdtKH.Size = new System.Drawing.Size(199, 22);
            this.sdtKH.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Số điện thoại:";
            // 
            // themNV
            // 
            this.themNV.BackColor = System.Drawing.Color.ForestGreen;
            this.themNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themNV.ForeColor = System.Drawing.Color.White;
            this.themNV.Location = new System.Drawing.Point(118, 223);
            this.themNV.Margin = new System.Windows.Forms.Padding(2);
            this.themNV.Name = "themNV";
            this.themNV.Size = new System.Drawing.Size(152, 48);
            this.themNV.TabIndex = 55;
            this.themNV.Text = "THÊM";
            this.themNV.UseVisualStyleBackColor = false;
            this.themNV.Click += new System.EventHandler(this.themNV_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(184, 289);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(24, 16);
            this.id.TabIndex = 56;
            this.id.Text = "{?}";
            this.id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 38);
            this.label1.TabIndex = 57;
            this.label1.Text = "Thêm Người Chơi";
            // 
            // themNguoiChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.themNV);
            this.Controls.Add(this.tenKH);
            this.Controls.Add(this.emailKH);
            this.Controls.Add(this.sdtKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 384);
            this.MinimumSize = new System.Drawing.Size(420, 384);
            this.Name = "themNguoiChoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themNguoiChoi";
            this.Load += new System.EventHandler(this.themNguoiChoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tenKH;
        private System.Windows.Forms.TextBox emailKH;
        private System.Windows.Forms.TextBox sdtKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button themNV;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
    }
}