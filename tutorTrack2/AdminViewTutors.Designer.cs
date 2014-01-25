namespace tutorTrack2
{
    partial class AdminViewTutors
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clientListing1 = new tutorTrack2.clientListing();
            this.tutorCourseList1 = new tutorTrack2.TutorCourseList();
            this.btnFinished = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 186);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // clientListing1
            // 
            this.clientListing1.Location = new System.Drawing.Point(12, 291);
            this.clientListing1.Name = "clientListing1";
            this.clientListing1.Size = new System.Drawing.Size(756, 187);
            this.clientListing1.TabIndex = 2;
            this.clientListing1.Visible = false;
            // 
            // tutorCourseList1
            // 
            this.tutorCourseList1.Location = new System.Drawing.Point(12, 12);
            this.tutorCourseList1.Name = "tutorCourseList1";
            this.tutorCourseList1.Size = new System.Drawing.Size(675, 273);
            this.tutorCourseList1.TabIndex = 1;
            this.tutorCourseList1.Visible = false;
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(708, 13);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(75, 44);
            this.btnFinished.TabIndex = 3;
            this.btnFinished.Text = "Done";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // AdminViewTutors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 484);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.clientListing1);
            this.Controls.Add(this.tutorCourseList1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminViewTutors";
            this.Text = "Select a Tutor";
            this.Load += new System.EventHandler(this.AdminViewTutors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private TutorCourseList tutorCourseList1;
        private clientListing clientListing1;
        private System.Windows.Forms.Button btnFinished;
    }
}