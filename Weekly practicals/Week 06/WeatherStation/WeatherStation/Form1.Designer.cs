namespace WeatherStation
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
            this.btnUpdateMeasurements = new System.Windows.Forms.Button();
            this.tbTemprature = new System.Windows.Forms.TextBox();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.tbBarometricPressure = new System.Windows.Forms.TextBox();
            this.lbReadings = new System.Windows.Forms.ListBox();
            this.lbAverageReadings = new System.Windows.Forms.ListBox();
            this.lbForecast = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAverageReadings = new System.Windows.Forms.Label();
            this.lblForecast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateMeasurements
            // 
            this.btnUpdateMeasurements.Location = new System.Drawing.Point(34, 33);
            this.btnUpdateMeasurements.Name = "btnUpdateMeasurements";
            this.btnUpdateMeasurements.Size = new System.Drawing.Size(179, 44);
            this.btnUpdateMeasurements.TabIndex = 0;
            this.btnUpdateMeasurements.Text = "Update Measurements";
            this.btnUpdateMeasurements.UseVisualStyleBackColor = true;
            this.btnUpdateMeasurements.Click += new System.EventHandler(this.btnUpdateMeasurements_Click);
            // 
            // tbTemprature
            // 
            this.tbTemprature.Location = new System.Drawing.Point(34, 182);
            this.tbTemprature.Name = "tbTemprature";
            this.tbTemprature.Size = new System.Drawing.Size(179, 20);
            this.tbTemprature.TabIndex = 1;
            // 
            // tbHumidity
            // 
            this.tbHumidity.Location = new System.Drawing.Point(34, 292);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(179, 20);
            this.tbHumidity.TabIndex = 2;
            // 
            // tbBarometricPressure
            // 
            this.tbBarometricPressure.Location = new System.Drawing.Point(34, 402);
            this.tbBarometricPressure.Name = "tbBarometricPressure";
            this.tbBarometricPressure.Size = new System.Drawing.Size(179, 20);
            this.tbBarometricPressure.TabIndex = 3;
            // 
            // lbReadings
            // 
            this.lbReadings.FormattingEnabled = true;
            this.lbReadings.Location = new System.Drawing.Point(333, 47);
            this.lbReadings.Name = "lbReadings";
            this.lbReadings.Size = new System.Drawing.Size(329, 95);
            this.lbReadings.TabIndex = 4;
            // 
            // lbAverageReadings
            // 
            this.lbAverageReadings.FormattingEnabled = true;
            this.lbAverageReadings.Location = new System.Drawing.Point(333, 192);
            this.lbAverageReadings.Name = "lbAverageReadings";
            this.lbAverageReadings.Size = new System.Drawing.Size(329, 95);
            this.lbAverageReadings.TabIndex = 5;
            // 
            // lbForecast
            // 
            this.lbForecast.FormattingEnabled = true;
            this.lbForecast.Location = new System.Drawing.Point(333, 337);
            this.lbForecast.Name = "lbForecast";
            this.lbForecast.Size = new System.Drawing.Size(329, 95);
            this.lbForecast.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Temprature (C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Humidity (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Barometric Pressure";
            // 
            // lblAverageReadings
            // 
            this.lblAverageReadings.AutoSize = true;
            this.lblAverageReadings.Location = new System.Drawing.Point(330, 176);
            this.lblAverageReadings.Name = "lblAverageReadings";
            this.lblAverageReadings.Size = new System.Drawing.Size(92, 13);
            this.lblAverageReadings.TabIndex = 11;
            this.lblAverageReadings.Text = "AverageReadings";
            // 
            // lblForecast
            // 
            this.lblForecast.AutoSize = true;
            this.lblForecast.Location = new System.Drawing.Point(330, 321);
            this.lblForecast.Name = "lblForecast";
            this.lblForecast.Size = new System.Drawing.Size(48, 13);
            this.lblForecast.TabIndex = 12;
            this.lblForecast.Text = "Forecast";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 480);
            this.Controls.Add(this.lblForecast);
            this.Controls.Add(this.lblAverageReadings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbForecast);
            this.Controls.Add(this.lbAverageReadings);
            this.Controls.Add(this.lbReadings);
            this.Controls.Add(this.tbBarometricPressure);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.tbTemprature);
            this.Controls.Add(this.btnUpdateMeasurements);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateMeasurements;
        private System.Windows.Forms.TextBox tbTemprature;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox tbBarometricPressure;
        private System.Windows.Forms.ListBox lbReadings;
        private System.Windows.Forms.ListBox lbAverageReadings;
        private System.Windows.Forms.ListBox lbForecast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAverageReadings;
        private System.Windows.Forms.Label lblForecast;
    }
}

