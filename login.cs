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



namespace To_do_List
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enter key is pressed, perform login action
                string myusername = this.username.Text;
                string mypassword = this.password.Text;


                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                    conn.Open();

                    // Update all users to "Inactive" initially
                    string updateAllUsersSql = "UPDATE users SET Status = 'Inactive'";
                    MySqlCommand updateAllUsersCommand = new MySqlCommand(updateAllUsersSql, conn);
                    updateAllUsersCommand.ExecuteNonQuery();

                    string sql = "SELECT COUNT(*) FROM users WHERE Username = @myusername AND Password = @mypassword";

                    MySqlCommand command = new MySqlCommand(sql, conn);
                    {
                        command.Parameters.AddWithValue("@myusername", myusername);
                        command.Parameters.AddWithValue("@mypassword", mypassword);

                        int result = Convert.ToInt32(command.ExecuteScalar());

                        if (result > 0)
                        {
                            // Update the status of the logged-in user to "Active"
                            string updateLoggedInUserSql = "UPDATE users SET Status = 'Active' WHERE Username = @myusername";
                            MySqlCommand updateLoggedInUserCommand = new MySqlCommand(updateLoggedInUserSql, conn);
                            updateLoggedInUserCommand.Parameters.AddWithValue("@myusername", myusername);
                            updateLoggedInUserCommand.ExecuteNonQuery();

                            MessageBox.Show("Login successful!");
                            var dashboardForm = new dashboard();
                            dashboardForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string myusername = this.username.Text;
            string mypassword = this.password.Text;

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                // Update all users to "Inactive" initially
                string updateAllUsersSql = "UPDATE users SET Status = 'Inactive'";
                MySqlCommand updateAllUsersCommand = new MySqlCommand(updateAllUsersSql, conn);
                updateAllUsersCommand.ExecuteNonQuery();

                // Check the login credentials
                string sql = "SELECT COUNT(*) FROM users WHERE Username = @myusername AND Password = @mypassword";
                
                MySqlCommand command = new MySqlCommand(sql, conn);
                {
                    command.Parameters.AddWithValue("@myusername", myusername);
                    command.Parameters.AddWithValue("@mypassword", mypassword);

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result > 0)
                    {
                        // Update the status of the logged-in user to "Active"
                        string updateLoggedInUserSql = "UPDATE users SET Status = 'Active' WHERE Username = @myusername";
                        MySqlCommand updateLoggedInUserCommand = new MySqlCommand(updateLoggedInUserSql, conn);
                        updateLoggedInUserCommand.Parameters.AddWithValue("@myusername", myusername);
                        updateLoggedInUserCommand.ExecuteNonQuery();

                        MessageBox.Show("Login successful!");
                        var dashboardForm = new dashboard();
                        dashboardForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var forgotpassForm = new forgotpass();
            forgotpassForm.Show();
            this.Hide(); // Hide the login form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signForm = new signup();
            signForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var startForm = new choose();
            startForm.Show();
            this.Hide();
        }
    }
    }