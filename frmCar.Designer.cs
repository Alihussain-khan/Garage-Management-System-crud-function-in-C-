namespace BSCS181041
{
    partial class frmCar
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
            this.txt_Carid = new System.Windows.Forms.TextBox();
            this.txt_Clientid = new System.Windows.Forms.TextBox();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Carid
            // 
            this.txt_Carid.Location = new System.Drawing.Point(164, 36);
            this.txt_Carid.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Carid.Name = "txt_Carid";
            this.txt_Carid.Size = new System.Drawing.Size(246, 26);
            this.txt_Carid.TabIndex = 0;
            this.txt_Carid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Clientid
            // 
            this.txt_Clientid.Location = new System.Drawing.Point(164, 154);
            this.txt_Clientid.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Clientid.Name = "txt_Clientid";
            this.txt_Clientid.Size = new System.Drawing.Size(246, 26);
            this.txt_Clientid.TabIndex = 1;
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(164, 96);
            this.txtMode.Margin = new System.Windows.Forms.Padding(5);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(246, 26);
            this.txtMode.TabIndex = 2;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lable1.Location = new System.Drawing.Point(23, 36);
            this.lable1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(61, 20);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "Car ID";
            this.lable1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(23, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client ID";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.Location = new System.Drawing.Point(14, 245);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 35);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.Location = new System.Drawing.Point(336, 245);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(125, 35);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "detele";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.Location = new System.Drawing.Point(172, 245);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(125, 35);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnview.Location = new System.Drawing.Point(500, 245);
            this.btnview.Margin = new System.Windows.Forms.Padding(5);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(125, 35);
            this.btnview.TabIndex = 9;
            this.btnview.Text = "view";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // frmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BSCS181041.Properties.Resources.hakon_sataoen_qyfco1nfMtg_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 305);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.txt_Clientid);
            this.Controls.Add(this.txt_Carid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCar";
            this.Text = "Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Carid;
        private System.Windows.Forms.TextBox txt_Clientid;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnview;
    }
}