namespace tutorTrack2
{
    partial class ClientConfirm
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
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(12, 12);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(269, 50);
            this.login1.TabIndex = 0;
            // 
            // ClientConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.login1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientConfirm";
            this.Text = "Client:";
            this.ResumeLayout(false);

        }

        #endregion

        private login login1;
    }
}