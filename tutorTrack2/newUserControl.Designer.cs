namespace tutorTrack2
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
            this.cBCourses = new System.Windows.Forms.ComboBox();
            this.cBTutors = new System.Windows.Forms.ComboBox();
            this.gBClient = new System.Windows.Forms.GroupBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBid = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.gBtutor = new System.Windows.Forms.GroupBox();
            this.lbTutorCourses = new System.Windows.Forms.ListBox();
            this.gBClient.SuspendLayout();
            this.gBtutor.SuspendLayout();
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
            // cBCourses
            // 
            this.cBCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCourses.FormattingEnabled = true;
            this.cBCourses.Location = new System.Drawing.Point(13, 13);
            this.cBCourses.Name = "cBCourses";
            this.cBCourses.Size = new System.Drawing.Size(121, 21);
            this.cBCourses.TabIndex = 2;
            this.cBCourses.DropDown += new System.EventHandler(this.cBCourses_DropDown);
            this.cBCourses.SelectedIndexChanged += new System.EventHandler(this.Courses_SelectedIndexChanged);
            // 
            // cBTutors
            // 
            this.cBTutors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTutors.FormattingEnabled = true;
            this.cBTutors.Location = new System.Drawing.Point(13, 40);
            this.cBTutors.Name = "cBTutors";
            this.cBTutors.Size = new System.Drawing.Size(121, 21);
            this.cBTutors.TabIndex = 2;
            this.cBTutors.SelectedIndexChanged += new System.EventHandler(this.Tutors_SelectedIndexChanged);
            // 
            // gBClient
            // 
            this.gBClient.Controls.Add(this.cBTutors);
            this.gBClient.Controls.Add(this.cBCourses);
            this.gBClient.Location = new System.Drawing.Point(4, 121);
            this.gBClient.Name = "gBClient";
            this.gBClient.Size = new System.Drawing.Size(177, 129);
            this.gBClient.TabIndex = 3;
            this.gBClient.TabStop = false;
            this.gBClient.Text = " ";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(4, 52);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(177, 20);
            this.tBName.TabIndex = 4;
            this.tBName.Text = "Enter New User Name";
            this.tBName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tBName_MouseClick);
            this.tBName.TextChanged += new System.EventHandler(this.tBName_TextChanged);
            // 
            // tBid
            // 
            this.tBid.Location = new System.Drawing.Point(4, 79);
            this.tBid.Name = "tBid";
            this.tBid.Size = new System.Drawing.Size(177, 20);
            this.tBid.TabIndex = 5;
            this.tBid.Text = "Enter New User ID (H number)";
            this.tBid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxID_MouseClick);
            this.tBid.TextChanged += new System.EventHandler(this.tBid_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(130, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // gBtutor
            // 
            this.gBtutor.Controls.Add(this.lbTutorCourses);
            this.gBtutor.Location = new System.Drawing.Point(4, 105);
            this.gBtutor.Name = "gBtutor";
            this.gBtutor.Size = new System.Drawing.Size(178, 144);
            this.gBtutor.TabIndex = 8;
            this.gBtutor.TabStop = false;
            this.gBtutor.Text = " ";
            // 
            // lbTutorCourses
            // 
            this.lbTutorCourses.FormattingEnabled = true;
            this.lbTutorCourses.Location = new System.Drawing.Point(8, 13);
            this.lbTutorCourses.Name = "lbTutorCourses";
            this.lbTutorCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTutorCourses.Size = new System.Drawing.Size(120, 121);
            this.lbTutorCourses.TabIndex = 0;
            // 
            // newUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBtutor);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tBid);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.gBClient);
            this.Controls.Add(this.rbTutor);
            this.Controls.Add(this.rbClient);
            this.Name = "newUserControl";
            this.Size = new System.Drawing.Size(220, 282);
            this.gBClient.ResumeLayout(false);
            this.gBtutor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbTutor;
        private System.Windows.Forms.ComboBox cBCourses;
        private System.Windows.Forms.ComboBox cBTutors;
        private System.Windows.Forms.GroupBox gBClient;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBid;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gBtutor;
        private System.Windows.Forms.ListBox lbTutorCourses;
    }
}
