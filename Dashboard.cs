using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnlgout_Click(object sender, EventArgs e)
        {
            loginPage login= new loginPage();
            login.Show();
            this.Hide();
        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
            this.Hide();
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void btndiagno_Click(object sender, EventArgs e)
        {
            Dignosis dg = new Dignosis();
            dg.Show();
            this.Hide();
        }
    }
}
