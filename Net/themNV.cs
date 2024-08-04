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
    public partial class themNV : Form
    {
        public themNV()
        {
            InitializeComponent();
        }

        private void themNV_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Phục vụ");
            comboBox1.Items.Add("Thu ngân");
            comboBox1.Items.Add("Thủ kho");
            comboBox1.Items.Add("Quản lý");

            comboBox2.Items.Add("Nam");
            comboBox2.Items.Add("Nữ");
            comboBox2.Items.Add("Khác");


            // Chọn mục đầu tiên là mặc định
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tenNV.Text.Length ==0)
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");

            }
            else
            {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string Ten = tenNV.Text;
            string gioitinh = comboBox2.SelectedItem.ToString();
            string que = queNV.Text;
            string chucvu = comboBox1.SelectedItem.ToString();




            string query = "EXEC Net.dbo.themNV  N'" + Ten + "',N'" + gioitinh + "',N'" + que + "',N'" + chucvu + "'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Đã thêm nhân viên thành công");

            this.Close();
            Admin adminForm = Application.OpenForms["Admin"] as Admin;
            if (adminForm != null)
            {
                adminForm.RefreshData(); // RefreshData là tên phương thức refresh hoặc load dữ liệu trên form Admin
            }
            }

        }
    }
}
