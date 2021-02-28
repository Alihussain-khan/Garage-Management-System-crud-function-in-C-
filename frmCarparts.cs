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
    public partial class frmCarparts : Form
    {
        public frmCarparts()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            string strcmd = "insert into CarParts values(@Pid, @Pname, @Pcar, @number)";
            SqlConnection sqlConn = new SqlConnection(strCon);
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlConn);
            int gId, number;
            string PName, Pcar;
            gId = Convert.ToInt32(txtpartid.Text);
            number = Convert.ToInt32(txtavailibility.Text);
            PName = txtpartname.Text;
            Pcar = txtcarpart.Text;

            sqlcmd.Parameters.AddWithValue("@Pid", gId);
            sqlcmd.Parameters.AddWithValue("@number", number);
            sqlcmd.Parameters.AddWithValue("@Pname", PName);
            sqlcmd.Parameters.AddWithValue("@Pcar", Pcar);

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
            string strcmd = "delete from CarParts where Part_Id=@id";
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);
            int id;
            id = Convert.ToInt32(txtpartid.Text);
            sqlcmd.Parameters.AddWithValue("@id", id);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALI\source\repos\BSCS181041\Database1.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(strconn);
            string strcmd = "update CarParts set Part_Name=@name, Part_car=@adress, Availibility_Number=@Phone where Part_Id=@id";
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);

            int gid, gphone;
            string name, adress;

            gid = Convert.ToInt32(txtpartid.Text);
            gphone = Convert.ToInt32(txtavailibility.Text);
            name = txtpartname.Text;
            adress = txtcarpart.Text;


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
            string strcmd = "select * from CarParts where Part_Id=@id";
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);
            int id;

            id = Convert.ToInt32(txtpartid.Text);
            sqlcmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr;
            sqlconn.Open();
            dr = sqlcmd.ExecuteReader();

            if (dr.Read())
            {
                txtpartid.Text = dr[0].ToString();
                txtpartname.Text = dr[1].ToString();
                txtcarpart.Text = dr[2].ToString();
                txtavailibility.Text = dr[3].ToString();
            }
        }

        private void frmCarparts_Load(object sender, EventArgs e)
        {

        }
    }
}
