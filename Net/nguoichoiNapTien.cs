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
    public partial class nguoichoiNapTien : Form
    {
        public string tk = "{?}";
        public nguoichoiNapTien()
        {
            InitializeComponent();
        }

        private void nguoichoiNapTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet9.thanhtoanTK' table. You can move, or remove it, as needed.
            this.thanhtoanTKTableAdapter.Fill(this.netDataSet9.thanhtoanTK);
            tkNC.Text = tk;
            LoadDataToDataGridView3();

        }

        private void LoadDataToDataGridView3()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM thanhtoanTK WHERE taikhoan = @taikhoan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@taikhoan", tk);

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
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                int sogio = Convert.ToInt32(giothue.Text);
                if(sogio <= 0)
                {
                    MessageBox.Show("Giờ thuê phải lớn hơn 0");

                }
                else
                {
                string query = "EXEC Net.dbo.naptien    '" + tk + "'," + sogio + "";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đã tạo hóa đơn thành công");
                LoadDataToDataGridView3();
            }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID hoặc khóa chính của hàng được chọn (ví dụ, giả sử cột đầu tiên là ID)
                string ten = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
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

                // Refresh DataGridView sau khi xóa
                LoadDataToDataGridView3();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }
    }
}
