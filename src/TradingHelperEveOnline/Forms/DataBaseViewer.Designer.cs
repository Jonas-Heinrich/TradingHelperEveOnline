namespace TradingHelperEveOnline
{
    partial class DataBaseViewer
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
            this.components = new System.ComponentModel.Container();
            this.cmdUpdateMarketFull = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblSecondsLeft = new System.Windows.Forms.Label();
            this.pgUpdateStatus = new System.Windows.Forms.ProgressBar();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.TimerUpdateStatus = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdUpdateMarketFull
            // 
            this.cmdUpdateMarketFull.Location = new System.Drawing.Point(707, 62);
            this.cmdUpdateMarketFull.Name = "cmdUpdateMarketFull";
            this.cmdUpdateMarketFull.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateMarketFull.TabIndex = 0;
            this.cmdUpdateMarketFull.Text = "Full Update";
            this.cmdUpdateMarketFull.UseVisualStyleBackColor = true;
            this.cmdUpdateMarketFull.Click += new System.EventHandler(this.cmdUpdateMarketFull_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdUpdate);
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.lblSecondsLeft);
            this.groupBox1.Controls.Add(this.pgUpdateStatus);
            this.groupBox1.Controls.Add(this.lblUpdateStatus);
            this.groupBox1.Controls.Add(this.cmdUpdateMarketFull);
            this.groupBox1.Location = new System.Drawing.Point(12, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MarketData";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(788, 62);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 2;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Enabled = false;
            this.cmdCancel.Location = new System.Drawing.Point(869, 62);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lblSecondsLeft
            // 
            this.lblSecondsLeft.AutoSize = true;
            this.lblSecondsLeft.Location = new System.Drawing.Point(535, 67);
            this.lblSecondsLeft.Name = "lblSecondsLeft";
            this.lblSecondsLeft.Size = new System.Drawing.Size(0, 13);
            this.lblSecondsLeft.TabIndex = 4;
            // 
            // pgUpdateStatus
            // 
            this.pgUpdateStatus.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.pgUpdateStatus.Location = new System.Drawing.Point(6, 32);
            this.pgUpdateStatus.Name = "pgUpdateStatus";
            this.pgUpdateStatus.Size = new System.Drawing.Size(938, 23);
            this.pgUpdateStatus.TabIndex = 3;
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Location = new System.Drawing.Point(6, 67);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(0, 13);
            this.lblUpdateStatus.TabIndex = 2;
            // 
            // TimerUpdateStatus
            // 
            this.TimerUpdateStatus.Tick += new System.EventHandler(this.TimerUpdateStatus_Tick);
            // 
            // DataBaseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 598);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataBaseViewer";
            this.Text = "Database View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUpdateMarketFull;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Timer TimerUpdateStatus;
        private System.Windows.Forms.ProgressBar pgUpdateStatus;
        private System.Windows.Forms.Label lblSecondsLeft;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdUpdate;
    }
}

