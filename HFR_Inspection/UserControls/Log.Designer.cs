namespace HFR_Inspection.UserControls
{
    partial class ucLog
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.optLog_System = new System.Windows.Forms.RadioButton();
            this.optLog_Inspection = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLog = new QuickDataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendar.Checked = false;
            this.dtpCalendar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpCalendar.Location = new System.Drawing.Point(1002, 31);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.Size = new System.Drawing.Size(230, 29);
            this.dtpCalendar.TabIndex = 20;
            // 
            // optLog_System
            // 
            this.optLog_System.Appearance = System.Windows.Forms.Appearance.Button;
            this.optLog_System.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.optLog_System.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optLog_System.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.optLog_System.Location = new System.Drawing.Point(672, 20);
            this.optLog_System.Name = "optLog_System";
            this.optLog_System.Size = new System.Drawing.Size(137, 54);
            this.optLog_System.TabIndex = 21;
            this.optLog_System.Text = "시스템";
            this.optLog_System.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optLog_System.UseVisualStyleBackColor = true;
            this.optLog_System.CheckedChanged += new System.EventHandler(this.optLog_System_CheckedChanged);
            // 
            // optLog_Inspection
            // 
            this.optLog_Inspection.Appearance = System.Windows.Forms.Appearance.Button;
            this.optLog_Inspection.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.optLog_Inspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optLog_Inspection.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.optLog_Inspection.Location = new System.Drawing.Point(831, 20);
            this.optLog_Inspection.Name = "optLog_Inspection";
            this.optLog_Inspection.Size = new System.Drawing.Size(137, 54);
            this.optLog_Inspection.TabIndex = 22;
            this.optLog_Inspection.Text = "검사";
            this.optLog_Inspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optLog_Inspection.UseVisualStyleBackColor = true;
            this.optLog_Inspection.CheckedChanged += new System.EventHandler(this.optLog_Inspection_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.optLog_System);
            this.groupBox1.Controls.Add(this.optLog_Inspection);
            this.groupBox1.Controls.Add(this.dtpCalendar);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1905, 876);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLog);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1899, 793);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // dgvLog
            // 
            this.dgvLog.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLog.Location = new System.Drawing.Point(3, 20);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(1893, 770);
            this.dgvLog.TabIndex = 23;
            // 
            // ucLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucLog";
            this.Size = new System.Drawing.Size(1911, 882);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpCalendar;
        private System.Windows.Forms.RadioButton optLog_System;
        private System.Windows.Forms.RadioButton optLog_Inspection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private QuickDataGridView dgvLog;
    }
}
