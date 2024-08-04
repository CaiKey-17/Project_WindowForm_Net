using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Net
{
    public partial class Admin : Form
    {
        public string name = "{?}";
        public string calam = "{?}";


        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet15.thanhtoanMA' table. You can move, or remove it, as needed.
            this.thanhtoanMATableAdapter.Fill(this.netDataSet15.thanhtoanMA);
            // TODO: This line of code loads data into the 'netDataSet14.thanhtoanTK' table. You can move, or remove it, as needed.
            this.thanhtoanTKTableAdapter.Fill(this.netDataSet14.thanhtoanTK);
            // TODO: This line of code loads data into the 'netDataSet8.thietbi' table. You can move, or remove it, as needed.
            this.thietbiTableAdapter.Fill(this.netDataSet8.thietbi);
            // TODO: This line of code loads data into the 'netDataSet7.kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.netDataSet7.kho);
            // TODO: This line of code loads data into the 'netDataSet2.maytinh' table. You can move, or remove it, as needed.
            this.maytinhTableAdapter.Fill(this.netDataSet2.maytinh);
            // TODO: This line of code loads data into the 'netDataSet1.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.netDataSet1.nhanvien);
            nv_name.Text = name;
            ca.Text = calam;
            LoadDataToDataGridView();


            // Thêm các mục vào comboBox1



            Series series = new Series("TongTien");
            chart1.Series.Add(series); // Thêm Series vào control Chart
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT DISTINCT MONTH(ngay) AS Thang FROM thanhtoanMA WHERE trangthai = N'Hoàn tất' ORDER BY Thang";

            // Kết nối đến cơ sở dữ liệu và lấy dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Thiết lập dữ liệu cho trục X của biểu đồ cột
                while (reader.Read())
                {
                    int month = reader.GetInt32(0);
                    chart1.ChartAreas[0].AxisX.CustomLabels.Add(month - 0.5, month + 0.5, month.ToString());
                }
                reader.Close();

                // Lấy dữ liệu tổng tiền từ cơ sở dữ liệu và thiết lập cho biểu đồ
                query = "SELECT MONTH(ngay) AS Thang, SUM(tongtien) AS TongTien FROM thanhtoanMA WHERE trangthai = N'Hoàn tất' GROUP BY MONTH(ngay)";
                command.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Thiết lập dữ liệu cho biểu đồ cột
                foreach (DataRow row in dataTable.Rows)
                {
                    int month = Convert.ToInt32(row["Thang"]);
                    double total = Convert.ToDouble(row["TongTien"]);
                    chart1.Series["TongTien"].Points.AddXY(month, total);
                }
            }

            // Thiết lập thuộc tính cho biểu đồ cột
            chart1.Series["TongTien"].ChartType = SeriesChartType.Column;
            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Tổng thu order";
            chart1.ChartAreas[0].AxisX.Minimum = 0.5; // Bắt đầu từ tháng 1
            chart1.ChartAreas[0].AxisX.Maximum = 12.5; // Kết thúc ở tháng 12
            chart1.ChartAreas[0].AxisX.Interval = 1; // Bước nhảy giữa các tháng


            Series series2 = new Series("TongThuNhap");
            chart2.Series.Add(series2); // Thêm Series vào control Chart
            string query2 = "SELECT MONTH(ngay) AS Thang, SUM(tongtien) AS TongThuNhap FROM thanhtoanTK WHERE trangthai = N'Đã thanh toán' GROUP BY MONTH(ngay)";

            // Kết nối đến cơ sở dữ liệu và lấy dữ liệu
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                SqlCommand command2 = new SqlCommand(query2, connection2);
                connection2.Open();
                SqlDataReader reader2 = command2.ExecuteReader();

                // Thiết lập dữ liệu cho biểu đồ cột thứ hai
                while (reader2.Read())
                {
                    int month = reader2.GetInt32(0);
                    double total = Convert.ToDouble(reader2["TongThuNhap"]);
                    chart2.Series["TongThuNhap"].Points.AddXY(month, total);

                    // Tính toán vị trí cho nhãn của tháng trên trục X
                    double labelPosition = month - 0.5 + 1;
                    chart2.ChartAreas[0].AxisX.CustomLabels.Add(month - 0.5, month + 0.5, month.ToString());
                }
                reader2.Close();
            }

            // Thiết lập thuộc tính cho biểu đồ cột thứ hai
            chart2.Series["TongThuNhap"].ChartType = SeriesChartType.Column;
            chart2.ChartAreas[0].AxisX.Title = "Tháng";
            chart2.ChartAreas[0].AxisY.Title = "Tổng thu tài khoản";
            chart2.ChartAreas[0].AxisX.Minimum = 0.5; // Bắt đầu từ tháng 1
            chart2.ChartAreas[0].AxisX.Maximum = 12.5; // Kết thúc ở tháng 12
            chart2.ChartAreas[0].AxisX.Interval = 1; // Bước nhảy giữa các tháng


        }
        public void RefreshData()
        {
            // Refresh hoặc load lại dữ liệu vào các controls trên form Admin
            // Ví dụ:
            // this.maytinhTableAdapter.Fill(this.netDataSet2.maytinh);
            this.nhanvienTableAdapter.Fill(this.netDataSet1.nhanvien);
            LoadDataToDataGridView();
            // this.comboBox1.SelectedIndex = 0;
            // this.comboBox2.SelectedIndex = 0;

            // Sau khi refresh hoặc load lại dữ liệu, bạn có thể gọi phương thức này từ form themNV để cập nhật dữ liệu trên form Admin
        }
        private void Admin_Shown(object sender, EventArgs e)
        {
            // Gọi lại phương thức Admin_Load để refresh lại dữ liệu khi form được hiển thị
            Admin_Load(sender, e);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nv_name_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dangNhapAdmin dangNhapAdmin = new dangNhapAdmin();
            dangNhapAdmin.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ca_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            themNV themNV = new themNV();
            themNV.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string ten = tenNV.Text;
                string gioitinh = gioitinhNV.Text;
                if (gioitinh.Equals("Nam") || gioitinh.Equals("Nữ") || gioitinh.Equals("Khác"))
                {

                    string que = queNV.Text;
                    string maNV = id.Text;

                    // Corrected table name to 'nhanvien'
                    string query = "UPDATE nhanvien SET ten = N'" + ten + "', gioitinh = N'" + gioitinh + "', quequan = N'" + que + "' WHERE id = '" + maNV + "'";

                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa thông tin nhân viên thành công");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Giới tính không hợp lệ");

                }
            }





        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID hoặc khóa chính của hàng được chọn (ví dụ, giả sử cột đầu tiên là ID)
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();


                string query = "EXEC Net.dbo.xoaNV   '" + id + "'";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                LoadDataToDataGridView();
                // Gán giá trị mới cho datMon.Text
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }

        private void LoadDataToDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM nhanvien where trangthai = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;




        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel3.Visible = false;

            panel4.Visible = true;
            panel5.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;


        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                // Lấy dữ liệu từ các cột trong dòng được chọn và gán nó vào các TextBox tương ứng
                tenNV.Text = row.Cells["nameNV"].Value.ToString();
                gioitinhNV.Text = row.Cells["genderNV"].Value.ToString();
                queNV.Text = row.Cells["qqNV"].Value.ToString();
                id.Text = row.Cells["maNV"].Value.ToString();
                chucvuNV.Text = row.Cells["chucvuDataGridViewTextBoxColumn"].Value.ToString();

            }
        }

       

        private void button12_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = true;
            panel7.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel7.Visible = true;
            panel6.Visible = false;
            panel8.Visible = false;


        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = true;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
