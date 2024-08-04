using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net
{
    public partial class thuNgan : Form
    {
        public string name = "{?}";
        public string calam = "{?}";
        public string maNV = "{?}";



        public thuNgan()
        {
            InitializeComponent();
        }

        private void nv_name_Click(object sender, EventArgs e)
        {

        }

        private void thuNgan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet6.thanhtoanMA' table. You can move, or remove it, as needed.
            this.thanhtoanMATableAdapter.Fill(this.netDataSet6.thanhtoanMA);
            // TODO: This line of code loads data into the 'netDataSet4.thanhtoanTK' table. You can move, or remove it, as needed.
            this.thanhtoanTKTableAdapter.Fill(this.netDataSet4.thanhtoanTK);
            // TODO: This line of code loads data into the 'netDataSet3.khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.netDataSet3.khachhang);
            nv_name.Text = name;
            ca.Text = calam;
            id.Text = maNV;

            LoadDataToDataGridView();

            LoadDataToDataGridView2();
            LoadDataToDataGridView3();
            LoadDataToDataGridView4();
            LoadDataToDataGridView5();

        }
        private void LoadDataToDataGridView2()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM thanhtoanTK WHERE trangthai = N'Chưa thanh toán'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
                    }
                }
            }
        }

        private void LoadDataToDataGridView3()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM thanhtoanTK WHERE trangthai = N'Đã thanh toán'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView4.DataSource = dataTable;
                    }
                }
            }
        }


        private void LoadDataToDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM thanhtoanMA WHERE trangthai = N'Đang đặt'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView3.DataSource = dataTable;
                    }
                }
            }

        }
        private void LoadDataToDataGridView4()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM thanhtoanMA WHERE trangthai = N'Hoàn tất'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView5.DataSource = dataTable;
                    }
                }
            }

        }

        private void LoadDataToDataGridView5()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM khachhang";

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

        public void loadKH()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM khachhang";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ca_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dangNhapAdmin dangNhapAdmin = new dangNhapAdmin();
            dangNhapAdmin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            themNguoiChoi themNguoiChoi = new themNguoiChoi();
            themNguoiChoi.idNV = maNV;
            themNguoiChoi.Show();
        }
        public void RefreshData()
        {
            // Refresh hoặc load lại dữ liệu vào các controls trên form Admin
            // Ví dụ:
            // this.maytinhTableAdapter.Fill(this.netDataSet2.maytinh);
            this.khachhangTableAdapter.Fill(this.netDataSet3.khachhang);
            this.thanhtoanTKTableAdapter.Fill(this.netDataSet4.thanhtoanTK);

            // this.comboBox1.SelectedIndex = 0;
            // this.comboBox2.SelectedIndex = 0;

            // Sau khi refresh hoặc load lại dữ liệu, bạn có thể gọi phương thức này từ form themNV để cập nhật dữ liệu trên form Admin
        }
        public void HidePanel3()
        {
            panel3.Visible = false;
        }

        // Khai báo phương thức công khai để hiển thị panel4
        public void ShowPanel4()
        {
            panel4.Visible = true;
            LoadDataToDataGridView2();
        }
        private void id_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sdt = sdtKH.Text;
                string ten = tenKH.Text;
                string email = emailKH.Text;

                string insertQuery = "UPDATE khachhang SET ten = @ten WHERE sdt = @sdt";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@ten", ten);
                    insertCommand.Parameters.AddWithValue("@sdt", sdt);
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Sửa thông tin khách hàng thành công");
                LoadDataToDataGridView5();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                // Lấy dữ liệu từ các cột trong dòng được chọn và gán nó vào các TextBox tương ứng
                sdtKH.Text = row.Cells["sdt"].Value.ToString();
                tenKH.Text = row.Cells["ten"].Value.ToString();
                emailKH.Text = row.Cells["email"].Value.ToString();
                reset.Text = row.Cells["sdt"].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            naptien naptien = new naptien();
            naptien.sdt = sdtKH.Text;
            naptien.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                // Lấy dữ liệu từ các cột trong dòng được chọn và gán nó vào các TextBox tương ứng
                maHDTK.Text = row.Cells["mahd"].Value.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string mahoadon = maHDTK.Text;

            string query = "EXEC Net.dbo.xacnhanDK    '" + mahoadon + "'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thanh toán thành công");
            LoadDataToDataGridView();

            LoadDataToDataGridView2();
            LoadDataToDataGridView3();
            LoadDataToDataGridView4();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID hoặc khóa chính của hàng được chọn (ví dụ, giả sử cột đầu tiên là ID)
                string ten = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                // Thực hiện câu lệnh DELETE trong cơ sở dữ liệu bằng ID hoặc khóa chính đã lấy được
                string deleteQuery = "DELETE FROM khachhang WHERE sdt = @ten";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@ten", ten);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                // Refresh DataGridView sau khi xóa
                this.khachhangTableAdapter.Fill(this.netDataSet3.khachhang);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nameSearch = textBox1.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ khoảng trắng

            // Chuẩn bị câu truy vấn SQL
            string query = "SELECT * FROM khachhang WHERE sdt LIKE '%' + @nameSearch + '%'";

            // Kết nối đến cơ sở dữ liệu
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Thực thi câu truy vấn
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameSearch", nameSearch);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Cập nhật DataGridView với kết quả truy vấn
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;

            panel5.Visible = true;
            panel6.Visible = false;


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView3.SelectedRows.Count > 0)
            {
                string ten = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
                string hd = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();



                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();


                string query = "EXEC Net.dbo.hoanTat  '" + hd + "','" + ten + "'";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thanh toán thành công");
                LoadDataToDataGridView();

                LoadDataToDataGridView2();
                LoadDataToDataGridView3();
                LoadDataToDataGridView4();


            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần thanh toán.");
            }




        }

        private void button11_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sdt = reset.Text;

                string insertQuery = "UPDATE taikhoanC SET matkhau = 1 WHERE sdt = @sdt";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@sdt", sdt);
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Đã khôi phục thành công");

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Lấy ID hoặc khóa chính của hàng được chọn (ví dụ, giả sử cột đầu tiên là ID)
                string ten = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                // Thực hiện câu lệnh DELETE trong cơ sở dữ liệu bằng ID hoặc khóa chính đã lấy được
                string deleteQuery = "DELETE FROM thanhtoanTK WHERE HDTK = @ten and trangthai = N'Chưa thanh toán'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@ten", ten);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                LoadDataToDataGridView2();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
             string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView3.SelectedRows.Count > 0)
            {
                string kh = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
                string mon = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                string hd = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();




                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();


                string query = "EXEC Net.dbo.xoaMonAn1   '" + kh + "',N'" + mon + "','" + hd + "'";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                LoadDataToDataGridView();

                LoadDataToDataGridView2();
                LoadDataToDataGridView3();
                LoadDataToDataGridView4();


            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }
    }
}
