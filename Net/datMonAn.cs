using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Net
{
    public partial class datMonAn : Form
    {
        int NUMBER;
        int NUMBER1;
        int NUMBER2;
        int NUMBER3;
        int NUMBER4;

        float tongtien;

        public string khachhang = "{?}";

        public datMonAn()
        {
            InitializeComponent();
        }

        private void datMonAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet5.thanhtoanMA' table. You can move, or remove it, as needed.
            this.thanhtoanMATableAdapter.Fill(this.netDataSet5.thanhtoanMA);
            NUMBL.Text = "0";
            NUMBL1.Text = "0";
            NUMBL2.Text = "0";
            NUMBL3.Text = "0";
            NUMBL4.Text = "0";
            datMon.Text = tongtien.ToString();

            KH.Text = khachhang;

            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM thanhtoanMA WHERE taikhoan = @khachhang and trangthai = N'Chưa đặt'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@khachhang", khachhang);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            


            LoadDataToDataGridView();
        }
        private void UpdateTotalAmount()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT SUM(tongtien) AS TotalTongTien FROM thanhtoanMA WHERE taikhoan = @khachhang and trangthai = N'Chưa đặt'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@khachhang", khachhang);

                    // Execute scalar query to get the sum of 'tongtien'
                    object result = sqlCommand.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        // Convert the result to float and assign it to 'tongtien'
                        tongtien = Convert.ToSingle(result);
                    }
                    else
                    {
                        tongtien = 0; // If there are no rows, set tongtien to 0
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            NUMBER++;
            NUMBL.Text = NUMBER.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NUMBER--;
            if (NUMBER <= 0)
            {
                NUMBL.Text = "0";
                NUMBER = 0;
            }
            else
            {
            NUMBL.Text = NUMBER.ToString();
            }
        }

        private void LoadDataToDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM thanhtoanMA WHERE taikhoan = @khachhang and trangthai = N'Chưa đặt'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@khachhang", khachhang);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(NUMBER == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng");
            }
            else
            {

            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string Ten = "Mì hảo hảo";
            int soluong = NUMBER;

            string query = "EXEC Net.dbo.themMonAn  '" + khachhang + "',N'" + Ten + "'," + soluong + ",NULL";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm món thành công");
            NUMBL.Text = "0";
            NUMBER = 0;
            UpdateTotalAmount();

            // Gán giá trị mới cho datMon.Text
            datMon.Text = tongtien.ToString();

            // Load lại dữ liệu vào DataGridView
            LoadDataToDataGridView();
            }



        }

        public NetDataSet DataSet { get; set; }


        private void button16_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID hoặc khóa chính của hàng được chọn (ví dụ, giả sử cột đầu tiên là ID)
                string ten = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string KH = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                // Thực hiện câu lệnh DELETE trong cơ sở dữ liệu bằng ID hoặc khóa chính đã lấy được

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
              

                string query = "EXEC Net.dbo.xoaMonAn  '" + KH + "',N'" + ten + "'";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                UpdateTotalAmount();

                // Gán giá trị mới cho datMon.Text
                datMon.Text = tongtien.ToString();
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NUMBER1++;
            NUMBL1.Text = NUMBER1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NUMBER1--;
            if (NUMBER1 <= 0)
            {
                NUMBL1.Text = "0";
                NUMBER1 = 0;
            }
            else
            {
                NUMBL1.Text = NUMBER1.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NUMBER2--;
            if (NUMBER2 <= 0)
            {
                NUMBL2.Text = "0";
                NUMBER2 = 0;
            }
            else
            {
                NUMBL2.Text = NUMBER2.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NUMBER2++;
            NUMBL2.Text = NUMBER2.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NUMBER3++;
            NUMBL3.Text = NUMBER3.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NUMBER3--;
            if (NUMBER3 <= 0)
            {
                NUMBL3.Text = "0";
                NUMBER3 = 0;
            }
            else
            {
                NUMBL3.Text = NUMBER3.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NUMBER4--;
            if (NUMBER4 <= 0)
            {
                NUMBL4.Text = "0";
                NUMBER4 = 0;
            }
            else
            {
                NUMBL4.Text = NUMBER4.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NUMBER4++;
            NUMBL4.Text = NUMBER4.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (NUMBER1 == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng");
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string Ten = "Sting";
                int soluong = NUMBER1;

                string query = "EXEC Net.dbo.themMonAn  '" + khachhang + "',N'" + Ten + "'," + soluong + ",NULL";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm món thành công");
                NUMBL1.Text = "0";
                NUMBER1 = 0;
                UpdateTotalAmount();

                // Gán giá trị mới cho datMon.Text
                datMon.Text = tongtien.ToString();
                LoadDataToDataGridView();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (NUMBER2 == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng");
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string Ten = "Nước suối";
                int soluong = NUMBER2;

                string query = "EXEC Net.dbo.themMonAn  '" + khachhang + "',N'" + Ten + "'," + soluong + ",NULL";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm món thành công");
                NUMBL2.Text = "0";
                NUMBER2 = 0;
                UpdateTotalAmount();

                // Gán giá trị mới cho datMon.Text
                datMon.Text = tongtien.ToString();
                LoadDataToDataGridView();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (NUMBER3 == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng");
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string Ten = "Pepsi";
                int soluong = NUMBER3;

                string query = "EXEC Net.dbo.themMonAn  '" + khachhang + "',N'" + Ten + "'," + soluong + ",NULL";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm món thành công");
                NUMBL3.Text = "0";
                NUMBER3 = 0;
                UpdateTotalAmount();

                // Gán giá trị mới cho datMon.Text
                datMon.Text = tongtien.ToString();
                LoadDataToDataGridView();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (NUMBER4 == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng");
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string Ten = "Snack";
                int soluong = NUMBER4;

                string query = "EXEC Net.dbo.themMonAn  '" + khachhang + "',N'" + Ten + "'," + soluong + ",NULL";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm món thành công");
                NUMBL4.Text = "0";
                NUMBER4 = 0;
                UpdateTotalAmount();

                // Gán giá trị mới cho datMon.Text
                datMon.Text = tongtien.ToString();
                LoadDataToDataGridView();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "EXEC Net.dbo.datMon  '" + khachhang + "'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Đặt thành công");
            LoadDataToDataGridView();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
    }
}
