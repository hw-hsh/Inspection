using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Haewon.Module;

namespace HFR_Inspection
{
    public partial class frmSetting : Form
    {
        public delegate void SendData(string Message);
        public event SendData sendMessage;

        public delegate void UpdateData(string Update_Parameter, Common.Camera cam);
        public event UpdateData UpdateParameter;

        RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("HFR_Inspection");

        string strCam1, strCam2, strIPCam1, strIPCam2;
        string strMotion;
        string strLog;
        string strRecipe;

        public frmSetting()
        {
            InitializeComponent();

            txtPath_Cam1.Text = regKey.GetValue("PathImageSave_Cam1", "경로를 지정해 주세요.").ToString();
            txtPath_Cam2.Text = regKey.GetValue("PathImageSave_Cam2", "경로를 지정해 주세요.").ToString();
            txtIP_Cam1.Text = regKey.GetValue("Cam1_IP", "192.168.0.0").ToString();
            txtIP_Cam2.Text = regKey.GetValue("Cam2_IP", "192.168.0.0").ToString();
            txtDate_Cam1.Text = regKey.GetValue("Cam1_FolderDelete_day", "120").ToString();
            txtDate_Cam2.Text = regKey.GetValue("Cam2_FolderDelete_day", "120").ToString();
            txtIP_Motion.Text = regKey.GetValue("Motion_IP", "192.168.0.0").ToString();
            txtPath_Log.Text = regKey.GetValue("Log_Path", "경로를 지정해 주세요.").ToString();
            txtPath_Recipe.Text = regKey.GetValue("Recipe_Path", "경로를 지정해 주세요.").ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("적용 하시겠습니까?", "취소", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.OK)
            {
                regKey.SetValue("PathImageSave_Cam1", txtPath_Cam1.Text);
                regKey.SetValue("PathImageSave_Cam2", txtPath_Cam2.Text);
                regKey.SetValue("Cam1_IP", txtIP_Cam1.Text);
                regKey.SetValue("Cam2_IP", txtIP_Cam2.Text);
                regKey.SetValue("Cam1_FolderDelete_day", txtDate_Cam1.Text);
                regKey.SetValue("Cam2_FolderDelete_day", txtDate_Cam2.Text);

                regKey.SetValue("Log_Path", txtPath_Log.Text);

                regKey.SetValue("Motion_IP", txtIP_Motion.Text);

                regKey.SetValue("Recipe_Path", txtPath_Recipe.Text);

                UpdateParameter(txtPath_Cam1.Text, Common.Camera.Cam1);
                UpdateParameter(txtPath_Cam2.Text, Common.Camera.Cam2);

                sendMessage("btnApply_Click : 적용");
            }
            else
            {
                sendMessage("btnApply_Click : 취소");
            }
        }

        string strMatch = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        private void txtIP_Cam1_Leave(object sender, EventArgs e)
        {
            try
            {
                strIPCam1 = txtIP_Cam1.Text;
                Regex regex = new Regex(strMatch);
                if (regex.IsMatch(strIPCam1) == false)
                {
                    MessageBox.Show("IP주소를 재입력 해주세요\r예시 : 192.168.0.20");
                }
                else
                {
                    //regKey.SetValue("Cam1_IP", txtPath_Cam1.Text);
                }
            }
            catch (Exception ex) { }
        }

        private void txtIP_Cam2_Leave(object sender, EventArgs e)
        {
            try
            {
                strIPCam2 = txtIP_Cam2.Text;
                Regex regex = new Regex(strMatch);
                if (regex.IsMatch(strIPCam2) == false)
                {
                    MessageBox.Show("IP주소를 재입력 해주세요\r예시 : 192.168.0.20");
                }
                else
                {
                    //regKey.SetValue("Cam2_IP", txtPath_Cam2.Text);
                }
            }
            catch (Exception ex) { }
        }

        private void txtIP_Motion_Leave(object sender, EventArgs e)
        {
            try
            {
                strIPCam1 = txtIP_Cam1.Text;
                Regex regex = new Regex(strMatch);
                if (regex.IsMatch(strIPCam1) == false)
                {
                    MessageBox.Show("IP주소를 재입력 해주세요\r예시 : 192.168.0.20");
                }
                else
                {
                    //regKey.SetValue("Cam1_IP", txtPath_Cam1.Text);
                }
            }
            catch (Exception ex) { }
        }

        private void txtIP_Motion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                strMotion = txtIP_Motion.Text;
                Regex regex = new Regex(strMatch);
                if (regex.IsMatch(strMotion) == false)
                {
                    MessageBox.Show("IP주소를 재입력 해주세요\r예시 : 192.168.0.20");
                }
                else
                {
                    //regKey.SetValue("Cam1_IP", txtPath_Cam1.Text);
                }
            }
            catch (Exception ex) { }
        }

        private void btnLog_Path_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPath_Log.Text = dialog.SelectedPath + @"\Log";
                    strLog = txtPath_Log.Text;

                    sendMessage("btnLog_Path_Click : 경로지정 - " + txtPath_Log.Text);
                }
            }
            catch (Exception ex)
            {
                sendMessage("btnLog_Path_Click 에러");
            }
        }

        private void btnRecipe_Path_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPath_Recipe.Text = dialog.SelectedPath ;
                    strRecipe = txtPath_Recipe.Text;

                    sendMessage("btnRecipe_Path_Click : 경로지정 - " + txtPath_Recipe.Text);
                }
            }
            catch (Exception ex)
            {
                sendMessage("btnRecipe_Path_Click 에러");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            sendMessage("btnClose_Click : Form Close");
            this.Close();
        }

        private void btnCam1_Path_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPath_Cam1.Text = dialog.SelectedPath + @"\Cam1";
                    strCam1 = txtPath_Cam1.Text;
                    //regKey.SetValue("PathImageSave_Cam1", strCam1.Text);

                    sendMessage("btnCam1_Path_Click : 경로지정 - " + txtPath_Cam1.Text);
                }
            }
            catch (Exception ex)
            {
                sendMessage("btnCam1_Path_Click 에러");
            }
        }

        private void btnCam2_Path_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPath_Cam2.Text = dialog.SelectedPath + @"\Cam2";
                    strCam2 = txtPath_Cam2.Text;
                    //regKey.SetValue("PathImageSave_Cam2", strCam2.Text);

                    sendMessage("btnCam2_Path_Click : 경로지정 - " + txtPath_Cam2.Text);
                }
            }
            catch (Exception ex)
            {
                sendMessage("btnCam2_Path_Click 에러");
            }
        }
    }
}
