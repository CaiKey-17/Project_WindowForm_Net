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
    public partial class thuKho : Form
    {
        public string name = "{?}";
        public string calam = "{?}";

        public NetDataSet DataSet { get; set; }

       
        public thuKho()
        {
            InitializeComponent();
        }

        private void thuKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet.kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.netDataSet.kho);
            nv_name.Text = name;
            ca.Text = calam;

        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            themKho tk = new themKho();

            tk.Show(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID hoặc khóa chính của hàng được chọn (ví dụ, giả sử cột đầu tiên là ID)
                string ten = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                // Thực hiện câu lệnh DELETE trong cơ sở dữ liệu bằng ID hoặc khóa chính đã lấy được
                string deleteQuery = "DELETE FROM kho WHERE ten = @ten";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@ten",ten);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                // Refresh DataGridView sau khi xóa
                this.khoTableAdapter.Fill(this.netDataSet.kho);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }
        public void RefreshDataGridView()
        {
            this.khoTableAdapter.Fill(this.netDataSet.kho);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string ten = tk_ten.Text;
                int soluong = Convert.ToInt32(tk_sl.Text); // Chuyển đổi soluong sang kiểu số nguyên
                float dongia = float.Parse(tk_dongia.Text); // Chuyển đổi dongia sang kiểu số thực
                DateTime hansudung = tk_hansudung.Value;
                string ghichu = tk_ghichu.Text;

                string insertQuery = "UPDATE kho SET soluong = @soluong,dongia = @dongia, hansudung = @hansudung, ghichu = @ghichu WHERE ten = @ten";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@ten", ten);
                    insertCommand.Parameters.AddWithValue("@soluong", soluong);
                    insertCommand.Parameters.AddWithValue("@dongia", dongia);
                    insertCommand.Parameters.AddWithValue("@hansudung", hansudung);
                    insertCommand.Parameters.AddWithValue("@ghichu", ghichu);
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Sửa thành công");
               
                this.khoTableAdapter.Fill(this.netDataSet.kho);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) { 
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                // Lấy dữ liệu từ các cột trong dòng được chọn và gán nó vào các TextBox tương ứng
                tk_ten.Text = row.Cells["ten"].Value.ToString();
                tk_sl.Text = row.Cells["soluong"].Value.ToString();
                tk_dongia.Text = row.Cells["dongia"].Value.ToString();
                tk_hansudung.Value = (DateTime)row.Cells["hansudung"].Value;
                tk_ghichu.Text = row.Cells["ghichu"].Value.ToString();
            }
        }

        private void ca_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dangNhapAdmin dangNhapAdmin = new dangNhapAdmin();
            dangNhapAdmin.Show();
            this.Close();
        }
    }
}
