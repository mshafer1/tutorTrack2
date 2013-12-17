namespace tutorTrack2
{
    partial class Admin
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
            this.SuspendLayout();
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(19, 29);
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
            this.btnSheets.Location = new System.Drawing.Point(19, 59);
            this.btnSheets.Name = "btnSheets";
            this.btnSheets.Size = new System.Drawing.Size(75, 40);
            this.btnSheets.TabIndex = 2;
            this.btnSheets.Text = "Print Time Sheets";
            this.btnSheets.UseVisualStyleBackColor = true;
            this.btnSheets.Click += new System.EventHandler(this.btnSheets_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSheets);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogs);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(119, 102);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnSheets;
    }
}
