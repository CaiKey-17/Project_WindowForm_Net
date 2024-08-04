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
    public partial class lichsugiaodich : Form
    {
        public string manguoichoi = "{?}";
        public lichsugiaodich()
        {
            InitializeComponent();
        }

        private void lichsugiaodich_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet13.thanhtoanMA' table. You can move, or remove it, as needed.
            this.thanhtoanMATableAdapter.Fill(this.netDataSet13.thanhtoanMA);
            // TODO: This line of code loads data into the 'netDataSet12.thanhtoanTK' table. You can move, or remove it, as needed.
            this.thanhtoanTKTableAdapter.Fill(this.netDataSet12.thanhtoanTK);
            sdt.Text = manguoichoi;
            LoadDataToDataGridView();
            LoadDataToDataGridView1();





        }

        private void LoadDataToDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM thanhtoanMA WHERE taikhoan = @manguoichoi and trangthai = N'Hoàn tất'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@manguoichoi", manguoichoi);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
                    }
                }
            }

        }

        private void LoadDataToDataGridView1()
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string query = "SELECT * FROM thanhtoanTK WHERE taikhoan = @manguoichoi and trangthai = N'Đã thanh toán'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@manguoichoi", manguoichoi);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }

        }
    }
}
