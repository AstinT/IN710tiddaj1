﻿namespace AnimalWorldFactoryPattern
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
            this.btnNorthAmerica = new System.Windows.Forms.Button();
            this.btnAustralia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(258, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 368);
            this.listBox1.TabIndex = 0;
            // 
            // btnNorthAmerica
            // 
            this.btnNorthAmerica.Location = new System.Drawing.Point(258, 424);
            this.btnNorthAmerica.Name = "btnNorthAmerica";
            this.btnNorthAmerica.Size = new System.Drawing.Size(121, 23);
            this.btnNorthAmerica.TabIndex = 1;
            this.btnNorthAmerica.Text = "North America";
            this.btnNorthAmerica.UseVisualStyleBackColor = true;
            this.btnNorthAmerica.Click += new System.EventHandler(this.btnNorthAmerica_Click);
            // 
            // btnAustralia
            // 
            this.btnAustralia.Location = new System.Drawing.Point(552, 424);
            this.btnAustralia.Name = "btnAustralia";
            this.btnAustralia.Size = new System.Drawing.Size(121, 23);
            this.btnAustralia.TabIndex = 2;
            this.btnAustralia.Text = "Australia";
            this.btnAustralia.UseVisualStyleBackColor = true;
            this.btnAustralia.Click += new System.EventHandler(this.btnAustralia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.btnAustralia);
            this.Controls.Add(this.btnNorthAmerica);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNorthAmerica;
        private System.Windows.Forms.Button btnAustralia;
    }
}
