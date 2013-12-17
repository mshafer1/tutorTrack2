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
            this.login1 = new tutorTrack2.login();
            this.admin1 = new tutorTrack2.Admin();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(18, 30);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(269, 50);
            this.login1.TabIndex = 0;
            // 
            // admin1
            // 
            this.admin1.Location = new System.Drawing.Point(69, 30);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(119, 102);
            this.admin1.TabIndex = 1;
            this.admin1.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 268);
            this.Controls.Add(this.admin1);
            this.Controls.Add(this.login1);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private login login1;
        private Admin admin1;

    }
}

