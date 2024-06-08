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

namespace ISAD
{
    public partial class Form2 : Form
    {
        SqlCommand com;
        SqlDataAdapter dap;
        DataTable dt;
        public Form2()
        {
            db.myConnection();
            InitializeComponent();
            LoadData();
        }

        A1Y3 db = new A1Y3();

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            dgPro.DataSource = null;

            com = new SqlCommand("getPro", db.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgPro.DataSource = dt;
        }
        public void OnChange(object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgPro.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("SPro_Name", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pn", (txtPro.Text).ToString());

            dap = new SqlDataAdapter();
            dap.SelectCommand = com;
            dt = new DataTable();
            dap.Fill(dt);

            dgPro.DataSource = dt;
            txtCode.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult yn;
            yn = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yn == DialogResult.Yes)
            {
                com = new SqlCommand("DelProA1", db.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@pid", txtCode.Text);
                com.ExecuteNonQuery();
                com.Dispose();
            }
            txtCode.Clear();
            txtPro.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("InsProA1", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pn", txtPro.Text);
            com.Parameters.Add("@pid", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();

            int pid = int.Parse(com.Parameters["@pid"].Value.ToString());
            MessageBox.Show("New Product's ID: " + pid);

            com.Dispose();
            txtPro.Clear();
            txtCode.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("UpProA1", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pid", int.Parse(txtCode.Text));
            com.Parameters.AddWithValue("@pn", txtPro.Text);
            com.ExecuteNonQuery();
            com.Dispose();
            MessageBox.Show("Your product have been updated...");
            txtCode.Clear();
        }

        private void dgPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (dgPro.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                    return;


                DataGridViewRow row = dgPro.Rows[idx];
                txtCode.Text = row.Cells[0].Value.ToString();
                txtPro.Text = row.Cells[1].Value.ToString();

                txtCode.ReadOnly = true;

            }
        }
    }
}
