namespace SocialNetwork
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpMain = new System.Windows.Forms.TabPage();
            this.tbpFriend1 = new System.Windows.Forms.TabPage();
            this.tbpFriend2 = new System.Windows.Forms.TabPage();
            this.tbpFriend3 = new System.Windows.Forms.TabPage();
            this.tbpFriend4 = new System.Windows.Forms.TabPage();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.tbUpdateStatus = new System.Windows.Forms.TextBox();
            this.lbFriend1 = new System.Windows.Forms.ListBox();
            this.lbFriend2 = new System.Windows.Forms.ListBox();
            this.lbFriend3 = new System.Windows.Forms.ListBox();
            this.lbFriend4 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tbpMain.SuspendLayout();
            this.tbpFriend1.SuspendLayout();
            this.tbpFriend2.SuspendLayout();
            this.tbpFriend3.SuspendLayout();
            this.tbpFriend4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpMain);
            this.tabControl1.Controls.Add(this.tbpFriend1);
            this.tabControl1.Controls.Add(this.tbpFriend2);
            this.tabControl1.Controls.Add(this.tbpFriend3);
            this.tabControl1.Controls.Add(this.tbpFriend4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpMain
            // 
            this.tbpMain.Controls.Add(this.tbUpdateStatus);
            this.tbpMain.Controls.Add(this.btnUpdateStatus);
            this.tbpMain.Controls.Add(this.lbMain);
            this.tbpMain.Location = new System.Drawing.Point(4, 22);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMain.Size = new System.Drawing.Size(631, 395);
            this.tbpMain.TabIndex = 0;
            this.tbpMain.Text = "Main Page";
            this.tbpMain.UseVisualStyleBackColor = true;
            // 
            // tbpFriend1
            // 
            this.tbpFriend1.Controls.Add(this.lbFriend1);
            this.tbpFriend1.Location = new System.Drawing.Point(4, 22);
            this.tbpFriend1.Name = "tbpFriend1";
            this.tbpFriend1.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFriend1.Size = new System.Drawing.Size(631, 395);
            this.tbpFriend1.TabIndex = 1;
            this.tbpFriend1.Text = "Friend 1";
            this.tbpFriend1.UseVisualStyleBackColor = true;
            // 
            // tbpFriend2
            // 
            this.tbpFriend2.Controls.Add(this.lbFriend2);
            this.tbpFriend2.Location = new System.Drawing.Point(4, 22);
            this.tbpFriend2.Name = "tbpFriend2";
            this.tbpFriend2.Size = new System.Drawing.Size(631, 395);
            this.tbpFriend2.TabIndex = 2;
            this.tbpFriend2.Text = "Friend 2";
            this.tbpFriend2.UseVisualStyleBackColor = true;
            // 
            // tbpFriend3
            // 
            this.tbpFriend3.Controls.Add(this.lbFriend3);
            this.tbpFriend3.Location = new System.Drawing.Point(4, 22);
            this.tbpFriend3.Name = "tbpFriend3";
            this.tbpFriend3.Size = new System.Drawing.Size(631, 395);
            this.tbpFriend3.TabIndex = 3;
            this.tbpFriend3.Text = "Friend 3";
            this.tbpFriend3.UseVisualStyleBackColor = true;
            // 
            // tbpFriend4
            // 
            this.tbpFriend4.Controls.Add(this.lbFriend4);
            this.tbpFriend4.Location = new System.Drawing.Point(4, 22);
            this.tbpFriend4.Name = "tbpFriend4";
            this.tbpFriend4.Size = new System.Drawing.Size(631, 395);
            this.tbpFriend4.TabIndex = 4;
            this.tbpFriend4.Text = "Friend 4";
            this.tbpFriend4.UseVisualStyleBackColor = true;
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.Location = new System.Drawing.Point(7, 27);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(618, 290);
            this.lbMain.TabIndex = 0;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(7, 347);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateStatus.TabIndex = 1;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // tbUpdateStatus
            // 
            this.tbUpdateStatus.Location = new System.Drawing.Point(216, 347);
            this.tbUpdateStatus.Name = "tbUpdateStatus";
            this.tbUpdateStatus.Size = new System.Drawing.Size(409, 20);
            this.tbUpdateStatus.TabIndex = 2;
            // 
            // lbFriend1
            // 
            this.lbFriend1.FormattingEnabled = true;
            this.lbFriend1.Location = new System.Drawing.Point(7, 30);
            this.lbFriend1.Name = "lbFriend1";
            this.lbFriend1.Size = new System.Drawing.Size(618, 355);
            this.lbFriend1.TabIndex = 0;
            // 
            // lbFriend2
            // 
            this.lbFriend2.FormattingEnabled = true;
            this.lbFriend2.Location = new System.Drawing.Point(4, 27);
            this.lbFriend2.Name = "lbFriend2";
            this.lbFriend2.Size = new System.Drawing.Size(624, 355);
            this.lbFriend2.TabIndex = 0;
            // 
            // lbFriend3
            // 
            this.lbFriend3.FormattingEnabled = true;
            this.lbFriend3.Location = new System.Drawing.Point(4, 27);
            this.lbFriend3.Name = "lbFriend3";
            this.lbFriend3.Size = new System.Drawing.Size(624, 355);
            this.lbFriend3.TabIndex = 0;
            // 
            // lbFriend4
            // 
            this.lbFriend4.FormattingEnabled = true;
            this.lbFriend4.Location = new System.Drawing.Point(4, 19);
            this.lbFriend4.Name = "lbFriend4";
            this.lbFriend4.Size = new System.Drawing.Size(624, 368);
            this.lbFriend4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 445);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbpMain.ResumeLayout(false);
            this.tbpMain.PerformLayout();
            this.tbpFriend1.ResumeLayout(false);
            this.tbpFriend2.ResumeLayout(false);
            this.tbpFriend3.ResumeLayout(false);
            this.tbpFriend4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpMain;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.TabPage tbpFriend1;
        private System.Windows.Forms.TabPage tbpFriend2;
        private System.Windows.Forms.TabPage tbpFriend3;
        private System.Windows.Forms.TabPage tbpFriend4;
        private System.Windows.Forms.TextBox tbUpdateStatus;
        private System.Windows.Forms.ListBox lbFriend1;
        private System.Windows.Forms.ListBox lbFriend2;
        private System.Windows.Forms.ListBox lbFriend3;
        private System.Windows.Forms.ListBox lbFriend4;
    }
}

