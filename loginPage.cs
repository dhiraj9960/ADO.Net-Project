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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpwd.Text;
            if(username=="abc" && password=="xyz")
            {
               // MessageBox.Show("Login Succesfull");
                this.Hide();
                Dashboard ds=new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Try Again!!");
            }
        }
    }
}
