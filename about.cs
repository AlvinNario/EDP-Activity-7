using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do_List
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void dashboardlabel_Click(object sender, EventArgs e)
        {
            var dashboardForm = new dashboard();
            dashboardForm.Show();
            this.Hide(); // Hide the login form
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var reportForm = new report();
            reportForm.Show();
            this.Hide(); // Hide the login form
        }

        private void aboutlbl_Click(object sender, EventArgs e)
        {
            var aboutForm = new about();
            aboutForm.Show();
            this.Hide(); // Hide the login form
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // If the user clicks Yes, show the login form and hide the dashboard form
                var loginForm = new login();
                loginForm.Show();
                this.Hide();

                // Optionally, you can close the dashboard form if you don't need it anymore
                // this.Close();
            }
        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void reportlabel_Click(object sender, EventArgs e)
        {
            var reportForm = new report();
            reportForm.Show();
            this.Hide(); // Hide the login form
        }

        private void aboutlbl_Click_1(object sender, EventArgs e)
        {
            var aboutForm = new about();
            aboutForm.Show();
            this.Hide(); // Hide the login form
        }

        private void userlbl_Click(object sender, EventArgs e)
        {
            var usersForm = new users();
            usersForm.Show();
            this.Hide();
        }

        private void dashboardlbl_Click(object sender, EventArgs e)
        {
            var dashboardForm = new dashboard();
            dashboardForm.Show();
            this.Hide(); // Hide the login form
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var studentList = new studentList();
            studentList.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var teacherForm = new teacherList();
            teacherForm.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            var subject = new subjectList();
            subject.Show();
            this.Hide();
        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            // Show a confirmation dialog before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // If the user clicks Yes, show the login form and hide the dashboard form
                var loginForm = new login();
                loginForm.Show();
                this.Hide();

                // Optionally, you can close the dashboard form if you don't need it anymore
                // this.Close();
            }
        }
    }
}
