namespace HFR_Inspection
{
    partial class frmInitialize
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
            this.pgbInit = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtInit = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompletionRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbInit
            // 
            this.pgbInit.Location = new System.Drawing.Point(3, 54);
            this.pgbInit.MarqueeAnimationSpeed = 10;
            this.pgbInit.Name = "pgbInit";
            this.pgbInit.Size = new System.Drawing.Size(1022, 48);
            this.pgbInit.Step = 1;
            this.pgbInit.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbInit.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "진행률 : ";
            // 
            // rtxtInit
            // 
            this.rtxtInit.Location = new System.Drawing.Point(3, 184);
            this.rtxtInit.Name = "rtxtInit";
            this.rtxtInit.ReadOnly = true;
            this.rtxtInit.Size = new System.Drawing.Size(1023, 456);
            this.rtxtInit.TabIndex = 2;
            this.rtxtInit.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1029, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Initialize...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompletionRate
            // 
            this.lblCompletionRate.AutoSize = true;
            this.lblCompletionRate.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletionRate.Location = new System.Drawing.Point(539, 123);
            this.lblCompletionRate.Name = "lblCompletionRate";
            this.lblCompletionRate.Size = new System.Drawing.Size(54, 32);
            this.lblCompletionRate.TabIndex = 4;
            this.lblCompletionRate.Text = "0%";
            // 
            // frmInitialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 643);
            this.Controls.Add(this.lblCompletionRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtInit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pgbInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInitialize";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInitialize";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar pgbInit;
        public System.Windows.Forms.RichTextBox rtxtInit;
        public System.Windows.Forms.Label lblCompletionRate;
    }
}