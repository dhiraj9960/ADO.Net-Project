namespace HospitalManagement
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lbldcname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblexper = new System.Windows.Forms.Label();
            this.lbllicen = new System.Windows.Forms.Label();
            this.txtdocid = new System.Windows.Forms.TextBox();
            this.txtdocname = new System.Windows.Forms.TextBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.txtlicence = new System.Windows.Forms.TextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.grddoctor = new System.Windows.Forms.DataGridView();
            this.tbldoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet1 = new HospitalManagement.hospitalDataSet1();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnedelete = new System.Windows.Forms.Button();
            this.btndash = new System.Windows.Forms.Button();
            this.tbl_doctorTableAdapter = new HospitalManagement.hospitalDataSet1TableAdapters.tbl_doctorTableAdapter();
            this.doctoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenscenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lbldocrecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grddoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctor.Location = new System.Drawing.Point(12, 68);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(81, 18);
            this.lbldoctor.TabIndex = 0;
            this.lbldoctor.Text = "Doctor ID";
            // 
            // lbldcname
            // 
            this.lbldcname.AutoSize = true;
            this.lbldcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldcname.Location = new System.Drawing.Point(122, 68);
            this.lbldcname.Name = "lbldcname";
            this.lbldcname.Size = new System.Drawing.Size(109, 18);
            this.lbldcname.TabIndex = 1;
            this.lbldcname.Text = "Doctor Name";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(264, 68);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(120, 18);
            this.lblgender.TabIndex = 2;
            this.lblgender.Text = "Doctor Gender";
            // 
            // lblexper
            // 
            this.lblexper.AutoSize = true;
            this.lblexper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexper.Location = new System.Drawing.Point(399, 68);
            this.lblexper.Name = "lblexper";
            this.lblexper.Size = new System.Drawing.Size(159, 18);
            this.lblexper.TabIndex = 3;
            this.lblexper.Text = "Years of Experience";
            // 
            // lbllicen
            // 
            this.lbllicen.AutoSize = true;
            this.lbllicen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllicen.Location = new System.Drawing.Point(586, 68);
            this.lbllicen.Name = "lbllicen";
            this.lbllicen.Size = new System.Drawing.Size(202, 18);
            this.lbllicen.TabIndex = 4;
            this.lbllicen.Text = "Medical Licensce Number";
            // 
            // txtdocid
            // 
            this.txtdocid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocid.Location = new System.Drawing.Point(15, 101);
            this.txtdocid.Name = "txtdocid";
            this.txtdocid.Size = new System.Drawing.Size(86, 22);
            this.txtdocid.TabIndex = 5;
            // 
            // txtdocname
            // 
            this.txtdocname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocname.Location = new System.Drawing.Point(131, 101);
            this.txtdocname.Name = "txtdocname";
            this.txtdocname.Size = new System.Drawing.Size(100, 22);
            this.txtdocname.TabIndex = 6;
            // 
            // txtexperience
            // 
            this.txtexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexperience.Location = new System.Drawing.Point(427, 101);
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(100, 22);
            this.txtexperience.TabIndex = 7;
            // 
            // txtlicence
            // 
            this.txtlicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlicence.Location = new System.Drawing.Point(623, 101);
            this.txtlicence.Name = "txtlicence";
            this.txtlicence.Size = new System.Drawing.Size(100, 22);
            this.txtlicence.TabIndex = 8;
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(280, 101);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(121, 24);
            this.cmbgender.TabIndex = 9;
            // 
            // grddoctor
            // 
            this.grddoctor.AutoGenerateColumns = false;
            this.grddoctor.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grddoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctoridDataGridViewTextBoxColumn,
            this.doctornameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.licenscenumberDataGridViewTextBoxColumn});
            this.grddoctor.DataSource = this.tbldoctorBindingSource;
            this.grddoctor.Location = new System.Drawing.Point(100, 147);
            this.grddoctor.Name = "grddoctor";
            this.grddoctor.Size = new System.Drawing.Size(560, 220);
            this.grddoctor.TabIndex = 10;
            this.grddoctor.DoubleClick += new System.EventHandler(this.grddoctor_DoubleClick);
            // 
            // tbldoctorBindingSource
            // 
            this.tbldoctorBindingSource.DataMember = "tbl_doctor";
            this.tbldoctorBindingSource.DataSource = this.hospitalDataSet1;
            // 
            // hospitalDataSet1
            // 
            this.hospitalDataSet1.DataSetName = "hospitalDataSet1";
            this.hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadd.Location = new System.Drawing.Point(171, 393);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(96, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdate.Location = new System.Drawing.Point(288, 393);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(96, 23);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnedelete
            // 
            this.btnedelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnedelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnedelete.Location = new System.Drawing.Point(402, 393);
            this.btnedelete.Name = "btnedelete";
            this.btnedelete.Size = new System.Drawing.Size(96, 23);
            this.btnedelete.TabIndex = 13;
            this.btnedelete.Text = "DELETE";
            this.btnedelete.UseVisualStyleBackColor = false;
            this.btnedelete.Click += new System.EventHandler(this.btnedelete_Click);
            // 
            // btndash
            // 
            this.btndash.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btndash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndash.Location = new System.Drawing.Point(519, 393);
            this.btndash.Name = "btndash";
            this.btndash.Size = new System.Drawing.Size(125, 23);
            this.btndash.TabIndex = 15;
            this.btndash.Text = "DASHBOARD";
            this.btndash.UseVisualStyleBackColor = false;
            this.btndash.Click += new System.EventHandler(this.btndash_Click);
            // 
            // tbl_doctorTableAdapter
            // 
            this.tbl_doctorTableAdapter.ClearBeforeFill = true;
            // 
            // doctoridDataGridViewTextBoxColumn
            // 
            this.doctoridDataGridViewTextBoxColumn.DataPropertyName = "doctorid";
            this.doctoridDataGridViewTextBoxColumn.HeaderText = "doctorid";
            this.doctoridDataGridViewTextBoxColumn.Name = "doctoridDataGridViewTextBoxColumn";
            this.doctoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctornameDataGridViewTextBoxColumn
            // 
            this.doctornameDataGridViewTextBoxColumn.DataPropertyName = "doctor_name";
            this.doctornameDataGridViewTextBoxColumn.HeaderText = "doctor_name";
            this.doctornameDataGridViewTextBoxColumn.Name = "doctornameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // licenscenumberDataGridViewTextBoxColumn
            // 
            this.licenscenumberDataGridViewTextBoxColumn.DataPropertyName = "licensce_number";
            this.licenscenumberDataGridViewTextBoxColumn.HeaderText = "licensce_number";
            this.licenscenumberDataGridViewTextBoxColumn.Name = "licenscenumberDataGridViewTextBoxColumn";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Red;
            this.btnsearch.Location = new System.Drawing.Point(656, 13);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(105, 27);
            this.btnsearch.TabIndex = 16;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lbldocrecords
            // 
            this.lbldocrecords.AutoSize = true;
            this.lbldocrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldocrecords.Location = new System.Drawing.Point(276, 9);
            this.lbldocrecords.Name = "lbldocrecords";
            this.lbldocrecords.Size = new System.Drawing.Size(155, 24);
            this.lbldocrecords.TabIndex = 17;
            this.lbldocrecords.Text = "Doctor Records";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldocrecords);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndash);
            this.Controls.Add(this.btnedelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.grddoctor);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.txtlicence);
            this.Controls.Add(this.txtexperience);
            this.Controls.Add(this.txtdocname);
            this.Controls.Add(this.txtdocid);
            this.Controls.Add(this.lbllicen);
            this.Controls.Add(this.lblexper);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbldcname);
            this.Controls.Add(this.lbldoctor);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lbldcname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblexper;
        private System.Windows.Forms.Label lbllicen;
        private System.Windows.Forms.TextBox txtdocid;
        private System.Windows.Forms.TextBox txtdocname;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.TextBox txtlicence;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.DataGridView grddoctor;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnedelete;
        private System.Windows.Forms.Button btndash;
        private hospitalDataSet1 hospitalDataSet1;
        private System.Windows.Forms.BindingSource tbldoctorBindingSource;
        private hospitalDataSet1TableAdapters.tbl_doctorTableAdapter tbl_doctorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenscenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lbldocrecords;
    }
}