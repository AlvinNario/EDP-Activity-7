using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace To_do_List
{
    public partial class dashboard : Form
    {

        public dashboard()
        {
            InitializeComponent();
        }


        private void dashboard_Load(object sender, EventArgs e)
        {
            // Call method to count students and update label
            UpdateStudentCount();
            UpdateTeacherCount();
            UpdateClassCount();
            UpdateLeavesCount();
            LoadRecentLogins();
        }
        private void LoadRecentLogins()
        {
            MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySqlConnection(myConnString);
                conn.Open();

                string selectSql = "SELECT profile, name, login_time, user_type FROM recent_login ORDER BY login_time DESC";
                    MySqlCommand command = new MySqlCommand(selectSql, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    // Clear any existing columns and data in the DataGridView
                    recent_login.Columns.Clear();
                    recent_login.DataSource = null;

                    // Set the DataSource to the DataTable
                    recent_login.DataSource = dataTable;

                    // Autosize all columns to fit the content
                    recent_login.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Set DataGridView column headers
                    recent_login.Columns["profile"].HeaderText = "Profile";
                    recent_login.Columns["name"].HeaderText = "Name";
                    recent_login.Columns["login_time"].HeaderText = "Login Time";
                    recent_login.Columns["user_type"].HeaderText = "User Type";
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        private void UpdateStudentCount()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                // SQL query to count the number of students
                string query = "SELECT COUNT(*) FROM students";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        // ExecuteScalar is used since we expect a single value (the count)
                        int studentCount = Convert.ToInt32(command.ExecuteScalar());

                        // Update the label text with the student count
                        studentcount.Text = "" + studentCount.ToString();
                    }
                }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateTeacherCount()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                // SQL query to count the number of students
                string query = "SELECT COUNT(*) FROM teachers";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    // ExecuteScalar is used since we expect a single value (the count)
                    int studentCount = Convert.ToInt32(command.ExecuteScalar());

                    // Update the label text with the student count
                    teachercount.Text = "" + studentCount.ToString();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateClassCount()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                // SQL query to count the number of students
                string query = "SELECT COUNT(*) FROM classes";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    // ExecuteScalar is used since we expect a single value (the count)
                    int studentCount = Convert.ToInt32(command.ExecuteScalar());

                    // Update the label text with the student count
                    classcount.Text = "" + studentCount.ToString();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateLeavesCount()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                // SQL query to count the number of students
                string query = "SELECT COUNT(*) FROM leaves";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    // ExecuteScalar is used since we expect a single value (the count)
                    int studentCount = Convert.ToInt32(command.ExecuteScalar());

                    // Update the label text with the student count
                    leavescount.Text = "" + studentCount.ToString();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            var studentForm = new studentList();
            studentForm.Show();
            this.Hide();
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

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void userlbl_Click(object sender, EventArgs e)
        {
            var usersForm = new users();
            usersForm.Show();
            this.Hide(); // Hide the login form
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teacher_Click(object sender, EventArgs e)
        {
            var teacherForm = new teacherList();
            teacherForm.Show();
            this.Hide();
        }

        private void dashboardlbl_Click(object sender, EventArgs e)
        {
            var dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            var subject = new subjectList();
            subject.Show();
            this.Hide();
        }
    }
}
