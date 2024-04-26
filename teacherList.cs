using MySql.Data.MySqlClient;
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
    public partial class teacherList : Form
    {
        private BindingSource bindingSource;
        public teacherList()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        private void teacherList_Load(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();
                // Define the SQL query
                string sql = "SELECT teacher_id, first_name, last_name, account FROM teachers";

                // Create a data adapter
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);

                // Create and fill a DataSet
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Users");

                // Bind the DataSet to the DataGridView
                teachList.DataSource = dataSet.Tables["Users"];

                bindingSource.DataSource = dataSet.Tables["Users"];
                teachList.DataSource = bindingSource;

                // Auto-size the "Account" column after data is loaded
                DataGridViewColumn accountColumn = teachList.Columns["Account"];
                if (accountColumn != null)
                {
                    accountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void student_Click(object sender, EventArgs e)
        {
            var studentList = new studentList();
            studentList.Show();
            this.Hide();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            var teacherForm = new teacherList();
            teacherForm.Show();
            this.Hide();
        }

        private void subject_Click(object sender, EventArgs e)
        {
            var subject = new subjectList();
            subject.Show();
            this.Hide();
        }

        private void reportlabel_Click(object sender, EventArgs e)
        {
            var report = new report();
            report.Show();
            this.Hide();
        }

        private void aboutlbl_Click(object sender, EventArgs e)
        {
            var about = new about();
            about.Show();
            this.Hide();
        }

        private void user_Click(object sender, EventArgs e)
        {
            var user = new users();
            user.Show();
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
    }
}
