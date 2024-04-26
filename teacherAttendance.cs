using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do_List
{
    public partial class teacherAttendance : Form
    {
        public teacherAttendance(string fullName, string imagePath)
        {
            InitializeComponent();

            // Set the full name to the student_name label
            student_name.Text = fullName;

            // Load the image into pictureBox1 and make it round
            pictureBox1.Image = Image.FromFile(imagePath);


            // Call the method to update the time label every second
            timer1.Start();
            timer1.Tick += Timer1_Tick;

            // Update the label immediately when the form loads
            UpdateTimeLabel();

            MakePictureBoxRound(pictureBox1);
        }
        private void MakePictureBoxRound(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1);
            Region region = new Region(gp);
            pb.Region = region;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Call the method to update the time label every second
            UpdateTimeLabel();
        }
        private void UpdateTimeLabel()
        {
            // Update the label text with the current time in 12-hour format
            time.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            var indexForm = new index();
            indexForm.Show();
            this.Hide();
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

            var myprof = new studentAttendance(fullName, imagePath);
            myprof.Show();
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

            var myprofteacher = new teacherForm(fullName, imagePath);
            myprofteacher.Show();
            this.Hide();
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
                string query = "SELECT profile FROM teachers WHERE CONCAT(first_name, ' ', last_name) = @fullName";

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

        private void timeInbtn_Click(object sender, EventArgs e)
        {
            string studentid = studentID.Text;
            string classid = classID.Text;

            // Check if student ID is provided and valid
            if (!string.IsNullOrEmpty(studentid) && IsStudent(studentid))
            {
                // Record the current date and time in the studentattendance table
                RecordTimeIn(studentid, classid, DateTime.Now);
            }
            else
            {
                MessageBox.Show("Invalid student ID.");
            }
        }
        private void timeOutbtn_Click_1(object sender, EventArgs e)
        {
            string studentid = studentID.Text;
            string classid = classID.Text;

            // Check if student ID is provided and valid
            if (!string.IsNullOrEmpty(studentid) && IsStudent(studentid))
            {
                // Record the current date and time in the studentattendance table
                RecordTimeOut(studentid, classid, DateTime.Now);
            }
            else
            {
                MessageBox.Show("Invalid student ID.");
            }
        }
        private bool IsStudent(string studentID)
        {
            bool isStudent = false;

            MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySqlConnection(myConnString);
                conn.Open();

                // Check if the student ID exists in the students table
                string query = "SELECT COUNT(*) FROM teachers WHERE teacher_id = @studentID";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@studentID", studentID);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    isStudent = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking student existence: " + ex.Message);
            }

            return isStudent;
        }
        private void RecordTimeIn(string studentID, string classID, DateTime timeIn)
        {
            MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySqlConnection(myConnString);
                conn.Open();

                // Check if the record already exists
                string checkQuery = "SELECT COUNT(*) FROM teacherattendance WHERE teacher_id = @studentID AND class_id = @classID AND date = @date";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn);
                checkCommand.Parameters.AddWithValue("@studentID", studentID); // Use the provided studentID
                checkCommand.Parameters.AddWithValue("@classID", classID);
                checkCommand.Parameters.AddWithValue("@date", timeIn.Date);
                int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (existingCount == 0) // No existing record found
                {
                    // Retrieve the start time of the class from the database
                    string startTimeQuery = "SELECT start_time FROM classes WHERE class_id = @classID";
                    MySqlCommand startTimeCommand = new MySqlCommand(startTimeQuery, conn);
                    startTimeCommand.Parameters.AddWithValue("@classID", classID);
                    TimeSpan classStartTime = (TimeSpan)startTimeCommand.ExecuteScalar();

                    // Get the current time
                    TimeSpan currentTime = timeIn.TimeOfDay;
                    string status;

                    // Determine the status based on the comparison of class start time and current time
                    if (currentTime > classStartTime)
                    {
                        status = "Late";
                    }
                    else
                    {
                        status = "Present";
                    }

                    // Insert the record into the studentattendance table with status
                    string insertQuery = "INSERT INTO teacherattendance (teacher_id, class_id, date, timeIN, inStatus) " +
                                         "VALUES (@studentID, @classID, @date, @timeIn, @status)";

                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                    insertCommand.Parameters.AddWithValue("@studentID", studentID); // Use the provided studentID
                    insertCommand.Parameters.AddWithValue("@classID", classID);
                    insertCommand.Parameters.AddWithValue("@date", timeIn.Date); // Insert date only
                    insertCommand.Parameters.AddWithValue("@timeIn", timeIn);
                    insertCommand.Parameters.AddWithValue("@status", status);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Time in recorded successfully. Status: " + status);
                }
                else
                {
                    MessageBox.Show("Attendance already recorded for this student in this class on this date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording time in: " + ex.Message);
            }
        }
        private void RecordTimeOut(string studentID, string classID, DateTime timeOut)
        {
            MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=alvin;database=attendance;";

            try
            {
                conn = new MySqlConnection(myConnString);
                conn.Open();

                // Retrieve the end time of the class from the database
                string endTimeQuery = "SELECT end_time FROM classes WHERE class_id = @classID";
                MySqlCommand endTimeCommand = new MySqlCommand(endTimeQuery, conn);
                endTimeCommand.Parameters.AddWithValue("@classID", classID);
                TimeSpan classEndTime = (TimeSpan)endTimeCommand.ExecuteScalar();

                // Determine if the time out is early, on-time, or overtime
                string outStatus;
                TimeSpan currentTime = timeOut.TimeOfDay;
                if (currentTime < classEndTime)
                {
                    outStatus = "Early";
                }
                else if (currentTime == classEndTime)
                {
                    outStatus = "On-time";
                }
                else
                {
                    outStatus = "Overtime";
                }

                // Update the record in the studentattendance table with time out and outStatus
                string updateQuery = "UPDATE teacherattendance SET timeOut = @timeOut, outStatus = @outStatus WHERE teacher_id = @studentID AND class_id = @classID AND date = @date";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn);
                updateCommand.Parameters.AddWithValue("@timeOut", timeOut);
                updateCommand.Parameters.AddWithValue("@outStatus", outStatus);
                updateCommand.Parameters.AddWithValue("@studentID", studentID);
                updateCommand.Parameters.AddWithValue("@classID", classID);
                updateCommand.Parameters.AddWithValue("@date", timeOut.Date); // Use the date of time out

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Time out recorded successfully. Status: " + outStatus);
                }
                else
                {
                    MessageBox.Show("No attendance record found for this student in this class on this date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording time out: " + ex.Message);
            }
        }
    }
}