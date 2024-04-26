namespace To_do_List
{
    partial class choose
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminbtn = new System.Windows.Forms.Button();
            this.stud_techbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(162, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "ATTENDANCE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::To_do_List.Properties.Resources.image_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(52, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // adminbtn
            // 
            this.adminbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.adminbtn.Font = new System.Drawing.Font("Palatino Linotype", 11.2F, System.Drawing.FontStyle.Bold);
            this.adminbtn.Location = new System.Drawing.Point(109, 179);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(206, 47);
            this.adminbtn.TabIndex = 12;
            this.adminbtn.Text = "Admin";
            this.adminbtn.UseVisualStyleBackColor = false;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // stud_techbtn
            // 
            this.stud_techbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.stud_techbtn.Font = new System.Drawing.Font("Palatino Linotype", 11.2F, System.Drawing.FontStyle.Bold);
            this.stud_techbtn.Location = new System.Drawing.Point(109, 248);
            this.stud_techbtn.Name = "stud_techbtn";
            this.stud_techbtn.Size = new System.Drawing.Size(206, 47);
            this.stud_techbtn.TabIndex = 13;
            this.stud_techbtn.Text = "Student or Teacher";
            this.stud_techbtn.UseVisualStyleBackColor = false;
            this.stud_techbtn.Click += new System.EventHandler(this.stud_techbtn_Click);
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 340);
            this.Controls.Add(this.stud_techbtn);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "choose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Button stud_techbtn;
    }
}