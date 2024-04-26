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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            var startForm = new choose();
            startForm.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string myusername = this.username.Text;
            string mypassword = this.password.Text;

            MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySqlConnection(myConnString);
                conn.Open();

                // Check the login credentials for students
                string studentSql = "SELECT COUNT(*) FROM students WHERE Username = @myusername AND Password = @mypassword";
                MySqlCommand studentCommand = new MySqlCommand(studentSql, conn);
                studentCommand.Parameters.AddWithValue("@myusername", myusername);
                studentCommand.Parameters.AddWithValue("@mypassword", mypassword);

                int studentResult = Convert.ToInt32(studentCommand.ExecuteScalar());

                // Check the login credentials for teachers
                string teacherSql = "SELECT COUNT(*) FROM teachers WHERE Username = @myusername AND Password = @mypassword";
                MySqlCommand teacherCommand = new MySqlCommand(teacherSql, conn);
                teacherCommand.Parameters.AddWithValue("@myusername", myusername);
                teacherCommand.Parameters.AddWithValue("@mypassword", mypassword);

                int teacherResult = Convert.ToInt32(teacherCommand.ExecuteScalar());

                if (studentResult > 0)
                {
                    string[] userInfo = GetUserInfo(conn, myusername, "student");
                    string fullName = userInfo[0];
                    string imagePath = userInfo[1];
                    string userId = userInfo[2]; // Fetching user_id
                    InsertIntoRecentLogin(conn, fullName, "student", userId); // Insert into recent_login table
                    OpenStudentForm(conn, fullName, imagePath); // Open student form
                }
                else if (teacherResult > 0)
                    {
                        string[] userInfo = GetUserInfo(conn, myusername, "teacher");
                        string fullName = userInfo[0];
                        string imagePath = userInfo[1];
                        string userId = userInfo[2]; // Fetching user_id
                        InsertIntoRecentLogin(conn, fullName, "teacher", userId); // Insert into recent_login table
                        OpenTeacherForm(conn, fullName, imagePath); // Open teacher form
                    }
                    else
                    {
                        // Handle the case where neither a student nor a teacher with the given credentials exists
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Method to get the full name, image path, and user ID of the user from the database
            string[] GetUserInfo(MySqlConnection connection, string username, string userType)
            {
                string[] userInfo = new string[3]; // Modified to include user_id

                string getProfileSql = "";
                string userIdColumn = ""; // Column name for student_id or teacher_id
                if (userType == "student")
                {
                    getProfileSql = "SELECT first_name, last_name, profile, student_id FROM students WHERE Username = @username";
                    userIdColumn = "student_id";
                }
                else if (userType == "teacher")
                {
                    getProfileSql = "SELECT first_name, last_name, profile, teacher_id FROM teachers WHERE Username = @username";
                    userIdColumn = "teacher_id";
                }

                MySqlCommand getProfileCommand = new MySqlCommand(getProfileSql, connection);
                getProfileCommand.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = getProfileCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string firstName = reader["first_name"].ToString();
                        string lastName = reader["last_name"].ToString();
                        string fullName = $"{firstName} {lastName}";
                        string imagePath = reader["profile"].ToString();
                        string userId = reader[userIdColumn].ToString(); // Fetching student_id or teacher_id
                        userInfo[0] = fullName;
                        userInfo[1] = imagePath;
                        userInfo[2] = userId; // Storing user_id
                    }
                }

                return userInfo;
            }

            // Method to insert login information into recent_login table
            void InsertIntoRecentLogin(MySqlConnection connection, string fullName, string userType, string userId)
            {
                string insertSql = "INSERT INTO recent_login (name, login_time, user_type, user_id) VALUES (@name, NOW(), @userType, @userId)";
                MySqlCommand insertCommand = new MySqlCommand(insertSql, connection);
                insertCommand.Parameters.AddWithValue("@name", fullName);
                insertCommand.Parameters.AddWithValue("@userType", userType);
                insertCommand.Parameters.AddWithValue("@userId", userId); // Inserting user_id
                insertCommand.ExecuteNonQuery();
            }

            // Method to open the student form
            void OpenStudentForm(MySqlConnection connection, string fullName, string imagePath)
            {
                MessageBox.Show($"Login successful! Welcome, {fullName}.");
                var studentForm = new studentForm(fullName, imagePath);
                studentForm.Show();
                this.Hide();
            }

            // Method to open the teacher form
            void OpenTeacherForm(MySqlConnection connection, string fullName, string imagePath)
            {
                MessageBox.Show($"Login successful! Welcome, {fullName}.");
                var teacherForm = new teacherForm(fullName, imagePath);
                teacherForm.Show();
                this.Hide();
            }

        }
    }
}
