using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Drawing.Chart;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using OfficeOpenXml.Table.PivotTable;

namespace To_do_List
{
    public partial class report : Form
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        public report()
        {
            InitializeComponent();
            comboBoxReportType.SelectedIndexChanged += comboBoxReportType_SelectedIndexChanged;
            exportbtn.Click += exportbtn_Click;
            // Set the LicenseContext to suppress the license exception
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Initialize chart1 here
            chart1 = new Chart();
        }

        private void report_Load(object sender, EventArgs e)
        {

        }
        private void comboBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedReportType = comboBoxReportType.SelectedItem.ToString();

            switch (selectedReportType)
            {
                case "Recent Login":
                    DisplayRecentLoginData();
                    break;
                case "Student Attendance":
                    DisplayStudentAttendanceData();
                    break;
                case "Teacher Attendance":
                    DisplayTeacherAttendanceData();
                    break;
                default:
                    MessageBox.Show("Invalid report type selected.");
                    break;
            }
        }

        private void DisplayRecentLoginData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;password=alvin;database=attendance;"))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT login_id, name, login_time, user_type, user_id FROM recent_login", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportlist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying recent login data: " + ex.Message);
            }
        }

        private void DisplayStudentAttendanceData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;password=alvin;database=attendance;"))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM studentattendance", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportlist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching student attendance data: " + ex.Message);
            }
        }

        private void DisplayTeacherAttendanceData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;password=alvin;database=attendance;"))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM teacherattendance", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportlist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching teacher attendance data: " + ex.Message);
            }
        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Sheet 1: Report data
                        ExcelWorksheet ws1 = excelPackage.Workbook.Worksheets.Add("Report");

                        // Save the logo image to a temporary file with a valid image extension
                        string tempLogoPath = Path.GetTempFileName();
                        tempLogoPath = Path.ChangeExtension(tempLogoPath, ".png");
                        logo.Image.Save(tempLogoPath, System.Drawing.Imaging.ImageFormat.Png);

                        // Add the logo image to cell A3 with size 70px
                        ExcelPicture logoPicture = ws1.Drawings.AddPicture("Logo", new FileInfo(tempLogoPath));
                        logoPicture.SetPosition(1, 0, 0, 0); // Position at cell A3 with size 70px
                        logoPicture.SetSize(70, 70);

                        // Get the brand name from Label
                        string brandName = systemName.Text;

                        // Insert brand name into cell B3 and set font
                        ws1.Cells["B3"].Value = brandName;
                        ws1.Cells["B3"].Style.Font.Name = "Palatino Linotype";
                        ws1.Cells["B3"].Style.Font.Size = 20.8f;
                        ws1.Cells["B3"].Style.Font.Bold = true;

                        // Add signature placeholder
                        ws1.Cells["B5"].Value = "Signature: ______________________";

                        // Export DataGridView data to Sheet 1
                        DataTable dt = (DataTable)reportlist.DataSource;
                        ws1.Cells["A7"].LoadFromDataTable(dt, true);

                        // Adjust column width for date and time columns
                        for (int i = 1; i <= dt.Columns.Count; i++)
                        {
                            DataColumn column = dt.Columns[i - 1];
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                int rowIndex = j + 7; // Adjust for header rows
                                if (DateTime.TryParse(dt.Rows[j][column].ToString(), out DateTime value))
                                {
                                    if (value.TimeOfDay.TotalSeconds > 0) // If time component is present
                                    {
                                        ws1.Cells[rowIndex, i].Style.Numberformat.Format = "h:mm:ss";
                                    }
                                    else // If only date component is present
                                    {
                                        ws1.Cells[rowIndex, i].Style.Numberformat.Format = "dd-mm-yyyy";
                                    }
                                }
                            }

                            // Auto fit column width after formatting
                            ws1.Column(i).AutoFit();
                        }
                        // Format last row separately
                        int lastRowIndex = dt.Rows.Count + 7; // Adjust for header rows
                        for (int i = 1; i <= dt.Columns.Count; i++)
                        {
                            DataColumn column = dt.Columns[i - 1];
                            if (DateTime.TryParse(dt.Rows[dt.Rows.Count - 1][column].ToString(), out DateTime value))
                            {
                                if (value.TimeOfDay.TotalSeconds > 0) // If time component is present
                                {
                                    ws1.Cells[lastRowIndex, i].Style.Numberformat.Format = "h:mm:ss";
                                }
                                else // If only date component is present
                                {
                                    ws1.Cells[lastRowIndex, i].Style.Numberformat.Format = "dd-mm-yyyy";
                                }
                            }
                        }
                        // Assuming you have a DataTable dt containing student attendance data with columns student_id and inStatus

                        // Check if the export is for student attendance
                        bool isStudentAttendance = (comboBoxReportType.SelectedItem != null && comboBoxReportType.SelectedItem.ToString() == "Student Attendance");
                        bool isTeacherAttendance = (comboBoxReportType.SelectedItem != null && comboBoxReportType.SelectedItem.ToString() == "Teacher Attendance");

                        // Sheet 2: Graph of the data
                        ExcelWorksheet ws2 = excelPackage.Workbook.Worksheets.Add("Sheet2");

                        if (isStudentAttendance)
                        {
                            // Group the data by inStatus and count the number of student_id for each inStatus
                            var groupedData = dt.AsEnumerable()
                                                .GroupBy(row => row.Field<string>("inStatus"))
                                                .Select(group => new {
                                                    InStatus = group.Key,
                                                    Count = group.Count()
                                                });

                            // Insert data into the worksheet
                            int rowNum = 1;
                            foreach (var item in groupedData)
                            {
                                ws2.Cells[rowNum, 1].Value = item.InStatus;
                                ws2.Cells[rowNum, 2].Value = item.Count;
                                rowNum++;
                            }

                            // Define the chart
                            var chart = ws2.Drawings.AddChart("Chart", OfficeOpenXml.Drawing.Chart.eChartType.ColumnClustered);

                            // Load data for the chart
                            var range = ws2.Cells["A1:A" + rowNum];
                            var dataRange = ws2.Cells["B1:B" + rowNum];
                            chart.Series.Add(dataRange, range);

                            // Set chart properties
                            chart.Title.Text = "Count of Students by Attendance Status";
                            chart.SetPosition(1, 0, 4, 0);
                            chart.SetSize(600, 400);
                            chart.XAxis.Title.Text = "Attendance Status";
                            chart.YAxis.Title.Text = "Count";
                        }
                        else if (isTeacherAttendance)
                        {
                            // Group the data by inStatus and count the number of teacher_id for each inStatus
                            var groupedData = dt.AsEnumerable()
                                                .GroupBy(row => row.Field<string>("inStatus"))
                                                .Select(group => new {
                                                    InStatus = group.Key,
                                                    Count = group.Count()
                                                });

                            // Insert data into the worksheet
                            int rowNum = 1;
                            foreach (var item in groupedData)
                            {
                                ws2.Cells[rowNum, 1].Value = item.InStatus;
                                ws2.Cells[rowNum, 2].Value = item.Count;
                                rowNum++;
                            }

                            // Define the chart
                            var chart = ws2.Drawings.AddChart("Chart", OfficeOpenXml.Drawing.Chart.eChartType.ColumnClustered);

                            // Load data for the chart
                            var range = ws2.Cells["A1:A" + rowNum];
                            var dataRange = ws2.Cells["B1:B" + rowNum];
                            chart.Series.Add(dataRange, range);

                            // Set chart properties
                            chart.Title.Text = "Count of Teachers by Attendance Status";
                            chart.SetPosition(1, 0, 4, 0);
                            chart.SetSize(600, 400);
                            chart.XAxis.Title.Text = "Attendance Status";
                            chart.YAxis.Title.Text = "Count";
                        }

                        else
                        {
                            // Group the data by user_type and count the distinct number of user_id for each user_type
                            var groupedData = dt.AsEnumerable()
                                                .GroupBy(row => row.Field<string>("user_type"))
                                                .Select(group => new {
                                                    UserType = group.Key,
                                                    Count = group.Select(row => row.Field<int>("user_id")).Distinct().Count()
                                                })
                                                .OrderBy(item => item.UserType);

                            // Insert data into the worksheet
                            int rowNum = 1;
                            foreach (var item in groupedData)
                            {
                                ws2.Cells[rowNum, 1].Value = item.UserType;
                                ws2.Cells[rowNum, 2].Value = item.Count;
                                rowNum++;
                            }

                            // Define the chart
                            var chart = ws2.Drawings.AddChart("Chart", OfficeOpenXml.Drawing.Chart.eChartType.ColumnClustered);

                            // Load data for the chart
                            var range = ws2.Cells["A1:A" + rowNum];
                            var dataRange = ws2.Cells["B1:B" + rowNum];
                            chart.Series.Add(dataRange, range);

                            // Set chart properties
                            chart.Title.Text = "Count of Unique User IDs by User Type";
                            chart.SetPosition(1, 0, 4, 0);
                            chart.SetSize(600, 400);
                            chart.XAxis.Title.Text = "User Type";
                            chart.YAxis.Title.Text = "Count";
                        }

                        // Save Excel file
                        excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
                        MessageBox.Show("Data exported successfully!");

                    }
                    // Close the save file dialog if export was successful
                    saveFileDialog.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message);
            }
        }
        private void dashboardlabel_Click(object sender, EventArgs e)
        {
            var dashboardForm = new dashboard();
            dashboardForm.Show();
            this.Hide(); // Hide the login form
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

        private void aboutlbl_Click(object sender, EventArgs e)
        {
            var aboutForm = new about();
            aboutForm.Show();
            this.Hide(); // Hide the login form
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            var dashboard = new dashboard();
            dashboard.Show();
            this.Hide(); // Hide the login form
        }

        private void reportlabel_Click(object sender, EventArgs e)
        {
            var reportForm = new report();
            reportForm.Show();
            this.Hide(); // Hide the login form
        }

        private void aboutlbl_Click_1(object sender, EventArgs e)
        {
            var aboutForm = new about();
            aboutForm.Show();
            this.Hide(); // Hide the login form
        }

        private void userlbl_Click(object sender, EventArgs e)
        {
            var usersForm = new users();
            usersForm.Show();
            this.Hide(); // Hide the login form
        }

        private void students_Click(object sender, EventArgs e)
        {
            var studentForm = new studentList();
            studentForm.Show();
            this.Hide();
        }

        private void teachers_Click(object sender, EventArgs e)
        {
            var teacher = new teacherList();
            teacher.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            var subj = new subjectList();
            subj.Show();
            this.Hide();
        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
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
    }
}