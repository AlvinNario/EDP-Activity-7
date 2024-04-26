using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;

namespace To_do_List
{
    public partial class users : Form
    {
        private BindingSource bindingSource;
        public users()
        {
            InitializeComponent();
            updateButton.Hide(); // Hide the button by default
            bindingSource = new BindingSource();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountlisttbl_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
        private void users_Load(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();
                // Define the SQL query
                string sql = "SELECT ID, Name, Username, Account, Status FROM users";

                // Create a data adapter
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);

                // Create and fill a DataSet
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Users");

                // Bind the DataSet to the DataGridView
                accountlist.DataSource = dataSet.Tables["Users"];

                bindingSource.DataSource = dataSet.Tables["Users"];
                accountlist.DataSource = bindingSource;

                // Auto-size the "Account" column after data is loaded
                DataGridViewColumn accountColumn = accountlist.Columns["Account"];
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
        private void Accountlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             // Auto-size the "Account" column after data is loaded
            DataGridViewColumn accountColumn = accountlist.Columns["Account"];

            if (accountColumn != null)
            {
                accountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // A cell in the row is clicked, show the update button
                updateButton.Show();
            }
            else if (accountlist.SelectedRows.Count > 0)
            {
                // A whole row is selected, show the update button
                updateButton.Show();
            }
            else
            {
                // No cell or row is selected, hide the update button
                updateButton.Hide();
            }
            if (e.RowIndex >= 0)
            {
                accountlist.Rows[e.RowIndex].Selected = true;
            }

        }

        // Add code for the updateButton click event handler if needed
        private void Accountlist_Leave(object sender, EventArgs e)
        {
            accountlist.Leave += Accountlist_Leave;
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            int selectedRowsCount = accountlist.SelectedRows.Count;
            int selectedCellsCount = accountlist.SelectedCells.Count;
            Console.WriteLine($"Selected Rows Count: {selectedRowsCount}, Selected Cells Count: {selectedCellsCount}");

            if (selectedRowsCount > 0)
            {
        
                DataGridViewRow selectedRow = accountlist.SelectedRows[0];

                // Assuming the DataGridView columns are named "ID", "Name", "Username", "Account", "Status"
                string ID = selectedRow.Cells["ID"].Value?.ToString();
                string Name = selectedRow.Cells["Name"].Value?.ToString();
                string Username = selectedRow.Cells["Username"].Value?.ToString();
                string Account = selectedRow.Cells["Account"].Value?.ToString();

                // Check if any of the values are null before proceeding
                if (ID != null && Name != null && Username != null && Account != null)
                {
                    // Open the update form and pass the selected data
                    update updateForm = new update();
                    updateForm.UpdateID = ID;
                    updateForm.UpdateName = Name;
                    updateForm.UpdateUsername = Username;
                    updateForm.UpdateAccount = Account;
                    updateForm.ShowDialog();

                    return; // Exit the method to avoid showing the MessageBox below
                }
            }

            MessageBox.Show("Please select a valid row to update.");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            var dashboardForm = new dashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void reportlabel_Click(object sender, EventArgs e)
        {
            var reportForm = new report();
            reportForm.Show();
            this.Hide();
        }

        private void aboutlbl_Click(object sender, EventArgs e)
        {
            var aboutForm = new about();
            aboutForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var usersForm = new users();
            usersForm.Show();
            this.Hide();
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            var addaccountForm = new addaccnt();
            addaccountForm.Show();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            var usersForm = new users();
            usersForm.Show();
            this.Hide();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchText = searchbox.Text.Trim();

            // Check if the search text is not empty
            if (!string.IsNullOrEmpty(searchText))
            {
                // Use the Filter property to filter rows based on the "Name" column
                bindingSource.Filter = $"Name LIKE '%{searchText}%'";
            }
            else
            {
                // If the search text is empty, clear the filter
                bindingSource.RemoveFilter();
            }
        }

        // Optionally, add the following event handler to handle Enter key press in the search box
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void searchbtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Perform search when Enter key is pressed
                searchbtn_Click(sender, e);
            }
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
    }
    }