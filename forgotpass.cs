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
    public partial class forgotpass : Form
    {
        public forgotpass()
        {
            InitializeComponent();
        }

        private void forgotpass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailtxtbox.Text;

            MySql.Data.MySqlClient.MySqlConnection conn;
            // Replace "Your_Server_Name" and "Your_Database_Name" with your actual server and database names.
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                string sql = "SELECT COUNT(*) FROM users WHERE Account = @email";

                MySqlCommand command = new MySqlCommand(sql, conn);
                {
                    command.Parameters.AddWithValue("@email", email);

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result > 0)
                    {
                        // Open the resetpass form and pass the retrieved username
                        var resetpassForm = new resetpass(email);
                        resetpassForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or email. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            var loginForm = new login();
            loginForm.Show();
            this.Hide();
        }
    }
}