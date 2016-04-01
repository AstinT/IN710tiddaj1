namespace ProgressIndicator
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
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rbNumericUpDown = new System.Windows.Forms.RadioButton();
            this.rbTrackBar = new System.Windows.Forms.RadioButton();
            this.rbProgressBar = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbProgressBar);
            this.groupBox1.Controls.Add(this.rbTrackBar);
            this.groupBox1.Controls.Add(this.rbNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress Indicators";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 148);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 271);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(542, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(24, 209);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(542, 45);
            this.trackBar1.TabIndex = 3;
            // 
            // rbNumericUpDown
            // 
            this.rbNumericUpDown.AutoSize = true;
            this.rbNumericUpDown.Location = new System.Drawing.Point(11, 29);
            this.rbNumericUpDown.Name = "rbNumericUpDown";
            this.rbNumericUpDown.Size = new System.Drawing.Size(112, 17);
            this.rbNumericUpDown.TabIndex = 0;
            this.rbNumericUpDown.TabStop = true;
            this.rbNumericUpDown.Text = "Numeric Up Down";
            this.rbNumericUpDown.UseVisualStyleBackColor = true;
            // 
            // rbTrackBar
            // 
            this.rbTrackBar.AutoSize = true;
            this.rbTrackBar.Location = new System.Drawing.Point(11, 62);
            this.rbTrackBar.Name = "rbTrackBar";
            this.rbTrackBar.Size = new System.Drawing.Size(72, 17);
            this.rbTrackBar.TabIndex = 1;
            this.rbTrackBar.TabStop = true;
            this.rbTrackBar.Text = "Track Bar";
            this.rbTrackBar.UseVisualStyleBackColor = true;
            // 
            // rbProgressBar
            // 
            this.rbProgressBar.AutoSize = true;
            this.rbProgressBar.Location = new System.Drawing.Point(11, 93);
            this.rbProgressBar.Name = "rbProgressBar";
            this.rbProgressBar.Size = new System.Drawing.Size(82, 17);
            this.rbProgressBar.TabIndex = 2;
            this.rbProgressBar.TabStop = true;
            this.rbProgressBar.Text = "ProgressBar";
            this.rbProgressBar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(353, 87);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 315);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbProgressBar;
        private System.Windows.Forms.RadioButton rbTrackBar;
        private System.Windows.Forms.RadioButton rbNumericUpDown;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

