namespace BeehiveManagementSystem
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWorkNextShift = new System.Windows.Forms.Button();
            this.cmbWorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbWorkerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // btnWorkNextShift
            // 
            this.btnWorkNextShift.Location = new System.Drawing.Point(521, 38);
            this.btnWorkNextShift.Name = "btnWorkNextShift";
            this.btnWorkNextShift.Size = new System.Drawing.Size(206, 148);
            this.btnWorkNextShift.TabIndex = 0;
            this.btnWorkNextShift.Text = "Work the next shift";
            this.btnWorkNextShift.UseVisualStyleBackColor = true;
            // 
            // cmbWorkerBeeJob
            // 
            this.cmbWorkerBeeJob.FormattingEnabled = true;
            this.cmbWorkerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.cmbWorkerBeeJob.Location = new System.Drawing.Point(29, 38);
            this.cmbWorkerBeeJob.Name = "cmbWorkerBeeJob";
            this.cmbWorkerBeeJob.Size = new System.Drawing.Size(121, 21);
            this.cmbWorkerBeeJob.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnWorkNextShift);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbWorkerBeeJob;
        private System.Windows.Forms.Button btnWorkNextShift;
    }
}

