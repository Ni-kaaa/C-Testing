using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace ISAD
{
    public class A1Y3
    {
        public SqlConnection con;
        public static string conStr = "Data Source=.;Database=A1Y3G25; Integrated Security=true;";
        public void myConnection()
        {
            try
            {
                SqlDependency.Stop(conStr);
                SqlDependency.Start(conStr);

                con = new SqlConnection(conStr);
                con.Open();
            }
            catch (Exception e){
                MessageBox.Show(e.Message);
            }
        }
    }
}
