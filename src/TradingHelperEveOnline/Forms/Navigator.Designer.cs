namespace TradingHelperEveOnline.Forms
{
    partial class Navigator
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
            this.cmdStartDataBaseView = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdStartOreCalculator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdStartDataBaseView
            // 
            this.cmdStartDataBaseView.Location = new System.Drawing.Point(12, 12);
            this.cmdStartDataBaseView.Name = "cmdStartDataBaseView";
            this.cmdStartDataBaseView.Size = new System.Drawing.Size(195, 23);
            this.cmdStartDataBaseView.TabIndex = 0;
            this.cmdStartDataBaseView.Text = "Database Viewer";
            this.cmdStartDataBaseView.UseVisualStyleBackColor = true;
            this.cmdStartDataBaseView.Click += new System.EventHandler(this.cmdStartDataBaseView_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(132, 226);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdStartOreCalculator
            // 
            this.cmdStartOreCalculator.Location = new System.Drawing.Point(12, 41);
            this.cmdStartOreCalculator.Name = "cmdStartOreCalculator";
            this.cmdStartOreCalculator.Size = new System.Drawing.Size(195, 23);
            this.cmdStartOreCalculator.TabIndex = 2;
            this.cmdStartOreCalculator.Text = "Ore Reprocessing Calculator";
            this.cmdStartOreCalculator.UseVisualStyleBackColor = true;
            this.cmdStartOreCalculator.Click += new System.EventHandler(this.cmdStartOreCalculator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maybe I\'ll add more l8";
            // 
            // Navigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdStartOreCalculator);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdStartDataBaseView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Navigator";
            this.Text = "Navigator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStartDataBaseView;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdStartOreCalculator;
        private System.Windows.Forms.Label label1;
    }
}