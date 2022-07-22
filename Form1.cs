using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Start.User;

namespace Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Cashier");
            cbRole.Items.Add("Pharmasist");
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           // cbDOB.Items.Add(MonthCalendar1);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Users a = new Users();
            a.username= txtUserName.Text;
            a.password = txtPassword.Text;

            /*accept all info from users database table and check if there is a match for the
            username and password accepted from the textbox (with loop)

            if there is {
            if (userRole= Admin)   ===>  go to the admin dashboard
            else if (userRole==Pharmasist)   ===> go to the pharmasist dashboard
            else ===> go to the cashier dashboard
                      }
            else{
            MessageBox.Show("Wrong Username or Password")
                }*/
            

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUserRole.Items.Add("Admin");
            cbUserRole.Items.Add("Pharmasist");
            cbUserRole.Items.Add("Cashier");
        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
