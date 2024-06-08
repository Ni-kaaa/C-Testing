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

namespace ISAD
{
    public partial class Form4 : Form
    {
        SqlCommand com;
        SqlDataAdapter dap;
        DataTable dt;
        public Form4()
        {
            db.myConnection();
            InitializeComponent();
            LoadData();
        }

        A1Y3 db = new A1Y3();

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            dgStaff.DataSource = null;

            com = new SqlCommand("getStaff", db.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgStaff.DataSource = dt;
        }
        public void OnChange(object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgStaff.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("SSta_Name", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@stname", (txtStaff.Text).ToString());

            dap = new SqlDataAdapter();
            dap.SelectCommand = com;
            dt = new DataTable();
            dap.Fill(dt);

            dgStaff.DataSource = dt;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult yn;
            yn = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yn == DialogResult.Yes)
            {
                com = new SqlCommand("DelStaA1", db.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@stid", txtID.Text);
                com.ExecuteNonQuery();
                com.Dispose();
            }
            txtID.Clear();
            txtStaff.Clear();
            txtPos.Clear();
            txtSal.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("InsStaA1", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@stid", int.Parse(txtID.Text));
            com.Parameters.AddWithValue("@stname", txtStaff.Text);
            if (rdbF.Checked == true)
                com.Parameters.AddWithValue("@stgen", 'F');
            else
                com.Parameters.AddWithValue("@stgen", 'M');
            com.Parameters.AddWithValue("@stdob", dtp.Value);
            com.Parameters.AddWithValue("@stpos", txtPos.Text);
            com.Parameters.AddWithValue("@stsal", decimal.Parse(txtSal.Text));
            com.Parameters.AddWithValue("@ststo", 0);

            com.ExecuteNonQuery();

            int stid = int.Parse(com.Parameters["@stid"].Value.ToString());
            MessageBox.Show("New Staff's ID: " + stid);

            com.Dispose();
            txtID.Clear();
            txtStaff.Clear();
            txtPos.Clear();
            txtSal.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("UpStaA1", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@stid", int.Parse(txtID.Text));
            com.Parameters.AddWithValue("@stname", txtStaff.Text);
            if (rdbF.Checked == true)
                com.Parameters.AddWithValue("@stgen", 'F');
            else
                com.Parameters.AddWithValue("@stgen", 'M');
            com.Parameters.AddWithValue("@stdob", dtp.Value);
            com.Parameters.AddWithValue("@stpos", txtPos.Text);
            com.Parameters.AddWithValue("@stsal", decimal.Parse(txtSal.Text));
            if (ckb.Checked == true)
                com.Parameters.AddWithValue("@ststo", 1);
            else
                com.Parameters.AddWithValue("@ststo", 0);
            com.ExecuteNonQuery();
            com.Dispose();
            MessageBox.Show("Your staff's info have been updated...");
        }

        private void dgStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (dgStaff.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                    return;

                DataGridViewRow row = dgStaff.Rows[idx];
                txtID.Text = row.Cells[0].Value.ToString();
                txtStaff.Text = row.Cells[1].Value.ToString();
                if (rdbF.Checked == true)
                    rdbF.Text = row.Cells[2].Value.ToString();
                else
                    rdbM.Text = row.Cells[2].Value.ToString();
                dtp.Text = row.Cells[3].Value.ToString();
                txtPos.Text = row.Cells[4].Value.ToString();
                txtSal.Text = row.Cells[5].Value.ToString();
                ckb.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
