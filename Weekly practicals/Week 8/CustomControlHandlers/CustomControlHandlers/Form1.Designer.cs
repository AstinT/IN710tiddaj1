namespace CustomControlHandlers
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
            this.btnTestHandlers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestHandlers
            // 
            this.btnTestHandlers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestHandlers.Location = new System.Drawing.Point(13, 13);
            this.btnTestHandlers.Name = "btnTestHandlers";
            this.btnTestHandlers.Size = new System.Drawing.Size(293, 94);
            this.btnTestHandlers.TabIndex = 0;
            this.btnTestHandlers.Text = "Test Handlers";
            this.btnTestHandlers.UseVisualStyleBackColor = true;
            this.btnTestHandlers.Click += new System.EventHandler(this.btnTestHandlers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 119);
            this.Controls.Add(this.btnTestHandlers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestHandlers;
    }
}

