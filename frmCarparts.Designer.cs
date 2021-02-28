namespace BSCS181041
{
    partial class frmCarparts
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
            this.txtpartid = new System.Windows.Forms.TextBox();
            this.txtpartname = new System.Windows.Forms.TextBox();
            this.txtcarpart = new System.Windows.Forms.TextBox();
            this.txtavailibility = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpartid
            // 
            this.txtpartid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartid.Location = new System.Drawing.Point(204, 48);
            this.txtpartid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpartid.Name = "txtpartid";
            this.txtpartid.Size = new System.Drawing.Size(271, 22);
            this.txtpartid.TabIndex = 0;
            // 
            // txtpartname
            // 
            this.txtpartname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartname.Location = new System.Drawing.Point(204, 88);
            this.txtpartname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpartname.Name = "txtpartname";
            this.txtpartname.Size = new System.Drawing.Size(271, 22);
            this.txtpartname.TabIndex = 1;
            // 
            // txtcarpart
            // 
            this.txtcarpart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarpart.Location = new System.Drawing.Point(204, 128);
            this.txtcarpart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcarpart.Name = "txtcarpart";
            this.txtcarpart.Size = new System.Drawing.Size(271, 22);
            this.txtcarpart.TabIndex = 2;
            // 
            // txtavailibility
            // 
            this.txtavailibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtavailibility.Location = new System.Drawing.Point(204, 168);
            this.txtavailibility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtavailibility.Name = "txtavailibility";
            this.txtavailibility.Size = new System.Drawing.Size(271, 22);
            this.txtavailibility.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "part ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "part Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "car part";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "availiblity number";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btninsert.Location = new System.Drawing.Point(70, 224);
            this.btninsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(112, 35);
            this.btninsert.TabIndex = 12;
            this.btninsert.Text = "insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.Location = new System.Drawing.Point(204, 224);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 35);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.Location = new System.Drawing.Point(338, 224);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 35);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnview.Location = new System.Drawing.Point(472, 224);
            this.btnview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(112, 35);
            this.btnview.TabIndex = 15;
            this.btnview.Text = "view";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // frmCarparts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BSCS181041.Properties.Resources.hakon_sataoen_qyfco1nfMtg_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 305);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtavailibility);
            this.Controls.Add(this.txtcarpart);
            this.Controls.Add(this.txtpartname);
            this.Controls.Add(this.txtpartid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCarparts";
            this.Text = "Car parts";
            this.Load += new System.EventHandler(this.frmCarparts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpartid;
        private System.Windows.Forms.TextBox txtpartname;
        private System.Windows.Forms.TextBox txtcarpart;
        private System.Windows.Forms.TextBox txtavailibility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnview;
    }
}