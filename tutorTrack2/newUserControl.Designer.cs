﻿namespace tutorTrack2
{
    partial class newUserControl
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
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.rbTutor = new System.Windows.Forms.RadioButton();
            this.gBClient = new System.Windows.Forms.GroupBox();
            this.lblTutorSelectMust = new System.Windows.Forms.Label();
            this.cbTutors = new System.Windows.Forms.ComboBox();
            this.cBCourses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBid = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(4, 4);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(51, 17);
            this.rbClient.TabIndex = 0;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbClient_CheckedChanged);
            // 
            // rbTutor
            // 
            this.rbTutor.AutoSize = true;
            this.rbTutor.Location = new System.Drawing.Point(4, 28);
            this.rbTutor.Name = "rbTutor";
            this.rbTutor.Size = new System.Drawing.Size(50, 17);
            this.rbTutor.TabIndex = 1;
            this.rbTutor.TabStop = true;
            this.rbTutor.Text = "Tutor";
            this.rbTutor.UseVisualStyleBackColor = true;
            this.rbTutor.CheckedChanged += new System.EventHandler(this.rbTutor_CheckedChanged);
            // 
            // gBClient
            // 
            this.gBClient.Controls.Add(this.lblTutorSelectMust);
            this.gBClient.Controls.Add(this.cbTutors);
            this.gBClient.Controls.Add(this.cBCourses);
            this.gBClient.Controls.Add(this.label3);
            this.gBClient.Location = new System.Drawing.Point(7, 132);
            this.gBClient.Name = "gBClient";
            this.gBClient.Size = new System.Drawing.Size(283, 129);
            this.gBClient.TabIndex = 3;
            this.gBClient.TabStop = false;
            this.gBClient.Text = " ";
            // 
            // lblTutorSelectMust
            // 
            this.lblTutorSelectMust.AutoSize = true;
            this.lblTutorSelectMust.Enabled = false;
            this.lblTutorSelectMust.Location = new System.Drawing.Point(139, 12);
            this.lblTutorSelectMust.Name = "lblTutorSelectMust";
            this.lblTutorSelectMust.Size = new System.Drawing.Size(94, 13);
            this.lblTutorSelectMust.TabIndex = 20;
            this.lblTutorSelectMust.Text = "Must select a tutor";
            this.lblTutorSelectMust.Visible = false;
            // 
            // cbTutors
            // 
            this.cbTutors.FormattingEnabled = true;
            this.cbTutors.Location = new System.Drawing.Point(139, 28);
            this.cbTutors.Name = "cbTutors";
            this.cbTutors.Size = new System.Drawing.Size(121, 21);
            this.cbTutors.TabIndex = 5;
            this.cbTutors.SelectedIndexChanged += new System.EventHandler(this.Tutors_SelectedIndexChanged);
            // 
            // cBCourses
            // 
            this.cBCourses.FormattingEnabled = true;
            this.cBCourses.Location = new System.Drawing.Point(12, 28);
            this.cBCourses.Name = "cBCourses";
            this.cBCourses.Size = new System.Drawing.Size(120, 95);
            this.cBCourses.TabIndex = 4;
            this.cBCourses.SelectedIndexChanged += new System.EventHandler(this.Courses_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Must select a course";
            this.label3.Visible = false;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(3, 79);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(177, 20);
            this.tBName.TabIndex = 2;
            this.tBName.Text = "Enter New User Name";
            this.tBName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tBName_MouseClick);
            this.tBName.TextChanged += new System.EventHandler(this.tBName_TextChanged);
            // 
            // tBid
            // 
            this.tBid.AcceptsTab = true;
            this.tBid.Location = new System.Drawing.Point(3, 106);
            this.tBid.Name = "tBid";
            this.tBid.Size = new System.Drawing.Size(177, 20);
            this.tBid.TabIndex = 3;
            this.tBid.Text = "Enter New User ID (H number)";
            this.tBid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxID_MouseClick);
            this.tBid.TextChanged += new System.EventHandler(this.tBid_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(38, 280);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Must enter a name";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Must enter an id#";
            this.label2.Visible = false;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(4, 52);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdbAdmin.TabIndex = 2;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            this.rdbAdmin.CheckedChanged += new System.EventHandler(this.rdbAdmin_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // newUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rdbAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tBid);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.gBClient);
            this.Controls.Add(this.rbTutor);
            this.Controls.Add(this.rbClient);
            this.Name = "newUserControl";
            this.Size = new System.Drawing.Size(290, 306);
            this.Load += new System.EventHandler(this.newUserControl_Load);
            this.gBClient.ResumeLayout(false);
            this.gBClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbTutor;
        private System.Windows.Forms.GroupBox gBClient;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBid;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.ListBox cBCourses;
        private System.Windows.Forms.ComboBox cbTutors;
        private System.Windows.Forms.Label lblTutorSelectMust;
        private System.Windows.Forms.Button btnCancel;
    }
}
