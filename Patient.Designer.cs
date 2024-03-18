namespace HospitalManagement
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.lblptid = new System.Windows.Forms.Label();
            this.txtptid = new System.Windows.Forms.TextBox();
            this.txtptname = new System.Windows.Forms.TextBox();
            this.lblptname = new System.Windows.Forms.Label();
            this.txtptaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtptage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.lblphnumber = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblbdgrp = new System.Windows.Forms.Label();
            this.txtsymp = new System.Windows.Forms.TextBox();
            this.lblsymp = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.cmbblood = new System.Windows.Forms.ComboBox();
            this.lblrecord = new System.Windows.Forms.Label();
            this.grdpatient = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdpatient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblptid
            // 
            this.lblptid.AutoSize = true;
            this.lblptid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblptid.Location = new System.Drawing.Point(26, 73);
            this.lblptid.Name = "lblptid";
            this.lblptid.Size = new System.Drawing.Size(91, 16);
            this.lblptid.TabIndex = 0;
            this.lblptid.Text = "PATIENT ID";
            // 
            // txtptid
            // 
            this.txtptid.Location = new System.Drawing.Point(148, 73);
            this.txtptid.Name = "txtptid";
            this.txtptid.Size = new System.Drawing.Size(100, 20);
            this.txtptid.TabIndex = 1;
            // 
            // txtptname
            // 
            this.txtptname.Location = new System.Drawing.Point(148, 122);
            this.txtptname.Name = "txtptname";
            this.txtptname.Size = new System.Drawing.Size(100, 20);
            this.txtptname.TabIndex = 3;
            // 
            // lblptname
            // 
            this.lblptname.AutoSize = true;
            this.lblptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblptname.Location = new System.Drawing.Point(26, 125);
            this.lblptname.Name = "lblptname";
            this.lblptname.Size = new System.Drawing.Size(119, 16);
            this.lblptname.TabIndex = 2;
            this.lblptname.Text = "PATIENT NAME";
            // 
            // txtptaddress
            // 
            this.txtptaddress.Location = new System.Drawing.Point(148, 172);
            this.txtptaddress.Name = "txtptaddress";
            this.txtptaddress.Size = new System.Drawing.Size(100, 20);
            this.txtptaddress.TabIndex = 5;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(26, 178);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(80, 16);
            this.lbladdress.TabIndex = 4;
            this.lbladdress.Text = "ADDRESS";
            // 
            // txtptage
            // 
            this.txtptage.Location = new System.Drawing.Point(148, 225);
            this.txtptage.Name = "txtptage";
            this.txtptage.Size = new System.Drawing.Size(100, 20);
            this.txtptage.TabIndex = 7;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(26, 229);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(38, 16);
            this.lblage.TabIndex = 6;
            this.lblage.Text = "AGE";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(505, 72);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 20);
            this.txtnumber.TabIndex = 9;
            // 
            // lblphnumber
            // 
            this.lblphnumber.AutoSize = true;
            this.lblphnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphnumber.Location = new System.Drawing.Point(362, 73);
            this.lblphnumber.Name = "lblphnumber";
            this.lblphnumber.Size = new System.Drawing.Size(129, 16);
            this.lblphnumber.TabIndex = 8;
            this.lblphnumber.Text = "PHONE NUMBER";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(371, 122);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(71, 16);
            this.lblgender.TabIndex = 10;
            this.lblgender.Text = "GENDER";
            // 
            // lblbdgrp
            // 
            this.lblbdgrp.AutoSize = true;
            this.lblbdgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbdgrp.Location = new System.Drawing.Point(371, 172);
            this.lblbdgrp.Name = "lblbdgrp";
            this.lblbdgrp.Size = new System.Drawing.Size(112, 16);
            this.lblbdgrp.TabIndex = 12;
            this.lblbdgrp.Text = "BLOODGROUP";
            // 
            // txtsymp
            // 
            this.txtsymp.Location = new System.Drawing.Point(505, 211);
            this.txtsymp.Name = "txtsymp";
            this.txtsymp.Size = new System.Drawing.Size(100, 20);
            this.txtsymp.TabIndex = 15;
            // 
            // lblsymp
            // 
            this.lblsymp.AutoSize = true;
            this.lblsymp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblsymp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsymp.Location = new System.Drawing.Point(371, 215);
            this.lblsymp.Name = "lblsymp";
            this.lblsymp.Size = new System.Drawing.Size(92, 16);
            this.lblsymp.TabIndex = 14;
            this.lblsymp.Text = "SYMPTOMS";
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(670, 62);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(670, 115);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(670, 165);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(670, 219);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 23);
            this.btnhome.TabIndex = 19;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Location = new System.Drawing.Point(505, 116);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(121, 21);
            this.cmbgender.TabIndex = 20;
            // 
            // cmbblood
            // 
            this.cmbblood.FormattingEnabled = true;
            this.cmbblood.Location = new System.Drawing.Point(505, 168);
            this.cmbblood.Name = "cmbblood";
            this.cmbblood.Size = new System.Drawing.Size(121, 21);
            this.cmbblood.TabIndex = 21;
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecord.ForeColor = System.Drawing.Color.Red;
            this.lblrecord.Location = new System.Drawing.Point(304, 32);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(163, 20);
            this.lblrecord.TabIndex = 22;
            this.lblrecord.Text = "PATIENT RECORD";
            // 
            // grdpatient
            // 
            this.grdpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdpatient.Location = new System.Drawing.Point(70, 296);
            this.grdpatient.Name = "grdpatient";
            this.grdpatient.Size = new System.Drawing.Size(660, 150);
            this.grdpatient.TabIndex = 23;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(680, 13);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(83, 30);
            this.btnsearch.TabIndex = 24;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.grdpatient);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.cmbblood);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtsymp);
            this.Controls.Add(this.lblsymp);
            this.Controls.Add(this.lblbdgrp);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.lblphnumber);
            this.Controls.Add(this.txtptage);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.txtptaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtptname);
            this.Controls.Add(this.lblptname);
            this.Controls.Add(this.txtptid);
            this.Controls.Add(this.lblptid);
            this.Name = "Patient";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.grdpatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblptid;
        private System.Windows.Forms.TextBox txtptid;
        private System.Windows.Forms.TextBox txtptname;
        private System.Windows.Forms.Label lblptname;
        private System.Windows.Forms.TextBox txtptaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtptage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label lblphnumber;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblbdgrp;
        private System.Windows.Forms.TextBox txtsymp;
        private System.Windows.Forms.Label lblsymp;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.ComboBox cmbblood;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.DataGridView grdpatient;
        private System.Windows.Forms.Button btnsearch;
    }
}