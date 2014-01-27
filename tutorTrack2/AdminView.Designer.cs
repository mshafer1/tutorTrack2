namespace tutorTrack2
{
    partial class AdminControl
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
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnSheets = new System.Windows.Forms.Button();
            this.btnUserView = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(19, 58);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(75, 23);
            this.btnLogs.TabIndex = 0;
            this.btnLogs.Text = "View Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(19, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Add User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnSheets
            // 
            this.btnSheets.Location = new System.Drawing.Point(19, 87);
            this.btnSheets.Name = "btnSheets";
            this.btnSheets.Size = new System.Drawing.Size(75, 40);
            this.btnSheets.TabIndex = 2;
            this.btnSheets.Text = "Print Time Sheets";
            this.btnSheets.UseVisualStyleBackColor = true;
            this.btnSheets.Click += new System.EventHandler(this.btnSheets_Click);
            // 
            // btnUserView
            // 
            this.btnUserView.Location = new System.Drawing.Point(19, 29);
            this.btnUserView.Name = "btnUserView";
            this.btnUserView.Size = new System.Drawing.Size(75, 23);
            this.btnUserView.TabIndex = 1;
            this.btnUserView.Text = "View Tutor";
            this.btnUserView.UseVisualStyleBackColor = true;
            this.btnUserView.Click += new System.EventHandler(this.btnUserView_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(115, 87);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(79, 40);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Return to login";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnSheets);
            this.Controls.Add(this.btnUserView);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogs);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(204, 138);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnSheets;
        private System.Windows.Forms.Button btnUserView;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
