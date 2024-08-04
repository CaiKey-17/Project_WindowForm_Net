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
    public partial class thongtin : Form
    {
        public string sdt = "{?}";
        public thongtin()
        {
            InitializeComponent();
        }

        private void thongtin_Load(object sender, EventArgs e)
        {
            sdtKH.Text = sdt;
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ten, email FROM khachhang WHERE sdt = @sdt";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sdt", sdt);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string ten = reader["ten"].ToString();
                    string email = reader["email"].ToString();
                    // Gán giá trị vào các control trên form
                    tenKH.Text = ten;
                    emailKH.Text = email;
                }
                reader.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            string tenMoi = tenKH.Text;
            string emailMoi = emailKH.Text;
            if(tenMoi.Length == 0)
            {
                MessageBox.Show("Tên không được để trống!");

            }
            else if(emailMoi.Length == 0) {
                MessageBox.Show("Email không được để trống!");

            }
            else
            {

            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE khachhang SET ten = @ten, email = @email WHERE sdt = @sdt";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ten", tenMoi);
                command.Parameters.AddWithValue("@email", emailMoi);
                command.Parameters.AddWithValue("@sdt", sdt);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
            }

        }
    }
}
