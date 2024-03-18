using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Doctor : Form

    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1NR34J4\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Context Connection=False");
        public Doctor()
        {
            InitializeComponent();
            cmbgender.SelectedIndex = 0;
      
        }
        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet1.tbl_doctor' table. You can move, or remove it, as needed.
            // this.tbl_doctorTableAdapter.Fill(this.hospitalDataSet1.tbl_doctor);
            DisplayDoctor();

        }

        private void btndash_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
        private void DisplayDoctor()
        {
            try
            {
                con.Open();
                string Query = "select * from tbl_doctor";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                grddoctor.DataSource = ds.Tables[0];
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_add_doctor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@doctor_name", SqlDbType.NVarChar).Value = txtdocname.Text;
            cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = cmbgender.Text;
            cmd.Parameters.Add("@experience", SqlDbType.NVarChar).Value = txtexperience.Text;
            cmd.Parameters.Add("@licensce_number", SqlDbType.NVarChar).Value = txtlicence.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Added Success!!");
            con.Close();
            txtdocid.Text = "";
            txtdocname.Text = "";
            cmbgender.SelectedIndex = 0;
            txtexperience.Text = "";
            txtlicence.Text = "";

        }

        private void btnedelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-1NR34J4\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Context Connection=False"))
            {
                con.Open();

                if (!string.IsNullOrEmpty(txtdocid.Text))
                {
                    int doctorIdToDelete = int.Parse(txtdocid.Text);

                    using (SqlCommand cmd = new SqlCommand("sp_delete_doctor", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@doctorid", SqlDbType.Int).Value = doctorIdToDelete;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Deleted Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Doctor ID for deletion.");
                }

                // Clear input fields after deletion
                txtdocid.Text = "";
                txtdocname.Text = "";
                cmbgender.SelectedIndex = 0;
                txtexperience.Text = "";
                txtlicence.Text = "";
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                string query = "update tbl_doctor set  doctorid=@doctorid,doctor_name=@doctor_name,gender= @gender @experience,license_number= @license_number";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@docid", txtdocid.Text);
                cmd.Parameters.AddWithValue("@doctor_name", txtdocname.Text);
                cmd.Parameters.AddWithValue("@gender", cmbgender.Text);
                cmd.Parameters.AddWithValue("@experience", txtexperience.Text);
                cmd.Parameters.AddWithValue("@license_number", txtlicence.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                DisplayDoctor();
            }
            con.Close();
            txtdocid.Text = "";
            txtdocname.Text = "";
            cmbgender.SelectedIndex = 0;
            txtexperience.Text = "";
            txtlicence.Text = "";

        }

        private void grddoctor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtdocid.Text = grddoctor.SelectedRows[0].Cells[0].Value.ToString();
                txtdocname.Text = grddoctor.SelectedRows[1].Cells[1].Value.ToString();
                cmbgender.Text = grddoctor.SelectedRows[2].Cells[2].Value.ToString();
                txtexperience.Text = grddoctor.SelectedRows[3].Cells[3].Value.ToString();
                txtlicence.Text = grddoctor.SelectedRows[4].Cells[4].Value.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_search_doctor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@doctorid", SqlDbType.NVarChar).Value = txtdocid.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grddoctor.DataSource = dt;
            con.Close();
        }
    }
    

}
