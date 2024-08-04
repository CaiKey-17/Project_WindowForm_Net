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
    public partial class phucvu : Form
    {
        public string name = "{?}";
        public string calam = "{?}";


        public phucvu()
        {
            InitializeComponent();
        }

        private void phucvu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netDataSet11.thietbi' table. You can move, or remove it, as needed.
            this.thietbiTableAdapter.Fill(this.netDataSet11.thietbi);
            // TODO: This line of code loads data into the 'netDataSet10.maytinh' table. You can move, or remove it, as needed.
            this.maytinhTableAdapter.Fill(this.netDataSet10.maytinh);
            nv_name.Text = name;
            ca.Text = calam;

        }

        public void RefreshDataGridView()
        {
            this.maytinhTableAdapter.Fill(this.netDataSet10.maytinh);
            this.thietbiTableAdapter.Fill(this.netDataSet11.thietbi);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nv_name_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dangNhapAdmin dangNhapAdmin = new dangNhapAdmin();
            dangNhapAdmin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            maytinh mt = new maytinh();
            mt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string deleteQuery = "DELETE FROM maytinh WHERE ma = @ma";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@ma", ma);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                this.maytinhTableAdapter.Fill(this.netDataSet10.maytinh);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                // Lấy dữ liệu từ các cột trong dòng được chọn và gán nó vào các TextBox tương ứng
                ma_mt.Text = row.Cells["ma"].Value.ToString();
                sl_mt.Text = row.Cells["soluong"].Value.ToString();
                ms_mt.Text = row.Cells["mausac"].Value.ToString();
                tt_mt.Text = row.Cells["tinhtrang"].Value.ToString();
                ch_mt.Text = row.Cells["cauhinh"].Value.ToString();
                gc_mt.Text = row.Cells["ghichu"].Value.ToString();




            }
        }

        private void button7_Click(object sender, EventArgs e)
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
                string ghichu = gc_mt.Text;

                string insertQuery = "UPDATE maytinh SET soluong = @soluong,mausac = @mausac, tinhtrang = @tinhtrang, cauhinh = @cauhinh, ghichu = @ghichu WHERE ma = @ma";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@ma", ma);
                    insertCommand.Parameters.AddWithValue("@soluong", soluong);
                    insertCommand.Parameters.AddWithValue("@mausac", mausac);
                    insertCommand.Parameters.AddWithValue("@tinhtrang", tinhtrang);
                    insertCommand.Parameters.AddWithValue("@cauhinh", cauhinh);
                    insertCommand.Parameters.AddWithValue("@ghichu", ghichu);
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Sửa thành công");

                this.maytinhTableAdapter.Fill(this.netDataSet10.maytinh);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            thietbi thietbi = new thietbi();
            thietbi.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                ten_tb.Text = row.Cells["ttb"].Value.ToString();
                sl_tb.Text = row.Cells["sltb"].Value.ToString();
                gia_tb.Text = row.Cells["giatb"].Value.ToString();
                tt_tb.Text = row.Cells["tttb"].Value.ToString();
                gc_tb.Text = row.Cells["gctb"].Value.ToString();




            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string ten = ten_tb.Text;
                int soluong = Convert.ToInt32(sl_tb.Text);
                float trigia = float.Parse(gia_tb.Text);
                string tinhtrang = tt_tb.Text;
                string ghichu = gc_tb.Text;


                string insertQuery = "UPDATE thietbi SET soluong = @soluong,dongia = @trigia, tinhtrang = @tinhtrang, ghichu = @ghichu WHERE tenthietbi = @ten";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@ten", ten);
                    insertCommand.Parameters.AddWithValue("@soluong", soluong);
                    insertCommand.Parameters.AddWithValue("@trigia", trigia);
                    insertCommand.Parameters.AddWithValue("@tinhtrang", tinhtrang);
                    insertCommand.Parameters.AddWithValue("@ghichu", ghichu);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công"); 
                }


            this.thietbiTableAdapter.Fill(this.netDataSet11.thietbi);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            if (dataGridView2.SelectedRows.Count > 0)
            {
                string ten = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string deleteQuery = "DELETE FROM thietbi WHERE tenthietbi = @ten";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@ten", ten);
                        deleteCommand.ExecuteNonQuery();
                    }
                }
                this.thietbiTableAdapter.Fill(this.netDataSet11.thietbi);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
