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
    public partial class Dignosis : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1NR34J4\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Context Connection=False");
        public Dignosis()
        {
            InitializeComponent();
        }

        private void Dignosis_Load(object sender, EventArgs e)
        {

        }
        string patient_name;
        void DisplayPatientName()
        {
            try
            {
                con.Open();
                string query = "select *from tbl_patient where patient_id=" + cmbptid.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    patient_name = dr["patient_name"].ToString();
                    txtptname.Text = patient_name;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbptid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisplayPatientName();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_add_doctor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@patient_id", SqlDbType.NVarChar).Value = cmbptid.Text;
            cmd.Parameters.Add("@patient_name", SqlDbType.NVarChar).Value = txtptname.Text;
            cmd.Parameters.Add("@symptoms", SqlDbType.NVarChar).Value = txtsymptons.Text;
            cmd.Parameters.Add("@dignosis_test", SqlDbType.NVarChar).Value = txtdiagnotest.Text;
            cmd.Parameters.Add("@medicine", SqlDbType.NVarChar).Value = txtmedicine.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Dianosis Added Success!!");
            con.Close();
            txtdiagnoid.Text = "";
            cmbptid.SelectedIndex = 0;
            txtptname.Text = "";
            txtsymptons.Text = "";
            txtdiagnotest.Text = "";
            txtmedicine.Text = "";

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            {
                con.Open();
                string query = "update tbl_diagnosis set  patient_id=@patient_id,patient_name=@patient_name,symptoms= @symptoms,dignosis_test= @dignosis_test,medicine= @medicine";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dignosisId", txtdiagnoid.Text);
                cmd.Parameters.AddWithValue("@patient_id", cmbptid.Text);
                cmd.Parameters.AddWithValue("@patient_name", txtptname.Text);
                cmd.Parameters.AddWithValue("@symptoms", txtsymptons.Text);
                cmd.Parameters.AddWithValue("@dignosis_test", txtdiagnotest.Text);
                cmd.Parameters.AddWithValue("@medicine", txtmedicine.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                //DisplayDoctor();
            }
            con.Close();
            txtdiagnoid.Text = "";
            cmbptid.SelectedIndex = 0;
            txtptname.Text = "";
            txtsymptons.Text = "";
            txtdiagnotest.Text = "";
            txtmedicine.Text = "";

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-1NR34J4\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Context Connection=False"))
            {
                con.Open();

                if (!string.IsNullOrEmpty(txtdiagnoid.Text))
                {
                    int dignosis = int.Parse(txtdiagnoid.Text);

                    using (SqlCommand cmd = new SqlCommand("sp_delete_diagnosis", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@dignosisId", SqlDbType.Int).Value = dignosis;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Diagnosis Deleted Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Doctor ID for deletion.");
                }
            }
        }

        private void grddianosis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtdiagnoid.Text = grddianosis.SelectedRows[0].Cells[0].Value.ToString();
                cmbptid.Text = grddianosis.SelectedRows[1].Cells[1].Value.ToString();
                txtptname.Text = grddianosis.SelectedRows[2].Cells[2].Value.ToString();
                txtsymptons.Text = grddianosis.SelectedRows[3].Cells[3].Value.ToString();
                txtdiagnotest.Text = grddianosis.SelectedRows[4].Cells[4].Value.ToString();
                txtmedicine.Text = grddianosis.SelectedRows[5].Cells[5].Value.ToString();

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

        private void btcsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_search_diagnosis", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@dignosisId", SqlDbType.NVarChar).Value = txtdiagnoid.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grddianosis.DataSource = dt;
            con.Close();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
