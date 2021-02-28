namespace BSCS181041
{
    partial class frmOrderedparts
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
            this.txtoerderid = new System.Windows.Forms.TextBox();
            this.txtpartname = new System.Windows.Forms.TextBox();
            this.txtcarname = new System.Windows.Forms.TextBox();
            this.txtrequirednumber = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtpartid = new System.Windows.Forms.TextBox();
            this.txtcompanyid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtoerderid
            // 
            this.txtoerderid.Location = new System.Drawing.Point(194, 12);
            this.txtoerderid.Name = "txtoerderid";
            this.txtoerderid.Size = new System.Drawing.Size(170, 20);
            this.txtoerderid.TabIndex = 0;
            // 
            // txtpartname
            // 
            this.txtpartname.Location = new System.Drawing.Point(194, 38);
            this.txtpartname.Name = "txtpartname";
            this.txtpartname.Size = new System.Drawing.Size(170, 20);
            this.txtpartname.TabIndex = 1;
            // 
            // txtcarname
            // 
            this.txtcarname.Location = new System.Drawing.Point(194, 64);
            this.txtcarname.Name = "txtcarname";
            this.txtcarname.Size = new System.Drawing.Size(170, 20);
            this.txtcarname.TabIndex = 2;
            // 
            // txtrequirednumber
            // 
            this.txtrequirednumber.Location = new System.Drawing.Point(194, 90);
            this.txtrequirednumber.Name = "txtrequirednumber";
            this.txtrequirednumber.Size = new System.Drawing.Size(170, 20);
            this.txtrequirednumber.TabIndex = 3;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(194, 116);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(170, 20);
            this.txtdate.TabIndex = 4;
            // 
            // txtpartid
            // 
            this.txtpartid.Location = new System.Drawing.Point(194, 142);
            this.txtpartid.Name = "txtpartid";
            this.txtpartid.Size = new System.Drawing.Size(170, 20);
            this.txtpartid.TabIndex = 5;
            // 
            // txtcompanyid
            // 
            this.txtcompanyid.Location = new System.Drawing.Point(194, 168);
            this.txtcompanyid.Name = "txtcompanyid";
            this.txtcompanyid.Size = new System.Drawing.Size(170, 20);
            this.txtcompanyid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(89, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(89, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "part name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(89, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "car name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(89, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "required number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(89, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(89, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "part id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(89, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "company id";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btninsert.Location = new System.Drawing.Point(70, 232);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 14;
            this.btninsert.Text = "insert";
            this.btninsert.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.Location = new System.Drawing.Point(173, 232);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.Location = new System.Drawing.Point(280, 232);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 16;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnview.Location = new System.Drawing.Point(387, 232);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 17;
            this.btnview.Text = "view";
            this.btnview.UseVisualStyleBackColor = false;
            // 
            // frmOrderedparts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BSCS181041.Properties.Resources.hakon_sataoen_qyfco1nfMtg_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 305);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcompanyid);
            this.Controls.Add(this.txtpartid);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtrequirednumber);
            this.Controls.Add(this.txtcarname);
            this.Controls.Add(this.txtpartname);
            this.Controls.Add(this.txtoerderid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrderedparts";
            this.Text = "Ordered parts";
            this.Load += new System.EventHandler(this.frmOrderedparts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoerderid;
        private System.Windows.Forms.TextBox txtpartname;
        private System.Windows.Forms.TextBox txtcarname;
        private System.Windows.Forms.TextBox txtrequirednumber;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtpartid;
        private System.Windows.Forms.TextBox txtcompanyid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnview;
    }
}