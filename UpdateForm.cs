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
    public partial class UpdateForm : Form
    {
        // Properties to store edited profile data
        public string StudentName { get; private set; }
        public string StudentId { get; private set; }
        public string Username { get; private set; }
        public string Account { get; private set; }
        public string Address { get; private set; }
        public UpdateForm()
        {
            InitializeComponent();
        }
        public void LoadProfileData(string studentName, string studentId, string username, string account, string address)
        {
            txtStudentName.Text = studentName;
            txtStudentId.Text = studentId;
            txtUsername.Text = username;
            txtAccount.Text = account;
            txtAddress.Text = address;
        }

        private void UpdateStudent(string Username, string Account, string Address)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                string query = "UPDATE students SET first_name = @firstName, last_name = @lastName, username = @username, account = @account, address = @address WHERE student_id = @studentId";
                // Split full name into first_name and last_name
                string[] names = txtStudentName.Text.Split(' '); // Assuming txtFullName.Text contains the full name separated by a space
                string firstName = names[0];
                string lastName = string.Join(" ", names.Skip(1)); // Join the remaining parts as the last name

                MySqlCommand command = new MySqlCommand(query, conn);
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@username", Username);
                    command.Parameters.AddWithValue("@account", Account);
                    command.Parameters.AddWithValue("@address", Address);
                    // Exclude @studentId parameter as it's fixed
                    // command.Parameters.AddWithValue("@studentId", StudentId);

                    // Execute the UPDATE query
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No rows were affected. Check if the student ID exists.");
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            // Close the form without saving changes
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Save edited profile data
            StudentName = txtStudentName.Text;
            StudentId = txtStudentId.Text;
            Username = txtUsername.Text;
            Account = txtAccount.Text;
            Address = txtAddress.Text;

            // Update the student information in the students table
            UpdateStudent(Username, Account, Address);



            // Close the form
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
