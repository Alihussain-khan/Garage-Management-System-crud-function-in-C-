namespace BSCS181041
{
    partial class frmWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.garageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oderedpartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.garageToolStripMenuItem,
            this.carToolStripMenuItem,
            this.carpartsToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.oderedpartsToolStripMenuItem,
            this.partSupplierToolStripMenuItem,
            this.visitsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // garageToolStripMenuItem
            // 
            this.garageToolStripMenuItem.Name = "garageToolStripMenuItem";
            this.garageToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.garageToolStripMenuItem.Text = "Garage";
            this.garageToolStripMenuItem.Click += new System.EventHandler(this.garageToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.carToolStripMenuItem.Text = "Car";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // carpartsToolStripMenuItem
            // 
            this.carpartsToolStripMenuItem.Name = "carpartsToolStripMenuItem";
            this.carpartsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.carpartsToolStripMenuItem.Text = "Carparts";
            this.carpartsToolStripMenuItem.Click += new System.EventHandler(this.carpartsToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // oderedpartsToolStripMenuItem
            // 
            this.oderedpartsToolStripMenuItem.Name = "oderedpartsToolStripMenuItem";
            this.oderedpartsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.oderedpartsToolStripMenuItem.Text = "Odered parts";
            this.oderedpartsToolStripMenuItem.Click += new System.EventHandler(this.oderedpartsToolStripMenuItem_Click);
            // 
            // partSupplierToolStripMenuItem
            // 
            this.partSupplierToolStripMenuItem.Name = "partSupplierToolStripMenuItem";
            this.partSupplierToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.partSupplierToolStripMenuItem.Text = "part supplier";
            this.partSupplierToolStripMenuItem.Click += new System.EventHandler(this.partSupplierToolStripMenuItem_Click);
            // 
            // visitsToolStripMenuItem
            // 
            this.visitsToolStripMenuItem.Name = "visitsToolStripMenuItem";
            this.visitsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.visitsToolStripMenuItem.Text = "Visits";
            this.visitsToolStripMenuItem.Click += new System.EventHandler(this.visitsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 422);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWelcome";
            this.Text = "Garage Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem garageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carpartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oderedpartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

