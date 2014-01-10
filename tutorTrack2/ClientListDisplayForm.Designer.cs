namespace tutorTrack2
{
    partial class ClientListDisplayForm
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
            this.clientListing1 = new tutorTrack2.clientListing();
            this.SuspendLayout();
            // 
            // clientListing1
            // 
            this.clientListing1.Location = new System.Drawing.Point(2, -2);
            this.clientListing1.Name = "clientListing1";
            this.clientListing1.Size = new System.Drawing.Size(525, 188);
            this.clientListing1.TabIndex = 0;
            // 
            // ClientListDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 186);
            this.Controls.Add(this.clientListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientListDisplayForm";
            this.Text = "ClientListDisplayForm";
            this.ResumeLayout(false);

        }

        #endregion

        public clientListing clientListing1;
    }
}