namespace Predicate_Practical
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
            this.btnGenerateRandoms = new System.Windows.Forms.Button();
            this.btnEvenNumbers = new System.Windows.Forms.Button();
            this.btnNumLess10 = new System.Windows.Forms.Button();
            this.lbSelectedNumbers = new System.Windows.Forms.ListBox();
            this.lbRandoms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerateRandoms
            // 
            this.btnGenerateRandoms.Location = new System.Drawing.Point(36, 45);
            this.btnGenerateRandoms.Name = "btnGenerateRandoms";
            this.btnGenerateRandoms.Size = new System.Drawing.Size(171, 23);
            this.btnGenerateRandoms.TabIndex = 0;
            this.btnGenerateRandoms.Text = "Generate Randoms";
            this.btnGenerateRandoms.UseVisualStyleBackColor = true;
            this.btnGenerateRandoms.Click += new System.EventHandler(this.btnGenerateRandoms_Click);
            // 
            // btnEvenNumbers
            // 
            this.btnEvenNumbers.Location = new System.Drawing.Point(270, 45);
            this.btnEvenNumbers.Name = "btnEvenNumbers";
            this.btnEvenNumbers.Size = new System.Drawing.Size(171, 23);
            this.btnEvenNumbers.TabIndex = 1;
            this.btnEvenNumbers.Text = "Select Even Numbers";
            this.btnEvenNumbers.UseVisualStyleBackColor = true;
            this.btnEvenNumbers.Click += new System.EventHandler(this.btnEvenNumbers_Click);
            // 
            // btnNumLess10
            // 
            this.btnNumLess10.Location = new System.Drawing.Point(270, 95);
            this.btnNumLess10.Name = "btnNumLess10";
            this.btnNumLess10.Size = new System.Drawing.Size(171, 23);
            this.btnNumLess10.TabIndex = 2;
            this.btnNumLess10.Text = "Select Numbers < 10";
            this.btnNumLess10.UseVisualStyleBackColor = true;
            this.btnNumLess10.Click += new System.EventHandler(this.btnNumLess10_Click);
            // 
            // lbSelectedNumbers
            // 
            this.lbSelectedNumbers.FormattingEnabled = true;
            this.lbSelectedNumbers.Location = new System.Drawing.Point(270, 144);
            this.lbSelectedNumbers.Name = "lbSelectedNumbers";
            this.lbSelectedNumbers.Size = new System.Drawing.Size(171, 472);
            this.lbSelectedNumbers.TabIndex = 3;
            // 
            // lbRandoms
            // 
            this.lbRandoms.FormattingEnabled = true;
            this.lbRandoms.Location = new System.Drawing.Point(36, 144);
            this.lbRandoms.Name = "lbRandoms";
            this.lbRandoms.Size = new System.Drawing.Size(171, 472);
            this.lbRandoms.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 634);
            this.Controls.Add(this.lbRandoms);
            this.Controls.Add(this.lbSelectedNumbers);
            this.Controls.Add(this.btnNumLess10);
            this.Controls.Add(this.btnEvenNumbers);
            this.Controls.Add(this.btnGenerateRandoms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateRandoms;
        private System.Windows.Forms.Button btnEvenNumbers;
        private System.Windows.Forms.Button btnNumLess10;
        private System.Windows.Forms.ListBox lbSelectedNumbers;
        private System.Windows.Forms.ListBox lbRandoms;
    }
}

