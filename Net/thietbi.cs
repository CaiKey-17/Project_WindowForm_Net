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
using System.Windows.Forms.DataVisualization.Charting;

namespace Net
{
    public partial class thietbi : Form
    {
        public thietbi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string ten = ten_tb.Text;
                int soluong = Convert.ToInt32(sl_tb.Text);
                float trigia = float.Parse(gia_tb.Text);
                string tinhtrang = tt_tb.Text;




                string insertQuery = "INSERT INTO thietbi VALUES(@ten,@soluong,@trigia,@tinhtrang,NULL)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@ten", ten);
                    insertCommand.Parameters.AddWithValue("@soluong", soluong);
                    insertCommand.Parameters.AddWithValue("@trigia", trigia);
                    insertCommand.Parameters.AddWithValue("@tinhtrang", tinhtrang);
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
