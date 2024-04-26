namespace To_do_List
{
    partial class resetpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resetpass));
            this.resetpassbtn = new System.Windows.Forms.Button();
            this.newpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetpassbtn
            // 
            this.resetpassbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.resetpassbtn.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpassbtn.Location = new System.Drawing.Point(65, 192);
            this.resetpassbtn.Name = "resetpassbtn";
            this.resetpassbtn.Size = new System.Drawing.Size(252, 42);
            this.resetpassbtn.TabIndex = 11;
            this.resetpassbtn.Text = "Reset Password";
            this.resetpassbtn.UseVisualStyleBackColor = false;
            this.resetpassbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // newpass
            // 
            this.newpass.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(65, 123);
            this.newpass.Multiline = true;
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '•';
            this.newpass.Size = new System.Drawing.Size(252, 32);
            this.newpass.TabIndex = 9;
            this.newpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reset Password";
            // 
            // resetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 271);
            this.Controls.Add(this.resetpassbtn);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "resetpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetpassbtn;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}