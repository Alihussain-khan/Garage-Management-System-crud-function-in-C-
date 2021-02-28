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
    public partial class frmCar : Form
    {
        public frmCar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            string strcmd = "insert into Car values(@gid, @model, @ClientID)";
            SqlConnection sqlConn = new SqlConnection(strCon);
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlConn);
            int cId, ClientID;
            string model;
            cId = Convert.ToInt32(txt_Carid.Text);
            ClientID = Convert.ToInt32(txt_Clientid.Text);
            model= txtMode.Text;

            sqlcmd.Parameters.AddWithValue("@gid", cId);
            sqlcmd.Parameters.AddWithValue("@ClientID", ClientID);
            sqlcmd.Parameters.AddWithValue("@model", model);
            

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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(strconn);
            string strcmd = "update Car set Model=@name,  FK_Client_iD=@Phone where Car_Id=@id";
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);

            int gid, gphone;
            string name, adress;

            gid = Convert.ToInt32(txt_Carid.Text);
            gphone = Convert.ToInt32(txt_Clientid.Text);
            name = txtMode.Text;


            sqlcmd.Parameters.AddWithValue("@name", name);
            
            sqlcmd.Parameters.AddWithValue("@id", gid);
            sqlcmd.Parameters.AddWithValue("@Phone", gphone);

            try
            {
                sqlconn.Open();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("updated");
            }
            catch (Exception exp)
            {
                MessageBox.Show("error " + exp.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(strconn);
            string strcmd = "delete from Car where Car_Id=@gid";
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);
            int id;
            id = Convert.ToInt32(txt_Carid.Text);
            sqlcmd.Parameters.AddWithValue("@gid", id);
            try
            {
                sqlconn.Open();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("deleted");
            }
            catch (Exception exp)
            {
                MessageBox.Show("error " + exp.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(strconn);
            string strcmd = "select * from Car where Car_Id=@id";
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);
            int id;

            id = Convert.ToInt32(txt_Carid.Text);
            sqlcmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr;
            sqlconn.Open();
            dr = sqlcmd.ExecuteReader();

            if (dr.Read())
            {
                txt_Carid.Text = dr[0].ToString();
                txtMode.Text = dr[1].ToString();
                txt_Clientid.Text = dr[2].ToString();
                
            }
        }
    }
}
