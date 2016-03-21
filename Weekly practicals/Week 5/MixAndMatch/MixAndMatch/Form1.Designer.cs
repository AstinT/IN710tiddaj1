namespace MixAndMatch
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
            this.cbHead = new System.Windows.Forms.ComboBox();
            this.cbLegs = new System.Windows.Forms.ComboBox();
            this.cbTorso = new System.Windows.Forms.ComboBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTorso = new System.Windows.Forms.Label();
            this.lblLegs = new System.Windows.Forms.Label();
            this.btnMakeMonster = new System.Windows.Forms.Button();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pbTorso = new System.Windows.Forms.PictureBox();
            this.pbLegs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHead
            // 
            this.cbHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHead.FormattingEnabled = true;
            this.cbHead.Location = new System.Drawing.Point(464, 51);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(198, 21);
            this.cbHead.TabIndex = 0;
            // 
            // cbLegs
            // 
            this.cbLegs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLegs.FormattingEnabled = true;
            this.cbLegs.Location = new System.Drawing.Point(464, 239);
            this.cbLegs.Name = "cbLegs";
            this.cbLegs.Size = new System.Drawing.Size(198, 21);
            this.cbLegs.TabIndex = 1;
            // 
            // cbTorso
            // 
            this.cbTorso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTorso.FormattingEnabled = true;
            this.cbTorso.Location = new System.Drawing.Point(464, 145);
            this.cbTorso.Name = "cbTorso";
            this.cbTorso.Size = new System.Drawing.Size(198, 21);
            this.cbTorso.TabIndex = 2;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(382, 54);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(33, 13);
            this.lblHead.TabIndex = 3;
            this.lblHead.Text = "Head";
            // 
            // lblTorso
            // 
            this.lblTorso.AutoSize = true;
            this.lblTorso.Location = new System.Drawing.Point(382, 148);
            this.lblTorso.Name = "lblTorso";
            this.lblTorso.Size = new System.Drawing.Size(34, 13);
            this.lblTorso.TabIndex = 4;
            this.lblTorso.Text = "Torso";
            // 
            // lblLegs
            // 
            this.lblLegs.AutoSize = true;
            this.lblLegs.Location = new System.Drawing.Point(382, 242);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(30, 13);
            this.lblLegs.TabIndex = 5;
            this.lblLegs.Text = "Legs";
            // 
            // btnMakeMonster
            // 
            this.btnMakeMonster.Location = new System.Drawing.Point(464, 372);
            this.btnMakeMonster.Name = "btnMakeMonster";
            this.btnMakeMonster.Size = new System.Drawing.Size(198, 23);
            this.btnMakeMonster.TabIndex = 6;
            this.btnMakeMonster.Text = "Make Monster";
            this.btnMakeMonster.UseVisualStyleBackColor = true;
            this.btnMakeMonster.Click += new System.EventHandler(this.btnMakeMonster_Click);
            // 
            // pbHead
            // 
            this.pbHead.Location = new System.Drawing.Point(13, 13);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(346, 176);
            this.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHead.TabIndex = 7;
            this.pbHead.TabStop = false;
            // 
            // pbTorso
            // 
            this.pbTorso.Location = new System.Drawing.Point(13, 195);
            this.pbTorso.Name = "pbTorso";
            this.pbTorso.Size = new System.Drawing.Size(346, 176);
            this.pbTorso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTorso.TabIndex = 8;
            this.pbTorso.TabStop = false;
            // 
            // pbLegs
            // 
            this.pbLegs.Location = new System.Drawing.Point(13, 377);
            this.pbLegs.Name = "pbLegs";
            this.pbLegs.Size = new System.Drawing.Size(346, 176);
            this.pbLegs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLegs.TabIndex = 9;
            this.pbLegs.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 572);
            this.Controls.Add(this.pbLegs);
            this.Controls.Add(this.pbTorso);
            this.Controls.Add(this.pbHead);
            this.Controls.Add(this.btnMakeMonster);
            this.Controls.Add(this.lblLegs);
            this.Controls.Add(this.lblTorso);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.cbTorso);
            this.Controls.Add(this.cbLegs);
            this.Controls.Add(this.cbHead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHead;
        private System.Windows.Forms.ComboBox cbLegs;
        private System.Windows.Forms.ComboBox cbTorso;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTorso;
        private System.Windows.Forms.Label lblLegs;
        private System.Windows.Forms.Button btnMakeMonster;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbTorso;
        private System.Windows.Forms.PictureBox pbLegs;
    }
}

