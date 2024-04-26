namespace To_do_List
{
    partial class teacherAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherAttendance));
            this.studentID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.student_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.attendancelbl = new System.Windows.Forms.Label();
            this.myprofilelbl = new System.Windows.Forms.Label();
            this.tecaher = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeOutbtn = new System.Windows.Forms.Button();
            this.timeInbtn = new System.Windows.Forms.Button();
            this.classID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentlist = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // studentID
            // 
            this.studentID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentID.Location = new System.Drawing.Point(446, 245);
            this.studentID.Multiline = true;
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(348, 46);
            this.studentID.TabIndex = 60;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Palatino Linotype", 20.2F, System.Drawing.FontStyle.Bold);
            this.time.Location = new System.Drawing.Point(529, 123);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 46);
            this.time.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::To_do_List.Properties.Resources.image_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(632, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.student_name);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(204, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 57);
            this.panel2.TabIndex = 54;
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.ForeColor = System.Drawing.Color.White;
            this.student_name.Location = new System.Drawing.Point(689, 17);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(0, 24);
            this.student_name.TabIndex = 16;
            this.student_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Attendance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 20.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(80, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 47);
            this.label5.TabIndex = 17;
            this.label5.Text = "AMS";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::To_do_List.Properties.Resources.image_removebg_preview__2_;
            this.pictureBox4.Location = new System.Drawing.Point(19, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.logoutbtn.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(57, 654);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(84, 36);
            this.logoutbtn.TabIndex = 0;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // attendancelbl
            // 
            this.attendancelbl.AutoSize = true;
            this.attendancelbl.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendancelbl.Location = new System.Drawing.Point(67, 176);
            this.attendancelbl.Name = "attendancelbl";
            this.attendancelbl.Size = new System.Drawing.Size(106, 24);
            this.attendancelbl.TabIndex = 8;
            this.attendancelbl.Text = "Attendance";
            // 
            // myprofilelbl
            // 
            this.myprofilelbl.AutoSize = true;
            this.myprofilelbl.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myprofilelbl.Location = new System.Drawing.Point(66, 108);
            this.myprofilelbl.Name = "myprofilelbl";
            this.myprofilelbl.Size = new System.Drawing.Size(98, 24);
            this.myprofilelbl.TabIndex = 7;
            this.myprofilelbl.Text = "My Profile";
            this.myprofilelbl.Click += new System.EventHandler(this.myprofilelbl_Click);
            // 
            // tecaher
            // 
            this.tecaher.AutoSize = true;
            this.tecaher.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tecaher.Location = new System.Drawing.Point(442, 219);
            this.tecaher.Name = "tecaher";
            this.tecaher.Size = new System.Drawing.Size(94, 23);
            this.tecaher.TabIndex = 61;
            this.tecaher.Text = "Teacher ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Class ID";
            // 
            // timeOutbtn
            // 
            this.timeOutbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.timeOutbtn.Font = new System.Drawing.Font("Palatino Linotype", 11.2F, System.Drawing.FontStyle.Bold);
            this.timeOutbtn.Location = new System.Drawing.Point(634, 465);
            this.timeOutbtn.Name = "timeOutbtn";
            this.timeOutbtn.Size = new System.Drawing.Size(224, 47);
            this.timeOutbtn.TabIndex = 56;
            this.timeOutbtn.Text = "Time Out";
            this.timeOutbtn.UseVisualStyleBackColor = false;
            this.timeOutbtn.Click += new System.EventHandler(this.timeOutbtn_Click_1);
            // 
            // timeInbtn
            // 
            this.timeInbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.timeInbtn.Font = new System.Drawing.Font("Palatino Linotype", 11.2F, System.Drawing.FontStyle.Bold);
            this.timeInbtn.Location = new System.Drawing.Point(379, 465);
            this.timeInbtn.Name = "timeInbtn";
            this.timeInbtn.Size = new System.Drawing.Size(224, 47);
            this.timeInbtn.TabIndex = 55;
            this.timeInbtn.Text = "Time In";
            this.timeInbtn.UseVisualStyleBackColor = false;
            this.timeInbtn.Click += new System.EventHandler(this.timeInbtn_Click);
            // 
            // classID
            // 
            this.classID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classID.Location = new System.Drawing.Point(446, 349);
            this.classID.Multiline = true;
            this.classID.Name = "classID";
            this.classID.Size = new System.Drawing.Size(348, 46);
            this.classID.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.studentlist);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.attendancelbl);
            this.panel1.Controls.Add(this.myprofilelbl);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 720);
            this.panel1.TabIndex = 53;
            // 
            // studentlist
            // 
            this.studentlist.Image = ((System.Drawing.Image)(resources.GetObject("studentlist.Image")));
            this.studentlist.Location = new System.Drawing.Point(22, 226);
            this.studentlist.Name = "studentlist";
            this.studentlist.Size = new System.Drawing.Size(39, 50);
            this.studentlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentlist.TabIndex = 63;
            this.studentlist.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 62;
            this.label1.Text = "Student List";
            // 
            // teacherAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 719);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.time);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tecaher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeOutbtn);
            this.Controls.Add(this.timeInbtn);
            this.Controls.Add(this.classID);
            this.Controls.Add(this.panel1);
            this.Name = "teacherAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacherAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label attendancelbl;
        private System.Windows.Forms.Label myprofilelbl;
        private System.Windows.Forms.Label tecaher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button timeOutbtn;
        private System.Windows.Forms.Button timeInbtn;
        private System.Windows.Forms.TextBox classID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox studentlist;
        private System.Windows.Forms.Label label1;
    }
}