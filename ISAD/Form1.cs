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
    public partial class Form1 : Form
    {
        SqlCommand com;
        SqlDataAdapter dap;
        DataTable dt;
        public Form1()
        {
            db.myConnection();
            InitializeComponent();
            LoadData();
        }
        A1Y3 db = new A1Y3();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            dgCus.DataSource = null;

            com = new SqlCommand("getCus", db.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgCus.DataSource = dt;
        }
        public void OnChange(object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgCus.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("Scus_Name", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", (txtCus.Text).ToString());

            dap = new SqlDataAdapter();
            dap.SelectCommand = com;
            dt = new DataTable();
            dap.Fill(dt);

            dgCus.DataSource = dt;
            txtID.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult yn;
            yn = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yn == DialogResult.Yes)
            {
                com = new SqlCommand("DelCusA1", db.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", txtID.Text);
                com.ExecuteNonQuery();
                com.Dispose();
            }
            txtID.Clear();
            txtCus.Clear();
            txtCon.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("InsCusA1", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@cn", txtCus.Text);
            com.Parameters.AddWithValue("@cCon", txtCon.Text);
            com.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();

            int cid = int.Parse(com.Parameters["@id"].Value.ToString());
            MessageBox.Show("New Customer's ID: " + cid);

            com.Dispose();
            txtCus.Clear();
            txtID.Clear();
            txtCon.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("UpCusA1", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
            com.Parameters.AddWithValue("@cn", txtCus.Text);
            com.Parameters.AddWithValue("@cCon", txtCon.Text);
            com.ExecuteNonQuery();
            com.Dispose();
            MessageBox.Show("Your data have been updated...");
            txtID.Clear();
            txtCus.Clear();
            txtCon.Clear();
        }

        private void dgCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (dgCus.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                    return;

                DataGridViewRow row = dgCus.Rows[idx];
                txtID.Text = row.Cells[0].Value.ToString();
                txtCus.Text = row.Cells[1].Value.ToString();
                txtCon.Text = row.Cells[2].Value.ToString();

                txtID.ReadOnly = true;

            }
        }

    }
}