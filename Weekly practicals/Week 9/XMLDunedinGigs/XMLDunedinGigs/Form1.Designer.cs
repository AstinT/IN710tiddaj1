namespace XMLDunedinGigs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colBandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAllUpcomingEvents = new System.Windows.Forms.Button();
            this.btnHardRock = new System.Windows.Forms.Button();
            this.btnCurrentMonth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBandName,
            this.colGenre,
            this.colVenue,
            this.colDateTime});
            this.dataGridView1.Location = new System.Drawing.Point(13, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // colBandName
            // 
            this.colBandName.HeaderText = "Band Name";
            this.colBandName.Name = "colBandName";
            // 
            // colGenre
            // 
            this.colGenre.HeaderText = "Genre";
            this.colGenre.Name = "colGenre";
            // 
            // colVenue
            // 
            this.colVenue.HeaderText = "Venue";
            this.colVenue.Name = "colVenue";
            // 
            // colDateTime
            // 
            this.colDateTime.HeaderText = "Date and Time";
            this.colDateTime.Name = "colDateTime";
            // 
            // btnAllUpcomingEvents
            // 
            this.btnAllUpcomingEvents.Location = new System.Drawing.Point(13, 35);
            this.btnAllUpcomingEvents.Name = "btnAllUpcomingEvents";
            this.btnAllUpcomingEvents.Size = new System.Drawing.Size(157, 23);
            this.btnAllUpcomingEvents.TabIndex = 1;
            this.btnAllUpcomingEvents.Text = "All Upcoming Events";
            this.btnAllUpcomingEvents.UseVisualStyleBackColor = true;
            this.btnAllUpcomingEvents.Click += new System.EventHandler(this.btnAllUpcomingEvents_Click);
            // 
            // btnHardRock
            // 
            this.btnHardRock.Location = new System.Drawing.Point(218, 34);
            this.btnHardRock.Name = "btnHardRock";
            this.btnHardRock.Size = new System.Drawing.Size(157, 23);
            this.btnHardRock.TabIndex = 2;
            this.btnHardRock.Text = "Hard Rock";
            this.btnHardRock.UseVisualStyleBackColor = true;
            this.btnHardRock.Click += new System.EventHandler(this.btnHardRock_Click);
            // 
            // btnCurrentMonth
            // 
            this.btnCurrentMonth.Location = new System.Drawing.Point(423, 34);
            this.btnCurrentMonth.Name = "btnCurrentMonth";
            this.btnCurrentMonth.Size = new System.Drawing.Size(157, 23);
            this.btnCurrentMonth.TabIndex = 3;
            this.btnCurrentMonth.Text = "Current Month";
            this.btnCurrentMonth.UseVisualStyleBackColor = true;
            this.btnCurrentMonth.Click += new System.EventHandler(this.btnCurrentMonth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 498);
            this.Controls.Add(this.btnCurrentMonth);
            this.Controls.Add(this.btnHardRock);
            this.Controls.Add(this.btnAllUpcomingEvents);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.Button btnAllUpcomingEvents;
        private System.Windows.Forms.Button btnHardRock;
        private System.Windows.Forms.Button btnCurrentMonth;
    }
}

