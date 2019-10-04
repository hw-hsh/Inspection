namespace HFR_Inspection
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDate_Cam2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPath_Cam2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP_Cam2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDate_Cam1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPath_Cam1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP_Cam1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtIP_Motion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtPath_Log = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtPath_Recipe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRecipe_Path = new System.Windows.Forms.Button();
            this.btnLog_Path = new System.Windows.Forms.Button();
            this.btnCam2_Path = new System.Windows.Forms.Button();
            this.btnCam1_Path = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Apply.png");
            this.imageList1.Images.SetKeyName(1, "Close.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 278);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "카메라";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDate_Cam2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCam2_Path);
            this.groupBox3.Controls.Add(this.txtPath_Cam2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtIP_Cam2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 123);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2번 카메라";
            // 
            // txtDate_Cam2
            // 
            this.txtDate_Cam2.BackColor = System.Drawing.Color.White;
            this.txtDate_Cam2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtDate_Cam2.Location = new System.Drawing.Point(155, 85);
            this.txtDate_Cam2.Name = "txtDate_Cam2";
            this.txtDate_Cam2.Size = new System.Drawing.Size(100, 26);
            this.txtDate_Cam2.TabIndex = 25;
            this.txtDate_Cam2.Text = "120";
            this.txtDate_Cam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "이미지 보관 기간(일)";
            // 
            // txtPath_Cam2
            // 
            this.txtPath_Cam2.BackColor = System.Drawing.Color.White;
            this.txtPath_Cam2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPath_Cam2.Location = new System.Drawing.Point(155, 53);
            this.txtPath_Cam2.Name = "txtPath_Cam2";
            this.txtPath_Cam2.Size = new System.Drawing.Size(220, 26);
            this.txtPath_Cam2.TabIndex = 7;
            this.txtPath_Cam2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "이미지 저장경로";
            // 
            // txtIP_Cam2
            // 
            this.txtIP_Cam2.BackColor = System.Drawing.Color.White;
            this.txtIP_Cam2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtIP_Cam2.Location = new System.Drawing.Point(155, 21);
            this.txtIP_Cam2.Name = "txtIP_Cam2";
            this.txtIP_Cam2.Size = new System.Drawing.Size(168, 26);
            this.txtIP_Cam2.TabIndex = 3;
            this.txtIP_Cam2.Text = "0.0.0.0";
            this.txtIP_Cam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIP_Cam2.Leave += new System.EventHandler(this.txtIP_Cam2_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "IP 주소";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDate_Cam1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnCam1_Path);
            this.groupBox2.Controls.Add(this.txtPath_Cam1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIP_Cam1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 123);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1번 카메라";
            // 
            // txtDate_Cam1
            // 
            this.txtDate_Cam1.BackColor = System.Drawing.Color.White;
            this.txtDate_Cam1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtDate_Cam1.Location = new System.Drawing.Point(155, 85);
            this.txtDate_Cam1.Name = "txtDate_Cam1";
            this.txtDate_Cam1.Size = new System.Drawing.Size(100, 26);
            this.txtDate_Cam1.TabIndex = 23;
            this.txtDate_Cam1.Text = "120";
            this.txtDate_Cam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "이미지 보관 기간(일)";
            // 
            // txtPath_Cam1
            // 
            this.txtPath_Cam1.BackColor = System.Drawing.Color.White;
            this.txtPath_Cam1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPath_Cam1.Location = new System.Drawing.Point(155, 53);
            this.txtPath_Cam1.Name = "txtPath_Cam1";
            this.txtPath_Cam1.Size = new System.Drawing.Size(220, 26);
            this.txtPath_Cam1.TabIndex = 7;
            this.txtPath_Cam1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "이미지 저장경로";
            // 
            // txtIP_Cam1
            // 
            this.txtIP_Cam1.BackColor = System.Drawing.Color.White;
            this.txtIP_Cam1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtIP_Cam1.Location = new System.Drawing.Point(155, 21);
            this.txtIP_Cam1.Name = "txtIP_Cam1";
            this.txtIP_Cam1.Size = new System.Drawing.Size(168, 26);
            this.txtIP_Cam1.TabIndex = 3;
            this.txtIP_Cam1.Text = "0.0.0.0";
            this.txtIP_Cam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIP_Cam1.Leave += new System.EventHandler(this.txtIP_Cam1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP 주소";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(440, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 92);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "구동부";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtIP_Motion);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(420, 65);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Controller";
            // 
            // txtIP_Motion
            // 
            this.txtIP_Motion.BackColor = System.Drawing.Color.White;
            this.txtIP_Motion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtIP_Motion.Location = new System.Drawing.Point(155, 21);
            this.txtIP_Motion.Name = "txtIP_Motion";
            this.txtIP_Motion.Size = new System.Drawing.Size(168, 26);
            this.txtIP_Motion.TabIndex = 3;
            this.txtIP_Motion.Text = "0.0.0.0";
            this.txtIP_Motion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIP_Motion.TextChanged += new System.EventHandler(this.txtIP_Motion_TextChanged);
            this.txtIP_Motion.Leave += new System.EventHandler(this.txtIP_Motion_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(12, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "IP 주소";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(4, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 92);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "로그";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnLog_Path);
            this.groupBox7.Controls.Add(this.txtPath_Log);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(6, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(420, 65);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            // 
            // txtPath_Log
            // 
            this.txtPath_Log.BackColor = System.Drawing.Color.White;
            this.txtPath_Log.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPath_Log.Location = new System.Drawing.Point(155, 23);
            this.txtPath_Log.Name = "txtPath_Log";
            this.txtPath_Log.Size = new System.Drawing.Size(220, 26);
            this.txtPath_Log.TabIndex = 23;
            this.txtPath_Log.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log 저장경로";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(4, 382);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(432, 92);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "작업 파일";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnRecipe_Path);
            this.groupBox9.Controls.Add(this.txtPath_Recipe);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(6, 20);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(420, 65);
            this.groupBox9.TabIndex = 19;
            this.groupBox9.TabStop = false;
            // 
            // txtPath_Recipe
            // 
            this.txtPath_Recipe.BackColor = System.Drawing.Color.White;
            this.txtPath_Recipe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPath_Recipe.Location = new System.Drawing.Point(155, 23);
            this.txtPath_Recipe.Name = "txtPath_Recipe";
            this.txtPath_Recipe.Size = new System.Drawing.Size(220, 26);
            this.txtPath_Recipe.TabIndex = 26;
            this.txtPath_Recipe.Text = "0";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Recipe 저장경로";
            // 
            // btnRecipe_Path
            // 
            this.btnRecipe_Path.BackgroundImage = global::HFR_Inspection.Properties.Resources.Foler;
            this.btnRecipe_Path.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecipe_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipe_Path.Location = new System.Drawing.Point(381, 23);
            this.btnRecipe_Path.Name = "btnRecipe_Path";
            this.btnRecipe_Path.Size = new System.Drawing.Size(31, 26);
            this.btnRecipe_Path.TabIndex = 27;
            this.btnRecipe_Path.UseVisualStyleBackColor = true;
            this.btnRecipe_Path.Click += new System.EventHandler(this.btnRecipe_Path_Click);
            // 
            // btnLog_Path
            // 
            this.btnLog_Path.BackgroundImage = global::HFR_Inspection.Properties.Resources.Foler;
            this.btnLog_Path.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLog_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog_Path.Location = new System.Drawing.Point(381, 23);
            this.btnLog_Path.Name = "btnLog_Path";
            this.btnLog_Path.Size = new System.Drawing.Size(31, 26);
            this.btnLog_Path.TabIndex = 24;
            this.btnLog_Path.UseVisualStyleBackColor = true;
            this.btnLog_Path.Click += new System.EventHandler(this.btnLog_Path_Click);
            // 
            // btnCam2_Path
            // 
            this.btnCam2_Path.BackgroundImage = global::HFR_Inspection.Properties.Resources.Foler;
            this.btnCam2_Path.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCam2_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCam2_Path.Location = new System.Drawing.Point(381, 53);
            this.btnCam2_Path.Name = "btnCam2_Path";
            this.btnCam2_Path.Size = new System.Drawing.Size(31, 26);
            this.btnCam2_Path.TabIndex = 22;
            this.btnCam2_Path.UseVisualStyleBackColor = true;
            this.btnCam2_Path.Click += new System.EventHandler(this.btnCam2_Path_Click);
            // 
            // btnCam1_Path
            // 
            this.btnCam1_Path.BackgroundImage = global::HFR_Inspection.Properties.Resources.Foler;
            this.btnCam1_Path.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCam1_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCam1_Path.Location = new System.Drawing.Point(381, 53);
            this.btnCam1_Path.Name = "btnCam1_Path";
            this.btnCam1_Path.Size = new System.Drawing.Size(31, 26);
            this.btnCam1_Path.TabIndex = 21;
            this.btnCam1_Path.UseVisualStyleBackColor = true;
            this.btnCam1_Path.Click += new System.EventHandler(this.btnCam1_Path_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(733, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 54);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.ImageIndex = 0;
            this.btnApply.ImageList = this.imageList1;
            this.btnApply.Location = new System.Drawing.Point(590, 495);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(137, 54);
            this.btnApply.TabIndex = 16;
            this.btnApply.Text = "Apply";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 561);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "설정";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCam2_Path;
        private System.Windows.Forms.TextBox txtPath_Cam2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP_Cam2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCam1_Path;
        private System.Windows.Forms.TextBox txtPath_Cam1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP_Cam1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate_Cam2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDate_Cam1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtIP_Motion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnLog_Path;
        private System.Windows.Forms.TextBox txtPath_Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnRecipe_Path;
        private System.Windows.Forms.TextBox txtPath_Recipe;
        private System.Windows.Forms.Label label5;
    }
}