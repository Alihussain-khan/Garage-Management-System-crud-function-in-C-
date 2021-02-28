using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSCS181041
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void startFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void garageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGarage frmg = new frmGarage();
            frmg.MdiParent = this;
            frmg.Show();
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCar frmCar = new frmCar();
            frmCar.MdiParent=this;
            frmCar.Show();

        }

        private void carpartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarparts frmparts=new frmCarparts();
            frmparts.MdiParent = this;
            frmparts.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frmE = new frmEmployee();
            frmE.MdiParent = this;
            frmE.Show();
        }

        private void oderedpartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderedparts frmp = new frmOrderedparts();
            frmp.MdiParent = this;
            frmp.Show();
        }

        private void partSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpartsupplier frms = new frmpartsupplier();
            frms.MdiParent = this;
            frms.Show();
        }

        private void visitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisits frmv = new frmVisits();
            frmv.MdiParent = this;
            frmv.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient frml = new frmClient();
            frml.MdiParent = this;
            frml.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
