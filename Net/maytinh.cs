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
    public partial class maytinh : Form
    {
        public maytinh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ma_mt.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã máy");

            }
            else if (Convert.ToInt32(sl_mt.Text)<=0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
            }
            else
            {

            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string ma = ma_mt.Text;
                int soluong = Convert.ToInt32(sl_mt.Text);
                string mausac = ms_mt.Text;
                string tinhtrang = tt_mt.Text;
                string cauhinh = ch_mt.Text;




                string insertQuery = "INSERT INTO maytinh VALUES(@ma,@soluong,@mausac,@tinhtrang,@cauhinh,NULL)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@ma", ma);
                    insertCommand.Parameters.AddWithValue("@soluong", soluong);
                    insertCommand.Parameters.AddWithValue("@mausac", mausac);
                    insertCommand.Parameters.AddWithValue("@tinhtrang", tinhtrang);
                    insertCommand.Parameters.AddWithValue("@cauhinh", cauhinh);
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm thành công");
                phucvu thuKhoForm = Application.OpenForms["phucvu"] as phucvu;
                // Kiểm tra xem form thuKho có tồn tại không
                if (thuKhoForm != null)
                {
                    // Gọi phương thức làm mới DataGridView của form thuKho
                    thuKhoForm.RefreshDataGridView();
                }
                // Tắt form themKho và refresh form thuKho
                this.Close();
            }
            }
        }
    }
}
