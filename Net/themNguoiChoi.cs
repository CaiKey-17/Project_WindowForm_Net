using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Net
{
    public partial class themNguoiChoi : Form
    {
        public string idNV = "{?}";

        public themNguoiChoi()
        {
            InitializeComponent();
        }

        private void themNV_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8IARUUE\\SQLEXPRESS;Initial Catalog=Net;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sdt = sdtKH.Text;
            string ten = tenKH.Text;
            string email = emailKH.Text;

            string query = "EXEC Net.dbo.themKH   '" + sdt + "',N'" + ten + "','" + email + "','" + idNV + "'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Đã thêm người chơi thành công");

            this.Close();
            thuNgan adminForm = Application.OpenForms["thuNgan"] as thuNgan;
            if (adminForm != null)
            {
                adminForm.loadKH(); // RefreshData là tên phương thức refresh hoặc load dữ liệu trên form Admin
            }
        }

        private void themNguoiChoi_Load(object sender, EventArgs e)
        {
            id.Text = idNV;
        }
    }
}
