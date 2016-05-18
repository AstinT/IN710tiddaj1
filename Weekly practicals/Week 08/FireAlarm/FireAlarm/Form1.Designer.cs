namespace FireAlarm
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
            this.btnFireAlarm = new System.Windows.Forms.Button();
            this.gpFireCategory = new System.Windows.Forms.GroupBox();
            this.rbInferno = new System.Windows.Forms.RadioButton();
            this.rbSerious = new System.Windows.Forms.RadioButton();
            this.rbMinor = new System.Windows.Forms.RadioButton();
            this.gpFireCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFireAlarm
            // 
            this.btnFireAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireAlarm.Location = new System.Drawing.Point(13, 13);
            this.btnFireAlarm.Name = "btnFireAlarm";
            this.btnFireAlarm.Size = new System.Drawing.Size(236, 63);
            this.btnFireAlarm.TabIndex = 0;
            this.btnFireAlarm.Text = "Fire Alarm";
            this.btnFireAlarm.UseVisualStyleBackColor = true;
            this.btnFireAlarm.Click += new System.EventHandler(this.btnFireAlarm_Click);
            // 
            // gpFireCategory
            // 
            this.gpFireCategory.Controls.Add(this.rbInferno);
            this.gpFireCategory.Controls.Add(this.rbSerious);
            this.gpFireCategory.Controls.Add(this.rbMinor);
            this.gpFireCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFireCategory.Location = new System.Drawing.Point(13, 83);
            this.gpFireCategory.Name = "gpFireCategory";
            this.gpFireCategory.Size = new System.Drawing.Size(236, 231);
            this.gpFireCategory.TabIndex = 1;
            this.gpFireCategory.TabStop = false;
            this.gpFireCategory.Text = "Fire Category";
            // 
            // rbInferno
            // 
            this.rbInferno.AutoSize = true;
            this.rbInferno.Location = new System.Drawing.Point(18, 165);
            this.rbInferno.Name = "rbInferno";
            this.rbInferno.Size = new System.Drawing.Size(97, 30);
            this.rbInferno.TabIndex = 2;
            this.rbInferno.TabStop = true;
            this.rbInferno.Text = "Inferno";
            this.rbInferno.UseVisualStyleBackColor = true;
            // 
            // rbSerious
            // 
            this.rbSerious.AutoSize = true;
            this.rbSerious.Location = new System.Drawing.Point(18, 109);
            this.rbSerious.Name = "rbSerious";
            this.rbSerious.Size = new System.Drawing.Size(104, 30);
            this.rbSerious.TabIndex = 1;
            this.rbSerious.TabStop = true;
            this.rbSerious.Text = "Serious";
            this.rbSerious.UseVisualStyleBackColor = true;
            // 
            // rbMinor
            // 
            this.rbMinor.AutoSize = true;
            this.rbMinor.Location = new System.Drawing.Point(18, 53);
            this.rbMinor.Name = "rbMinor";
            this.rbMinor.Size = new System.Drawing.Size(84, 30);
            this.rbMinor.TabIndex = 0;
            this.rbMinor.TabStop = true;
            this.rbMinor.Text = "Minor";
            this.rbMinor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 326);
            this.Controls.Add(this.gpFireCategory);
            this.Controls.Add(this.btnFireAlarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpFireCategory.ResumeLayout(false);
            this.gpFireCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFireAlarm;
        private System.Windows.Forms.GroupBox gpFireCategory;
        private System.Windows.Forms.RadioButton rbInferno;
        private System.Windows.Forms.RadioButton rbSerious;
        private System.Windows.Forms.RadioButton rbMinor;
    }
}

