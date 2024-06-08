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
    public partial class Form3 : Form
    {
        SqlCommand com;
        SqlDataAdapter dap;
        DataTable dt;
        public Form3()
        {
            db.myConnection();
            InitializeComponent();
            LoadData();
        }
        A1Y3 db = new A1Y3();
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            dgSup.DataSource = null;

            com = new SqlCommand("getSup", db.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgSup.DataSource = dt;
        }
        public void OnChange(object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgSup.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("SSup_Name", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sn", (txtSup.Text).ToString());

            dap = new SqlDataAdapter();
            dap.SelectCommand = com;
            dt = new DataTable();
            dap.Fill(dt);

            dgSup.DataSource = dt;
            txtID.Clear();
            txtAdd.Clear();
            txtCon.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult yn;
            yn = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yn == DialogResult.Yes)
            {
                com = new SqlCommand("DelSupA1", db.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@sid", txtID.Text);
                com.ExecuteNonQuery();
                com.Dispose();
            }
            txtID.Clear();
            txtSup.Clear();
            txtAdd.Clear();
            txtCon.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("InsSupA1", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sn", txtSup.Text);
            com.Parameters.AddWithValue("@sadd", txtAdd.Text);
            com.Parameters.AddWithValue("@scon", txtCon.Text);
            com.Parameters.Add("@sid", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();

            int sid = int.Parse(com.Parameters["@sid"].Value.ToString());
            MessageBox.Show("New Supplier's ID: " + sid);

            com.Dispose();
            txtSup.Clear();
            txtCon.Clear();
            txtAdd.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("UpSupA1", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sid", int.Parse(txtID.Text));
            com.Parameters.AddWithValue("@sn", txtSup.Text);
            com.Parameters.AddWithValue("@sadd", txtAdd.Text);
            com.Parameters.AddWithValue("@scon", txtCon.Text);
            com.ExecuteNonQuery();
            com.Dispose();
            MessageBox.Show("Your supplier have been updated...");
            txtID.Clear();
        }

        private void dgSup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (dgSup.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                    return;

                DataGridViewRow row = dgSup.Rows[idx];
                txtID.Text = row.Cells[0].Value.ToString();
                txtSup.Text = row.Cells[1].Value.ToString();
                txtAdd.Text = row.Cells[2].Value.ToString();
                txtCon.Text = row.Cells[3].Value.ToString();

                txtID.ReadOnly = true;

            }
        }
    }
}
