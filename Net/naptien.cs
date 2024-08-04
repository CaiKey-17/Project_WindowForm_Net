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
    public partial class naptien : Form
    {
        public string sdt = "{?}";
        public naptien()
        {
            InitializeComponent();
        }

        private void naptien_Load(object sender, EventArgs e)
        {
            sdtKH.Text = sdt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string maKH = sdt;
            int giothue = Convert.ToInt32(gt.Text);
            string query = "EXEC Net.dbo.naptien    '" + sdt + "'," + giothue + "";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Đã tạo hóa đơn thành công");

            thuNgan thuNganForm = Application.OpenForms.OfType<thuNgan>().FirstOrDefault();
            if (thuNganForm != null)
            {
                // Thực hiện ẩn panel3 và hiển thị panel4
                thuNganForm.HidePanel3();
                thuNganForm.ShowPanel4();
            }

            this.Close();



        }
    }
}
