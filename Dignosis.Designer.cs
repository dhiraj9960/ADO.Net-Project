namespace HospitalManagement
{
    partial class Dignosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dignosis));
            this.lbldignoid = new System.Windows.Forms.Label();
            this.txtdiagnoid = new System.Windows.Forms.TextBox();
            this.lblptid = new System.Windows.Forms.Label();
            this.txtptname = new System.Windows.Forms.TextBox();
            this.lblpname = new System.Windows.Forms.Label();
            this.txtsymptons = new System.Windows.Forms.TextBox();
            this.lblsymp = new System.Windows.Forms.Label();
            this.txtdiagnotest = new System.Windows.Forms.TextBox();
            this.lbldgtest = new System.Windows.Forms.Label();
            this.txtmedicine = new System.Windows.Forms.TextBox();
            this.LBLMEDICINE = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.grddianosis = new System.Windows.Forms.DataGridView();
            this.DiagnosisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbptid = new System.Windows.Forms.ComboBox();
            this.btcsearch = new System.Windows.Forms.Button();
            this.lbldiago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grddianosis)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldignoid
            // 
            this.lbldignoid.AutoSize = true;
            this.lbldignoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldignoid.Location = new System.Drawing.Point(32, 101);
            this.lbldignoid.Name = "lbldignoid";
            this.lbldignoid.Size = new System.Drawing.Size(119, 18);
            this.lbldignoid.TabIndex = 0;
            this.lbldignoid.Text = "DIAGNOSIS ID";
            // 
            // txtdiagnoid
            // 
            this.txtdiagnoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagnoid.Location = new System.Drawing.Point(197, 102);
            this.txtdiagnoid.Name = "txtdiagnoid";
            this.txtdiagnoid.Size = new System.Drawing.Size(100, 22);
            this.txtdiagnoid.TabIndex = 1;
            // 
            // lblptid
            // 
            this.lblptid.AutoSize = true;
            this.lblptid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblptid.Location = new System.Drawing.Point(32, 144);
            this.lblptid.Name = "lblptid";
            this.lblptid.Size = new System.Drawing.Size(97, 18);
            this.lblptid.TabIndex = 2;
            this.lblptid.Text = "PATIENT ID";
            // 
            // txtptname
            // 
            this.txtptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtptname.Location = new System.Drawing.Point(197, 191);
            this.txtptname.Name = "txtptname";
            this.txtptname.Size = new System.Drawing.Size(100, 22);
            this.txtptname.TabIndex = 5;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.Location = new System.Drawing.Point(32, 190);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(128, 18);
            this.lblpname.TabIndex = 4;
            this.lblpname.Text = "PATIENT NAME";
            // 
            // txtsymptons
            // 
            this.txtsymptons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsymptons.Location = new System.Drawing.Point(581, 99);
            this.txtsymptons.Name = "txtsymptons";
            this.txtsymptons.Size = new System.Drawing.Size(100, 22);
            this.txtsymptons.TabIndex = 7;
            // 
            // lblsymp
            // 
            this.lblsymp.AutoSize = true;
            this.lblsymp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsymp.Location = new System.Drawing.Point(416, 98);
            this.lblsymp.Name = "lblsymp";
            this.lblsymp.Size = new System.Drawing.Size(100, 18);
            this.lblsymp.TabIndex = 6;
            this.lblsymp.Text = "SYMPTONS";
            // 
            // txtdiagnotest
            // 
            this.txtdiagnotest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagnotest.Location = new System.Drawing.Point(581, 145);
            this.txtdiagnotest.Name = "txtdiagnotest";
            this.txtdiagnotest.Size = new System.Drawing.Size(100, 22);
            this.txtdiagnotest.TabIndex = 9;
            // 
            // lbldgtest
            // 
            this.lbldgtest.AutoSize = true;
            this.lbldgtest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldgtest.Location = new System.Drawing.Point(416, 144);
            this.lbldgtest.Name = "lbldgtest";
            this.lbldgtest.Size = new System.Drawing.Size(145, 18);
            this.lbldgtest.TabIndex = 8;
            this.lbldgtest.Text = "DIAGNOSIS TEST";
            // 
            // txtmedicine
            // 
            this.txtmedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedicine.Location = new System.Drawing.Point(581, 196);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Size = new System.Drawing.Size(100, 22);
            this.txtmedicine.TabIndex = 11;
            // 
            // LBLMEDICINE
            // 
            this.LBLMEDICINE.AutoSize = true;
            this.LBLMEDICINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMEDICINE.Location = new System.Drawing.Point(416, 195);
            this.LBLMEDICINE.Name = "LBLMEDICINE";
            this.LBLMEDICINE.Size = new System.Drawing.Size(88, 18);
            this.LBLMEDICINE.TabIndex = 10;
            this.LBLMEDICINE.Text = "MEDICINE";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(155, 248);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(273, 248);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(398, 248);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(530, 248);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 23);
            this.btnhome.TabIndex = 15;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // grddianosis
            // 
            this.grddianosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddianosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiagnosisID,
            this.PatientID,
            this.PatientName,
            this.Symptoms,
            this.DiagnosisTest,
            this.Medicine});
            this.grddianosis.Location = new System.Drawing.Point(35, 293);
            this.grddianosis.Name = "grddianosis";
            this.grddianosis.Size = new System.Drawing.Size(640, 239);
            this.grddianosis.TabIndex = 16;
            this.grddianosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddianosis_CellContentClick);
            // 
            // DiagnosisID
            // 
            this.DiagnosisID.HeaderText = "DiagnosisID";
            this.DiagnosisID.Name = "DiagnosisID";
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "PatientName";
            this.PatientName.Name = "PatientName";
            // 
            // Symptoms
            // 
            this.Symptoms.HeaderText = "Symptoms";
            this.Symptoms.Name = "Symptoms";
            // 
            // DiagnosisTest
            // 
            this.DiagnosisTest.HeaderText = "DiagnosisTest";
            this.DiagnosisTest.Name = "DiagnosisTest";
            // 
            // Medicine
            // 
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.Name = "Medicine";
            // 
            // cmbptid
            // 
            this.cmbptid.FormattingEnabled = true;
            this.cmbptid.Location = new System.Drawing.Point(197, 145);
            this.cmbptid.Name = "cmbptid";
            this.cmbptid.Size = new System.Drawing.Size(121, 21);
            this.cmbptid.TabIndex = 17;
            this.cmbptid.SelectionChangeCommitted += new System.EventHandler(this.cmbptid_SelectionChangeCommitted);
            // 
            // btcsearch
            // 
            this.btcsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcsearch.Location = new System.Drawing.Point(642, 34);
            this.btcsearch.Name = "btcsearch";
            this.btcsearch.Size = new System.Drawing.Size(106, 24);
            this.btcsearch.TabIndex = 18;
            this.btcsearch.Text = "SEARCH";
            this.btcsearch.UseVisualStyleBackColor = true;
            this.btcsearch.Click += new System.EventHandler(this.btcsearch_Click);
            // 
            // lbldiago
            // 
            this.lbldiago.AutoSize = true;
            this.lbldiago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiago.Location = new System.Drawing.Point(304, 32);
            this.lbldiago.Name = "lbldiago";
            this.lbldiago.Size = new System.Drawing.Size(169, 24);
            this.lbldiago.TabIndex = 19;
            this.lbldiago.Text = "Diagnosis Report";
            // 
            // Dignosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 645);
            this.Controls.Add(this.lbldiago);
            this.Controls.Add(this.btcsearch);
            this.Controls.Add(this.cmbptid);
            this.Controls.Add(this.grddianosis);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtmedicine);
            this.Controls.Add(this.LBLMEDICINE);
            this.Controls.Add(this.txtdiagnotest);
            this.Controls.Add(this.lbldgtest);
            this.Controls.Add(this.txtsymptons);
            this.Controls.Add(this.lblsymp);
            this.Controls.Add(this.txtptname);
            this.Controls.Add(this.lblpname);
            this.Controls.Add(this.lblptid);
            this.Controls.Add(this.txtdiagnoid);
            this.Controls.Add(this.lbldignoid);
            this.Name = "Dignosis";
            this.Text = "Dignosis";
            this.Load += new System.EventHandler(this.Dignosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddianosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldignoid;
        private System.Windows.Forms.TextBox txtdiagnoid;
        private System.Windows.Forms.Label lblptid;
        private System.Windows.Forms.TextBox txtptname;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.TextBox txtsymptons;
        private System.Windows.Forms.Label lblsymp;
        private System.Windows.Forms.TextBox txtdiagnotest;
        private System.Windows.Forms.Label lbldgtest;
        private System.Windows.Forms.TextBox txtmedicine;
        private System.Windows.Forms.Label LBLMEDICINE;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.DataGridView grddianosis;
        private System.Windows.Forms.ComboBox cmbptid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symptoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.Button btcsearch;
        private System.Windows.Forms.Label lbldiago;
    }
}