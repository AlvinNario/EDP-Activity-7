using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace To_do_List
{
    public partial class studentForm : Form
    {
        public studentForm(string fullName, string imagePath)
        {

            InitializeComponent();

            // Set the full name to the student_name label
            student_name.Text = fullName;

            // Load the image into pictureBox1 and make it round
            pictureBox1.Image = Image.FromFile(imagePath);
            MakePictureBoxRound(pictureBox1);

            PopulateStudentData(fullName);

        }
        private void MakePictureBoxRound(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1);
            Region region = new Region(gp);
            pb.Region = region;
        }
        private void PopulateStudentData(string fullName)
        {
            MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySqlConnection(myConnString);
                conn.Open();

                string query = "SELECT student_id, first_name, last_name, username, profile, account, address FROM students WHERE CONCAT(first_name, ' ', last_name) = @FullName";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@FullName", fullName);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Retrieve data from the reader
                        string studentID = reader["student_id"].ToString();
                        string firstName = reader["first_name"].ToString();
                        string lastName = reader["last_name"].ToString();
                        string username = reader["username"].ToString();
                        string account = reader["account"].ToString();
                        string address = reader["address"].ToString();
                        string profileImagePath = reader["profile"].ToString(); // Assuming profile stores the file path to the image

                        // Set values to the form controls
                        studentIDlbl.Text = studentID;
                        namelbl.Text = $"{firstName} {lastName}";
                        usernamelbl.Text = username;
                        emaillbl.Text = account;
                        addresslbl.Text = address;

                        try
                        {
                            // Load profile image into pictureBox5 directly from file path
                            pictureBox5.Image = Image.FromFile(profileImagePath);
                        }
                        catch (Exception ex)
                        {
                            // Handle error loading profile image
                            MessageBox.Show("Error loading profile image: " + ex.Message);
                            // You might want to set a default image or display an error placeholder in pictureBox5
                        }


                    }
                    else
                    {
                        MessageBox.Show("Student not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student data: " + ex.Message);
            }
        }

        private void studentForm_Load(object sender, EventArgs e)
        {

        }
    private string RetrieveImagePathFromDatabase(string fullName)
        {
            string imagePath = ""; // Initialize imagePath variable


            MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySqlConnection(myConnString);
                conn.Open();

                // Assuming 'image_path' is the column name in the students table where the image path is stored
                string query = "SELECT profile FROM students WHERE CONCAT(first_name, ' ', last_name) = @fullName";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@fullName", fullName);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    imagePath = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving image path from database: " + ex.Message);
            }

    return imagePath;
}


    private void label2_Click(object sender, EventArgs e)
        {
            var myprofForm = new myprofile();
            myprofForm.Show();
            this.Hide();
        }

        private void myprofilelbl_Click(object sender, EventArgs e)
        {
            // Assuming fullName is accessible in studentForm
            string fullName = student_name.Text; // Assuming student_name is the label displaying the full name

            string imagePath = RetrieveImagePathFromDatabase(fullName);

            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Image path not found or empty.");
                return; // Exit the method or handle this case as appropriate
            }

            var myprof = new studentForm(fullName, imagePath);
            myprof.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }

        private void attendancelbl_Click(object sender, EventArgs e)
        {
            // Assuming fullName is accessible in studentForm
            string fullName = student_name.Text; // Assuming student_name is the label displaying the full name

            string imagePath = RetrieveImagePathFromDatabase(fullName);

            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Image path not found or empty.");
                return; // Exit the method or handle this case as appropriate
            }

            var studentattend = new studentAttendance(fullName, imagePath);
            studentattend.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            var indexForm = new index();
            indexForm.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editprofile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Assuming you have a form named UpdateForm for editing profile information
            UpdateForm updateForm = new UpdateForm();

            // Pass current profile information to the update form (you might need to implement this)
            updateForm.LoadProfileData(namelbl.Text, studentIDlbl.Text, usernamelbl.Text, emaillbl.Text, addresslbl.Text);

            // Show the update form
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                // Update the profile information in studentForm with the edited data
                namelbl.Text = updateForm.StudentName;
                studentIDlbl.Text = updateForm.StudentId;
                usernamelbl.Text = updateForm.Username;
                emaillbl.Text = updateForm.Account;
                addresslbl.Text = updateForm.Address;
            }
        }

    }
}
