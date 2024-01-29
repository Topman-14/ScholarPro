namespace ScholarPro_CSC221_Project
{
    partial class viewCourseStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.courseTitle = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.instrutName = new System.Windows.Forms.Label();
            this.contentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.courseContent = new System.Windows.Forms.Label();
            this.contentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Course Details";
            // 
            // courseTitle
            // 
            this.courseTitle.AutoSize = true;
            this.courseTitle.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTitle.ForeColor = System.Drawing.Color.White;
            this.courseTitle.Location = new System.Drawing.Point(18, 85);
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.Size = new System.Drawing.Size(415, 46);
            this.courseTitle.TabIndex = 12;
            this.courseTitle.Text = "CSC 225 Fundamentals";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(31, 170);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(227, 18);
            this.description.TabIndex = 11;
            this.description.Text = "This is the description for the Course";
            // 
            // instrutName
            // 
            this.instrutName.AutoSize = true;
            this.instrutName.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrutName.ForeColor = System.Drawing.Color.White;
            this.instrutName.Location = new System.Drawing.Point(28, 135);
            this.instrutName.Name = "instrutName";
            this.instrutName.Size = new System.Drawing.Size(157, 27);
            this.instrutName.TabIndex = 11;
            this.instrutName.Text = "By Mr Omosebi";
            this.instrutName.Click += new System.EventHandler(this.label3_Click);
            // 
            // contentContainer
            // 
            this.contentContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.contentContainer.Controls.Add(this.courseContent);
            this.contentContainer.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentContainer.Location = new System.Drawing.Point(37, 233);
            this.contentContainer.Name = "contentContainer";
            this.contentContainer.Size = new System.Drawing.Size(759, 198);
            this.contentContainer.TabIndex = 13;
            // 
            // courseContent
            // 
            this.courseContent.AutoSize = true;
            this.courseContent.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseContent.ForeColor = System.Drawing.Color.White;
            this.courseContent.Location = new System.Drawing.Point(3, 0);
            this.courseContent.Name = "courseContent";
            this.courseContent.Padding = new System.Windows.Forms.Padding(5);
            this.courseContent.Size = new System.Drawing.Size(74, 32);
            this.courseContent.TabIndex = 0;
            this.courseContent.Text = "Hellooo";
            // 
            // viewCourseStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(829, 458);
            this.Controls.Add(this.contentContainer);
            this.Controls.Add(this.courseTitle);
            this.Controls.Add(this.description);
            this.Controls.Add(this.instrutName);
            this.Controls.Add(this.label1);
            this.Name = "viewCourseStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Course | Student";
            this.Load += new System.EventHandler(this.viewCourseStudent_Load);
            this.contentContainer.ResumeLayout(false);
            this.contentContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label courseTitle;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label instrutName;
        private System.Windows.Forms.FlowLayoutPanel contentContainer;
        private System.Windows.Forms.Label courseContent;

    }
}