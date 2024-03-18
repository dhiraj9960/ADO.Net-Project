namespace HospitalManagement
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblhsptmng = new System.Windows.Forms.Label();
            this.btndoctor = new System.Windows.Forms.Button();
            this.btnpatient = new System.Windows.Forms.Button();
            this.btndiagno = new System.Windows.Forms.Button();
            this.btnlgout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhsptmng
            // 
            this.lblhsptmng.AutoSize = true;
            this.lblhsptmng.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhsptmng.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblhsptmng.Image = ((System.Drawing.Image)(resources.GetObject("lblhsptmng.Image")));
            this.lblhsptmng.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblhsptmng.Location = new System.Drawing.Point(202, 23);
            this.lblhsptmng.Name = "lblhsptmng";
            this.lblhsptmng.Size = new System.Drawing.Size(358, 29);
            this.lblhsptmng.TabIndex = 0;
            this.lblhsptmng.Text = "Hospital Management System";
            // 
            // btndoctor
            // 
            this.btndoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoctor.Image = ((System.Drawing.Image)(resources.GetObject("btndoctor.Image")));
            this.btndoctor.Location = new System.Drawing.Point(263, 94);
            this.btndoctor.Name = "btndoctor";
            this.btndoctor.Size = new System.Drawing.Size(176, 39);
            this.btndoctor.TabIndex = 1;
            this.btndoctor.Text = "Doctor";
            this.btndoctor.UseVisualStyleBackColor = true;
            this.btndoctor.Click += new System.EventHandler(this.btndoctor_Click);
            // 
            // btnpatient
            // 
            this.btnpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpatient.Image = ((System.Drawing.Image)(resources.GetObject("btnpatient.Image")));
            this.btnpatient.Location = new System.Drawing.Point(263, 165);
            this.btnpatient.Name = "btnpatient";
            this.btnpatient.Size = new System.Drawing.Size(176, 34);
            this.btnpatient.TabIndex = 2;
            this.btnpatient.Text = "Patient";
            this.btnpatient.UseVisualStyleBackColor = true;
            this.btnpatient.Click += new System.EventHandler(this.btnpatient_Click);
            // 
            // btndiagno
            // 
            this.btndiagno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiagno.Image = ((System.Drawing.Image)(resources.GetObject("btndiagno.Image")));
            this.btndiagno.Location = new System.Drawing.Point(263, 235);
            this.btndiagno.Name = "btndiagno";
            this.btndiagno.Size = new System.Drawing.Size(176, 34);
            this.btndiagno.TabIndex = 3;
            this.btndiagno.Text = "Dignosis";
            this.btndiagno.UseVisualStyleBackColor = true;
            this.btndiagno.Click += new System.EventHandler(this.btndiagno_Click);
            // 
            // btnlgout
            // 
            this.btnlgout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlgout.Image = ((System.Drawing.Image)(resources.GetObject("btnlgout.Image")));
            this.btnlgout.Location = new System.Drawing.Point(263, 302);
            this.btnlgout.Name = "btnlgout";
            this.btnlgout.Size = new System.Drawing.Size(176, 34);
            this.btnlgout.TabIndex = 4;
            this.btnlgout.Text = "Log Out";
            this.btnlgout.UseVisualStyleBackColor = true;
            this.btnlgout.Click += new System.EventHandler(this.btnlgout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.btnlgout);
            this.Controls.Add(this.btndiagno);
            this.Controls.Add(this.btnpatient);
            this.Controls.Add(this.btndoctor);
            this.Controls.Add(this.lblhsptmng);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhsptmng;
        private System.Windows.Forms.Button btndoctor;
        private System.Windows.Forms.Button btnpatient;
        private System.Windows.Forms.Button btndiagno;
        private System.Windows.Forms.Button btnlgout;
    }
}