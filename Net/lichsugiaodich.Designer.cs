namespace Net
{
    partial class lichsugiaodich
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hDTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sogioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtoanTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netDataSet12 = new Net.NetDataSet12();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hDMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtoanMABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netDataSet13 = new Net.NetDataSet13();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.Label();
            this.thanhtoanTKTableAdapter = new Net.NetDataSet12TableAdapters.thanhtoanTKTableAdapter();
            this.thanhtoanMATableAdapter = new Net.NetDataSet13TableAdapters.thanhtoanMATableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhtoanTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhtoanMABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hDTKDataGridViewTextBoxColumn,
            this.sogioDataGridViewTextBoxColumn,
            this.tongtienDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn,
            this.taikhoanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thanhtoanTKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(887, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // hDTKDataGridViewTextBoxColumn
            // 
            this.hDTKDataGridViewTextBoxColumn.DataPropertyName = "HDTK";
            this.hDTKDataGridViewTextBoxColumn.HeaderText = "ID";
            this.hDTKDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.hDTKDataGridViewTextBoxColumn.Name = "hDTKDataGridViewTextBoxColumn";
            this.hDTKDataGridViewTextBoxColumn.Width = 200;
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
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngày thanh toán";
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
            this.thanhtoanTKBindingSource.DataSource = this.netDataSet12;
            // 
            // netDataSet12
            // 
            this.netDataSet12.DataSetName = "NetDataSet12";
            this.netDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hDMADataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.tongtienDataGridViewTextBoxColumn1,
            this.ngayDataGridViewTextBoxColumn1,
            this.trangthaiDataGridViewTextBoxColumn1,
            this.taikhoanDataGridViewTextBoxColumn1,
            this.ghichuDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.thanhtoanMABindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 408);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(887, 254);
            this.dataGridView2.TabIndex = 1;
            // 
            // hDMADataGridViewTextBoxColumn
            // 
            this.hDMADataGridViewTextBoxColumn.DataPropertyName = "HDMA";
            this.hDMADataGridViewTextBoxColumn.HeaderText = "ID";
            this.hDMADataGridViewTextBoxColumn.MinimumWidth = 10;
            this.hDMADataGridViewTextBoxColumn.Name = "hDMADataGridViewTextBoxColumn";
            this.hDMADataGridViewTextBoxColumn.Width = 200;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Món";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 200;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soluongDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.Visible = false;
            this.soluongDataGridViewTextBoxColumn.Width = 200;
            // 
            // tongtienDataGridViewTextBoxColumn1
            // 
            this.tongtienDataGridViewTextBoxColumn1.DataPropertyName = "tongtien";
            this.tongtienDataGridViewTextBoxColumn1.HeaderText = "Tổng";
            this.tongtienDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.tongtienDataGridViewTextBoxColumn1.Name = "tongtienDataGridViewTextBoxColumn1";
            this.tongtienDataGridViewTextBoxColumn1.Width = 200;
            // 
            // ngayDataGridViewTextBoxColumn1
            // 
            this.ngayDataGridViewTextBoxColumn1.DataPropertyName = "ngay";
            this.ngayDataGridViewTextBoxColumn1.HeaderText = "Ngày thanh toán";
            this.ngayDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.ngayDataGridViewTextBoxColumn1.Name = "ngayDataGridViewTextBoxColumn1";
            this.ngayDataGridViewTextBoxColumn1.Width = 200;
            // 
            // trangthaiDataGridViewTextBoxColumn1
            // 
            this.trangthaiDataGridViewTextBoxColumn1.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn1.HeaderText = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.trangthaiDataGridViewTextBoxColumn1.Name = "trangthaiDataGridViewTextBoxColumn1";
            this.trangthaiDataGridViewTextBoxColumn1.Visible = false;
            this.trangthaiDataGridViewTextBoxColumn1.Width = 200;
            // 
            // taikhoanDataGridViewTextBoxColumn1
            // 
            this.taikhoanDataGridViewTextBoxColumn1.DataPropertyName = "taikhoan";
            this.taikhoanDataGridViewTextBoxColumn1.HeaderText = "taikhoan";
            this.taikhoanDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.taikhoanDataGridViewTextBoxColumn1.Name = "taikhoanDataGridViewTextBoxColumn1";
            this.taikhoanDataGridViewTextBoxColumn1.Visible = false;
            this.taikhoanDataGridViewTextBoxColumn1.Width = 200;
            // 
            // ghichuDataGridViewTextBoxColumn
            // 
            this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "ghichu";
            this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghichuDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
            this.ghichuDataGridViewTextBoxColumn.Width = 200;
            // 
            // thanhtoanMABindingSource
            // 
            this.thanhtoanMABindingSource.DataMember = "thanhtoanMA";
            this.thanhtoanMABindingSource.DataSource = this.netDataSet13;
            // 
            // netDataSet13
            // 
            this.netDataSet13.DataSetName = "NetDataSet13";
            this.netDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nạp tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đặt món";
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt.Location = new System.Drawing.Point(18, 55);
            this.sdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(30, 23);
            this.sdt.TabIndex = 12;
            this.sdt.Text = "{?}";
            this.sdt.Visible = false;
            // 
            // thanhtoanTKTableAdapter
            // 
            this.thanhtoanTKTableAdapter.ClearBeforeFill = true;
            // 
            // thanhtoanMATableAdapter
            // 
            this.thanhtoanMATableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lịch sử giao dịch";
            // 
            // lichsugiaodich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(933, 720);
            this.MinimumSize = new System.Drawing.Size(933, 720);
            this.Name = "lichsugiaodich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lichsugiaodich";
            this.Load += new System.EventHandler(this.lichsugiaodich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhtoanTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhtoanMABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sdt;
        private NetDataSet12 netDataSet12;
        private System.Windows.Forms.BindingSource thanhtoanTKBindingSource;
        private NetDataSet12TableAdapters.thanhtoanTKTableAdapter thanhtoanTKTableAdapter;
        private NetDataSet13 netDataSet13;
        private System.Windows.Forms.BindingSource thanhtoanMABindingSource;
        private NetDataSet13TableAdapters.thanhtoanMATableAdapter thanhtoanMATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}