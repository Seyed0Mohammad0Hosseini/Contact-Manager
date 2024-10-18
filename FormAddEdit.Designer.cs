namespace ContactsProject
{
    partial class FormAddEdit
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
            this.grbNewInformation = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSavedInformation = new System.Windows.Forms.Button();
            this.grbNewInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNewInformation
            // 
            this.grbNewInformation.BackColor = System.Drawing.SystemColors.Control;
            this.grbNewInformation.Controls.Add(this.txtEmail);
            this.grbNewInformation.Controls.Add(this.txtJob);
            this.grbNewInformation.Controls.Add(this.txtAge);
            this.grbNewInformation.Controls.Add(this.txtLastName);
            this.grbNewInformation.Controls.Add(this.txtFirstName);
            this.grbNewInformation.Controls.Add(this.lblEmail);
            this.grbNewInformation.Controls.Add(this.lblJob);
            this.grbNewInformation.Controls.Add(this.lblAge);
            this.grbNewInformation.Controls.Add(this.lblLastName);
            this.grbNewInformation.Controls.Add(this.lblFirstName);
            this.grbNewInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grbNewInformation.Location = new System.Drawing.Point(8, 9);
            this.grbNewInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbNewInformation.Name = "grbNewInformation";
            this.grbNewInformation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbNewInformation.Size = new System.Drawing.Size(567, 337);
            this.grbNewInformation.TabIndex = 0;
            this.grbNewInformation.TabStop = false;
            this.grbNewInformation.Enter += new System.EventHandler(this.grbNewInformation_Enter);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(532, 48);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(30, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "نام :";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(484, 102);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(81, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "نام خانوادگی :";
            this.lblLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(532, 158);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(30, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "سن:";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(524, 219);
            this.lblJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(40, 20);
            this.lblJob.TabIndex = 3;
            this.lblJob.Text = "شغل :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(521, 278);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "ایمیل :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(244, 48);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 26);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(244, 102);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(202, 26);
            this.txtLastName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(244, 158);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(202, 26);
            this.txtAge.TabIndex = 7;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(244, 219);
            this.txtJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(202, 26);
            this.txtJob.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(244, 278);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // btnSavedInformation
            // 
            this.btnSavedInformation.Location = new System.Drawing.Point(224, 374);
            this.btnSavedInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavedInformation.Name = "btnSavedInformation";
            this.btnSavedInformation.Size = new System.Drawing.Size(106, 35);
            this.btnSavedInformation.TabIndex = 1;
            this.btnSavedInformation.Text = "ثبت";
            this.btnSavedInformation.UseVisualStyleBackColor = true;
            this.btnSavedInformation.Click += new System.EventHandler(this.btnSavedInformation_Click);
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 425);
            this.Controls.Add(this.btnSavedInformation);
            this.Controls.Add(this.grbNewInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormAddEdit_Load);
            this.grbNewInformation.ResumeLayout(false);
            this.grbNewInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNewInformation;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSavedInformation;
    }
}