namespace Net
{
    partial class themKho
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
            this.them_ten = new System.Windows.Forms.TextBox();
            this.them_sl = new System.Windows.Forms.TextBox();
            this.them_dongia = new System.Windows.Forms.TextBox();
            this.them_ghichu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.them_hansudung = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // them_ten
            // 
            this.them_ten.Location = new System.Drawing.Point(122, 76);
            this.them_ten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.them_ten.Name = "them_ten";
            this.them_ten.Size = new System.Drawing.Size(192, 22);
            this.them_ten.TabIndex = 0;
            // 
            // them_sl
            // 
            this.them_sl.Location = new System.Drawing.Point(122, 126);
            this.them_sl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.them_sl.Name = "them_sl";
            this.them_sl.Size = new System.Drawing.Size(192, 22);
            this.them_sl.TabIndex = 3;
            this.them_sl.TextChanged += new System.EventHandler(this.them_sl_TextChanged);
            // 
            // them_dongia
            // 
            this.them_dongia.Location = new System.Drawing.Point(122, 174);
            this.them_dongia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.them_dongia.Name = "them_dongia";
            this.them_dongia.Size = new System.Drawing.Size(192, 22);
            this.them_dongia.TabIndex = 4;
            // 
            // them_ghichu
            // 
            this.them_ghichu.Location = new System.Drawing.Point(122, 262);
            this.them_ghichu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.them_ghichu.Name = "them_ghichu";
            this.them_ghichu.Size = new System.Drawing.Size(192, 22);
            this.them_ghichu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hạn sử dụng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ghi chú:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(122, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "XONG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // them_hansudung
            // 
            this.them_hansudung.CustomFormat = "dd-MM-yyyy";
            this.them_hansudung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.them_hansudung.Location = new System.Drawing.Point(122, 219);
            this.them_hansudung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.them_hansudung.Name = "them_hansudung";
            this.them_hansudung.Size = new System.Drawing.Size(192, 22);
            this.them_hansudung.TabIndex = 13;
            this.them_hansudung.ValueChanged += new System.EventHandler(this.tk_hansudung_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "Thêm Kho";
            // 
            // themKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 365);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.them_hansudung);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.them_ghichu);
            this.Controls.Add(this.them_dongia);
            this.Controls.Add(this.them_sl);
            this.Controls.Add(this.them_ten);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 412);
            this.MinimumSize = new System.Drawing.Size(426, 412);
            this.Name = "themKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themKho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox them_ten;
        private System.Windows.Forms.TextBox them_sl;
        private System.Windows.Forms.TextBox them_dongia;
        private System.Windows.Forms.TextBox them_ghichu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker them_hansudung;
        private System.Windows.Forms.Label label6;
    }
}