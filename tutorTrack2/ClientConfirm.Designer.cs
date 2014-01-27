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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientConfirm));
            this.btnNoShow = new System.Windows.Forms.Button();
            this.login1 = new tutorTrack2.login();
            this.SuspendLayout();
            // 
            // btnNoShow
            // 
            this.btnNoShow.Location = new System.Drawing.Point(192, 57);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(75, 23);
            this.btnNoShow.TabIndex = 1;
            this.btnNoShow.Text = "No Show";
            this.btnNoShow.UseVisualStyleBackColor = true;
            this.btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);
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
            this.ClientSize = new System.Drawing.Size(284, 85);
            this.Controls.Add(this.btnNoShow);
            this.Controls.Add(this.login1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientConfirm";
            this.Text = "Client:";
            this.ResumeLayout(false);

        }

        #endregion

        private login login1;
        private System.Windows.Forms.Button btnNoShow;
    }
}