namespace HFR_Inspection
{
    partial class frmMain
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cvsInSightDisplay1 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cvsInSightDisplay2 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.gbMainMotion = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnLoad_Job = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSelect_JobName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHotKey_3 = new System.Windows.Forms.Button();
            this.btnHotKey_2 = new System.Windows.Forms.Button();
            this.btnHotKey_1 = new System.Windows.Forms.Button();
            this.btnHotKey_4 = new System.Windows.Forms.Button();
            this.rtxtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnProcessStart = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbCam2 = new System.Windows.Forms.GroupBox();
            this.btnFlimLast2 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.btnPre2 = new System.Windows.Forms.Button();
            this.btnFlimFrist2 = new System.Windows.Forms.Button();
            this.btnLive2 = new System.Windows.Forms.Button();
            this.btnOpenSaveFolder_Cam2 = new System.Windows.Forms.Button();
            this.btnManualTrigger2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbSaveType2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnOnline2 = new System.Windows.Forms.Button();
            this.lblJobName2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblOnlineCam2 = new System.Windows.Forms.Label();
            this.lblSavePath2 = new System.Windows.Forms.Label();
            this.chkGrpSave2 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chkImageSave2 = new System.Windows.Forms.CheckBox();
            this.txtNGRate2 = new System.Windows.Forms.TextBox();
            this.txtTotalCount2 = new System.Windows.Forms.TextBox();
            this.txtOKCount2 = new System.Windows.Forms.TextBox();
            this.txtNGCount2 = new System.Windows.Forms.TextBox();
            this.cvsFilmstrip2 = new Cognex.InSight.Controls.Filmstrip.CvsFilmstrip();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCntReset2 = new System.Windows.Forms.Button();
            this.gbCam1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnFlimLast1 = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnPre1 = new System.Windows.Forms.Button();
            this.btnFlimFrist1 = new System.Windows.Forms.Button();
            this.btnOpenSaveFolder_Cam1 = new System.Windows.Forms.Button();
            this.cbSaveType1 = new System.Windows.Forms.ComboBox();
            this.btnLive1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnManualTrigger1 = new System.Windows.Forms.Button();
            this.btnOnline1 = new System.Windows.Forms.Button();
            this.lblJobName1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblOnlineCam1 = new System.Windows.Forms.Label();
            this.lblSavePath1 = new System.Windows.Forms.Label();
            this.chkGrpSave1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkImageSave1 = new System.Windows.Forms.CheckBox();
            this.txtNGRate1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalCount1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cvsFilmstrip1 = new Cognex.InSight.Controls.Filmstrip.CvsFilmstrip();
            this.btnCntReset1 = new System.Windows.Forms.Button();
            this.txtNGCount1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOKCount1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tmStatus = new System.Windows.Forms.Timer(this.components);
            this.tmInitialize_Cam1 = new System.Windows.Forms.Timer(this.components);
            this.lblMainStatus = new System.Windows.Forms.Label();
            this.tmInitialize_Cam2 = new System.Windows.Forms.Timer(this.components);
            this.tmSystemStatus = new System.Windows.Forms.Timer(this.components);
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tmInitialize_Motion = new System.Windows.Forms.Timer(this.components);
            this.btnChange_Pass = new System.Windows.Forms.Button();
            this.optRecipe = new System.Windows.Forms.RadioButton();
            this.optLog = new System.Windows.Forms.RadioButton();
            this.btnMainSetting = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.optIO = new System.Windows.Forms.RadioButton();
            this.optMotion = new System.Windows.Forms.RadioButton();
            this.optVision = new System.Windows.Forms.RadioButton();
            this.optMain = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ucRecipe1 = new HFR_Inspection.ucRecipe1();
            this.motion1 = new HFR_Inspection.ucMotion();
            this.ucRecipe2 = new HFR_Inspection.ucRecipe2();
            this.titleBar1 = new HFR_Inspection.UserControls.TitleBar();
            this.ucLog1 = new HFR_Inspection.UserControls.ucLog();
            this.test1 = new HFR_Inspection.UserControls.TitleBar();
            this.tmSeq = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.gbMainMotion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCam2.SuspendLayout();
            this.gbCam1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.titleBar1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1920, 84);
            this.pnlTitle.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1035);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1920, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cvsInSightDisplay1);
            this.panel1.Location = new System.Drawing.Point(8, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 520);
            this.panel1.TabIndex = 3;
            // 
            // cvsInSightDisplay1
            // 
            this.cvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay1.DialogIcon = null;
            this.cvsInSightDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvsInSightDisplay1.Location = new System.Drawing.Point(0, 0);
            this.cvsInSightDisplay1.Name = "cvsInSightDisplay1";
            this.cvsInSightDisplay1.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.Default;
            this.cvsInSightDisplay1.Size = new System.Drawing.Size(709, 520);
            this.cvsInSightDisplay1.TabIndex = 11;
            this.cvsInSightDisplay1.InSightChanged += new System.EventHandler(this.cvsInSightDisplay1_InSightChanged);
            this.cvsInSightDisplay1.MouseLeave += new System.EventHandler(this.cvsInSightDisplay1_MouseLeave);
            this.cvsInSightDisplay1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cvsInSightDisplay1_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "V i s i o n (Cam1)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(723, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(709, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "V i s i o n (Cam2)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cvsInSightDisplay2);
            this.panel2.Location = new System.Drawing.Point(723, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 520);
            this.panel2.TabIndex = 11;
            // 
            // cvsInSightDisplay2
            // 
            this.cvsInSightDisplay2.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay2.DialogIcon = null;
            this.cvsInSightDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvsInSightDisplay2.Location = new System.Drawing.Point(0, 0);
            this.cvsInSightDisplay2.Name = "cvsInSightDisplay2";
            this.cvsInSightDisplay2.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.Default;
            this.cvsInSightDisplay2.Size = new System.Drawing.Size(709, 520);
            this.cvsInSightDisplay2.TabIndex = 11;
            this.cvsInSightDisplay2.InSightChanged += new System.EventHandler(this.cvsInSightDisplay2_InSightChanged);
            this.cvsInSightDisplay2.MouseLeave += new System.EventHandler(this.cvsInSightDisplay2_MouseLeave);
            this.cvsInSightDisplay2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cvsInSightDisplay2_MouseMove);
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.gbMainMotion);
            this.gbMain.Controls.Add(this.gbCam2);
            this.gbMain.Controls.Add(this.gbCam1);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.panel1);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.panel2);
            this.gbMain.Controls.Add(this.ucRecipe1);
            this.gbMain.Controls.Add(this.ucRecipe2);
            this.gbMain.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.Location = new System.Drawing.Point(3, 150);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1911, 882);
            this.gbMain.TabIndex = 14;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Main";
            // 
            // gbMainMotion
            // 
            this.gbMainMotion.Controls.Add(this.label22);
            this.gbMainMotion.Controls.Add(this.btnLoad_Job);
            this.gbMainMotion.Controls.Add(this.label20);
            this.gbMainMotion.Controls.Add(this.txtSelect_JobName);
            this.gbMainMotion.Controls.Add(this.groupBox1);
            this.gbMainMotion.Controls.Add(this.rtxtDisplay);
            this.gbMainMotion.Controls.Add(this.btnProcessStart);
            this.gbMainMotion.Controls.Add(this.textBox13);
            this.gbMainMotion.Controls.Add(this.label15);
            this.gbMainMotion.Controls.Add(this.textBox12);
            this.gbMainMotion.Controls.Add(this.label14);
            this.gbMainMotion.Controls.Add(this.textBox11);
            this.gbMainMotion.Controls.Add(this.label13);
            this.gbMainMotion.Controls.Add(this.textBox10);
            this.gbMainMotion.Controls.Add(this.label12);
            this.gbMainMotion.Controls.Add(this.textBox9);
            this.gbMainMotion.Controls.Add(this.label11);
            this.gbMainMotion.Location = new System.Drawing.Point(1438, 9);
            this.gbMainMotion.Name = "gbMainMotion";
            this.gbMainMotion.Size = new System.Drawing.Size(467, 867);
            this.gbMainMotion.TabIndex = 15;
            this.gbMainMotion.TabStop = false;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(7, 188);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 27);
            this.label22.TabIndex = 33;
            this.label22.Text = "작업 불러오기 :";
            // 
            // btnLoad_Job
            // 
            this.btnLoad_Job.BackgroundImage = global::HFR_Inspection.Properties.Resources.Foler;
            this.btnLoad_Job.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoad_Job.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad_Job.Location = new System.Drawing.Point(141, 182);
            this.btnLoad_Job.Name = "btnLoad_Job";
            this.btnLoad_Job.Size = new System.Drawing.Size(90, 38);
            this.btnLoad_Job.TabIndex = 32;
            this.btnLoad_Job.UseVisualStyleBackColor = true;
            this.btnLoad_Job.Click += new System.EventHandler(this.btnLoad_Job_Click);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(6, 215);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 27);
            this.label20.TabIndex = 31;
            this.label20.Text = "현재 작업 : ";
            // 
            // txtSelect_JobName
            // 
            this.txtSelect_JobName.BackColor = System.Drawing.Color.White;
            this.txtSelect_JobName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtSelect_JobName.Location = new System.Drawing.Point(56, 246);
            this.txtSelect_JobName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSelect_JobName.Name = "txtSelect_JobName";
            this.txtSelect_JobName.ReadOnly = true;
            this.txtSelect_JobName.Size = new System.Drawing.Size(354, 35);
            this.txtSelect_JobName.TabIndex = 30;
            this.txtSelect_JobName.Text = "-";
            this.txtSelect_JobName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHotKey_3);
            this.groupBox1.Controls.Add(this.btnHotKey_2);
            this.groupBox1.Controls.Add(this.btnHotKey_1);
            this.groupBox1.Controls.Add(this.btnHotKey_4);
            this.groupBox1.Location = new System.Drawing.Point(6, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 90);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "작업 변경 핫 키";
            // 
            // btnHotKey_3
            // 
            this.btnHotKey_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotKey_3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnHotKey_3.Location = new System.Drawing.Point(232, 29);
            this.btnHotKey_3.Name = "btnHotKey_3";
            this.btnHotKey_3.Size = new System.Drawing.Size(90, 38);
            this.btnHotKey_3.TabIndex = 36;
            this.btnHotKey_3.Text = "-";
            this.btnHotKey_3.UseVisualStyleBackColor = true;
            this.btnHotKey_3.Click += new System.EventHandler(this.btnHotKey_3_Click);
            // 
            // btnHotKey_2
            // 
            this.btnHotKey_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotKey_2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnHotKey_2.Location = new System.Drawing.Point(128, 29);
            this.btnHotKey_2.Name = "btnHotKey_2";
            this.btnHotKey_2.Size = new System.Drawing.Size(90, 38);
            this.btnHotKey_2.TabIndex = 35;
            this.btnHotKey_2.Text = "-";
            this.btnHotKey_2.UseVisualStyleBackColor = true;
            this.btnHotKey_2.Click += new System.EventHandler(this.btnHotKey_2_Click);
            // 
            // btnHotKey_1
            // 
            this.btnHotKey_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotKey_1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnHotKey_1.Location = new System.Drawing.Point(24, 29);
            this.btnHotKey_1.Name = "btnHotKey_1";
            this.btnHotKey_1.Size = new System.Drawing.Size(90, 38);
            this.btnHotKey_1.TabIndex = 33;
            this.btnHotKey_1.Text = "-";
            this.btnHotKey_1.UseVisualStyleBackColor = true;
            this.btnHotKey_1.Click += new System.EventHandler(this.btnHotKey_1_Click);
            // 
            // btnHotKey_4
            // 
            this.btnHotKey_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotKey_4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnHotKey_4.Location = new System.Drawing.Point(336, 29);
            this.btnHotKey_4.Name = "btnHotKey_4";
            this.btnHotKey_4.Size = new System.Drawing.Size(90, 38);
            this.btnHotKey_4.TabIndex = 34;
            this.btnHotKey_4.Text = "-";
            this.btnHotKey_4.UseVisualStyleBackColor = true;
            this.btnHotKey_4.Click += new System.EventHandler(this.btnHotKey_4_Click);
            // 
            // rtxtDisplay
            // 
            this.rtxtDisplay.Location = new System.Drawing.Point(6, 360);
            this.rtxtDisplay.Name = "rtxtDisplay";
            this.rtxtDisplay.ReadOnly = true;
            this.rtxtDisplay.Size = new System.Drawing.Size(455, 248);
            this.rtxtDisplay.TabIndex = 17;
            this.rtxtDisplay.Text = "";
            // 
            // btnProcessStart
            // 
            this.btnProcessStart.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessStart.Location = new System.Drawing.Point(2, 738);
            this.btnProcessStart.Name = "btnProcessStart";
            this.btnProcessStart.Size = new System.Drawing.Size(464, 123);
            this.btnProcessStart.TabIndex = 16;
            this.btnProcessStart.Text = "검사 시작";
            this.btnProcessStart.UseVisualStyleBackColor = true;
            this.btnProcessStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(206, 52);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 26);
            this.textBox13.TabIndex = 11;
            this.textBox13.Text = "000.000";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(159, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 19);
            this.label15.TabIndex = 10;
            this.label15.Text = "Z2 : ";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(54, 52);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 26);
            this.textBox12.TabIndex = 9;
            this.textBox12.Text = "000.000";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "Z1 : ";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(352, 20);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 26);
            this.textBox11.TabIndex = 7;
            this.textBox11.Text = "000.000";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(313, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "T : ";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(206, 20);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 26);
            this.textBox10.TabIndex = 5;
            this.textBox10.Text = "000.000";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(167, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Y : ";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(54, 20);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 26);
            this.textBox9.TabIndex = 3;
            this.textBox9.Text = "000.000";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "X : ";
            // 
            // gbCam2
            // 
            this.gbCam2.Controls.Add(this.btnFlimLast2);
            this.gbCam2.Controls.Add(this.btnNext2);
            this.gbCam2.Controls.Add(this.btnPre2);
            this.gbCam2.Controls.Add(this.btnFlimFrist2);
            this.gbCam2.Controls.Add(this.btnLive2);
            this.gbCam2.Controls.Add(this.btnOpenSaveFolder_Cam2);
            this.gbCam2.Controls.Add(this.btnManualTrigger2);
            this.gbCam2.Controls.Add(this.cbSaveType2);
            this.gbCam2.Controls.Add(this.label18);
            this.gbCam2.Controls.Add(this.btnOnline2);
            this.gbCam2.Controls.Add(this.lblJobName2);
            this.gbCam2.Controls.Add(this.label24);
            this.gbCam2.Controls.Add(this.lblOnlineCam2);
            this.gbCam2.Controls.Add(this.lblSavePath2);
            this.gbCam2.Controls.Add(this.chkGrpSave2);
            this.gbCam2.Controls.Add(this.label19);
            this.gbCam2.Controls.Add(this.chkImageSave2);
            this.gbCam2.Controls.Add(this.txtNGRate2);
            this.gbCam2.Controls.Add(this.txtTotalCount2);
            this.gbCam2.Controls.Add(this.txtOKCount2);
            this.gbCam2.Controls.Add(this.txtNGCount2);
            this.gbCam2.Controls.Add(this.cvsFilmstrip2);
            this.gbCam2.Controls.Add(this.label7);
            this.gbCam2.Controls.Add(this.label10);
            this.gbCam2.Controls.Add(this.label8);
            this.gbCam2.Controls.Add(this.label9);
            this.gbCam2.Controls.Add(this.btnCntReset2);
            this.gbCam2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCam2.Location = new System.Drawing.Point(723, 592);
            this.gbCam2.Name = "gbCam2";
            this.gbCam2.Size = new System.Drawing.Size(710, 284);
            this.gbCam2.TabIndex = 14;
            this.gbCam2.TabStop = false;
            this.gbCam2.Text = "Cam2";
            // 
            // btnFlimLast2
            // 
            this.btnFlimLast2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlimLast2.Location = new System.Drawing.Point(665, 168);
            this.btnFlimLast2.Name = "btnFlimLast2";
            this.btnFlimLast2.Size = new System.Drawing.Size(40, 40);
            this.btnFlimLast2.TabIndex = 31;
            this.btnFlimLast2.Text = ">|";
            this.btnFlimLast2.UseVisualStyleBackColor = true;
            this.btnFlimLast2.Click += new System.EventHandler(this.btnFlimLast2_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext2.Location = new System.Drawing.Point(619, 168);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(40, 40);
            this.btnNext2.TabIndex = 30;
            this.btnNext2.Text = ">>";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // btnPre2
            // 
            this.btnPre2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre2.Location = new System.Drawing.Point(573, 168);
            this.btnPre2.Name = "btnPre2";
            this.btnPre2.Size = new System.Drawing.Size(40, 40);
            this.btnPre2.TabIndex = 29;
            this.btnPre2.Text = "<<";
            this.btnPre2.UseVisualStyleBackColor = true;
            this.btnPre2.Click += new System.EventHandler(this.btnPre2_Click);
            // 
            // btnFlimFrist2
            // 
            this.btnFlimFrist2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlimFrist2.Location = new System.Drawing.Point(527, 168);
            this.btnFlimFrist2.Name = "btnFlimFrist2";
            this.btnFlimFrist2.Size = new System.Drawing.Size(40, 40);
            this.btnFlimFrist2.TabIndex = 28;
            this.btnFlimFrist2.Text = "|<";
            this.btnFlimFrist2.UseVisualStyleBackColor = true;
            this.btnFlimFrist2.Click += new System.EventHandler(this.btnFlimFrist2_Click);
            // 
            // btnLive2
            // 
            this.btnLive2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive2.Location = new System.Drawing.Point(661, 88);
            this.btnLive2.Name = "btnLive2";
            this.btnLive2.Size = new System.Drawing.Size(43, 29);
            this.btnLive2.TabIndex = 22;
            this.btnLive2.Text = "Live";
            this.btnLive2.UseVisualStyleBackColor = true;
            this.btnLive2.Click += new System.EventHandler(this.btnLive2_Click);
            // 
            // btnOpenSaveFolder_Cam2
            // 
            this.btnOpenSaveFolder_Cam2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpenSaveFolder_Cam2.Location = new System.Drawing.Point(122, 142);
            this.btnOpenSaveFolder_Cam2.Name = "btnOpenSaveFolder_Cam2";
            this.btnOpenSaveFolder_Cam2.Size = new System.Drawing.Size(100, 26);
            this.btnOpenSaveFolder_Cam2.TabIndex = 21;
            this.btnOpenSaveFolder_Cam2.Text = "폴더 열기";
            this.btnOpenSaveFolder_Cam2.UseVisualStyleBackColor = true;
            this.btnOpenSaveFolder_Cam2.Click += new System.EventHandler(this.btnOpenSaveFolder_Cam2_Click);
            // 
            // btnManualTrigger2
            // 
            this.btnManualTrigger2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualTrigger2.ImageIndex = 8;
            this.btnManualTrigger2.ImageList = this.imageList1;
            this.btnManualTrigger2.Location = new System.Drawing.Point(605, 88);
            this.btnManualTrigger2.Name = "btnManualTrigger2";
            this.btnManualTrigger2.Size = new System.Drawing.Size(43, 29);
            this.btnManualTrigger2.TabIndex = 21;
            this.btnManualTrigger2.UseVisualStyleBackColor = true;
            this.btnManualTrigger2.Click += new System.EventHandler(this.btnManualTrigger2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cam.png");
            this.imageList1.Images.SetKeyName(1, "Gear.png");
            this.imageList1.Images.SetKeyName(2, "Home.png");
            this.imageList1.Images.SetKeyName(3, "I_O.png");
            this.imageList1.Images.SetKeyName(4, "Init.png");
            this.imageList1.Images.SetKeyName(5, "Stage.png");
            this.imageList1.Images.SetKeyName(6, "제목없음.png");
            this.imageList1.Images.SetKeyName(7, "Disc.png");
            this.imageList1.Images.SetKeyName(8, "Camera.png");
            // 
            // cbSaveType2
            // 
            this.cbSaveType2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbSaveType2.FormattingEnabled = true;
            this.cbSaveType2.Items.AddRange(new object[] {
            "OK",
            "NG",
            "ALL"});
            this.cbSaveType2.Location = new System.Drawing.Point(321, 89);
            this.cbSaveType2.Name = "cbSaveType2";
            this.cbSaveType2.Size = new System.Drawing.Size(100, 27);
            this.cbSaveType2.TabIndex = 26;
            this.cbSaveType2.SelectedIndexChanged += new System.EventHandler(this.cbSaveType2_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(251, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 19);
            this.label18.TabIndex = 27;
            this.label18.Text = "저장 유형 :";
            // 
            // btnOnline2
            // 
            this.btnOnline2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnOnline2.Location = new System.Drawing.Point(605, 56);
            this.btnOnline2.Name = "btnOnline2";
            this.btnOnline2.Size = new System.Drawing.Size(100, 26);
            this.btnOnline2.TabIndex = 25;
            this.btnOnline2.Text = "On/Offline";
            this.btnOnline2.UseVisualStyleBackColor = true;
            this.btnOnline2.Click += new System.EventHandler(this.btnOnline2_Click);
            // 
            // lblJobName2
            // 
            this.lblJobName2.AutoSize = true;
            this.lblJobName2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName2.Location = new System.Drawing.Point(94, 165);
            this.lblJobName2.Name = "lblJobName2";
            this.lblJobName2.Size = new System.Drawing.Size(26, 29);
            this.lblJobName2.TabIndex = 24;
            this.lblJobName2.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(17, 165);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 29);
            this.label24.TabIndex = 23;
            this.label24.Text = "작업명 : ";
            // 
            // lblOnlineCam2
            // 
            this.lblOnlineCam2.BackColor = System.Drawing.SystemColors.Control;
            this.lblOnlineCam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOnlineCam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOnlineCam2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOnlineCam2.Location = new System.Drawing.Point(605, 24);
            this.lblOnlineCam2.Name = "lblOnlineCam2";
            this.lblOnlineCam2.Size = new System.Drawing.Size(100, 26);
            this.lblOnlineCam2.TabIndex = 15;
            this.lblOnlineCam2.Text = "OFFLINE";
            this.lblOnlineCam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSavePath2
            // 
            this.lblSavePath2.AutoSize = true;
            this.lblSavePath2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSavePath2.Location = new System.Drawing.Point(94, 120);
            this.lblSavePath2.Name = "lblSavePath2";
            this.lblSavePath2.Size = new System.Drawing.Size(125, 19);
            this.lblSavePath2.TabIndex = 22;
            this.lblSavePath2.Text = "경로를 지정해주세요.";
            // 
            // chkGrpSave2
            // 
            this.chkGrpSave2.AutoSize = true;
            this.chkGrpSave2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkGrpSave2.Location = new System.Drawing.Point(122, 94);
            this.chkGrpSave2.Name = "chkGrpSave2";
            this.chkGrpSave2.Size = new System.Drawing.Size(92, 23);
            this.chkGrpSave2.TabIndex = 21;
            this.chkGrpSave2.Text = "그래픽 포함";
            this.chkGrpSave2.UseVisualStyleBackColor = true;
            this.chkGrpSave2.CheckedChanged += new System.EventHandler(this.chkGrpSave2_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(17, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 19);
            this.label19.TabIndex = 20;
            this.label19.Text = "저장경로 : ";
            // 
            // chkImageSave2
            // 
            this.chkImageSave2.AutoSize = true;
            this.chkImageSave2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkImageSave2.Location = new System.Drawing.Point(22, 94);
            this.chkImageSave2.Name = "chkImageSave2";
            this.chkImageSave2.Size = new System.Drawing.Size(92, 23);
            this.chkImageSave2.TabIndex = 19;
            this.chkImageSave2.Text = "이미지 저장";
            this.chkImageSave2.UseVisualStyleBackColor = true;
            this.chkImageSave2.CheckedChanged += new System.EventHandler(this.chkImageSave2_CheckedChanged);
            // 
            // txtNGRate2
            // 
            this.txtNGRate2.BackColor = System.Drawing.Color.White;
            this.txtNGRate2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtNGRate2.Location = new System.Drawing.Point(321, 51);
            this.txtNGRate2.Name = "txtNGRate2";
            this.txtNGRate2.ReadOnly = true;
            this.txtNGRate2.Size = new System.Drawing.Size(100, 26);
            this.txtNGRate2.TabIndex = 18;
            this.txtNGRate2.Text = "0";
            this.txtNGRate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalCount2
            // 
            this.txtTotalCount2.BackColor = System.Drawing.Color.White;
            this.txtTotalCount2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalCount2.Location = new System.Drawing.Point(122, 51);
            this.txtTotalCount2.Name = "txtTotalCount2";
            this.txtTotalCount2.ReadOnly = true;
            this.txtTotalCount2.Size = new System.Drawing.Size(100, 26);
            this.txtTotalCount2.TabIndex = 16;
            this.txtTotalCount2.Text = "0";
            this.txtTotalCount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOKCount2
            // 
            this.txtOKCount2.BackColor = System.Drawing.Color.White;
            this.txtOKCount2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtOKCount2.Location = new System.Drawing.Point(122, 24);
            this.txtOKCount2.Name = "txtOKCount2";
            this.txtOKCount2.ReadOnly = true;
            this.txtOKCount2.Size = new System.Drawing.Size(100, 26);
            this.txtOKCount2.TabIndex = 11;
            this.txtOKCount2.Text = "0";
            this.txtOKCount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNGCount2
            // 
            this.txtNGCount2.BackColor = System.Drawing.Color.White;
            this.txtNGCount2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtNGCount2.Location = new System.Drawing.Point(321, 24);
            this.txtNGCount2.Name = "txtNGCount2";
            this.txtNGCount2.ReadOnly = true;
            this.txtNGCount2.Size = new System.Drawing.Size(100, 26);
            this.txtNGCount2.TabIndex = 13;
            this.txtNGCount2.Text = "0";
            this.txtNGCount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cvsFilmstrip2
            // 
            this.cvsFilmstrip2.BackColor = System.Drawing.Color.Transparent;
            this.cvsFilmstrip2.FilmQueue = null;
            this.cvsFilmstrip2.FirstThumbnailIndex = 0;
            this.cvsFilmstrip2.HeightScale = Cognex.InSight.Controls.Filmstrip.CvsFilmstripScale.One;
            this.cvsFilmstrip2.ImageIndex = 0;
            this.cvsFilmstrip2.Location = new System.Drawing.Point(6, 214);
            this.cvsFilmstrip2.Name = "cvsFilmstrip2";
            this.cvsFilmstrip2.SelectedIndex = -1;
            this.cvsFilmstrip2.ShowSummary = false;
            this.cvsFilmstrip2.ShowThumbnailImage = true;
            this.cvsFilmstrip2.Size = new System.Drawing.Size(701, 64);
            this.cvsFilmstrip2.StatusLevelStyle = Cognex.InSight.Controls.Filmstrip.CvsStatusLevelStyle.Geometric;
            this.cvsFilmstrip2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(241, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "NG Rate : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(31, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "OK Count : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(17, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Count : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(229, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "NG Count : ";
            // 
            // btnCntReset2
            // 
            this.btnCntReset2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCntReset2.Location = new System.Drawing.Point(428, 24);
            this.btnCntReset2.Name = "btnCntReset2";
            this.btnCntReset2.Size = new System.Drawing.Size(100, 26);
            this.btnCntReset2.TabIndex = 14;
            this.btnCntReset2.Text = "Reset";
            this.btnCntReset2.UseVisualStyleBackColor = true;
            this.btnCntReset2.Click += new System.EventHandler(this.btnCntReset2_Click);
            // 
            // gbCam1
            // 
            this.gbCam1.Controls.Add(this.checkBox2);
            this.gbCam1.Controls.Add(this.checkBox1);
            this.gbCam1.Controls.Add(this.btnFlimLast1);
            this.gbCam1.Controls.Add(this.btnNext1);
            this.gbCam1.Controls.Add(this.btnPre1);
            this.gbCam1.Controls.Add(this.btnFlimFrist1);
            this.gbCam1.Controls.Add(this.btnOpenSaveFolder_Cam1);
            this.gbCam1.Controls.Add(this.cbSaveType1);
            this.gbCam1.Controls.Add(this.btnLive1);
            this.gbCam1.Controls.Add(this.label17);
            this.gbCam1.Controls.Add(this.btnManualTrigger1);
            this.gbCam1.Controls.Add(this.btnOnline1);
            this.gbCam1.Controls.Add(this.lblJobName1);
            this.gbCam1.Controls.Add(this.label21);
            this.gbCam1.Controls.Add(this.lblOnlineCam1);
            this.gbCam1.Controls.Add(this.lblSavePath1);
            this.gbCam1.Controls.Add(this.chkGrpSave1);
            this.gbCam1.Controls.Add(this.label16);
            this.gbCam1.Controls.Add(this.chkImageSave1);
            this.gbCam1.Controls.Add(this.txtNGRate1);
            this.gbCam1.Controls.Add(this.label6);
            this.gbCam1.Controls.Add(this.txtTotalCount1);
            this.gbCam1.Controls.Add(this.label5);
            this.gbCam1.Controls.Add(this.cvsFilmstrip1);
            this.gbCam1.Controls.Add(this.btnCntReset1);
            this.gbCam1.Controls.Add(this.txtNGCount1);
            this.gbCam1.Controls.Add(this.label4);
            this.gbCam1.Controls.Add(this.txtOKCount1);
            this.gbCam1.Controls.Add(this.label3);
            this.gbCam1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCam1.Location = new System.Drawing.Point(6, 592);
            this.gbCam1.Name = "gbCam1";
            this.gbCam1.Size = new System.Drawing.Size(710, 284);
            this.gbCam1.TabIndex = 13;
            this.gbCam1.TabStop = false;
            this.gbCam1.Text = "Cam1";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(280, 168);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 19);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(281, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 19);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnFlimLast1
            // 
            this.btnFlimLast1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlimLast1.Location = new System.Drawing.Point(665, 168);
            this.btnFlimLast1.Name = "btnFlimLast1";
            this.btnFlimLast1.Size = new System.Drawing.Size(40, 40);
            this.btnFlimLast1.TabIndex = 24;
            this.btnFlimLast1.Text = ">|";
            this.btnFlimLast1.UseVisualStyleBackColor = true;
            this.btnFlimLast1.Click += new System.EventHandler(this.btnFlimLast1_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext1.Location = new System.Drawing.Point(619, 168);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(40, 40);
            this.btnNext1.TabIndex = 23;
            this.btnNext1.Text = ">>";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnPre1
            // 
            this.btnPre1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre1.Location = new System.Drawing.Point(573, 168);
            this.btnPre1.Name = "btnPre1";
            this.btnPre1.Size = new System.Drawing.Size(40, 40);
            this.btnPre1.TabIndex = 22;
            this.btnPre1.Text = "<<";
            this.btnPre1.UseVisualStyleBackColor = true;
            this.btnPre1.Click += new System.EventHandler(this.btnPre1_Click);
            // 
            // btnFlimFrist1
            // 
            this.btnFlimFrist1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlimFrist1.Location = new System.Drawing.Point(527, 168);
            this.btnFlimFrist1.Name = "btnFlimFrist1";
            this.btnFlimFrist1.Size = new System.Drawing.Size(40, 40);
            this.btnFlimFrist1.TabIndex = 21;
            this.btnFlimFrist1.Text = "|<";
            this.btnFlimFrist1.UseVisualStyleBackColor = true;
            this.btnFlimFrist1.Click += new System.EventHandler(this.btnFlimFrist1_Click);
            // 
            // btnOpenSaveFolder_Cam1
            // 
            this.btnOpenSaveFolder_Cam1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpenSaveFolder_Cam1.Location = new System.Drawing.Point(118, 142);
            this.btnOpenSaveFolder_Cam1.Name = "btnOpenSaveFolder_Cam1";
            this.btnOpenSaveFolder_Cam1.Size = new System.Drawing.Size(100, 26);
            this.btnOpenSaveFolder_Cam1.TabIndex = 20;
            this.btnOpenSaveFolder_Cam1.Text = "폴더 열기";
            this.btnOpenSaveFolder_Cam1.UseVisualStyleBackColor = true;
            this.btnOpenSaveFolder_Cam1.Click += new System.EventHandler(this.btnOpenSaveFolder_Cam1_Click);
            // 
            // cbSaveType1
            // 
            this.cbSaveType1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbSaveType1.FormattingEnabled = true;
            this.cbSaveType1.Items.AddRange(new object[] {
            "OK",
            "NG",
            "ALL"});
            this.cbSaveType1.Location = new System.Drawing.Point(316, 89);
            this.cbSaveType1.Name = "cbSaveType1";
            this.cbSaveType1.Size = new System.Drawing.Size(100, 27);
            this.cbSaveType1.TabIndex = 18;
            this.cbSaveType1.SelectedIndexChanged += new System.EventHandler(this.cbSaveType1_SelectedIndexChanged);
            // 
            // btnLive1
            // 
            this.btnLive1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive1.Location = new System.Drawing.Point(661, 88);
            this.btnLive1.Name = "btnLive1";
            this.btnLive1.Size = new System.Drawing.Size(43, 29);
            this.btnLive1.TabIndex = 20;
            this.btnLive1.Text = "Live";
            this.btnLive1.UseVisualStyleBackColor = true;
            this.btnLive1.Click += new System.EventHandler(this.btnLive1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(246, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 19);
            this.label17.TabIndex = 19;
            this.label17.Text = "저장 유형 :";
            // 
            // btnManualTrigger1
            // 
            this.btnManualTrigger1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualTrigger1.ImageIndex = 8;
            this.btnManualTrigger1.ImageList = this.imageList1;
            this.btnManualTrigger1.Location = new System.Drawing.Point(605, 88);
            this.btnManualTrigger1.Name = "btnManualTrigger1";
            this.btnManualTrigger1.Size = new System.Drawing.Size(43, 29);
            this.btnManualTrigger1.TabIndex = 19;
            this.btnManualTrigger1.UseVisualStyleBackColor = true;
            this.btnManualTrigger1.Click += new System.EventHandler(this.btnMaualTrigger1_Click);
            // 
            // btnOnline1
            // 
            this.btnOnline1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnOnline1.Location = new System.Drawing.Point(605, 56);
            this.btnOnline1.Name = "btnOnline1";
            this.btnOnline1.Size = new System.Drawing.Size(100, 26);
            this.btnOnline1.TabIndex = 17;
            this.btnOnline1.Text = "On/Offline";
            this.btnOnline1.UseVisualStyleBackColor = true;
            this.btnOnline1.Click += new System.EventHandler(this.btnOnline1_Click);
            // 
            // lblJobName1
            // 
            this.lblJobName1.AutoSize = true;
            this.lblJobName1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName1.Location = new System.Drawing.Point(90, 165);
            this.lblJobName1.Name = "lblJobName1";
            this.lblJobName1.Size = new System.Drawing.Size(26, 29);
            this.lblJobName1.TabIndex = 16;
            this.lblJobName1.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 29);
            this.label21.TabIndex = 15;
            this.label21.Text = "작업명 : ";
            // 
            // lblOnlineCam1
            // 
            this.lblOnlineCam1.BackColor = System.Drawing.SystemColors.Control;
            this.lblOnlineCam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOnlineCam1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOnlineCam1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOnlineCam1.Location = new System.Drawing.Point(605, 24);
            this.lblOnlineCam1.Name = "lblOnlineCam1";
            this.lblOnlineCam1.Size = new System.Drawing.Size(100, 26);
            this.lblOnlineCam1.TabIndex = 14;
            this.lblOnlineCam1.Text = "OFFLINE";
            this.lblOnlineCam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSavePath1
            // 
            this.lblSavePath1.AutoSize = true;
            this.lblSavePath1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSavePath1.Location = new System.Drawing.Point(90, 120);
            this.lblSavePath1.Name = "lblSavePath1";
            this.lblSavePath1.Size = new System.Drawing.Size(125, 19);
            this.lblSavePath1.TabIndex = 13;
            this.lblSavePath1.Text = "경로를 지정해주세요.";
            // 
            // chkGrpSave1
            // 
            this.chkGrpSave1.AutoSize = true;
            this.chkGrpSave1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkGrpSave1.Location = new System.Drawing.Point(118, 94);
            this.chkGrpSave1.Name = "chkGrpSave1";
            this.chkGrpSave1.Size = new System.Drawing.Size(92, 23);
            this.chkGrpSave1.TabIndex = 12;
            this.chkGrpSave1.Text = "그래픽 포함";
            this.chkGrpSave1.UseVisualStyleBackColor = true;
            this.chkGrpSave1.CheckedChanged += new System.EventHandler(this.chkGrpSave1_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(13, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 19);
            this.label16.TabIndex = 11;
            this.label16.Text = "저장경로 : ";
            // 
            // chkImageSave1
            // 
            this.chkImageSave1.AutoSize = true;
            this.chkImageSave1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkImageSave1.Location = new System.Drawing.Point(17, 94);
            this.chkImageSave1.Name = "chkImageSave1";
            this.chkImageSave1.Size = new System.Drawing.Size(92, 23);
            this.chkImageSave1.TabIndex = 10;
            this.chkImageSave1.Text = "이미지 저장";
            this.chkImageSave1.UseVisualStyleBackColor = true;
            this.chkImageSave1.CheckedChanged += new System.EventHandler(this.chkImageSave1_CheckedChanged);
            // 
            // txtNGRate1
            // 
            this.txtNGRate1.BackColor = System.Drawing.Color.White;
            this.txtNGRate1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtNGRate1.Location = new System.Drawing.Point(316, 51);
            this.txtNGRate1.Name = "txtNGRate1";
            this.txtNGRate1.ReadOnly = true;
            this.txtNGRate1.Size = new System.Drawing.Size(100, 26);
            this.txtNGRate1.TabIndex = 9;
            this.txtNGRate1.Text = "0";
            this.txtNGRate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(236, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "NG Rate : ";
            // 
            // txtTotalCount1
            // 
            this.txtTotalCount1.BackColor = System.Drawing.Color.White;
            this.txtTotalCount1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalCount1.Location = new System.Drawing.Point(118, 51);
            this.txtTotalCount1.Name = "txtTotalCount1";
            this.txtTotalCount1.ReadOnly = true;
            this.txtTotalCount1.Size = new System.Drawing.Size(100, 26);
            this.txtTotalCount1.TabIndex = 7;
            this.txtTotalCount1.Text = "0";
            this.txtTotalCount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Count : ";
            // 
            // cvsFilmstrip1
            // 
            this.cvsFilmstrip1.BackColor = System.Drawing.Color.Transparent;
            this.cvsFilmstrip1.FilmQueue = null;
            this.cvsFilmstrip1.FirstThumbnailIndex = 0;
            this.cvsFilmstrip1.HeightScale = Cognex.InSight.Controls.Filmstrip.CvsFilmstripScale.One;
            this.cvsFilmstrip1.ImageIndex = 0;
            this.cvsFilmstrip1.Location = new System.Drawing.Point(6, 214);
            this.cvsFilmstrip1.Name = "cvsFilmstrip1";
            this.cvsFilmstrip1.SelectedIndex = -1;
            this.cvsFilmstrip1.ShowSummary = false;
            this.cvsFilmstrip1.ShowThumbnailImage = true;
            this.cvsFilmstrip1.Size = new System.Drawing.Size(701, 64);
            this.cvsFilmstrip1.StatusLevelStyle = Cognex.InSight.Controls.Filmstrip.CvsStatusLevelStyle.Geometric;
            this.cvsFilmstrip1.TabIndex = 5;
            // 
            // btnCntReset1
            // 
            this.btnCntReset1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCntReset1.Location = new System.Drawing.Point(423, 24);
            this.btnCntReset1.Name = "btnCntReset1";
            this.btnCntReset1.Size = new System.Drawing.Size(100, 26);
            this.btnCntReset1.TabIndex = 4;
            this.btnCntReset1.Text = "Reset";
            this.btnCntReset1.UseVisualStyleBackColor = true;
            this.btnCntReset1.Click += new System.EventHandler(this.btnCntReset1_Click);
            // 
            // txtNGCount1
            // 
            this.txtNGCount1.BackColor = System.Drawing.Color.White;
            this.txtNGCount1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtNGCount1.Location = new System.Drawing.Point(316, 24);
            this.txtNGCount1.Name = "txtNGCount1";
            this.txtNGCount1.ReadOnly = true;
            this.txtNGCount1.Size = new System.Drawing.Size(100, 26);
            this.txtNGCount1.TabIndex = 3;
            this.txtNGCount1.Text = "0";
            this.txtNGCount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(224, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "NG Count : ";
            // 
            // txtOKCount1
            // 
            this.txtOKCount1.BackColor = System.Drawing.Color.White;
            this.txtOKCount1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtOKCount1.Location = new System.Drawing.Point(118, 24);
            this.txtOKCount1.Name = "txtOKCount1";
            this.txtOKCount1.ReadOnly = true;
            this.txtOKCount1.Size = new System.Drawing.Size(100, 26);
            this.txtOKCount1.TabIndex = 1;
            this.txtOKCount1.Text = "0";
            this.txtOKCount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "OK Count : ";
            // 
            // tmStatus
            // 
            this.tmStatus.Tick += new System.EventHandler(this.tmStatus_Tick);
            // 
            // tmInitialize_Cam1
            // 
            this.tmInitialize_Cam1.Tick += new System.EventHandler(this.tmInitialize_Tick);
            // 
            // lblMainStatus
            // 
            this.lblMainStatus.BackColor = System.Drawing.Color.White;
            this.lblMainStatus.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainStatus.Location = new System.Drawing.Point(1582, 87);
            this.lblMainStatus.Name = "lblMainStatus";
            this.lblMainStatus.Size = new System.Drawing.Size(327, 69);
            this.lblMainStatus.TabIndex = 16;
            this.lblMainStatus.Text = "대기중";
            this.lblMainStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmInitialize_Cam2
            // 
            this.tmInitialize_Cam2.Tick += new System.EventHandler(this.tmInitialize_Cam2_Tick);
            // 
            // tmSystemStatus
            // 
            this.tmSystemStatus.Tick += new System.EventHandler(this.tmSystemStatus_Tick);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1539, 111);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 16);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // tmInitialize_Motion
            // 
            this.tmInitialize_Motion.Tick += new System.EventHandler(this.tmInitialize_Motion_Tick);
            // 
            // btnChange_Pass
            // 
            this.btnChange_Pass.BackgroundImage = global::HFR_Inspection.Properties.Resources.Key;
            this.btnChange_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChange_Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange_Pass.Location = new System.Drawing.Point(1148, 89);
            this.btnChange_Pass.Name = "btnChange_Pass";
            this.btnChange_Pass.Size = new System.Drawing.Size(54, 55);
            this.btnChange_Pass.TabIndex = 23;
            this.btnChange_Pass.UseVisualStyleBackColor = true;
            this.btnChange_Pass.Visible = false;
            this.btnChange_Pass.Click += new System.EventHandler(this.btnChange_Pass_Click);
            // 
            // optRecipe
            // 
            this.optRecipe.Appearance = System.Windows.Forms.Appearance.Button;
            this.optRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optRecipe.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optRecipe.ImageIndex = 7;
            this.optRecipe.ImageList = this.imageList1;
            this.optRecipe.Location = new System.Drawing.Point(147, 89);
            this.optRecipe.Name = "optRecipe";
            this.optRecipe.Size = new System.Drawing.Size(136, 55);
            this.optRecipe.TabIndex = 19;
            this.optRecipe.Text = "Recipe";
            this.optRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optRecipe.UseVisualStyleBackColor = true;
            this.optRecipe.Click += new System.EventHandler(this.optRecipe_Click);
            // 
            // optLog
            // 
            this.optLog.Appearance = System.Windows.Forms.Appearance.Button;
            this.optLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optLog.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optLog.ImageIndex = 6;
            this.optLog.ImageList = this.imageList1;
            this.optLog.Location = new System.Drawing.Point(719, 89);
            this.optLog.Name = "optLog";
            this.optLog.Size = new System.Drawing.Size(136, 55);
            this.optLog.TabIndex = 18;
            this.optLog.Text = "Log    ";
            this.optLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optLog.UseVisualStyleBackColor = true;
            this.optLog.Click += new System.EventHandler(this.optLog_Click);
            // 
            // btnMainSetting
            // 
            this.btnMainSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainSetting.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnMainSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainSetting.ImageIndex = 1;
            this.btnMainSetting.ImageList = this.imageList1;
            this.btnMainSetting.Location = new System.Drawing.Point(862, 89);
            this.btnMainSetting.Name = "btnMainSetting";
            this.btnMainSetting.Size = new System.Drawing.Size(136, 55);
            this.btnMainSetting.TabIndex = 17;
            this.btnMainSetting.Text = "Setting";
            this.btnMainSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainSetting.UseVisualStyleBackColor = true;
            this.btnMainSetting.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInit
            // 
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnInit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInit.ImageIndex = 4;
            this.btnInit.ImageList = this.imageList1;
            this.btnInit.Location = new System.Drawing.Point(1004, 89);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(136, 55);
            this.btnInit.TabIndex = 15;
            this.btnInit.Text = "Initialize";
            this.btnInit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // optIO
            // 
            this.optIO.Appearance = System.Windows.Forms.Appearance.Button;
            this.optIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optIO.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optIO.ImageIndex = 3;
            this.optIO.ImageList = this.imageList1;
            this.optIO.Location = new System.Drawing.Point(576, 89);
            this.optIO.Name = "optIO";
            this.optIO.Size = new System.Drawing.Size(136, 55);
            this.optIO.TabIndex = 9;
            this.optIO.Text = "I/O     ";
            this.optIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optIO.UseVisualStyleBackColor = true;
            this.optIO.Click += new System.EventHandler(this.optIO_Click);
            // 
            // optMotion
            // 
            this.optMotion.Appearance = System.Windows.Forms.Appearance.Button;
            this.optMotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optMotion.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optMotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optMotion.ImageIndex = 5;
            this.optMotion.ImageList = this.imageList1;
            this.optMotion.Location = new System.Drawing.Point(433, 89);
            this.optMotion.Name = "optMotion";
            this.optMotion.Size = new System.Drawing.Size(136, 55);
            this.optMotion.TabIndex = 8;
            this.optMotion.Text = "Motion";
            this.optMotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optMotion.UseVisualStyleBackColor = true;
            this.optMotion.Click += new System.EventHandler(this.optMotion_Click);
            // 
            // optVision
            // 
            this.optVision.Appearance = System.Windows.Forms.Appearance.Button;
            this.optVision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optVision.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optVision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optVision.ImageIndex = 0;
            this.optVision.ImageList = this.imageList1;
            this.optVision.Location = new System.Drawing.Point(290, 89);
            this.optVision.Name = "optVision";
            this.optVision.Size = new System.Drawing.Size(136, 55);
            this.optVision.TabIndex = 7;
            this.optVision.Text = "Vision";
            this.optVision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optVision.UseVisualStyleBackColor = true;
            this.optVision.Click += new System.EventHandler(this.optVision_Click);
            // 
            // optMain
            // 
            this.optMain.Appearance = System.Windows.Forms.Appearance.Button;
            this.optMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optMain.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optMain.ImageIndex = 2;
            this.optMain.ImageList = this.imageList1;
            this.optMain.Location = new System.Drawing.Point(3, 89);
            this.optMain.Name = "optMain";
            this.optMain.Size = new System.Drawing.Size(136, 55);
            this.optMain.TabIndex = 6;
            this.optMain.Text = "Process";
            this.optMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optMain.UseVisualStyleBackColor = true;
            this.optMain.Click += new System.EventHandler(this.optMain_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(1207, 89);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 55);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ucRecipe1
            // 
            this.ucRecipe1.AutoSize = true;
            this.ucRecipe1.BackColor = System.Drawing.Color.White;
            this.ucRecipe1.Location = new System.Drawing.Point(6, 577);
            this.ucRecipe1.MainForm2 = this;
            this.ucRecipe1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucRecipe1.Motion2 = this.motion1;
            this.ucRecipe1.Name = "ucRecipe1";
            this.ucRecipe1.Size = new System.Drawing.Size(1426, 297);
            this.ucRecipe1.TabIndex = 27;
            this.ucRecipe1.Visible = false;
            // 
            // motion1
            // 
            this.motion1.BackColor = System.Drawing.Color.White;
            this.motion1.Location = new System.Drawing.Point(3, 151);
            this.motion1.MainForm2 = this;
            this.motion1.Name = "motion1";
            this.motion1.Size = new System.Drawing.Size(1911, 881);
            this.motion1.TabIndex = 20;
            this.motion1.Visible = false;
            // 
            // ucRecipe2
            // 
            this.ucRecipe2.BackColor = System.Drawing.Color.White;
            this.ucRecipe2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.ucRecipe2.Location = new System.Drawing.Point(1438, 9);
            this.ucRecipe2.MainForm2 = this;
            this.ucRecipe2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucRecipe2.Name = "ucRecipe2";
            this.ucRecipe2.Recipe2 = this.ucRecipe1;
            this.ucRecipe2.Size = new System.Drawing.Size(467, 867);
            this.ucRecipe2.TabIndex = 18;
            this.ucRecipe2.Visible = false;
            // 
            // titleBar1
            // 
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.MainForm2 = this;
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(1920, 84);
            this.titleBar1.TabIndex = 0;
            // 
            // ucLog1
            // 
            this.ucLog1.BackColor = System.Drawing.Color.White;
            this.ucLog1.Location = new System.Drawing.Point(3, 151);
            this.ucLog1.Name = "ucLog1";
            this.ucLog1.Size = new System.Drawing.Size(1911, 881);
            this.ucLog1.TabIndex = 22;
            this.ucLog1.Visible = false;
            // 
            // test1
            // 
            this.test1.BackColor = System.Drawing.SystemColors.Control;
            this.test1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.test1.Location = new System.Drawing.Point(0, 0);
            this.test1.MainForm2 = this;
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(1920, 84);
            this.test1.TabIndex = 7;
            // 
            // tmSeq
            // 
            this.tmSeq.Tick += new System.EventHandler(this.tmSeq_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1057);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChange_Pass);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.optRecipe);
            this.Controls.Add(this.optLog);
            this.Controls.Add(this.btnMainSetting);
            this.Controls.Add(this.lblMainStatus);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.optIO);
            this.Controls.Add(this.optMotion);
            this.Controls.Add(this.optVision);
            this.Controls.Add(this.optMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.motion1);
            this.Controls.Add(this.ucLog1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTitle.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbMainMotion.ResumeLayout(false);
            this.gbMainMotion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbCam2.ResumeLayout(false);
            this.gbCam2.PerformLayout();
            this.gbCam1.ResumeLayout(false);
            this.gbCam1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optMain;
        private UserControls.TitleBar test1;
        private System.Windows.Forms.RadioButton optIO;
        private System.Windows.Forms.RadioButton optMotion;
        private System.Windows.Forms.RadioButton optVision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.GroupBox gbCam2;
        private Cognex.InSight.Controls.Filmstrip.CvsFilmstrip cvsFilmstrip2;
        private System.Windows.Forms.GroupBox gbCam1;
        private System.Windows.Forms.TextBox txtNGRate1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalCount1;
        private System.Windows.Forms.Label label5;
        private Cognex.InSight.Controls.Filmstrip.CvsFilmstrip cvsFilmstrip1;
        private System.Windows.Forms.Button btnCntReset1;
        private System.Windows.Forms.TextBox txtNGCount1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOKCount1;
        private System.Windows.Forms.GroupBox gbMainMotion;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNGRate2;
        private System.Windows.Forms.TextBox txtTotalCount2;
        private System.Windows.Forms.TextBox txtOKCount2;
        private System.Windows.Forms.TextBox txtNGCount2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCntReset2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblSavePath2;
        private System.Windows.Forms.CheckBox chkGrpSave2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkImageSave2;
        private System.Windows.Forms.Label lblSavePath1;
        private System.Windows.Forms.CheckBox chkGrpSave1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkImageSave1;
        private System.Windows.Forms.Label lblOnlineCam2;
        private System.Windows.Forms.Label lblOnlineCam1;
        private System.Windows.Forms.Timer tmStatus;
        private System.Windows.Forms.Timer tmInitialize_Cam1;
        private System.Windows.Forms.Label lblMainStatus;
        private System.Windows.Forms.Button btnProcessStart;
        private System.Windows.Forms.Button btnMainSetting;
        private System.Windows.Forms.RadioButton optLog;
        private System.Windows.Forms.RadioButton optRecipe;
        private System.Windows.Forms.RichTextBox rtxtDisplay;
        private System.Windows.Forms.Label lblJobName2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblJobName1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnOnline2;
        private System.Windows.Forms.Button btnOnline1;
        private System.Windows.Forms.Timer tmInitialize_Cam2;
        private System.Windows.Forms.ComboBox cbSaveType2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbSaveType1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnLive1;
        private System.Windows.Forms.Button btnManualTrigger1;
        private System.Windows.Forms.Button btnLive2;
        private System.Windows.Forms.Button btnManualTrigger2;
        private System.Windows.Forms.Timer tmSystemStatus;
        private System.Windows.Forms.Button btnOpenSaveFolder_Cam2;
        private System.Windows.Forms.Button btnOpenSaveFolder_Cam1;
        private System.Windows.Forms.Button btnFlimLast2;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Button btnPre2;
        private System.Windows.Forms.Button btnFlimFrist2;
        private System.Windows.Forms.Button btnFlimLast1;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnPre1;
        private System.Windows.Forms.Button btnFlimFrist1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private UserControls.TitleBar titleBar1;
        public Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay2;
        public Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay1;
        public ucMotion motion1;
        private System.Windows.Forms.CheckBox checkBox3;
        private ucRecipe1 ucRecipe1;
        private System.Windows.Forms.Timer tmInitialize_Motion;
        private UserControls.ucLog ucLog1;
        public System.Windows.Forms.Button btnChange_Pass;
        public System.Windows.Forms.Button btnLogout;
        private ucRecipe2 ucRecipe2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSelect_JobName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnLoad_Job;
        public System.Windows.Forms.Button btnHotKey_3;
        public System.Windows.Forms.Button btnHotKey_2;
        public System.Windows.Forms.Button btnHotKey_1;
        public System.Windows.Forms.Button btnHotKey_4;
        private System.Windows.Forms.Timer tmSeq;
    }
}

