namespace To_do_List
{
    partial class UpdateForm
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
            this.idlbl = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dashboardlbl = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(245, 78);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(32, 24);
            this.idlbl.TabIndex = 100;
            this.idlbl.Text = "ID";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.txtStudentId.Location = new System.Drawing.Point(249, 108);
            this.txtStudentId.Multiline = true;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(298, 38);
            this.txtStudentId.TabIndex = 99;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(319, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 36);
            this.btnCancel.TabIndex = 98;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 97;
            this.label5.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.txtUsername.Location = new System.Drawing.Point(249, 302);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(298, 38);
            this.txtUsername.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 94;
            this.label1.Text = "Name";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.txtAccount.Location = new System.Drawing.Point(249, 400);
            this.txtAccount.Multiline = true;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(298, 38);
            this.txtAccount.TabIndex = 93;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(249, 206);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(298, 38);
            this.txtStudentName.TabIndex = 92;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(436, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 36);
            this.btnSave.TabIndex = 91;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // dashboardlbl
            // 
            this.dashboardlbl.AutoSize = true;
            this.dashboardlbl.Font = new System.Drawing.Font("Palatino Linotype", 12.8F, System.Drawing.FontStyle.Bold);
            this.dashboardlbl.Location = new System.Drawing.Point(231, 24);
            this.dashboardlbl.Name = "dashboardlbl";
            this.dashboardlbl.Size = new System.Drawing.Size(341, 29);
            this.dashboardlbl.TabIndex = 90;
            this.dashboardlbl.Text = "UPDATE STUDENT ACCOUNT";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.txtAddress.Location = new System.Drawing.Point(614, 273);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(298, 38);
            this.txtAddress.TabIndex = 101;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 529);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dashboardlbl);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label dashboardlbl;
        private System.Windows.Forms.TextBox txtAddress;
    }
}