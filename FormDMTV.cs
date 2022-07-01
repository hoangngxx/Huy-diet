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
    public partial class FormDMTV : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public FormDMTV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-KPTQ0N5E;Initial Catalog=QLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "Select MaSach,TenSach, MaLoaiSach, SoLuong, MaTG from Sach";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
