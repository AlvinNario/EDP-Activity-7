namespace To_do_List
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.dashboardlbl = new System.Windows.Forms.Label();
            this.loginlink = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 84;
            this.label5.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.usernameTextBox.Location = new System.Drawing.Point(74, 196);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(289, 38);
            this.usernameTextBox.TabIndex = 83;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 82;
            this.label4.Text = "Password";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(74, 362);
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '•';
            this.passTextBox.Size = new System.Drawing.Size(289, 38);
            this.passTextBox.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 80;
            this.label2.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "Name";
            // 
            // accountTextBox
            // 
            this.accountTextBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.accountTextBox.Location = new System.Drawing.Point(76, 283);
            this.accountTextBox.Multiline = true;
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(287, 38);
            this.accountTextBox.TabIndex = 78;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.nameTextBox.Location = new System.Drawing.Point(74, 117);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(289, 38);
            this.nameTextBox.TabIndex = 77;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.SkyBlue;
            this.updateButton.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(143, 479);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(141, 48);
            this.updateButton.TabIndex = 76;
            this.updateButton.Text = "Sign Up";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dashboardlbl
            // 
            this.dashboardlbl.AutoSize = true;
            this.dashboardlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.8F, System.Drawing.FontStyle.Bold);
            this.dashboardlbl.Location = new System.Drawing.Point(168, 25);
            this.dashboardlbl.Name = "dashboardlbl";
            this.dashboardlbl.Size = new System.Drawing.Size(106, 34);
            this.dashboardlbl.TabIndex = 75;
            this.dashboardlbl.Text = "Sign Up";
            // 
            // loginlink
            // 
            this.loginlink.AutoSize = true;
            this.loginlink.DisabledLinkColor = System.Drawing.Color.White;
            this.loginlink.Font = new System.Drawing.Font("Palatino Linotype", 9.2F);
            this.loginlink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.loginlink.LinkColor = System.Drawing.Color.Blue;
            this.loginlink.Location = new System.Drawing.Point(295, 416);
            this.loginlink.Name = "loginlink";
            this.loginlink.Size = new System.Drawing.Size(55, 22);
            this.loginlink.TabIndex = 86;
            this.loginlink.TabStop = true;
            this.loginlink.Text = "Log In";
            this.loginlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginlink_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel2.Font = new System.Drawing.Font("Palatino Linotype", 9.2F);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(83, 416);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(185, 22);
            this.linkLabel2.TabIndex = 85;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Already have an account?";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 548);
            this.Controls.Add(this.loginlink);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dashboardlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label dashboardlbl;
        private System.Windows.Forms.LinkLabel loginlink;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}