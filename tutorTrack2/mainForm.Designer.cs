namespace tutorTrack2
{
    partial class mainForm
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
            this.newUserControl1 = new tutorTrack2.newUserControl();
            this.admin1 = new tutorTrack2.AdminControl();
            this.login1 = new tutorTrack2.login();
            this.tutorLoggedIn1 = new tutorTrack2.TutorLoggedIn();
            this.SuspendLayout();
            // 
            // newUserControl1
            // 
            this.newUserControl1.Location = new System.Drawing.Point(-1, 0);
            this.newUserControl1.Name = "newUserControl1";
            this.newUserControl1.Size = new System.Drawing.Size(299, 310);
            this.newUserControl1.TabIndex = 2;
            this.newUserControl1.Visible = false;
            // 
            // admin1
            // 
            this.admin1.Location = new System.Drawing.Point(69, 30);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(119, 102);
            this.admin1.TabIndex = 1;
            this.admin1.Visible = false;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(18, 30);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(269, 50);
            this.login1.TabIndex = 0;
            // 
            // tutorLoggedIn1
            // 
            this.tutorLoggedIn1.Location = new System.Drawing.Point(107, 30);
            this.tutorLoggedIn1.Name = "tutorLoggedIn1";
            this.tutorLoggedIn1.Size = new System.Drawing.Size(93, 136);
            this.tutorLoggedIn1.TabIndex = 3;
            this.tutorLoggedIn1.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 326);
            this.Controls.Add(this.tutorLoggedIn1);
            this.Controls.Add(this.newUserControl1);
            this.Controls.Add(this.admin1);
            this.Controls.Add(this.login1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private login login1;
        private AdminControl admin1;
        private newUserControl newUserControl1;
        private TutorLoggedIn tutorLoggedIn1;

    }
}

