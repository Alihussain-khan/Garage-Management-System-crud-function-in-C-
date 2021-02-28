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

namespace BSCS181041
{
    public partial class frmGarage : Form
    {
        public frmGarage()
        {
            InitializeComponent();
        }

        private void frmGarage_Load(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            string strcmd = "insert into Garage values(@gid, @gname, @gadress, @gphone)";
            SqlConnection sqlConn = new SqlConnection(strCon);
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlConn);
            int gId, Gphone;
            string gName, gAdress;
            gId = Convert.ToInt32(txtgarageid.Text);
            Gphone = Convert.ToInt32(txtgaragephone.Text);
            gName = txtgaragename.Text;
            gAdress = txtgarageadress.Text;

            sqlcmd.Parameters.AddWithValue("@gid", gId);
            sqlcmd.Parameters.AddWithValue("@gphone", Gphone);
            sqlcmd.Parameters.AddWithValue("@gname", gName);
            sqlcmd.Parameters.AddWithValue("@gadress", gAdress);

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(strconn);
            string strcmd = "delete from Garage where Garage_ID=@gid";
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);
            int id;
            id = Convert.ToInt32(txtgarageid.Text);
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(strconn);
            string strcmd = "update Garage set Garage_Name=@name, Garage_Adress=@adress, Garage_Phone=@Phone where Garage_ID=@id";
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);

            int gid, gphone;
            string name, adress;

            gid = Convert.ToInt32(txtgarageid.Text);
            gphone = Convert.ToInt32(txtgaragephone.Text);
            name = txtgaragename.Text;
            adress = txtgarageadress.Text;


            sqlcmd.Parameters.AddWithValue("@name", name);
            sqlcmd.Parameters.AddWithValue("@adress", adress);
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

        private void btnview_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(strconn);
            string strcmd = "select * from Garage where Garage_ID=@id";
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);
            int id;
            
            id = Convert.ToInt32(txtgarageid.Text);
            sqlcmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr;
            sqlconn.Open();
            dr = sqlcmd.ExecuteReader();

            if (dr.Read())
            {
                txtgarageid.Text = dr[0].ToString();
                txtgaragename.Text = dr[1].ToString();
                txtgarageadress.Text = dr[2].ToString();
                txtgaragephone.Text = dr[3].ToString();
            }
        }
    }
}