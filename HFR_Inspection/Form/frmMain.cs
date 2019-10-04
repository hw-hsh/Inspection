using Cognex.InSight.Controls.Display;
using log4net.Config;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Haewon.Module;
using static Haewon.Module.Common;
using Cognex.InSight.Controls.Filmstrip;
using Cognex.InSight;

namespace HFR_Inspection
{
    public partial class frmMain : Form
    {
        frmSetting frmSubSetting;
        frmInitialize frmInit;

        //static RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("HFR_Inspection");
        static RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("HFR_Inspection");

        //private Cognex.InSight.Net.CvsNetworkMonitor oNetworkMonitor1;
        //private Cognex.InSight.Net.CvsNetworkMonitor oNetworkMonitor2;

        public HFR_Inspection.etc.L4Logger logger_Sys = new etc.L4Logger(regKey.GetValue("Log_Path", "경로를 지정해 주세요.").ToString() + @"\System", "system");
        public HFR_Inspection.etc.L4Logger logger_Ins = new etc.L4Logger(regKey.GetValue("Log_Path", "경로를 지정해 주세요.").ToString() + @"\Inspection", "inspection");

        Vision_Cognex clsVision_Cam1 = new Vision_Cognex();
        Vision_Cognex clsVision_Cam2 = new Vision_Cognex();

        public Haewon.Module.PaixMotion gMotion;
        short nRet = 0;

        bool bInit_Cam1 = false;
        bool bInit_Cam2 = false;
        public static bool bInit_Motion = false;
        public bool bInit_IO = false;

        public bool Islogin = false;

        //bool bOnline_Cam1 = false;
        //bool bOnline_Cam2 = false;
        bool bTimeout1, bTimeout2;

        public string strPass;

        string strRecipe_Name;
        string strRecipe_Path;

        DateTime dtStartTime;

        DateTime dtProcessTime1;
        DateTime dtProcessTime2;

        TimeSpan ts;

        Point pgbMain;

        int nCount_OK_Cam1, nCount_NG_Cam1, nCount_Total_Cam1;
        int nCount_OK_Cam2, nCount_NG_Cam2, nCount_Total_Cam2;
        double dbNGRate_Cam1, dbNGRate_Cam2;

        DateTime dtSystemStatus_Start_Day, dtSystemStatus_End_Day;

        //string PlaybackFolder1 = Application.StartupPath + @"\playbackfolder1";
        //string PlaybackFolder2 = Application.StartupPath + @"\playbackfolder2";

        //string PlaybackFolder1;
        //string PlaybackFolder2;

        public frmMain()
        {
            //Cognex.InSight.CvsInSightSoftwareDevelopmentKit.Initialize();

            InitializeComponent();

            //this.WindowState = FormWindowState.Maximized;

            //XmlConfigurator.Configure(new FileInfo("log4net.xml"));

            pgbMain.X = 4;
            pgbMain.Y = 150;
            gbMain.Location = pgbMain;

            gMotion = motion1.gMotion;

            //oNetworkMonitor1 = new Cognex.InSight.Net.CvsNetworkMonitor();

            clsVision_Cam1.oInsight = cvsInSightDisplay1.InSight;
            cvsInSightDisplay1.ConnectCompleted += CvsInSightDisplay1_ConnectCompleted;
            cvsInSightDisplay1.ResultsChanged += CvsInSightDisplay1_ResultsChanged;
            clsVision_Cam1.oNetworkMonitor = new Cognex.InSight.Net.CvsNetworkMonitor();
            clsVision_Cam1.oNativeModeClient = new Cognex.InSight.NativeMode.CvsNativeModeClient();
            clsVision_Cam1.oNativeModeClient.ConnectCompleted += ONativeModeClient_ConnectCompleted;
            //oNetworkMonitor2 = new Cognex.InSight.Net.CvsNetworkMonitor();

            clsVision_Cam2.oInsight = cvsInSightDisplay2.InSight;
            cvsInSightDisplay2.ConnectCompleted += CvsInSightDisplay2_ConnectCompleted;
            cvsInSightDisplay2.ResultsChanged += CvsInSightDisplay2_ResultsChanged;
            clsVision_Cam2.oNetworkMonitor = new Cognex.InSight.Net.CvsNetworkMonitor();
            clsVision_Cam2.oNativeModeClient = new Cognex.InSight.NativeMode.CvsNativeModeClient();
            clsVision_Cam2.oNativeModeClient.ConnectCompleted += ONativeModeClient_ConnectCompleted1;

            //tmStatus.Start();

            cvsFilmstrip1.ShowSummary = true;
            cvsFilmstrip2.ShowSummary = true;

            lblSavePath1.Text = regKey.GetValue("PathImageSave_Cam1", "경로를 지정해 주세요.").ToString();
            lblSavePath2.Text = regKey.GetValue("PathImageSave_Cam2", "경로를 지정해 주세요.").ToString();

            //check_DDate(regKey.GetValue("PathImageSave_Cam1", "경로를 지정해 주세요.").ToString() + @"\images");
            check_DDate(regKey.GetValue("PathImageSave_Cam1", "경로를 지정해 주세요.").ToString(), "Cam1_FolderDelete_day");
            check_DDate(regKey.GetValue("PathImageSave_Cam2", "경로를 지정해 주세요.").ToString(), "Cam2_FolderDelete_day");

            if (regKey.GetValue("Enable_SaveImage_Cam1", "경로를 지정해 주세요.").ToString() == "true")
                chkImageSave1.Checked = true;
            if (regKey.GetValue("Enable_SaveGraphic_Cam1", "경로를 지정해 주세요.").ToString() == "true")
                chkGrpSave1.Checked = true;
            if (regKey.GetValue("Enable_SaveImage_Cam2", "경로를 지정해 주세요.").ToString() == "true")
                chkImageSave2.Checked = true;
            if (regKey.GetValue("Enable_SaveGraphic_Cam2", "경로를 지정해 주세요.").ToString() == "true")
                chkGrpSave2.Checked = true;

            if (!Directory.Exists(lblSavePath1.Text))
                Directory.CreateDirectory(lblSavePath1.Text);

            if (!Directory.Exists(lblSavePath2.Text))
                Directory.CreateDirectory(lblSavePath2.Text);

            //플레이백 폴더는 PC에 저장된 이미지 
            cvsInSightDisplay1.Recorder.RecordFolder = lblSavePath1.Text;
            cvsInSightDisplay1.Recorder.PlaybackFolder = lblSavePath1.Text;

            cvsInSightDisplay2.Recorder.RecordFolder = lblSavePath2.Text;
            cvsInSightDisplay2.Recorder.PlaybackFolder = lblSavePath2.Text;

            clsVision_Cam1.oFilmstrip = new CvsFilmstripResultsQueue(cvsFilmstrip1);
            clsVision_Cam1.oFilmstripPlayback = new CvsFilmstripPlayback(cvsFilmstrip1);

            clsVision_Cam2.oFilmstrip = new CvsFilmstripResultsQueue(cvsFilmstrip2);
            clsVision_Cam2.oFilmstripPlayback = new CvsFilmstripPlayback(cvsFilmstrip2);

            Insight1 = cvsInSightDisplay1.InSight;
            Insight2 = cvsInSightDisplay2.InSight;

            //clsVision_Cam1.oFilmstrip.InSight = clsVision_Cam1.oInsight;

            //clsVision_Cam1.oFilmstrip.Settings.Mode = CvsFilmstripResultsQueueMode.All;
            //clsVision_Cam1.oFilmstrip.Settings.QueueSize = 20;
            //clsVision_Cam1.oFilmstrip.Settings.ClearOnline = false;
            //clsVision_Cam1.oFilmstrip.Settings.Type = CvsFilmstripResultsQueueType.Last;

            //clsVision_Cam2.oFilmstrip.InSight = clsVision_Cam2.oInsight;

            //clsVision_Cam2.oFilmstrip.Settings.Mode = CvsFilmstripResultsQueueMode.All;
            //clsVision_Cam2.oFilmstrip.Settings.QueueSize = 20;
            //clsVision_Cam2.oFilmstrip.Settings.ClearOnline = false;
            //clsVision_Cam2.oFilmstrip.Settings.Type = CvsFilmstripResultsQueueType.Last;

            strPass = regKey.GetValue("Password", "0000").ToString();

            cbSaveType1.SelectedIndex = Convert.ToInt16(regKey.GetValue("ImageSaveType_Cam1", "0"));
            cbSaveType2.SelectedIndex = Convert.ToInt16(regKey.GetValue("ImageSaveType_Cam2", "0"));

            dtSystemStatus_Start_Day = DateTime.Now;

            optMain.Checked = true;

            Update_HotKey();
        }

        private void ONativeModeClient_ConnectCompleted1(object sender, CvsConnectCompletedEventArgs e)
        {

        }

        private void ONativeModeClient_ConnectCompleted(object sender, CvsConnectCompletedEventArgs e)
        {

        }

        private CvsInSight Insight1
        {
            get { return clsVision_Cam1.oInsight; }
            set
            {
                clsVision_Cam1.oInsight = value;
                if (clsVision_Cam1.oInsight != null)
                {

                    // ResultsQueue operations are supported by the CvsInSight object.
                    clsVision_Cam1.oFilmstrip.InSight = clsVision_Cam1.oInsight;

                    // Initializes the ResultsQueue Settings.
                    clsVision_Cam1.oFilmstrip.Settings.Mode = CvsFilmstripResultsQueueMode.All;
                    clsVision_Cam1.oFilmstrip.Settings.QueueSize = 20;
                    clsVision_Cam1.oFilmstrip.Settings.ClearOnline = false;
                    clsVision_Cam1.oFilmstrip.Settings.Type = CvsFilmstripResultsQueueType.Last;
                }
            }
        }

        private CvsInSight Insight2
        {
            get { return clsVision_Cam2.oInsight; }
            set
            {
                clsVision_Cam2.oInsight = value;
                if (clsVision_Cam2.oInsight != null)
                {

                    // ResultsQueue operations are supported by the CvsInSight object.
                    clsVision_Cam2.oFilmstrip.InSight = clsVision_Cam2.oInsight;

                    // Initializes the ResultsQueue Settings.
                    clsVision_Cam2.oFilmstrip.Settings.Mode = CvsFilmstripResultsQueueMode.All;
                    clsVision_Cam2.oFilmstrip.Settings.QueueSize = 20;
                    clsVision_Cam2.oFilmstrip.Settings.ClearOnline = false;
                    clsVision_Cam2.oFilmstrip.Settings.Type = CvsFilmstripResultsQueueType.Last;
                }
            }
        }

        #region Function

        public void Update_HotKey()
        {
            try
            {
                btnHotKey_1.Text = regKey.GetValue("HotKey_A", "-").ToString();
                btnHotKey_2.Text = regKey.GetValue("HotKey_B", "-").ToString();
                btnHotKey_3.Text = regKey.GetValue("HotKey_C", "-").ToString();
                btnHotKey_4.Text = regKey.GetValue("HotKey_D", "-").ToString();
            }
            catch (Exception ex) { }
        }

        private void ConnectAsync(Cognex.InSight.NativeMode.CvsNativeModeClient Insight, string addr, string username, string password)
        {
            try
            {
                Insight.ConnectAsynchronous(addr, username, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveImage(Vision_Cognex vision, CvsInSightDisplay insight, CheckBox image, CheckBox graphic, string path)
        {
            try
            {
                string dt = string.Format("{0:00}{1:00}{2:00}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                string date = string.Format("{0:00}{1:00}{2:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                if (image.Checked == true && graphic.Checked == false)
                {
                    string sDirPath;
                    sDirPath = path + @"\images" + date;
                    DirectoryInfo di = new DirectoryInfo(sDirPath);
                    if (di.Exists == false)
                    {
                        di.Create();
                    }

                    vision.oImage = insight.Results.Image;
                    vision.oImage.Save(sDirPath + @"\" + dt + ".bmp");
                }
                else if (image.Checked == true && graphic.Checked == true)
                {
                    string sDirPath;
                    sDirPath = path + @"\images" + date;
                    DirectoryInfo di = new DirectoryInfo(sDirPath);
                    if (di.Exists == false)
                    {
                        di.Create();
                    }

                    vision.oImage = insight.Results.Image;
                    vision.oImage.Save(sDirPath + @"\" + dt + ".bmp");

                    sDirPath = path + @"\images" + date + @"\Graphic";
                    di = new DirectoryInfo(sDirPath);
                    if (di.Exists == false)
                    {
                        di.Create();
                    }

                    insight.SaveBitmap(sDirPath + @"\" + dt + ".bmp");
                }
            }
            catch (Exception ex) { }
        }

        private void SaveImage(Vision_Cognex vision, CvsInSightDisplay insight, CheckBox image, CheckBox graphic, string path, OK_NG result)
        {
            try
            {
                string dt = string.Format("{0:00}{1:00}{2:00}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                string date = string.Format("{0:00}{1:00}{2:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                switch (result)
                {
                    case OK_NG.OK:
                        if (image.Checked == true && graphic.Checked == false)
                        {
                            string sDirPath;
                            sDirPath = path + @"\images" + date + @"OK";
                            DirectoryInfo di = new DirectoryInfo(sDirPath);
                            if (di.Exists == false)
                            {
                                di.Create();
                            }

                            vision.oImage = insight.Results.Image;
                            vision.oImage.Save(sDirPath + @"\" + dt + ".bmp");
                            break;
                        }
                        else if (image.Checked == true && graphic.Checked == true)
                        {
                            string sDirPath;
                            sDirPath = path + @"\images" + date + @"OK";
                            DirectoryInfo di = new DirectoryInfo(sDirPath);
                            if (di.Exists == false)
                            {
                                di.Create();
                            }

                            vision.oImage = insight.Results.Image;
                            vision.oImage.Save(sDirPath + @"\" + dt + ".bmp");

                            sDirPath = path + @"\images" + date + @"OK" + @"\Graphic";
                            di = new DirectoryInfo(sDirPath);
                            if (di.Exists == false)
                            {
                                di.Create();
                            }

                            insight.SaveBitmap(sDirPath + @"\" + dt + ".bmp");
                            break;
                        }
                        break;

                    case OK_NG.NG:

                        if (image.Checked == true && graphic.Checked == false)
                        {
                            string sDirPath;
                            sDirPath = path + @"\images" + date + @"NG";
                            DirectoryInfo di = new DirectoryInfo(sDirPath);
                            if (di.Exists == false)
                            {
                                di.Create();
                            }

                            vision.oImage = insight.Results.Image;
                            vision.oImage.Save(sDirPath + @"\" + dt + ".bmp");
                            break;
                        }
                        else if (image.Checked == true && graphic.Checked == true)
                        {
                            string sDirPath;
                            sDirPath = path + @"\images" + date + @"NG";
                            DirectoryInfo di = new DirectoryInfo(sDirPath);
                            if (di.Exists == false)
                            {
                                di.Create();
                            }

                            vision.oImage = insight.Results.Image;
                            vision.oImage.Save(sDirPath + @"\" + dt + ".bmp");

                            sDirPath = path + @"\images" + date + @"NG" + @"\Graphic";
                            di = new DirectoryInfo(sDirPath);
                            if (di.Exists == false)
                            {
                                di.Create();
                            }

                            insight.SaveBitmap(sDirPath + @"\" + dt + ".bmp");
                            break;
                        }
                        break;

                    default:
                        if (image.Checked == true && graphic.Checked == false)
                        {
                            string sDirPath;
                            sDirPath = path + @"\images" + date;
                            DirectoryInfo di = new DirectoryInfo(sDirPath);
                            if (di.Exists == false)
                            {
                                di.Create();
                            }

                            vision.oImage = insight.Results.Image;
                            vision.oImage.Save(sDirPath + @"\" + dt + ".bmp");
                            break;
                        }
                        else if (image.Checked == true && graphic.Checked == true)
                        {
                            string sDirPath;
                            sDirPath = path + @"\images" + date;
                            DirectoryInfo di = new DirectoryInfo(sDirPath);
                            if (di.Exists == false)
                            {
                                di.Create();
                            }

                            vision.oImage = insight.Results.Image;
                            vision.oImage.Save(sDirPath + @"\" + dt + ".bmp");

                            sDirPath = path + @"\images" + date + @"\Graphic";
                            di = new DirectoryInfo(sDirPath);
                            if (di.Exists == false)
                            {
                                di.Create();
                            }

                            insight.SaveBitmap(sDirPath + @"\" + dt + ".bmp");
                            break;
                        }
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void Appand_Count(int OK_NG, TextBox txt)
        {
            try
            {
                int current_Count = Convert.ToInt32(txt.Text);
                txt.Text = (current_Count + 1).ToString();
                txtTotalCount1.Text = (Convert.ToInt64(txtOKCount1.Text) + Convert.ToInt64(txtNGCount1.Text)).ToString();
                txtTotalCount2.Text = (Convert.ToInt64(txtOKCount2.Text) + Convert.ToInt64(txtNGCount2.Text)).ToString();

                txtNGRate1.Text = (Convert.ToDouble(txtNGCount1.Text) / Convert.ToDouble(txtOKCount1.Text)).ToString("P3");
                txtNGRate2.Text = (Convert.ToInt64(txtNGCount2.Text) / Convert.ToInt64(txtOKCount2.Text)).ToString("p3");
            }
            catch (Exception ex) { }
        }

        private void check_DDate(string path, string registry)
        {
            try
            {
                int nDDay = Convert.ToInt16(regKey.GetValue(registry, "120"));
                string strPath = path;

                DateTime Dday = DateTime.Parse(DateTime.Now.ToShortDateString());
                DateTime Today;
                TimeSpan tsCount;
                int nCount = 0;

                if (Directory.Exists(strPath))
                {
                    DirectoryInfo di = new DirectoryInfo(strPath);
                    foreach (var item in di.GetDirectories())
                    {
                        Today = DateTime.Parse(item.CreationTime.ToShortDateString());
                        tsCount = Dday - Today;
                        nCount = tsCount.Days;
                        if (nCount >= nDDay)
                        {
                            item.Delete(true);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        public void UpdateLog_Sys(string message)
        {
            try
            {
                logger_Sys.Write(message);
            }
            catch (Exception ex)
            {
                logger_Sys.Write_Warn("UpdateLog 내부 에러 " + message);
            }
        }

        public void UpdateLog_Ins(string message)
        {
            try
            {
                logger_Ins.Write(message);
            }
            catch (Exception ex)
            {
                logger_Ins.Write_Warn("UpdateLog 내부 에러 " + message);
            }
        }

        public void UpdateLog_Warn_Sys(string message)
        {
            try
            {
                logger_Sys.Write_Warn(message);
            }
            catch (Exception ex)
            {
                logger_Sys.Write_Warn("UpdateLog_Warn 내부 에러 " + message);
            }
        }

        private void UpdateInit(int value, string message)
        {
            try
            {
                frmInit.pgbInit.Value = frmInit.pgbInit.Value + value;
                frmInit.lblCompletionRate.Text = String.Format("{0}%", frmInit.pgbInit.Value.ToString());
                frmInit.rtxtInit.AppendText(message);
                frmInit.rtxtInit.ScrollToCaret();
            }
            catch (Exception ex) { }
        }

        private int Connection_InSight(CvsInSightDisplay insight, string ip)
        {
            try
            {
                if (!(insight.Connected))
                {
                    insight.Connect(ip, "admin", "", false);
                    //btnConnect.Enabled = false;
                }
                else
                {
                    insight.Disconnect();
                }
                Refresh();

                return 0;
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        private void FrmSubSetting_UpdateParameter(string Update_Parameter, Camera cam)
        {
            try
            {
                if (cam == Camera.Cam1)
                {
                    lblSavePath1.Text = Update_Parameter;
                }
                else if (cam == Camera.Cam2)
                {
                    lblSavePath2.Text = Update_Parameter;
                }
            }
            catch (Exception ex) { }
        }

        private void Login()
        {
            frmPassword frmPass = new frmPassword
            {
                form = this,
                StartPosition = FormStartPosition.CenterParent
            };
            frmPass.ShowDialog();
        }

        private void Change_Password()
        {
            frmChangPass frmChangePassword = new frmChangPass
            {
                form = this,
                StartPosition = FormStartPosition.CenterParent
            };
            frmChangePassword.ShowDialog();
        }

        private void MenuVisible(Display_Menu display)
        {
            try
            {
                switch (display)
                {
                    case Display_Menu.Process:
                        optMain.BackColor = Color.Gray;
                        optRecipe.BackColor = Color.White;
                        optVision.BackColor = Color.White;
                        optMotion.BackColor = Color.White;
                        optIO.BackColor = Color.White;
                        optLog.BackColor = Color.White;

                        gbMain.Visible = true;
                        gbMainMotion.Visible = true;
                        gbCam1.Visible = true;
                        gbCam2.Visible = true;
                        motion1.Visible = false;
                        ucRecipe1.Visible = false;
                        ucRecipe2.Visible = false;
                        ucLog1.Visible = false;
                        break;

                    case Display_Menu.Recipe:
                        optMain.BackColor = Color.White;
                        optRecipe.BackColor = Color.Gray;
                        optVision.BackColor = Color.White;
                        optMotion.BackColor = Color.White;
                        optIO.BackColor = Color.White;
                        optLog.BackColor = Color.White;

                        gbMain.Visible = true;
                        gbMainMotion.Visible = false;
                        gbCam1.Visible = false;
                        gbCam2.Visible = false;
                        motion1.Visible = false;
                        ucRecipe1.Visible = true;
                        ucRecipe2.Visible = true;
                        ucLog1.Visible = false;
                        break;

                    case Display_Menu.Vision:
                        optMain.BackColor = Color.White;
                        optRecipe.BackColor = Color.White;
                        optVision.BackColor = Color.Gray;
                        optMotion.BackColor = Color.White;
                        optIO.BackColor = Color.White;
                        optLog.BackColor = Color.White;

                        gbMain.Visible = true;
                        gbMainMotion.Visible = false;
                        gbCam1.Visible = false;
                        gbCam2.Visible = false;
                        motion1.Visible = false;
                        ucRecipe1.Visible = false;
                        ucRecipe2.Visible = false;
                        ucLog1.Visible = false;
                        break;

                    case Display_Menu.Motion:
                        optMain.BackColor = Color.White;
                        optRecipe.BackColor = Color.White;
                        optVision.BackColor = Color.White;
                        optMotion.BackColor = Color.Gray;
                        optIO.BackColor = Color.White;
                        optLog.BackColor = Color.White;

                        gbMain.Visible = false;
                        gbMainMotion.Visible = false;
                        gbCam1.Visible = false;
                        gbCam2.Visible = false;
                        motion1.Visible = true;
                        ucRecipe1.Visible = false;
                        ucRecipe2.Visible = false;
                        ucLog1.Visible = false;
                        break;

                    case Display_Menu.IO:
                        optMain.BackColor = Color.White;
                        optRecipe.BackColor = Color.White;
                        optVision.BackColor = Color.White;
                        optMotion.BackColor = Color.White;
                        optIO.BackColor = Color.Gray;
                        optLog.BackColor = Color.White;

                        gbMain.Visible = false;
                        gbMainMotion.Visible = false;
                        gbCam1.Visible = false;
                        gbCam2.Visible = false;
                        motion1.Visible = false;
                        ucRecipe1.Visible = false;
                        ucRecipe2.Visible = false;
                        ucLog1.Visible = false;
                        break;

                    case Display_Menu.Log:
                        optMain.BackColor = Color.White;
                        optRecipe.BackColor = Color.White;
                        optVision.BackColor = Color.White;
                        optMotion.BackColor = Color.White;
                        optIO.BackColor = Color.White;
                        optLog.BackColor = Color.Gray;

                        gbMain.Visible = false;
                        gbMainMotion.Visible = false;
                        gbCam1.Visible = false;
                        gbCam2.Visible = false;
                        motion1.Visible = false;
                        ucRecipe1.Visible = false;
                        ucRecipe2.Visible = false;
                        ucLog1.Visible = true;
                        break;
                }
            }
            catch (Exception ex) { }
        }

        #endregion

        #region Timer

        private void tmStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                if (cvsInSightDisplay1.Connected)
                {
                    if (cvsInSightDisplay1.Edit.SoftOnline.Activated)
                    {
                        lblOnlineCam1.Text = "Online";
                        lblOnlineCam1.BackColor = Color.Lime;

                    }
                    else
                    {
                        lblOnlineCam1.Text = "Offline";
                        lblOnlineCam1.BackColor = Color.Gray;

                    }
                }

                if (clsVision_Cam1.oNativeModeClient.Connected == true)
                {
                    string strJobname = clsVision_Cam1.oNativeModeClient.SendCommand("GF");
                    string[] strAs;
                    strAs = strJobname.Split('\r');

                    strAs = strAs[2].Split('<');
                    strAs = strAs[1].Split('>');

                    strJobname = strAs[1].ToString();

                    lblJobName1.Text = strJobname;
                }

                else
                {
                    lblOnlineCam1.Text = "Offline";
                    lblOnlineCam1.BackColor = Color.Gray;
                }
                if (cvsInSightDisplay2.Connected)
                {
                    if (cvsInSightDisplay2.Edit.SoftOnline.Activated)
                    {
                        lblOnlineCam2.Text = "Online";
                        lblOnlineCam2.BackColor = Color.Lime;
                    }
                    else
                    {
                        lblOnlineCam2.Text = "Offline";
                        lblOnlineCam2.BackColor = Color.Gray;
                    }
                }
                else
                {
                    lblOnlineCam2.Text = "Offline";
                    lblOnlineCam2.BackColor = Color.Gray;
                }

                if (clsVision_Cam2.oNativeModeClient.Connected == true)
                {
                    string strJobname = clsVision_Cam2.oNativeModeClient.SendCommand("GF");
                    string[] strAs;
                    strAs = strJobname.Split('\r');

                    strAs = strAs[2].Split('<');
                    strAs = strAs[1].Split('>');

                    strJobname = strAs[1].ToString();

                    lblJobName2.Text = strJobname;
                }
            }
            catch (Exception ex) { }
        }


        #region Initialize
        private void tmInitialize_Tick(object sender, EventArgs e)
        {
            try
            {
                int nStep = Convert.ToInt16(regKey.GetValue("Initialize_Step_Cam1", 0));

                switch (nStep)
                {
                    case 0:
                        //nStep = Convert.ToInt16(regKey.GetValue("Initialize_Step", 0));
                        if (cvsInSightDisplay1.Connected == false)
                        {
                            dtStartTime = DateTime.Now;
                            if (Connection_InSight(cvsInSightDisplay1, regKey.GetValue("Cam1_IP", "0.0.0.0").ToString()) == 0)
                            {
                                UpdateInit(7, "카메라 1번 초기화 중.\r");
                                regKey.SetValue("Initialize_Step_Cam1", "1");
                            }
                            else
                            {
                                UpdateInit(7, "카메라 1번 초기화 실패.\r");
                            }
                        }
                        else
                        {
                            UpdateInit(7, "카메라 1번 초기화 중.\r");
                            regKey.SetValue("Initialize_Step_Cam1", "1");
                        }
                        break;

                    case 1:
                        if (cvsInSightDisplay1.Connected == true)
                        {
                            UpdateInit(7, "카메라 1번 초기화 완료.\r");

                            //cvsInSightDisplay1.ShowGrid = false;
                            //cvsInSightDisplay1.ShowCustomView = true;
                            cvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;
                            bInit_Cam1 = true;
                            tmInitialize_Cam1.Stop();
                            break;
                        }
                        else
                        {
                            ts = DateTime.Now - dtStartTime;

                            if (bTimeout1 == false)
                            {
                                if (ts.Seconds >= 10)
                                {
                                    bTimeout1 = true;
                                    UpdateInit(7, "카메라 1번 초기화 실패.\r");
                                    tmInitialize_Cam1.Stop();
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void tmInitialize_Cam2_Tick(object sender, EventArgs e)
        {
            try
            {
                int nStep = Convert.ToInt16(regKey.GetValue("Initialize_Step_Cam2", 0));

                switch (nStep)
                {
                    case 0:
                        //nStep = Convert.ToInt16(regKey.GetValue("Initialize_Step", 0));
                        if (cvsInSightDisplay2.Connected == false)
                        {
                            dtStartTime = DateTime.Now;
                            if (Connection_InSight(cvsInSightDisplay2, regKey.GetValue("Cam2_IP", "0.0.0.0").ToString()) == 0)
                            {
                                UpdateInit(7, "카메라 2번 초기화 중.\r");
                                regKey.SetValue("Initialize_Step_Cam2", "1");
                            }
                            else
                            {
                                UpdateInit(7, "카메라 2번 초기화 실패.\r");
                            }
                        }
                        else
                        {
                            UpdateInit(7, "카메라 2번 초기화 중.\r");
                            regKey.SetValue("Initialize_Step_Cam2", "1");
                        }
                        break;

                    case 1:
                        if (cvsInSightDisplay2.Connected == true)
                        {
                            UpdateInit(7, "카메라 2번 초기화 완료.\r");

                            //cvsInSightDisplay1.ShowGrid = false;
                            //cvsInSightDisplay1.ShowCustomView = true;
                            cvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;
                            bInit_Cam2 = true;
                            tmInitialize_Cam2.Stop();
                            break;
                        }
                        else
                        {
                            ts = DateTime.Now - dtStartTime;

                            if (bTimeout2 == false)
                            {
                                if (ts.Seconds >= 10)
                                {
                                    bTimeout2 = true;
                                    UpdateInit(7, "카메라 2번 초기화 실패.\r");
                                    tmInitialize_Cam2.Stop();
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void tmInitialize_Motion_Tick(object sender, EventArgs e)
        {
            try
            {
                int nStep = Convert.ToInt16(regKey.GetValue("Initialize_Step_Motion", 0));

                switch (nStep)
                {
                    case 0:
                        nRet = gMotion.PingCheck(regKey.GetValue("Motion_IP", "192.168.0.0").ToString());

                        if (nRet != 0)
                        {
                            UpdateInit(3, string.Format("{0}\r", (Motion_Paix_Function.EnmcX_FUNC_RESULT)nRet));
                            regKey.SetValue("Initialize_Step_Motion", "1");
                            break;
                        }

                        UpdateInit(3, "Motion Controller 정상 응답 확인.\r");
                        regKey.SetValue("Initialize_Step_Motion", "2");

                        break;

                    case 1:
                        UpdateInit(3, "Motion Controller 초기화 실패.\r");
                        tmInitialize_Motion.Stop();
                        break;

                    case 2:
                        nRet = motion1.Connect(regKey.GetValue("Motion_IP", "192.168.0.0").ToString());

                        if (nRet != 0)
                        {
                            UpdateInit(3, string.Format("{0}\r", (Motion_Paix_Function.EnmcX_FUNC_RESULT)nRet));
                            regKey.SetValue("Initialize_Step_Motion", "1");
                            break;
                        }

                        bInit_Motion = true;
                        UpdateInit(3, "Motion Controller 연결 완료.\r");
                        regKey.SetValue("Initialize_Step_Motion", "3");

                        break;

                    case 3:
                        if (motion1.tAllStatus.tServoSIDList.nCount != 3)
                        {
                            break;
                        }

                        //nRet = motion1.Servo_On(ucMotion.axis.X, ucMotion.OffOn.On);
                        //if (nRet != 0)
                        //{
                        //    UpdateInit(1, string.Format("{0}\r", (Motion_Paix_Function.EnmcX_FUNC_RESULT)nRet));
                        //    UpdateInit(0, "Motion Controller X축 서보 점검.\r");
                        //}

                        nRet = motion1.Servo_On(ucMotion.axis.Y, ucMotion.OffOn.On);
                        if (nRet != 0)
                        {
                            UpdateInit(3, string.Format("{0}\r", (Motion_Paix_Function.EnmcX_FUNC_RESULT)nRet));
                            UpdateInit(0, "Motion Controller Y축 서보 점검.\r");
                        }

                        motion1.Home_Cancel(ucMotion.axis.X);
                        motion1.Home_Cancel(ucMotion.axis.Y);
                        motion1.Home_Cancel(ucMotion.axis.T);
                        motion1.Home_Cancel(ucMotion.axis.Z1);
                        motion1.Home_Cancel(ucMotion.axis.Z2);

                        regKey.SetValue("Initialize_Step_Motion", "4");
                        break;

                    case 4:
                        //if (motion1.tAllStatus.tServo[(short)ucMotion.axis.X].nBusy != 1 && 
                        //    motion1.tAllStatus.tServo[(short)ucMotion.axis.X].nHomeStatus == 0)
                        //{
                        //    motion1.Home(ucMotion.axis.X);
                        //    UpdateInit(1, "X 축 원점 검색.\r");
                        //}
                        //else if (motion1.IsHome_X == false)
                        //{
                        //    if (motion1.IsHome_X == true)
                        //    {
                        //        UpdateInit(1, "X 축 원점 검색 완료.\r");
                        //    }
                        //}

                        if (motion1.tAllStatus.tServo[(short)ucMotion.axis.Y].nBusy != 1 &&
                            motion1.tAllStatus.tServo[(short)ucMotion.axis.Y].nHomeStatus != 1 &&
                            motion1.IsHome_Y == false)
                        {
                            motion1.Home(ucMotion.axis.Y);
                            UpdateInit(3, "Y 축 원점 검색.\r");
                        }
                        else
                        {
                            if (motion1.IsHome_Y == true && motion1.tAllStatus.tServo[(short)ucMotion.axis.Y].nHomeStatus == 1)
                            {
                                UpdateInit(3, "Y 축 원점 검색 완료.\r");
                            }
                        }

                        //if (motion1.IsHome_X && motion1.IsHome_Y)
                        if (motion1.IsHome_Y)
                        {
                            tmInitialize_Motion.Stop();
                            //frmInit.Close();
                        }
                        break;
                }
            }
            catch (Exception ex) { }
        }

        #endregion

        private void tmSystemStatus_Tick(object sender, EventArgs e)
        {
            dtSystemStatus_End_Day = DateTime.Now;

            if (dtSystemStatus_Start_Day.Day != dtSystemStatus_End_Day.Day)
            {
                check_DDate(regKey.GetValue("PathImageSave_Cam1", "경로를 지정해 주세요.").ToString(), "Cam1_FolderDelete_day");
                check_DDate(regKey.GetValue("PathImageSave_Cam2", "경로를 지정해 주세요.").ToString(), "Cam2_FolderDelete_day");
            }
            dtSystemStatus_Start_Day = dtSystemStatus_End_Day;
        }

        #endregion

        #region Event

        private void CvsInSightDisplay1_ResultsChanged(object sender, EventArgs e)
        {
            try
            {
                if (cvsInSightDisplay1.Connected == true)
                {
                    switch (cvsInSightDisplay1.Results.StatusLevel)
                    {
                        case Cognex.InSight.CvsStatusLevel.Pass:
                            Appand_Count(nCount_OK_Cam1, txtOKCount1);
                            break;

                        case Cognex.InSight.CvsStatusLevel.Fail:
                            Appand_Count(nCount_NG_Cam1, txtNGCount1);
                            break;
                    }

                    switch (cbSaveType1.SelectedItem.ToString())
                    {
                        case "OK":
                            if (cvsInSightDisplay1.Results.StatusLevel == Cognex.InSight.CvsStatusLevel.Pass)
                            {
                                SaveImage(clsVision_Cam1, cvsInSightDisplay1, chkImageSave1, chkGrpSave1, lblSavePath1.Text, OK_NG.OK);
                            }
                            break;

                        case "NG":
                            if (cvsInSightDisplay1.Results.StatusLevel == Cognex.InSight.CvsStatusLevel.Fail)
                            {
                                SaveImage(clsVision_Cam1, cvsInSightDisplay1, chkImageSave1, chkGrpSave1, lblSavePath1.Text, OK_NG.NG);
                            }
                            break;

                        case "ALL":
                            SaveImage(clsVision_Cam1, cvsInSightDisplay1, chkImageSave1, chkGrpSave1, lblSavePath1.Text);
                            break;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void CvsInSightDisplay2_ResultsChanged(object sender, EventArgs e)
        {
            try
            {
                if (cvsInSightDisplay2.Connected == true)
                {
                    switch (cvsInSightDisplay2.Results.StatusLevel)
                    {
                        case Cognex.InSight.CvsStatusLevel.Pass:
                            Appand_Count(nCount_OK_Cam2, txtOKCount2);
                            break;

                        case Cognex.InSight.CvsStatusLevel.Fail:
                            Appand_Count(nCount_NG_Cam2, txtNGCount2);
                            break;
                    }
                    switch (cbSaveType2.SelectedItem.ToString())
                    {
                        case "OK":
                            if (cvsInSightDisplay2.Results.StatusLevel == Cognex.InSight.CvsStatusLevel.Pass)
                            {
                                SaveImage(clsVision_Cam2, cvsInSightDisplay2, chkImageSave2, chkGrpSave2, lblSavePath2.Text, OK_NG.OK);
                                Appand_Count(nCount_OK_Cam2, txtOKCount2);
                            }
                            break;

                        case "NG":
                            if (cvsInSightDisplay2.Results.StatusLevel == Cognex.InSight.CvsStatusLevel.Fail)
                            {
                                SaveImage(clsVision_Cam2, cvsInSightDisplay2, chkImageSave2, chkGrpSave2, lblSavePath2.Text, OK_NG.NG);
                                Appand_Count(nCount_NG_Cam2, txtNGCount2);
                            }
                            break;

                        case "ALL":
                            SaveImage(clsVision_Cam2, cvsInSightDisplay2, chkImageSave2, chkGrpSave2, lblSavePath2.Text);
                            break;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void CvsInSightDisplay2_ConnectCompleted(object sender, Cognex.InSight.CvsConnectCompletedEventArgs e)
        {
            try
            {
                if (tmStatus.Enabled == false)
                    tmStatus.Start();

                ConnectAsync(clsVision_Cam2.oNativeModeClient, regKey.GetValue("Cam2_IP", "0.0.0.0").ToString(), "admin", "");

                if (cvsInSightDisplay2.Edit.SoftOnline.Activated == false)
                {
                    btnManualTrigger2.Enabled = true;
                    btnLive2.Enabled = true;
                }
                else
                {
                    btnManualTrigger2.Enabled = false;
                    btnLive2.Enabled = false;
                }

                cvsFilmstrip2.FilmQueue = clsVision_Cam2.oFilmstrip;
            }
            catch (Exception ex) { }
        }

        private void CvsInSightDisplay1_ConnectCompleted(object sender, Cognex.InSight.CvsConnectCompletedEventArgs e)
        {
            try
            {
                if (tmStatus.Enabled == false)
                    tmStatus.Start();

                ConnectAsync(clsVision_Cam1.oNativeModeClient, regKey.GetValue("Cam1_IP", "0.0.0.0").ToString(), "admin", "");

                if (cvsInSightDisplay1.Edit.SoftOnline.Activated == false)
                {
                    btnManualTrigger1.Enabled = true;
                    btnLive1.Enabled = true;
                }
                else
                {
                    //btnManualTrigger1.Enabled = false;
                    btnManualTrigger1.Enabled = true;
                    btnLive1.Enabled = false;
                }

                cvsFilmstrip1.FilmQueue = clsVision_Cam1.oFilmstrip;
            }
            catch (Exception ex) { }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateLog_Sys("프로그램 실행");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateLog_Sys("프로그램 종료");
        }

        private void cvsInSightDisplay1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //toolStripStatusLabel1.Text = "Cam1 - 픽셀 " + string.Format("{0}, {1}", e.X, e.Y);
                if (cvsInSightDisplay1.Connected == true)
                {
                    toolStripStatusLabel1.Text = cvsInSightDisplay1.StatusInformation;
                }
            }
            catch (Exception ex) { }
        }

        private void cvsInSightDisplay1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Status";
        }

        private void cvsInSightDisplay2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //toolStripStatusLabel1.Text = "Cam2 - 픽셀 " + string.Format("{0}, {1}", e.X, e.Y);
                if (cvsInSightDisplay2.Connected == true)
                {
                    toolStripStatusLabel1.Text = cvsInSightDisplay2.StatusInformation;
                }
            }
            catch (Exception ex) { }
        }

        private void cvsInSightDisplay2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Status";
        }

        private void chkImageSave1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkImageSave1.Checked == true)
                {
                    regKey.SetValue("Enable_SaveImage_Cam1", "true");
                    UpdateLog_Sys("chkImageSave1_CheckedChanged : true");
                }
                else
                {
                    regKey.SetValue("Enable_SaveImage_Cam1", "false");
                    UpdateLog_Sys("chkImageSave1_CheckedChanged : false");
                }
            }
            catch (Exception ex) { }
        }

        private void chkGrpSave1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkGrpSave1.Checked == true)
                {
                    regKey.SetValue("Enable_SaveGraphic_Cam1", "true");
                    UpdateLog_Sys("chkGrpSave1_CheckedChanged : true");
                }
                else
                {
                    regKey.SetValue("Enable_SaveGraphic_Cam1", "false");
                    UpdateLog_Sys("chkGrpSave1_CheckedChanged : false");
                }
            }
            catch (Exception ex) { }
        }

        private void chkImageSave2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkGrpSave1.Checked == true)
                {
                    regKey.SetValue("Enable_SaveImage_Cam2", "true");
                    UpdateLog_Sys("chkImageSave2_CheckedChanged : true");
                }
                else
                {
                    regKey.SetValue("Enable_SaveImage_Cam2", "false");
                    UpdateLog_Sys("chkImageSave2_CheckedChanged : false");
                }
            }
            catch (Exception ex) { }
        }

        private void chkGrpSave2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkGrpSave1.Checked == true)
                {
                    regKey.SetValue("Enable_SaveGraphic_Cam2", "true");
                    UpdateLog_Sys("chkGrpSave2_CheckedChanged : true");
                }
                else
                {
                    regKey.SetValue("Enable_SaveGraphic_Cam2", "false");
                    UpdateLog_Sys("chkGrpSave2_CheckedChanged : false");
                }
            }
            catch (Exception ex) { }
        }

        private void btnCntReset1_Click(object sender, EventArgs e)
        {
            try
            {
                txtNGRate1.Text = "0";
                txtNGCount1.Text = "0";
                txtOKCount1.Text = "0";
                txtTotalCount1.Text = "0";
                UpdateLog_Sys("btnCntReset1_Click : Cam1 카운트 리셋");
            }
            catch (Exception ex) { }

        }

        private void btnCntReset2_Click(object sender, EventArgs e)
        {
            try
            {
                txtNGRate2.Text = "0";
                txtNGCount2.Text = "0";
                txtOKCount2.Text = "0";
                txtTotalCount2.Text = "0";
                UpdateLog_Sys("btnCntReset2_Click : Cam2 카운트 리셋");
            }
            catch (Exception ex) { }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("초기화 하시겠습니까?", "취소", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.OK)
                {
                    frmInit = new frmInitialize();

                    lblMainStatus.Text = "초기화 중";
                    bTimeout1 = false;
                    bTimeout2 = false;

                    regKey.SetValue("Initialize_Step_Cam1", "0");
                    regKey.SetValue("Initialize_Step_Cam2", "0");
                    regKey.SetValue("Initialize_Step_Motion", "0");

                    frmInit.pgbInit.Value = 0;
                    frmInit.rtxtInit.Clear();

                    tmInitialize_Cam2.Start();
                    tmInitialize_Cam1.Start();
                    tmInitialize_Motion.Start();

                    frmInit.ShowDialog();

                    UpdateLog_Sys("btnInit_Click : 초기화");
                }
                else
                {
                    UpdateLog_Sys("btnInit_Click : 취소");
                }
            }
            catch (Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateLog_Sys("Form Load \"Setting\" ");
                frmSubSetting = new frmSetting();
                frmSubSetting.sendMessage += new frmSetting.SendData(UpdateLog_Sys);
                frmSubSetting.UpdateParameter += FrmSubSetting_UpdateParameter;
                frmSubSetting.ShowDialog();
            }
            catch (Exception ex) { }
        }

        private void optVision_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optVision.Checked == true)
                {
                    if (Islogin == false)
                        Login();

                    if (Islogin == true)
                        MenuVisible(Display_Menu.Vision);
                }
            }
            catch (Exception ex) { }
        }

        private void optMotion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optMotion.Checked == true)
                {
                    if (Islogin == false)
                        Login();

                    if (Islogin == true)
                        MenuVisible(Display_Menu.Motion);
                }
            }
            catch (Exception ex) { }
        }

        private void optIO_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optIO.Checked == true)
                {
                    if (Islogin == false)
                        Login();

                    if (Islogin == true)
                        MenuVisible(Display_Menu.IO);
                }
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateLog_Ins("테스트테스트");
                if (bInit_Cam1 == true && bInit_Cam2 == true)
                {

                }
                else
                {
                    MessageBox.Show("초기화 되지 않았습니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void optRecipe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRecipe.Checked == true)
                {
                    if (Islogin == false)
                        Login();

                    if (Islogin == true)
                        MenuVisible(Display_Menu.Recipe);
                }
            }
            catch (Exception ex) { }
        }

        private void optMain_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MenuVisible(Display_Menu.Process);
            }
            catch (Exception ex)
            {

            }
        }

        private void optLog_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optLog.Checked == true)
                {
                    if (Islogin == false)
                        Login();

                    if (Islogin == true)
                        MenuVisible(Display_Menu.Log);
                }
            }
            catch (Exception ex) { }
        }

        private void btnOnline1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("온라인/오프라인 으로 전환 변경하시겠습니까?", "주의", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    if (cvsInSightDisplay1.Edit.SoftOnline.Activated == false)
                    {
                        cvsInSightDisplay1.SoftOnline = true;
                        //btnManualTrigger1.Enabled = false;
                        btnManualTrigger1.Enabled = true;
                        btnLive1.Enabled = false;
                    }
                    else
                    {
                        cvsInSightDisplay1.SoftOnline = false;
                        btnManualTrigger1.Enabled = true;
                        btnLive1.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnMaualTrigger1_Click(object sender, EventArgs e)
        {
            try
            {
                cvsInSightDisplay1.InSight.ManualAcquire();
            }
            catch (Exception ex) { }
        }

        private void cbSaveType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                regKey.SetValue("ImageSaveType_Cam1", cbSaveType1.SelectedIndex);
            }
            catch (Exception ex) { }
        }

        private void cvsInSightDisplay1_InSightChanged(object sender, EventArgs e)
        {
            try
            {
                //clsVision_Cam1.oFilmstripPlayback.Recorder = cvsInSightDisplay1.Recorder;
            }
            catch (Exception ex) { }
        }

        private void cvsInSightDisplay2_InSightChanged(object sender, EventArgs e)
        {
            try
            {
                //clsVision_Cam2.oFilmstripPlayback.Recorder = cvsInSightDisplay2.Recorder;
            }
            catch (Exception ex) { }
        }

        private void btnFlimFrist1_Click(object sender, EventArgs e)
        {
            try
            {
                clsVision_Cam1.oFilmstrip.SelectFirst.Execute();
            }
            catch (Exception ex) { }
        }

        private void btnPre1_Click(object sender, EventArgs e)
        {
            try
            {
                clsVision_Cam1.oFilmstrip.SelectPrevPage.Execute();
            }
            catch (Exception ex) { }
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            try
            {
                clsVision_Cam1.oFilmstrip.SelectNextPage.Execute();
            }
            catch (Exception ex) { }
        }

        private void btnFlimLast1_Click(object sender, EventArgs e)
        {
            try
            {
                clsVision_Cam1.oFilmstrip.SelectLast.Execute();
            }
            catch (Exception ex) { }
        }

        private void btnFlimFrist2_Click(object sender, EventArgs e)
        {
            try
            {
                clsVision_Cam2.oFilmstrip.SelectFirst.Execute();
            }
            catch (Exception ex) { }
        }

        private void btnPre2_Click(object sender, EventArgs e)
        {
            try
            {
                clsVision_Cam2.oFilmstrip.SelectPrevPage.Execute();
            }
            catch (Exception ex) { }
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            try
            {
                clsVision_Cam2.oFilmstrip.SelectNextPage.Execute();
            }
            catch (Exception ex) { }
        }

        private void btnFlimLast2_Click(object sender, EventArgs e)
        {
            try
            {
                clsVision_Cam2.oFilmstrip.SelectLast.Execute();
            }
            catch (Exception ex) { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cvsInSightDisplay1.ShowGrid = false;
            }
            else
            {
                cvsInSightDisplay1.ShowGrid = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                //cvsInSightDisplay1.ShowGrid = false;
            }
            else
            {
                cvsFilmstrip1.FilmQueue = clsVision_Cam1.oFilmstrip;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        private void btnChange_Pass_Click(object sender, EventArgs e)
        {
            try
            {
                Change_Password();
            }
            catch (Exception ex) { }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("로그아웃 하시겠습니까?", "주의", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    Islogin = false;
                    btnChange_Pass.Visible = false;
                    btnLogout.Visible = false;

                    optMain_CheckedChanged(sender, e);
                }
            }
            catch (Exception ex) { }
        }

        private void btnHotKey_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("작업을 변경 하시겠습니까?", "물음", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtSelect_JobName.Text = regKey.GetValue("HotKey_A", "-").ToString();
                    strRecipe_Path = regKey.GetValue("Recipe_Path", "-").ToString() + "\\" + regKey.GetValue("HotKey_A", "-").ToString()+".hwr";
                }
            }
            catch (Exception ex) { }
        }

        private void btnHotKey_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("작업을 변경 하시겠습니까?", "물음", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtSelect_JobName.Text = regKey.GetValue("HotKey_B", "-").ToString();
                    strRecipe_Path = regKey.GetValue("Recipe_Path", "-").ToString() + "\\" + regKey.GetValue("HotKey_B", "-").ToString() + ".hwr";
                }
            }
            catch (Exception ex) { }
        }

        private void btnHotKey_3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("작업을 변경 하시겠습니까?", "물음", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtSelect_JobName.Text = regKey.GetValue("HotKey_C", "-").ToString();
                    strRecipe_Path = regKey.GetValue("Recipe_Path", "-").ToString() + "\\" + regKey.GetValue("HotKey_C", "-").ToString() + ".hwr";
                }
            }
            catch (Exception ex) { }
        }

        private void btnHotKey_4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("작업을 변경 하시겠습니까?", "물음", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtSelect_JobName.Text = regKey.GetValue("HotKey_D", "-").ToString();
                    strRecipe_Path = regKey.GetValue("Recipe_Path", "-").ToString() + "\\" + regKey.GetValue("HotKey_D", "-").ToString() + ".hwr";
                }
            }
            catch (Exception ex) { }
        }

        private void btnLoad_Job_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opFile = new OpenFileDialog();

                opFile.InitialDirectory = regKey.GetValue("Recipe_Path", "-").ToString();
                opFile.DefaultExt = "hwr";
                opFile.FileName = "*.hwr";
                opFile.Filter = "레시피 파일 (*.hwr)|*.hwr|모든 파일 (*.*)|*.*";

                if (opFile.ShowDialog() == DialogResult.OK)
                {
                    if (MessageBox.Show("작업을 변경 하시겠습니까?", "물음", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        StreamReader rd = new StreamReader(opFile.FileName);

                        strRecipe_Name = Path.GetFileNameWithoutExtension(opFile.FileName);
                        strRecipe_Path = opFile.FileName;

                        txtSelect_JobName.Text = strRecipe_Name;

                        rd.Close();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void cbSaveType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                regKey.SetValue("ImageSaveType_Cam2", cbSaveType2.SelectedIndex);
            }
            catch (Exception ex) { }
        }

        private void btnOpenSaveFolder_Cam1_Click(object sender, EventArgs e)
        {
            try
            {
                string sDirPath;
                sDirPath = lblSavePath1.Text;
                DirectoryInfo di = new DirectoryInfo(sDirPath);
                if (di.Exists == false)
                {
                    di.Create();
                }

                System.Diagnostics.Process.Start(sDirPath);
            }
            catch (Exception ex) { }
        }

        private void btnOpenSaveFolder_Cam2_Click(object sender, EventArgs e)
        {
            try
            {
                string sDirPath;
                sDirPath = lblSavePath2.Text;
                DirectoryInfo di = new DirectoryInfo(sDirPath);
                if (di.Exists == false)
                {
                    di.Create();
                }
                System.Diagnostics.Process.Start(sDirPath);
            }
            catch (Exception ex) { }
        }

        private void btnLive1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cvsInSightDisplay1.InSight.LiveAcquisition == false)
                    cvsInSightDisplay1.InSight.LiveAcquisition = true;
                else
                    cvsInSightDisplay1.InSight.LiveAcquisition = false;
            }
            catch (Exception ex) { }
        }

        private void btnManualTrigger2_Click(object sender, EventArgs e)
        {
            try
            {
                cvsInSightDisplay2.InSight.ManualAcquire();
                dtProcessTime2 = DateTime.Parse(DateTime.Now.ToShortTimeString());
            }
            catch (Exception ex) { }
        }

        private void btnLive2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cvsInSightDisplay2.InSight.LiveAcquisition == false)
                    cvsInSightDisplay2.InSight.LiveAcquisition = true;
                else
                    cvsInSightDisplay2.InSight.LiveAcquisition = false;
            }
            catch (Exception ex) { }
        }

        private void btnOnline2_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("온라인/오프라인 으로 전환 변경하시겠습니까?", "주의", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    if (cvsInSightDisplay2.Edit.SoftOnline.Activated == false)
                    {
                        cvsInSightDisplay2.SoftOnline = true;
                        btnManualTrigger2.Enabled = false;
                        btnLive2.Enabled = false;
                    }
                    else
                    {
                        cvsInSightDisplay2.SoftOnline = false;
                        btnManualTrigger2.Enabled = true;
                        btnLive2.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { }
        }

        #endregion
    }
}
