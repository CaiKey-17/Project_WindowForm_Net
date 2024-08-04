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
    public partial class manhinhNguoiChoi : Form
    {
        public string name = "{?}";
        public string taikhoan = "{?}";
        public int thoigian = 0;
        private Timer timer;

        public manhinhNguoiChoi()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 60000; // 1 phút
            timer.Tick += Timer_Tick;
        }

        private void manhinhNguoiChoi_Load(object sender, EventArgs e)
        {
            nameUer.Text = name;
            sdt.Text = taikhoan;
            tg.Text = thoigian.ToString();
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Giảm thoigian đi 1 sau mỗi phút
            thoigian--;

            // Cập nhật giá trị mới lên tg.Text
            tg.Text = thoigian.ToString();

            // Cập nhật giá trị mới vào cột hansudung trong bảng taikhoanC
            UpdateHanSuDung(thoigian);

            // Nếu thoigian <= 0, dừng Timer
            if (thoigian <= 0)
            {
                timer.Stop();
                MessageBox.Show("Hết thời gian!");
                string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

                string updateQuery = "UPDATE sudung SET trangthai = 0 WHERE taikhoan = @taikhoan";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
                    {
                        updateCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                this.Hide();
                dangNhapNguoiChoi f1 = new dangNhapNguoiChoi();

                timer.Stop();

                // Cập nhật giá trị hansudung trong bảng taikhoanC thành giá trị hiện tại của thoigian
                UpdateHanSuDung(thoigian); f1.Show();
            }
        }


        private void UpdateHanSuDung(int thoigian)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";
            string updateQuery = "UPDATE taikhoanC SET hansudung = @thoigian WHERE taikhoan = @taikhoan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
                {
                    updateCommand.Parameters.AddWithValue("@thoigian", thoigian);
                    updateCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            string updateQuery = "UPDATE sudung SET trangthai = 0 WHERE taikhoan = @taikhoan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
                {
                    updateCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
                    updateCommand.ExecuteNonQuery();
                }
            }
            this.Hide();
            dangNhapNguoiChoi f1 = new dangNhapNguoiChoi();

            timer.Stop();

            // Cập nhật giá trị hansudung trong bảng taikhoanC thành giá trị hiện tại của thoigian
            UpdateHanSuDung(thoigian); f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameUer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doimatkhau dmk = new doimatkhau();
            dmk.taikhoan = taikhoan;
            dmk.Show();
        }

        private void sdt_Click(object sender, EventArgs e)
        {

        }

        private void tg_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            datMonAn datMonAn = new datMonAn();
            datMonAn.khachhang = taikhoan;
            datMonAn.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            nguoichoiNapTien nc = new nguoichoiNapTien();
            nc.tk = taikhoan;
            nc.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            thongtin thongtin = new thongtin();
            thongtin.sdt = taikhoan;
            thongtin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lichsugiaodich lichsugiaodich = new lichsugiaodich();  
            lichsugiaodich.manguoichoi = taikhoan;
            lichsugiaodich.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
