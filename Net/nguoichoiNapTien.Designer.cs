namespace Net
{
    partial class nguoichoiNapTien
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
            this.components = new System.ComponentModel.Container();
            this.giothue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sogioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtoanTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netDataSet9 = new Net.NetDataSet9();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.thanhtoanTKTableAdapter = new Net.NetDataSet9TableAdapters.thanhtoanTKTableAdapter();
            this.tkNC = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhtoanTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // giothue
            // 
            this.giothue.Location = new System.Drawing.Point(93, 57);
            this.giothue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.giothue.Name = "giothue";
            this.giothue.Size = new System.Drawing.Size(129, 22);
            this.giothue.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hd,
            this.sogioDataGridViewTextBoxColumn,
            this.tongtienDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn,
            this.taikhoanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thanhtoanTKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(699, 138);
            this.dataGridView1.TabIndex = 1;
            // 
            // hd
            // 
            this.hd.DataPropertyName = "HDTK";
            this.hd.HeaderText = "HDTK";
            this.hd.MinimumWidth = 10;
            this.hd.Name = "hd";
            this.hd.Visible = false;
            this.hd.Width = 200;
            // 
            // sogioDataGridViewTextBoxColumn
            // 
            this.sogioDataGridViewTextBoxColumn.DataPropertyName = "sogio";
            this.sogioDataGridViewTextBoxColumn.HeaderText = "Giờ thuê";
            this.sogioDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sogioDataGridViewTextBoxColumn.Name = "sogioDataGridViewTextBoxColumn";
            this.sogioDataGridViewTextBoxColumn.Width = 200;
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            this.tongtienDataGridViewTextBoxColumn.DataPropertyName = "tongtien";
            this.tongtienDataGridViewTextBoxColumn.HeaderText = "Tổng";
            this.tongtienDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            this.tongtienDataGridViewTextBoxColumn.Width = 200;
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngày đặt";
            this.ngayDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            this.ngayDataGridViewTextBoxColumn.Width = 200;
            // 
            // trangthaiDataGridViewTextBoxColumn
            // 
            this.trangthaiDataGridViewTextBoxColumn.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn.HeaderText = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.trangthaiDataGridViewTextBoxColumn.Name = "trangthaiDataGridViewTextBoxColumn";
            this.trangthaiDataGridViewTextBoxColumn.Visible = false;
            this.trangthaiDataGridViewTextBoxColumn.Width = 200;
            // 
            // taikhoanDataGridViewTextBoxColumn
            // 
            this.taikhoanDataGridViewTextBoxColumn.DataPropertyName = "taikhoan";
            this.taikhoanDataGridViewTextBoxColumn.HeaderText = "taikhoan";
            this.taikhoanDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.taikhoanDataGridViewTextBoxColumn.Name = "taikhoanDataGridViewTextBoxColumn";
            this.taikhoanDataGridViewTextBoxColumn.Visible = false;
            this.taikhoanDataGridViewTextBoxColumn.Width = 200;
            // 
            // thanhtoanTKBindingSource
            // 
            this.thanhtoanTKBindingSource.DataMember = "thanhtoanTK";
            this.thanhtoanTKBindingSource.DataSource = this.netDataSet9;
            // 
            // netDataSet9
            // 
            this.netDataSet9.DataSetName = "NetDataSet9";
            this.netDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(615, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giờ thuê";
            // 
            // thanhtoanTKTableAdapter
            // 
            this.thanhtoanTKTableAdapter.ClearBeforeFill = true;
            // 
            // tkNC
            // 
            this.tkNC.Location = new System.Drawing.Point(317, 57);
            this.tkNC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tkNC.Name = "tkNC";
            this.tkNC.Size = new System.Drawing.Size(129, 22);
            this.tkNC.TabIndex = 4;
            this.tkNC.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(493, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Người Chơi Nạp Tiền";
            // 
            // nguoichoiNapTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(748, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tkNC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.giothue);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 308);
            this.MinimumSize = new System.Drawing.Size(766, 308);
            this.Name = "nguoichoiNapTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nguoichoiNapTien";
            this.Load += new System.EventHandler(this.nguoichoiNapTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhtoanTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox giothue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private NetDataSet9 netDataSet9;
        private System.Windows.Forms.BindingSource thanhtoanTKBindingSource;
        private NetDataSet9TableAdapters.thanhtoanTKTableAdapter thanhtoanTKTableAdapter;
        private System.Windows.Forms.TextBox tkNC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}