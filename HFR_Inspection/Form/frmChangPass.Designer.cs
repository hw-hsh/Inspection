namespace HFR_Inspection
{
    partial class frmChangPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangPass));
            this.btnPassClose = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass_New = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass_New_Check = new System.Windows.Forms.TextBox();
            this.chkCharEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPassClose
            // 
            this.btnPassClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPassClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPassClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassClose.ImageIndex = 1;
            this.btnPassClose.ImageList = this.imageList1;
            this.btnPassClose.Location = new System.Drawing.Point(155, 155);
            this.btnPassClose.Name = "btnPassClose";
            this.btnPassClose.Size = new System.Drawing.Size(137, 54);
            this.btnPassClose.TabIndex = 20;
            this.btnPassClose.Text = "Cancle";
            this.btnPassClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPassClose.UseVisualStyleBackColor = true;
            this.btnPassClose.Click += new System.EventHandler(this.btnPassClose_Click);
            // 
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.ImageIndex = 0;
            this.btnApply.ImageList = this.imageList1;
            this.btnApply.Location = new System.Drawing.Point(13, 155);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(137, 54);
            this.btnApply.TabIndex = 19;
            this.btnApply.Text = "OK";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Apply.png");
            this.imageList1.Images.SetKeyName(1, "Close.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "현재 암호";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPass.Location = new System.Drawing.Point(124, 38);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(168, 26);
            this.txtPass.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "새 암호";
            // 
            // txtPass_New
            // 
            this.txtPass_New.BackColor = System.Drawing.Color.White;
            this.txtPass_New.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPass_New.Location = new System.Drawing.Point(124, 91);
            this.txtPass_New.Name = "txtPass_New";
            this.txtPass_New.Size = new System.Drawing.Size(168, 26);
            this.txtPass_New.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "암호 확인";
            // 
            // txtPass_New_Check
            // 
            this.txtPass_New_Check.BackColor = System.Drawing.Color.White;
            this.txtPass_New_Check.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPass_New_Check.Location = new System.Drawing.Point(124, 123);
            this.txtPass_New_Check.Name = "txtPass_New_Check";
            this.txtPass_New_Check.Size = new System.Drawing.Size(168, 26);
            this.txtPass_New_Check.TabIndex = 25;
            // 
            // chkCharEnable
            // 
            this.chkCharEnable.AutoSize = true;
            this.chkCharEnable.Location = new System.Drawing.Point(206, 13);
            this.chkCharEnable.Name = "chkCharEnable";
            this.chkCharEnable.Size = new System.Drawing.Size(76, 16);
            this.chkCharEnable.TabIndex = 27;
            this.chkCharEnable.Text = "문자 표시";
            this.chkCharEnable.UseVisualStyleBackColor = true;
            this.chkCharEnable.CheckedChanged += new System.EventHandler(this.chkCharEnable_CheckedChanged);
            // 
            // frmChangPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 221);
            this.Controls.Add(this.chkCharEnable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass_New_Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass_New);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnPassClose);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangPass";
            this.Text = "암호 변경";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPassClose;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass_New;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass_New_Check;
        private System.Windows.Forms.CheckBox chkCharEnable;
    }
}