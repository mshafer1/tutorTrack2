﻿namespace tutorTrack2
{
    partial class TutorLoggedIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClient = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(3, 45);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(83, 38);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Clients";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(3, 89);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(83, 39);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(3, 0);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(83, 39);
            this.btnAppointment.TabIndex = 0;
            this.btnAppointment.Text = "Start Appointment";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(3, 134);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Return to login Screen";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TutorLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnClient);
            this.Name = "TutorLoggedIn";
            this.Size = new System.Drawing.Size(97, 186);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnExit;
    }
}
