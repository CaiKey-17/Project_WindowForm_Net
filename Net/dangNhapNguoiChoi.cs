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
    public partial class dangNhapNguoiChoi : Form
    {
        public dangNhapNguoiChoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tk.Text.Length==0) {
                MessageBox.Show("Vui lòng nhập tài khoản");
            }
            else if (mk.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");

            }
            else
            {

            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";




            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string taikhoan = tk.Text;
                string matkhau = mk.Text;
                string query = "SELECT COUNT(*) FROM taikhoanC WHERE taikhoan=@taikhoan AND matkhau=@matkhau AND hansudung > 0";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                    sqlCommand.Parameters.AddWithValue("@matkhau", matkhau);

                    int count = (int)sqlCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        string checkStatusQuery = "SELECT COUNT(*) FROM sudung WHERE trangthai = 1 AND taikhoan != @taikhoan";
                        using (SqlCommand checkStatusCommand = new SqlCommand(checkStatusQuery, conn))
                        {
                            checkStatusCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                            int machineInUseCount = (int)checkStatusCommand.ExecuteScalar();
                            if (machineInUseCount > 0)
                            {
                                MessageBox.Show("Có tài khoản khác đang sử dụng máy này.");
                                return; // Dừng lại, không cho phép đăng nhập
                            }
                        }

                        MessageBox.Show("Đăng nhập thành công");
                        string insertQuery = "INSERT INTO sudung VALUES(@taikhoan, 'MT1', GETDATE(),1)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                        {
                            insertCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                            insertCommand.ExecuteNonQuery();
                        }
                        // Truy vấn để lấy tên người dùng
                        string queryUserName = "SELECT ten,hansudung FROM taikhoanC INNER JOIN khachhang ON taikhoanC.sdt = khachhang.sdt WHERE taikhoanC.taikhoan = @taikhoan";


                        using (SqlCommand userNameCommand = new SqlCommand(queryUserName, conn))
                        {
                            userNameCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                            SqlDataReader reader = userNameCommand.ExecuteReader();
                            if (reader.Read())
                            {
                                string userName = reader["ten"].ToString();
                                int hansudung = Convert.ToInt32(reader["hansudung"]);

                                manhinhNguoiChoi mn = new manhinhNguoiChoi();
                                mn.name = userName; // Gán tên người dùng
                                mn.taikhoan = taikhoan; // Gán tên người dùng
                                mn.thoigian = hansudung; // Gán giá trị hansudung

                                mn.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin người dùng");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không được sử dụng");
                    }
                }
            }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dangNhapNguoiChoi_Load(object sender, EventArgs e)
        {

        }

        private void eye1_Click(object sender, EventArgs e)
        {
            if (mk.PasswordChar == '\0')
            {
                eye2.BringToFront();
                mk.PasswordChar = '*';
            }
        }

        private void eye2_Click(object sender, EventArgs e)
        {
            if (mk.PasswordChar == '*')
            {
                eye1.BringToFront();
                mk.PasswordChar = '\0';
            }
        }
    }
}
