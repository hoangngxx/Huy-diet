using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL
{
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sql = "select * from DangNhap where TenTK = '" + txtTenTK.Text + "' and MatKhau= '" + txtMatKhau.Text + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                FormQLTV f = new FormQLTV();
                f.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-KPTQ0N5E;Initial Catalog=QLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void txtTenTK_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
