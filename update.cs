using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace To_do_List
{
    public partial class update : Form
    {
        public string UpdateID
        {
            set { idTextBox.Text = value; }
        }

        public string UpdateName
        {
            set { nameTextBox.Text = value; }
        }

        public string UpdateUsername
        {
            set { usernameTextBox.Text = value; }
        }

        public string UpdateAccount
        {
            set { accountTextBox.Text = value; }
        }
    
    public update()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Assuming you have textboxes named txtID, txtName, txtUsername, txtAccount, txtPassword
            string updatedID = idTextBox.Text;
            string updatedName = nameTextBox.Text;
            string updatedUsername = usernameTextBox.Text;
            string updatedAccount = accountTextBox.Text;

            // Validate the inputs if needed

            // Update the data in the database
            UpdateDataInDatabase(updatedID, updatedName, updatedUsername, updatedAccount);

            // Close the update form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Method to update data in the database
        private void UpdateDataInDatabase(string updatedID, string updatedName, string updatedUsername, string updatedAccount)
        {

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();
                // Assuming your table is named 'YourTableName'
                string updateQuery = "UPDATE users SET Name = @Name, Username = @Username, Account = @Account WHERE ID = @ID";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@ID", updatedID);
                    cmd.Parameters.AddWithValue("@Name", updatedName);
                    cmd.Parameters.AddWithValue("@Username", updatedUsername);
                    cmd.Parameters.AddWithValue("@Account", updatedAccount);

                    // Execute the UPDATE query
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data updated successfully.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
  }


        private void update_Load(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            var usersForm = new users();
            usersForm.Show();
            this.Hide();
        }
    }
}
