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
    public partial class doimatkhau : Form
    {
        public string taikhoan = "{?}";

        public doimatkhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string matkhaucu = mk_cu.Text;
                string matkhaumoi = dmk_mkm.Text;
                string xacnhan = dmk_mkm_xn.Text;

                // Truy vấn SELECT để kiểm tra mật khẩu cũ
                string selectQuery = "SELECT COUNT(*) FROM taikhoanC WHERE taikhoan = @taikhoan AND matkhau = @matkhaucu";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                    selectCommand.Parameters.AddWithValue("@matkhaucu", matkhaucu);

                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        if (xacnhan.Equals(matkhaumoi))
                        {
                            string updateQuery = "UPDATE taikhoanC SET matkhau = @matkhaumoi WHERE taikhoan = @taikhoan";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
                            {
                                updateCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                                updateCommand.Parameters.AddWithValue("@matkhaumoi", matkhaumoi);
                                updateCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Đổi mật khẩu thành công");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Xác nhận không đúng mật khẩu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng");
                    }
                }
            }
        }


        private void doimatkhau_Load(object sender, EventArgs e)
        {
            sdt_dmk.Text = taikhoan;
        }

        private void tk_Click(object sender, EventArgs e)
        {

        }
    }
}
