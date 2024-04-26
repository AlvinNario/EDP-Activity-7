namespace To_do_List
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.forgotpass = new System.Windows.Forms.LinkLabel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.signup = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATTENDANCE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(163, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "MANAGEMENT SYSTEM";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(53, 211);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(348, 46);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(53, 307);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(348, 46);
            this.password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.DisabledLinkColor = System.Drawing.Color.White;
            this.forgotpass.Font = new System.Drawing.Font("Palatino Linotype", 9.2F);
            this.forgotpass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotpass.LinkColor = System.Drawing.Color.Blue;
            this.forgotpass.Location = new System.Drawing.Point(251, 370);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(130, 22);
            this.forgotpass.TabIndex = 6;
            this.forgotpass.TabStop = true;
            this.forgotpass.Text = "Forgot Password?";
            this.forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpass_LinkClicked);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.loginbtn.Font = new System.Drawing.Font("Palatino Linotype", 11.2F, System.Drawing.FontStyle.Bold);
            this.loginbtn.Location = new System.Drawing.Point(53, 425);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(348, 47);
            this.loginbtn.TabIndex = 7;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 9.2F);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(92, 489);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 22);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account?";
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.DisabledLinkColor = System.Drawing.Color.White;
            this.signup.Font = new System.Drawing.Font("Palatino Linotype", 9.2F);
            this.signup.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.signup.LinkColor = System.Drawing.Color.Blue;
            this.signup.Location = new System.Drawing.Point(280, 489);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(67, 22);
            this.signup.TabIndex = 10;
            this.signup.TabStop = true;
            this.signup.Text = "Sign Up";
            this.signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::To_do_List.Properties.Resources.image_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(53, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "←";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.forgotpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(436, 450);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel forgotpass;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel signup;
        private System.Windows.Forms.Label label5;
    }
}

