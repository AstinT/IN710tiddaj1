namespace ComputerBuilder
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
            this.gbComputers = new System.Windows.Forms.GroupBox();
            this.btnPrintSpec = new System.Windows.Forms.Button();
            this.lbDisplayBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gbComputers
            // 
            this.gbComputers.Location = new System.Drawing.Point(19, 73);
            this.gbComputers.Name = "gbComputers";
            this.gbComputers.Size = new System.Drawing.Size(176, 208);
            this.gbComputers.TabIndex = 0;
            this.gbComputers.TabStop = false;
            this.gbComputers.Text = "Machine Type";
            // 
            // btnPrintSpec
            // 
            this.btnPrintSpec.Location = new System.Drawing.Point(19, 13);
            this.btnPrintSpec.Name = "btnPrintSpec";
            this.btnPrintSpec.Size = new System.Drawing.Size(176, 30);
            this.btnPrintSpec.TabIndex = 1;
            this.btnPrintSpec.Text = "Print Spec";
            this.btnPrintSpec.UseVisualStyleBackColor = true;
            // 
            // lbDisplayBox
            // 
            this.lbDisplayBox.FormattingEnabled = true;
            this.lbDisplayBox.Location = new System.Drawing.Point(222, 15);
            this.lbDisplayBox.Name = "lbDisplayBox";
            this.lbDisplayBox.Size = new System.Drawing.Size(429, 264);
            this.lbDisplayBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 296);
            this.Controls.Add(this.lbDisplayBox);
            this.Controls.Add(this.btnPrintSpec);
            this.Controls.Add(this.gbComputers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbComputers;
        private System.Windows.Forms.Button btnPrintSpec;
        private System.Windows.Forms.ListBox lbDisplayBox;
    }
}

