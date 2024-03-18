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
    public partial class Patient : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1NR34J4\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Context Connection=False");
        public Patient()
        {
            InitializeComponent();
        }
        private void DisplayPatient()
        {
            try
            {
                con.Open();
                string Query = "select * from tbl_patient";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                grdpatient.DataSource = ds.Tables[0];
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
            SqlCommand cmd = new SqlCommand("sp_add_patient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@patient_name", SqlDbType.NVarChar).Value = txtptname.Text;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtptaddress.Text;
            cmd.Parameters.Add("@age", SqlDbType.NVarChar).Value = txtptage.Text;
            cmd.Parameters.Add("@phone_number", SqlDbType.NVarChar).Value = txtnumber.Text;
            cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = cmbgender.Text;
            cmd.Parameters.Add("@blood_group", SqlDbType.NVarChar).Value = cmbblood.Text;
            cmd.Parameters.Add("@symptoms", SqlDbType.NVarChar).Value = txtsymp.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Added Success!!");
            con.Close();
            txtptid.Text = "";
            txtptname.Text = "";
            txtptaddress.Text = "";
            txtptage.Text = "";
            txtnumber.Text = "";
            cmbgender.SelectedIndex = 0;
            cmbblood.SelectedIndex = 0;
            txtsymp.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                string query = "update tbl_doctor set  doctorid=@doctorid,doctor_name=@doctor_name,gender= @gender @experience,license_number= @license_number";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@patient_id", txtptid.Text);
                cmd.Parameters.AddWithValue("@patient_name", txtptname.Text);
                cmd.Parameters.AddWithValue("@address", txtptaddress.Text);
                cmd.Parameters.AddWithValue("@age", txtptage.Text);
                cmd.Parameters.AddWithValue("@phone_number", txtnumber.Text);
                cmd.Parameters.AddWithValue("@gender", cmbgender.Text);
                cmd.Parameters.AddWithValue("@blood_group", cmbblood.Text);
                cmd.Parameters.AddWithValue("@symptoms", txtsymp.Text);
                cmd.ExecuteNonQuery();
                con.Close(); 
                MessageBox.Show("Record Updated Successfully");
                
            }
            con.Close();
            txtptid.Text = "";
            txtptname.Text = "";
            txtptaddress.Text = "";
            txtptage.Text = "";
            txtnumber.Text = "";
            cmbgender.SelectedIndex = 0;
            cmbblood.SelectedIndex = 0;
            txtsymp.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-1NR34J4\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Context Connection=False"))
            {
                con.Open();

                if (!string.IsNullOrEmpty(txtptid.Text))
                {
                    int doctorIdToDelete = int.Parse(txtptid.Text);

                    using (SqlCommand cmd = new SqlCommand("sp_add_patient", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@patient_id", SqlDbType.Int).Value = doctorIdToDelete;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient Deleted Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Patient ID for deletion.");
                }

                // Clear input fields after deletion
                txtptid.Text = "";
                txtptname.Text = "";
                txtptaddress.Text = "";
                txtptage.Text = "";
                txtnumber.Text = "";
                cmbgender.SelectedIndex = 0;
                cmbblood.SelectedIndex = 0;
                txtsymp.Text = "";
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_search_patient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@patient_id", SqlDbType.NVarChar).Value = txtptid.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdpatient.DataSource = dt;
            con.Close();
        }
    }
}
