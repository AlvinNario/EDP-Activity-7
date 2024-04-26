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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace To_do_List
{
    public partial class resetpass : Form
    {
        private string email;

        public resetpass(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = newpass.Text;

            // Replace "Your_Server_Name" and "Your_Database_Name" with your actual server and database names.
            MySql.Data.MySqlClient.MySqlConnection conn;
            // Replace "Your_Server_Name" and "Your_Database_Name" with your actual server and database names.
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";
            try
                {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                    // Update the password based on the provided username.
                    string sql = "UPDATE users SET Password = @newPassword WHERE Account = @email";

                MySqlCommand command = new MySqlCommand(sql, conn);
                {
                        command.Parameters.AddWithValue("@newPassword", newPassword);
                        command.Parameters.AddWithValue("@email", email);

                    int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!");
                            // Optionally, navigate back to the login form or take other actions.
                            var loginForm = new login();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to change password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
