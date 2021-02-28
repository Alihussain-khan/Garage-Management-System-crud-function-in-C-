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


namespace BSCS181041
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            string strcmd = "insert into Client values(@cid, @cname, @cadress, @cphone, @carid)";
            SqlConnection sqlConn = new SqlConnection(strCon);
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlConn);
            int CId, Cphone,Car_ID;
            string cName, cAdress;
            CId = Convert.ToInt32(txtClient.Text);
            Cphone = Convert.ToInt32(txtphone.Text);
            cName = txtName.Text;
            cAdress = txtAdress.Text;
            Car_ID = Convert.ToInt32(txt_Carid.Text);

            sqlcmd.Parameters.AddWithValue("@cid", CId);
            sqlcmd.Parameters.AddWithValue("@cphone", Cphone);
            sqlcmd.Parameters.AddWithValue("@cname", cName);
            sqlcmd.Parameters.AddWithValue("@cadress", cAdress);
            sqlcmd.Parameters.AddWithValue("@carid", Car_ID);


            try
            {
                sqlConn.Open();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("values has been entered");
            }
            catch (Exception exp)
            {
                MessageBox.Show("some exeption has occured " + exp.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
