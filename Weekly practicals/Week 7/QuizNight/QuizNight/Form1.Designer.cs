namespace QuizNight
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
            this.rbChildren = new System.Windows.Forms.RadioButton();
            this.rbAdult = new System.Windows.Forms.RadioButton();
            this.tbCorrect = new System.Windows.Forms.TextBox();
            this.tbIncorrect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChildren);
            this.groupBox1.Controls.Add(this.rbAdult);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbChildren
            // 
            this.rbChildren.AutoSize = true;
            this.rbChildren.Location = new System.Drawing.Point(6, 82);
            this.rbChildren.Name = "rbChildren";
            this.rbChildren.Size = new System.Drawing.Size(63, 17);
            this.rbChildren.TabIndex = 1;
            this.rbChildren.TabStop = true;
            this.rbChildren.Text = "Children";
            this.rbChildren.UseVisualStyleBackColor = true;
            // 
            // rbAdult
            // 
            this.rbAdult.AutoSize = true;
            this.rbAdult.Location = new System.Drawing.Point(7, 40);
            this.rbAdult.Name = "rbAdult";
            this.rbAdult.Size = new System.Drawing.Size(54, 17);
            this.rbAdult.TabIndex = 0;
            this.rbAdult.TabStop = true;
            this.rbAdult.Text = "Adults";
            this.rbAdult.UseVisualStyleBackColor = true;
            // 
            // tbCorrect
            // 
            this.tbCorrect.Location = new System.Drawing.Point(182, 29);
            this.tbCorrect.Name = "tbCorrect";
            this.tbCorrect.Size = new System.Drawing.Size(224, 20);
            this.tbCorrect.TabIndex = 1;
            // 
            // tbIncorrect
            // 
            this.tbIncorrect.Location = new System.Drawing.Point(182, 95);
            this.tbIncorrect.Name = "tbIncorrect";
            this.tbIncorrect.Size = new System.Drawing.Size(224, 20);
            this.tbIncorrect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correct";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incorrect";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(185, 132);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(221, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(120, 241);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 108);
            this.lblScore.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 399);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIncorrect);
            this.Controls.Add(this.tbCorrect);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChildren;
        private System.Windows.Forms.RadioButton rbAdult;
        private System.Windows.Forms.TextBox tbCorrect;
        private System.Windows.Forms.TextBox tbIncorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
    }
}

