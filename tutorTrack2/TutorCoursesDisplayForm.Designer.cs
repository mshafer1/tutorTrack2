namespace tutorTrack2
{
    partial class TutorCoursesDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorCoursesDisplayForm));
            this.tutorCourseList1 = new tutorTrack2.TutorCourseList();
            this.SuspendLayout();
            // 
            // tutorCourseList1
            // 
            this.tutorCourseList1.Location = new System.Drawing.Point(2, 1);
            this.tutorCourseList1.Name = "tutorCourseList1";
            this.tutorCourseList1.Size = new System.Drawing.Size(437, 183);
            this.tutorCourseList1.TabIndex = 0;
            // 
            // TutorCoursesDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 260);
            this.Controls.Add(this.tutorCourseList1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TutorCoursesDisplayForm";
            this.Text = "Tutor Courses";
            this.ResumeLayout(false);

        }

        #endregion

        private TutorCourseList tutorCourseList1;
    }
}