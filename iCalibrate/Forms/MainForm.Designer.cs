namespace iCalibrate
{
    partial class MainForm
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
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnInstMast = new System.Windows.Forms.Button();
            this.btnInstruments = new System.Windows.Forms.Button();
            this.btnReportConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocations
            // 
            this.btnLocations.Location = new System.Drawing.Point(12, 12);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(75, 23);
            this.btnLocations.TabIndex = 0;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnInstMast
            // 
            this.btnInstMast.Location = new System.Drawing.Point(93, 12);
            this.btnInstMast.Name = "btnInstMast";
            this.btnInstMast.Size = new System.Drawing.Size(153, 23);
            this.btnInstMast.TabIndex = 1;
            this.btnInstMast.Text = "Instrument Master";
            this.btnInstMast.UseVisualStyleBackColor = true;
            this.btnInstMast.Click += new System.EventHandler(this.btnInstMast_Click);
            // 
            // btnInstruments
            // 
            this.btnInstruments.Location = new System.Drawing.Point(252, 12);
            this.btnInstruments.Name = "btnInstruments";
            this.btnInstruments.Size = new System.Drawing.Size(104, 23);
            this.btnInstruments.TabIndex = 1;
            this.btnInstruments.Text = "Instruments";
            this.btnInstruments.UseVisualStyleBackColor = true;
            this.btnInstruments.Click += new System.EventHandler(this.btnInstruments_Click);
            // 
            // btnReportConfig
            // 
            this.btnReportConfig.Location = new System.Drawing.Point(362, 12);
            this.btnReportConfig.Name = "btnReportConfig";
            this.btnReportConfig.Size = new System.Drawing.Size(104, 23);
            this.btnReportConfig.TabIndex = 1;
            this.btnReportConfig.Text = "Report Config";
            this.btnReportConfig.UseVisualStyleBackColor = true;
            this.btnReportConfig.Click += new System.EventHandler(this.btnReportConfig_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 390);
            this.Controls.Add(this.btnReportConfig);
            this.Controls.Add(this.btnInstruments);
            this.Controls.Add(this.btnInstMast);
            this.Controls.Add(this.btnLocations);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnInstMast;
        private System.Windows.Forms.Button btnInstruments;
        private System.Windows.Forms.Button btnReportConfig;
    }
}

