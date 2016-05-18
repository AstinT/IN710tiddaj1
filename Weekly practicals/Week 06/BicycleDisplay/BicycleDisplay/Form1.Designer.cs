namespace BicycleDisplay
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
            this.btnChangeSpeed = new System.Windows.Forms.Button();
            this.tbChangeRpm = new System.Windows.Forms.TextBox();
            this.gbRpm = new System.Windows.Forms.GroupBox();
            this.gbCalories = new System.Windows.Forms.GroupBox();
            this.gbKmsPerHour = new System.Windows.Forms.GroupBox();
            this.lblRpm = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblKmsPerHour = new System.Windows.Forms.Label();
            this.gbRpm.SuspendLayout();
            this.gbCalories.SuspendLayout();
            this.gbKmsPerHour.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeSpeed
            // 
            this.btnChangeSpeed.Location = new System.Drawing.Point(13, 13);
            this.btnChangeSpeed.Name = "btnChangeSpeed";
            this.btnChangeSpeed.Size = new System.Drawing.Size(179, 72);
            this.btnChangeSpeed.TabIndex = 0;
            this.btnChangeSpeed.Text = "Change Speed";
            this.btnChangeSpeed.UseVisualStyleBackColor = true;
            this.btnChangeSpeed.Click += new System.EventHandler(this.btnChangeSpeed_Click);
            // 
            // tbChangeRpm
            // 
            this.tbChangeRpm.Location = new System.Drawing.Point(208, 40);
            this.tbChangeRpm.Name = "tbChangeRpm";
            this.tbChangeRpm.Size = new System.Drawing.Size(147, 20);
            this.tbChangeRpm.TabIndex = 1;
            // 
            // gbRpm
            // 
            this.gbRpm.Controls.Add(this.lblRpm);
            this.gbRpm.Location = new System.Drawing.Point(13, 111);
            this.gbRpm.Name = "gbRpm";
            this.gbRpm.Size = new System.Drawing.Size(342, 100);
            this.gbRpm.TabIndex = 2;
            this.gbRpm.TabStop = false;
            this.gbRpm.Text = "Rpm";
            // 
            // gbCalories
            // 
            this.gbCalories.Controls.Add(this.lblCalories);
            this.gbCalories.Location = new System.Drawing.Point(13, 217);
            this.gbCalories.Name = "gbCalories";
            this.gbCalories.Size = new System.Drawing.Size(342, 100);
            this.gbCalories.TabIndex = 3;
            this.gbCalories.TabStop = false;
            this.gbCalories.Text = "Calories Per Hour";
            // 
            // gbKmsPerHour
            // 
            this.gbKmsPerHour.Controls.Add(this.lblKmsPerHour);
            this.gbKmsPerHour.Location = new System.Drawing.Point(12, 323);
            this.gbKmsPerHour.Name = "gbKmsPerHour";
            this.gbKmsPerHour.Size = new System.Drawing.Size(342, 100);
            this.gbKmsPerHour.TabIndex = 4;
            this.gbKmsPerHour.TabStop = false;
            this.gbKmsPerHour.Text = "Kms Per Hour";
            // 
            // lblRpm
            // 
            this.lblRpm.AutoSize = true;
            this.lblRpm.Location = new System.Drawing.Point(143, 38);
            this.lblRpm.Name = "lblRpm";
            this.lblRpm.Size = new System.Drawing.Size(22, 13);
            this.lblRpm.TabIndex = 0;
            this.lblRpm.Text = "0.0";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(142, 41);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(22, 13);
            this.lblCalories.TabIndex = 0;
            this.lblCalories.Text = "0.0";
            // 
            // lblKmsPerHour
            // 
            this.lblKmsPerHour.AutoSize = true;
            this.lblKmsPerHour.Location = new System.Drawing.Point(144, 41);
            this.lblKmsPerHour.Name = "lblKmsPerHour";
            this.lblKmsPerHour.Size = new System.Drawing.Size(22, 13);
            this.lblKmsPerHour.TabIndex = 0;
            this.lblKmsPerHour.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 435);
            this.Controls.Add(this.gbKmsPerHour);
            this.Controls.Add(this.gbCalories);
            this.Controls.Add(this.gbRpm);
            this.Controls.Add(this.tbChangeRpm);
            this.Controls.Add(this.btnChangeSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbRpm.ResumeLayout(false);
            this.gbRpm.PerformLayout();
            this.gbCalories.ResumeLayout(false);
            this.gbCalories.PerformLayout();
            this.gbKmsPerHour.ResumeLayout(false);
            this.gbKmsPerHour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeSpeed;
        private System.Windows.Forms.TextBox tbChangeRpm;
        private System.Windows.Forms.GroupBox gbRpm;
        private System.Windows.Forms.Label lblRpm;
        private System.Windows.Forms.GroupBox gbCalories;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.GroupBox gbKmsPerHour;
        private System.Windows.Forms.Label lblKmsPerHour;
    }
}

