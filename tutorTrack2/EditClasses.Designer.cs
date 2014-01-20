namespace tutorTrack2
{
    partial class EditClasses
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
            this.lBCurrent = new System.Windows.Forms.ListBox();
            this.lBOptions = new System.Windows.Forms.ListBox();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBCurrent
            // 
            this.lBCurrent.FormattingEnabled = true;
            this.lBCurrent.Location = new System.Drawing.Point(262, 18);
            this.lBCurrent.Name = "lBCurrent";
            this.lBCurrent.Size = new System.Drawing.Size(170, 199);
            this.lBCurrent.Sorted = true;
            this.lBCurrent.TabIndex = 0;
            this.lBCurrent.TabStop = false;
            this.lBCurrent.UseTabStops = false;
            // 
            // lBOptions
            // 
            this.lBOptions.FormattingEnabled = true;
            this.lBOptions.Location = new System.Drawing.Point(0, 18);
            this.lBOptions.Name = "lBOptions";
            this.lBOptions.Size = new System.Drawing.Size(170, 199);
            this.lBOptions.TabIndex = 0;
            this.lBOptions.TabStop = false;
            this.lBOptions.UseTabStops = false;
            this.lBOptions.SelectedIndexChanged += new System.EventHandler(this.lBOptions_SelectedIndexChanged);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Location = new System.Drawing.Point(194, 96);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(35, 25);
            this.btnShiftLeft.TabIndex = 1;
            this.btnShiftLeft.Text = "<<";
            this.btnShiftLeft.UseVisualStyleBackColor = true;
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Location = new System.Drawing.Point(194, 65);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(35, 25);
            this.btnShiftRight.TabIndex = 1;
            this.btnShiftRight.Text = ">>";
            this.btnShiftRight.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Courses";
            // 
            // EditClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShiftRight);
            this.Controls.Add(this.btnShiftLeft);
            this.Controls.Add(this.lBOptions);
            this.Controls.Add(this.lBCurrent);
            this.Name = "EditClasses";
            this.Size = new System.Drawing.Size(435, 226);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBCurrent;
        private System.Windows.Forms.ListBox lBOptions;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
