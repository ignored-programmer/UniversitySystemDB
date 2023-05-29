namespace UniversitySystemDB
{
    partial class HomePage
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
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_prfsr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(302, 130);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(135, 67);
            this.btn_student.TabIndex = 0;
            this.btn_student.Text = "دانشجویان";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_prfsr
            // 
            this.btn_prfsr.Location = new System.Drawing.Point(86, 130);
            this.btn_prfsr.Name = "btn_prfsr";
            this.btn_prfsr.Size = new System.Drawing.Size(135, 67);
            this.btn_prfsr.TabIndex = 1;
            this.btn_prfsr.Text = "اساتید";
            this.btn_prfsr.UseVisualStyleBackColor = true;
            this.btn_prfsr.Click += new System.EventHandler(this.btn_prfsr_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 312);
            this.Controls.Add(this.btn_prfsr);
            this.Controls.Add(this.btn_student);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_prfsr;
    }
}