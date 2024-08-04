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
    public partial class themKho : Form
    {
        public themKho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (them_ten.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên món hàng");
            }
            else if (Convert.ToInt32(them_sl.Text) <= 0) 
            {
                MessageBox.Show("Số lượng không hợp lệ");

            }
            else if (float.Parse(them_dongia.Text) <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ");

            }
            else
            {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string ten = them_ten.Text;
                int soluong = Convert.ToInt32(them_sl.Text); // Chuyển đổi soluong sang kiểu số nguyên
                float dongia = float.Parse(them_dongia.Text); // Chuyển đổi dongia sang kiểu số thực
                DateTime hansudung = them_hansudung.Value;
                string ghichu = them_ghichu.Text;

                string insertQuery = "INSERT INTO kho VALUES(@ten,@soluong,@dongia,@hansudung,@ghichu)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@ten", ten);
                    insertCommand.Parameters.AddWithValue("@soluong", soluong);
                    insertCommand.Parameters.AddWithValue("@dongia", dongia);
                    insertCommand.Parameters.AddWithValue("@hansudung", hansudung);
                    insertCommand.Parameters.AddWithValue("@ghichu", ghichu);
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm thành công");
                thuKho thuKhoForm = Application.OpenForms["thuKho"] as thuKho;
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


        private void tk_hansudung_ValueChanged(object sender, EventArgs e)
        {

        }

        private void them_sl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
