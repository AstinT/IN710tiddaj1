namespace EncryptionTool
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
            this.gbAlgorithms = new System.Windows.Forms.GroupBox();
            this.rbStringReverse = new System.Windows.Forms.RadioButton();
            this.rbRot13 = new System.Windows.Forms.RadioButton();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.gbAlgorithms.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlgorithms
            // 
            this.gbAlgorithms.Controls.Add(this.rbStringReverse);
            this.gbAlgorithms.Controls.Add(this.rbRot13);
            this.gbAlgorithms.Location = new System.Drawing.Point(48, 33);
            this.gbAlgorithms.Name = "gbAlgorithms";
            this.gbAlgorithms.Size = new System.Drawing.Size(200, 100);
            this.gbAlgorithms.TabIndex = 0;
            this.gbAlgorithms.TabStop = false;
            this.gbAlgorithms.Text = "Encryption Algorithm";
            // 
            // rbStringReverse
            // 
            this.rbStringReverse.AutoSize = true;
            this.rbStringReverse.Location = new System.Drawing.Point(6, 69);
            this.rbStringReverse.Name = "rbStringReverse";
            this.rbStringReverse.Size = new System.Drawing.Size(90, 17);
            this.rbStringReverse.TabIndex = 1;
            this.rbStringReverse.TabStop = true;
            this.rbStringReverse.Text = "String reverse";
            this.rbStringReverse.UseVisualStyleBackColor = true;
            // 
            // rbRot13
            // 
            this.rbRot13.AutoSize = true;
            this.rbRot13.Location = new System.Drawing.Point(6, 30);
            this.rbRot13.Name = "rbRot13";
            this.rbRot13.Size = new System.Drawing.Size(60, 17);
            this.rbRot13.TabIndex = 0;
            this.rbRot13.TabStop = true;
            this.rbRot13.Text = "ROT13";
            this.rbRot13.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(279, 72);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(400, 72);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(51, 177);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(31, 13);
            this.lbInput.TabIndex = 3;
            this.lbInput.Text = "Input";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(51, 246);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(39, 13);
            this.lbOutput.TabIndex = 4;
            this.lbOutput.Text = "Output";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(120, 174);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(354, 20);
            this.tbInput.TabIndex = 5;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(120, 238);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(354, 20);
            this.tbOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 282);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.gbAlgorithms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAlgorithms.ResumeLayout(false);
            this.gbAlgorithms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlgorithms;
        private System.Windows.Forms.RadioButton rbStringReverse;
        private System.Windows.Forms.RadioButton rbRot13;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

