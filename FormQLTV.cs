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
    public partial class FormQLTV : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public FormQLTV()
        {
            InitializeComponent();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " Select Distinct " + comTenTruong.Text + " From Sach ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comTenTruong.Text;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            sql = "Select MaSach, TenSach, MaLoaiSach, SoLuong, MaTG from Sach "
                + " where " + comTenTruong.Text + "='" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void FormQLTV_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i == grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, 0];
            }
            else
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i - 1];
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i == 0)
            {
                grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, i - 1];
            }
            NapCT();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin f = new FormLogin();
            f.Show();
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaLoaiSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaTG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaSach.Text = grdData.Rows[i].Cells["MaSach"].Value.ToString();
            txtTenSach.Text = grdData.Rows[i].Cells["TenSach"].Value.ToString();
            txtMaLoaiSach.Text = grdData.Rows[i].Cells["MaLoaiSach"].Value.ToString();
            txtSoLuong.Text = grdData.Rows[i].Cells["SoLuong"].Value.ToString();
            txtMaTG.Text = grdData.Rows[i].Cells["MaTG"].Value.ToString();
        }
    }
}
