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
    public partial class dangNhapAdmin : Form
    {
        public dangNhapAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (admin_tk.Text.Length ==0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản");

            }
            else if (admin_mk.Text.Length ==0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");

            }
            else { 
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";




            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string taikhoan = admin_tk.Text;
                string matkhau = admin_mk.Text;
                string query = "SELECT COUNT(*) FROM taikhoanNV tk,nhanvien nv WHERE tk.taikhoan=@taikhoan AND tk.matkhau=@matkhau AND tk.taikhoan = nv.id and nv.trangthai = 1";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                    sqlCommand.Parameters.AddWithValue("@matkhau", matkhau);

                    int count = (int)sqlCommand.ExecuteScalar();
                    if (count > 0)
                    {
                           

                        MessageBox.Show("Đăng nhập thành công");
                       
                        string queryUserName = "SELECT ten,chucvu FROM taikhoanNV, nhanvien where taikhoanNV.taikhoan = nhanvien.id and taikhoanNV.taikhoan = @taikhoan";

                        using (SqlCommand userNameCommand = new SqlCommand(queryUserName, conn))
                        {
                            userNameCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                            SqlDataReader reader = userNameCommand.ExecuteReader();

                            if (reader.Read())
                            {
                                string userName = reader["ten"].ToString(); // Lấy tên người dùng
                                string chucvu = reader["chucvu"].ToString(); // Lấy chức vụ
                                if (chucvu.Equals("Thu ngân")){
                                    thuNgan tn = new thuNgan();
                                    tn.name = userName; // Gán tên người dùng
                                    tn.maNV = taikhoan; // Gán tên người dùng

                                    DateTime currentTime = DateTime.Now;

                                    // Kiểm tra thời gian để xác định giá trị cho Label calamLabel
                                    if (currentTime.TimeOfDay >= TimeSpan.FromHours(7) && currentTime.TimeOfDay <= TimeSpan.FromHours(12))
                                    {
                                        tn.calam = "1";
                                    }
                                    else if (currentTime.TimeOfDay > TimeSpan.FromHours(12) && currentTime.TimeOfDay <= TimeSpan.FromHours(17))
                                    {
                                        tn.calam = "2";
                                    }
                                    else
                                    {
                                        tn.calam = "3";
                                    }
                                    tn.Show();
                                    this.Hide();

                                }
                                if (chucvu.Equals("Thủ kho")){
                                    thuKho tn = new thuKho();
                                    tn.name = userName;
                                    DateTime currentTime = DateTime.Now;

                                    // Kiểm tra thời gian để xác định giá trị cho Label calamLabel
                                    if (currentTime.TimeOfDay >= TimeSpan.FromHours(7) && currentTime.TimeOfDay <= TimeSpan.FromHours(12))
                                    {
                                        tn.calam = "1";
                                    }
                                    else if (currentTime.TimeOfDay > TimeSpan.FromHours(12) && currentTime.TimeOfDay <= TimeSpan.FromHours(17))
                                    {
                                        tn.calam = "2";
                                    }
                                    else
                                    {
                                        tn.calam = "3";
                                    }
                                    tn.Show();
                                    this.Hide();

                                }
                                if (chucvu.Equals("Quản lý")){
                                    Admin tn = new Admin();
                                    tn.name = userName; // Gán tên người dùng
                                    DateTime currentTime = DateTime.Now;

                                    // Kiểm tra thời gian để xác định giá trị cho Label calamLabel
                                    if (currentTime.TimeOfDay >= TimeSpan.FromHours(7) && currentTime.TimeOfDay <= TimeSpan.FromHours(12))
                                    {
                                        tn.calam = "1";
                                    }
                                    else if (currentTime.TimeOfDay > TimeSpan.FromHours(12) && currentTime.TimeOfDay <= TimeSpan.FromHours(17))
                                    {
                                        tn.calam = "2";
                                    }
                                    else
                                    {
                                        tn.calam = "3";
                                    }
                                    tn.Show();
                                    this.Hide();
                                }
                                if (chucvu.Equals("Phục vụ")){
                                    phucvu tn = new phucvu();
                                    tn.name = userName; // Gán tên người dùng
                                    DateTime currentTime = DateTime.Now;

                                    // Kiểm tra thời gian để xác định giá trị cho Label calamLabel
                                    if (currentTime.TimeOfDay >= TimeSpan.FromHours(7) && currentTime.TimeOfDay <= TimeSpan.FromHours(12))
                                    {
                                        tn.calam = "1";
                                    }
                                    else if (currentTime.TimeOfDay > TimeSpan.FromHours(12) && currentTime.TimeOfDay <= TimeSpan.FromHours(17))
                                    {
                                        tn.calam = "2";
                                    }
                                    else
                                    {
                                        tn.calam = "3";
                                    }
                                    tn.Show();
                                    this.Hide();
                                }

                               
                            }
                            else
                            {
                                // Xử lý trường hợp không tìm thấy dữ liệu
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

        private void eye1_Click(object sender, EventArgs e)
        {
            if (admin_mk.PasswordChar == '\0')
            {
                eye2.BringToFront();
                admin_mk.PasswordChar = '*';
            }
        }

        private void eye2_Click(object sender, EventArgs e)
        {
            if (admin_mk.PasswordChar == '*')
            {
                eye1.BringToFront();
                admin_mk.PasswordChar = '\0';
            }
        }
    }
}
