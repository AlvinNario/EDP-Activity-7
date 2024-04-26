namespace To_do_List
{
    partial class forgotpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotpass));
            this.forgotbtn = new System.Windows.Forms.Button();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forgotbtn
            // 
            this.forgotbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.forgotbtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.forgotbtn.Location = new System.Drawing.Point(164, 192);
            this.forgotbtn.Name = "forgotbtn";
            this.forgotbtn.Size = new System.Drawing.Size(153, 42);
            this.forgotbtn.TabIndex = 0;
            this.forgotbtn.Text = "Forgot Password";
            this.forgotbtn.UseVisualStyleBackColor = false;
            this.forgotbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.BackColor = System.Drawing.Color.White;
            this.emailtxtbox.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.emailtxtbox.Location = new System.Drawing.Point(65, 123);
            this.emailtxtbox.Multiline = true;
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(252, 32);
            this.emailtxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forgot Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.cancelbtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.cancelbtn.Location = new System.Drawing.Point(65, 192);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(93, 42);
            this.cancelbtn.TabIndex = 4;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // forgotpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 271);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.forgotbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "forgotpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.forgotpass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgotbtn;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelbtn;
    }
}