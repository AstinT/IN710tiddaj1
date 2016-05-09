namespace LINQ_External
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAveStrike = new System.Windows.Forms.Button();
            this.btnLargeThreeFires = new System.Windows.Forms.Button();
            this.btnPictures = new System.Windows.Forms.Button();
            this.btnFireStrikes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(642, 316);
            this.listBox1.TabIndex = 0;
            // 
            // btnAveStrike
            // 
            this.btnAveStrike.Location = new System.Drawing.Point(13, 13);
            this.btnAveStrike.Name = "btnAveStrike";
            this.btnAveStrike.Size = new System.Drawing.Size(156, 24);
            this.btnAveStrike.TabIndex = 1;
            this.btnAveStrike.Text = "Average Strike Intensity";
            this.btnAveStrike.UseVisualStyleBackColor = true;
            this.btnAveStrike.Click += new System.EventHandler(this.btnAveStrike_Click);
            // 
            // btnLargeThreeFires
            // 
            this.btnLargeThreeFires.Location = new System.Drawing.Point(175, 13);
            this.btnLargeThreeFires.Name = "btnLargeThreeFires";
            this.btnLargeThreeFires.Size = new System.Drawing.Size(156, 24);
            this.btnLargeThreeFires.TabIndex = 2;
            this.btnLargeThreeFires.Text = "Three Largest Fires";
            this.btnLargeThreeFires.UseVisualStyleBackColor = true;
            this.btnLargeThreeFires.Click += new System.EventHandler(this.btnLargeThreeFires_Click);
            // 
            // btnPictures
            // 
            this.btnPictures.Location = new System.Drawing.Point(337, 12);
            this.btnPictures.Name = "btnPictures";
            this.btnPictures.Size = new System.Drawing.Size(156, 24);
            this.btnPictures.TabIndex = 3;
            this.btnPictures.Text = "All Pictures";
            this.btnPictures.UseVisualStyleBackColor = true;
            this.btnPictures.Click += new System.EventHandler(this.btnPictures_Click);
            // 
            // btnFireStrikes
            // 
            this.btnFireStrikes.Location = new System.Drawing.Point(499, 12);
            this.btnFireStrikes.Name = "btnFireStrikes";
            this.btnFireStrikes.Size = new System.Drawing.Size(156, 24);
            this.btnFireStrikes.TabIndex = 4;
            this.btnFireStrikes.Text = "List Fires/Lightning Strikes";
            this.btnFireStrikes.UseVisualStyleBackColor = true;
            this.btnFireStrikes.Click += new System.EventHandler(this.btnFireStrikes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 372);
            this.Controls.Add(this.btnFireStrikes);
            this.Controls.Add(this.btnPictures);
            this.Controls.Add(this.btnLargeThreeFires);
            this.Controls.Add(this.btnAveStrike);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAveStrike;
        private System.Windows.Forms.Button btnLargeThreeFires;
        private System.Windows.Forms.Button btnPictures;
        private System.Windows.Forms.Button btnFireStrikes;
    }
}

