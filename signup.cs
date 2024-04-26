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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Assuming you have textboxes for user input named nameTextBox, accountTextBox, and statusTextBox
            string newName = nameTextBox.Text;
            string newusername = usernameTextBox.Text;
            string newAccount = accountTextBox.Text;
            string newpass = passTextBox.Text;

            // Validate input (you may want to add more validation)
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newusername) || string.IsNullOrWhiteSpace(newAccount) || string.IsNullOrWhiteSpace(newpass))
            {
                MessageBox.Show("Please enter values first.");
                return;
            }


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                // Replace "YourTableName" with the actual name of your table
                string sql = "INSERT INTO users (Name, Username, Account, Password) VALUES (@Name, @Username, @Account, @Password)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@Name", newName);
                    cmd.Parameters.AddWithValue("@Username", newusername);
                    cmd.Parameters.AddWithValue("@Account", newAccount);
                    cmd.Parameters.AddWithValue("@Password", newpass);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record inserted successfully.");

                var login = new login();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message);
            }
        }

        private void loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new login();
            login.Show();
            this.Hide();
        }
    }
}
