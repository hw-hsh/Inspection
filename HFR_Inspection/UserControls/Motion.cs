using System;
using System.Drawing;
using System.Windows.Forms;
using Haewon.Module;
using Microsoft.Win32;

namespace HFR_Inspection
{
    public partial class ucMotion : UserControl
    {
        protected Form MainForm;
        public Form MainForm2
        {
            get { return MainForm; }
            set { MainForm = value; }
        }

        public Haewon.Module.PaixMotion gMotion;
        public Motion_Paix_Function.TnmcX_ALL_STATUS tAllStatus;

        RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("HFR_Inspection");

        short gRet;

        public axis Selected_Axis;

        short nABS_SPD, nRel_SPD, nJog_SPD;
        double dbRel_Dst;

        //Dictionary<axis, short> dicAxis = new Dictionary<axis, short>();

        Label[] lbLbl = new Label[40];
        //string[] lbLbl = new string[40];

        Motion_IO IO_X, IO_Y, IO_T, IO_Z1, IO_Z2;
        Motion_IO Select_Label;

        public bool IsHome_X, IsHome_Y, IsHome_T, IsHome_Z1, IsHome_Z2;

        public ucMotion()
        {
            InitializeComponent();

            gMotion = new Haewon.Module.PaixMotion();
            tAllStatus = new Motion_Paix_Function.TnmcX_ALL_STATUS();

            Axis_Status();

            txtMotion_Ip.Text = regKey.GetValue("Motion_IP", "192.168.0.0").ToString();

            lblStage_Tag.Parent = this.pn_Stage;
            lblStage_Tag.BackColor = Color.Transparent;
            lblStage_Tag.Text = "Stage";
        }

        #region Function

        public enum axis
        {
            X = 0,
            Y,
            T,
            Z1,
            Z2
        }

        public enum OffOn
        {
            Off = 0,
            On
        }

        public short Connect(string ip)
        {
            try
            {
                string[] nIp = new string[4];
                string tmpStr = ip;

                nIp = tmpStr.Split('.');

                gRet = gMotion.Connect(Convert.ToInt16(nIp[3]), Convert.ToInt16(nIp[0]), Convert.ToInt16(nIp[1]), Convert.ToInt16(nIp[2]));

                if (gRet == (short)Motion_Paix_Function.EnmcX_FUNC_RESULT.nmcX_R_OK)
                {
                    gMotion.nDevNo = Convert.ToInt16(nIp[3]);

                    gMotion.GetAllStatus(out tAllStatus);

                    tmrMotionStatus.Start();
                    return gRet;
                }
                else
                {
                    return gRet;
                }
            }
            catch (Exception ex) { return gRet; }
        }

        public short Servo_On(axis Axis, OffOn offon)
        {
            try
            {
                gRet = gMotion.ServoOnOff((short)Axis, (short)offon);
                return gRet;
            }
            catch (Exception ex) { return gRet; }
        }

        public short Alarm_Reset(axis Axis)
        {
            try
            {
                gRet = gMotion.AlarmResetReq((short)Axis);
                return gRet;
            }
            catch (Exception ex) { return gRet; }
        }

        public short SpeedSet(axis Axis, short Profile, double Velocity)
        {
            try
            {
                gRet = gMotion.SpeedSet((short)Axis, 0, Velocity / 2, Velocity * 1.5, Velocity, Velocity * 1.5);
                return gRet;
            }
            catch (Exception ex) { return gRet; }
        }

        public void MoveJog(axis Axis, short dir)
        {
            try
            {
                gMotion.MoveVel((short)Axis, dir); // CCW
            }
            catch (Exception ex) { }
        }

        public short Move_ABS(axis axis, double pos)
        {
            try
            {
                gRet = gMotion.MoveAbs((short)axis, pos);
                return gRet;
            }
            catch (Exception ex) { return gRet; }
        }

        public short Move_Stop(axis axis)
        {
            try
            {
                gRet = gMotion.MoveStop((short)axis, 0);
                return gRet;
            }
            catch (Exception ex) { return gRet; }
        }

        public short Move_Stop_E(axis axis)
        {
            try
            {
                gRet = gMotion.MoveStop((short)axis, 1);
                return gRet;
            }
            catch (Exception ex) { return gRet; }
        }

        public short Move_Rel(axis axis, double pos)
        {
            try
            {
                gRet = gMotion.MoveRel((short)axis, pos);
                return gRet;
            }
            catch (Exception ex) { return gRet; }
        }

        #endregion

        private void btnMotion_Connect_Click(object sender, EventArgs e)
        {
            //string[] nIp = new string[4];
            //string tmpStr = txtMotion_Ip.Text;

            //nIp = tmpStr.Split('.');

            //gMotion.Connect(Convert.ToInt16(nIp[3]), Convert.ToInt16(nIp[0]), Convert.ToInt16(nIp[1]), Convert.ToInt16(nIp[2]));
            gRet = Connect(txtMotion_Ip.Text);

            //if (gRet == 0)
            //    tmrMotionStatus.Start();
        }

        private void btnABS_Move_Click(object sender, EventArgs e)
        {
            try
            {
                double pos = Convert.ToDouble(txtABS_Pos.Text);
                Move_ABS(Selected_Axis, pos);
            }
            catch (Exception ex) { }
        }

        private void btnABS_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                Move_Stop(Selected_Axis);
            }
            catch (Exception ex) { }
        }

        private void btnRelCCW_Click(object sender, EventArgs e)
        {
            try
            {
                double tmpPos = dbRel_Dst * -1;

                Move_Rel(Selected_Axis, tmpPos);
            }
            catch (Exception ex) { }
        }

        private void btnRelCW_Click(object sender, EventArgs e)
        {
            try
            {
                Move_Rel(Selected_Axis, dbRel_Dst);
            }
            catch (Exception ex) { }
        }

        private void btnRelStop_Click(object sender, EventArgs e)
        {
            try
            {
                Move_Stop(Selected_Axis);
            }
            catch (Exception ex) { }
        }

        private void btnJogE_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                Move_Stop_E(Selected_Axis);
            }
            catch (Exception ex) { }
        }

        private void btnJogCCW_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //gMotion.MoveVel(Selected_Axis, 0); // CW
                MoveJog(Selected_Axis, 0);
            }
            catch (Exception ex) { }
        }

        private void btnJogCCW_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Move_Stop(Selected_Axis);
            }
            catch (Exception ex) { }
        }

        private void btnJogCW_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                MoveJog(Selected_Axis, 1);
            }
            catch (Exception ex) { }
        }

        private void btnJogCW_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Move_Stop(Selected_Axis);
            }
            catch (Exception ex) { }
        }

        private void optX_CheckedChanged(object sender, EventArgs e)
        {
            if (optX.Checked == true)
            {
                Selected_Axis = axis.X;
                Select_Label = IO_X;
            }
        }

        private void optY_CheckedChanged(object sender, EventArgs e)
        {
            if (optY.Checked == true)
            {
                Selected_Axis = axis.Y;
                Select_Label = IO_Y;
            }
        }

        private void optT_CheckedChanged(object sender, EventArgs e)
        {
            if (optT.Checked == true)
            {
                Selected_Axis = axis.T;
                Select_Label = IO_T;
            }
        }

        private void optZ1_CheckedChanged(object sender, EventArgs e)
        {
            if (optZ1.Checked == true)
            {
                Selected_Axis = axis.Z1;
                Select_Label = IO_Z1;
            }
        }

        private void optZ2_CheckedChanged(object sender, EventArgs e)
        {
            if (optZ2.Checked == true)
            {
                Selected_Axis = axis.Z2;
                Select_Label = IO_Z2;
            }
        }

        private void optABSSpeed_10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optABSSpeed_10.Checked == true)
                {
                    nABS_SPD = 10;

                    //gRet = gMotion.SpeedSet(nSelected_Axis, 0, 200, 50000, 20000, 50000);
                    gRet = SpeedSet(Selected_Axis, 0, nABS_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void optABSSpeed_5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optABSSpeed_5.Checked == true)
                {
                    nABS_SPD = 5;

                    gRet = SpeedSet(Selected_Axis, 0, nABS_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void optABSSpeed_1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optABSSpeed_1.Checked == true)
                {
                    nABS_SPD = 1;

                    gRet = SpeedSet(Selected_Axis, 0, nABS_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void optABSSpeed_Manual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optABSSpeed_Manual.Checked == true)
                {
                    nABS_SPD = Convert.ToInt16(txtABSSpeed_Manual.Text);

                    gRet = SpeedSet(Selected_Axis, 0, nABS_SPD);
                }
            }
            catch (Exception ex) { MessageBox.Show("숫자만 입력 해주세요.", "안내", MessageBoxButtons.OK); }
        }

        private void txtABSSpeed_Manual_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (optABSSpeed_Manual.Checked == true)
                {
                    nABS_SPD = Convert.ToInt16(txtABSSpeed_Manual.Text);

                    gRet = SpeedSet(Selected_Axis, 0, nABS_SPD);
                }
            }
            catch (Exception ex) { MessageBox.Show("숫자만 입력 해주세요.", "안내", MessageBoxButtons.OK); }
        }

        private void optRelSpeed_10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelSpeed_10.Checked == true)
                {
                    nRel_SPD = 10;
                    gRet = SpeedSet(Selected_Axis, 0, nRel_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void optRelSpeed_5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelSpeed_5.Checked == true)
                {
                    nRel_SPD = 5;
                    gRet = SpeedSet(Selected_Axis, 0, nRel_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void optRelSpeed_1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelSpeed_1.Checked == true)
                {
                    nRel_SPD = 1;
                    gRet = SpeedSet(Selected_Axis, 0, nRel_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelSpeed_Manual.Checked == true)
                {
                    nRel_SPD = Convert.ToInt16(txtRelSpeed_Manual.Text);
                    gRet = SpeedSet(Selected_Axis, 0, nRel_SPD);
                }
            }
            catch (Exception ex) { MessageBox.Show("숫자만 입력 해주세요.", "안내", MessageBoxButtons.OK); }
        }

        private void txtRelSpeed_Manual_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelSpeed_Manual.Checked == true)
                {
                    nRel_SPD = Convert.ToInt16(txtRelSpeed_Manual.Text);
                    gRet = SpeedSet(Selected_Axis, 0, nRel_SPD);
                }
            }
            catch (Exception ex) { MessageBox.Show("숫자만 입력 해주세요.", "안내", MessageBoxButtons.OK); }
        }

        private void optRelDistance_10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelDistance_10.Checked == true)
                {
                    dbRel_Dst = 10;
                }
            }
            catch (Exception ex) { }
        }

        private void optRelDistance_5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelDistance_5.Checked == true)
                {
                    dbRel_Dst = 5;
                }
            }
            catch (Exception ex) { }
        }

        private void optRelDistance_1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelDistance_1.Checked == true)
                {
                    dbRel_Dst = 1;
                }
            }
            catch (Exception ex) { }
        }

        private void optRelDistance_Manual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelDistance_Manual.Checked == true)
                {
                    dbRel_Dst = Convert.ToDouble(txtRelDistance_Manual.Text);
                }
            }
            catch (Exception ex) { MessageBox.Show("숫자만 입력 해주세요.", "안내", MessageBoxButtons.OK); }
        }

        private void txtRelDistance_Manual_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelDistance_Manual.Checked == true)
                {
                    dbRel_Dst = Convert.ToDouble(txtRelDistance_Manual.Text);
                }
            }
            catch (Exception ex) { MessageBox.Show("숫자만 입력 해주세요.", "안내", MessageBoxButtons.OK); }
        }

        private void optJogSpeed_10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optJogSpeed_10.Checked == true)
                {
                    nJog_SPD = 10;
                    gRet = SpeedSet(Selected_Axis, 0, nJog_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void optJogSpeed_5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optJogSpeed_5.Checked == true)
                {
                    nJog_SPD = 5;
                    gRet = SpeedSet(Selected_Axis, 0, nJog_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void optJogSpeed_1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optJogSpeed_1.Checked == true)
                {
                    nJog_SPD = 1;
                    gRet = SpeedSet(Selected_Axis, 0, nJog_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void optJogSpeed_Manual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optJogSpeed_Manual.Checked == true)
                {
                    nJog_SPD = Convert.ToInt16(txtJogSpeed_Manual.Text);
                    gRet = SpeedSet(Selected_Axis, 0, nJog_SPD);
                }
            }
            catch (Exception ex) { MessageBox.Show("숫자만 입력 해주세요.", "안내", MessageBoxButtons.OK); }
        }

        private void txtJogSpeed_Manual_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (optJogSpeed_Manual.Checked == true)
                {
                    nJog_SPD = Convert.ToInt16(txtJogSpeed_Manual.Text);
                    gRet = SpeedSet(Selected_Axis, 0, nJog_SPD);
                }
            }
            catch (Exception ex) { MessageBox.Show("숫자만 입력 해주세요.", "안내", MessageBoxButtons.OK); }
        }

        private void btnServoOn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Select_Label.Servo_On.Text == "OFF")
                    Servo_On(Selected_Axis, OffOn.On);
                else
                    Servo_On(Selected_Axis, OffOn.Off);

            }
            catch (Exception ex) { }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("원점 복귀를 실행 하시겠습니까?", "주의", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    Home(Selected_Axis);
                }
            }
            catch (Exception ex) { }
        }

        public void Home(axis axAxis)
        {
            try
            {
                short nAxis = Convert.ToInt16(axAxis);
                gRet = gMotion.HomeSpeedSet(nAxis, 5000, 2000, 500, 500);

                gRet = gMotion.Homing(nAxis, 0, 1, 0, 1, 1, 10, 0);
            }
            catch (Exception ex) { MessageBox.Show(gRet.ToString(), "Error", MessageBoxButtons.OK); }
        }

        public void Home_Cancel(axis axAxis)
        {
            try
            {
                short nAxis = Convert.ToInt16(axAxis);
                gRet = gMotion.HomeCancel(nAxis);
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gRet = gMotion.PingCheck(regKey.GetValue("Motion_IP", "192.168.0.0").ToString());
            Motion_Paix_Function.EnmcX_FUNC_RESULT test = 0;
            test = (Motion_Paix_Function.EnmcX_FUNC_RESULT)gRet;
            textBox1.Text = test.ToString();
        }

        private void btnAlarmReset_Click(object sender, EventArgs e)
        {
            try
            {
                Alarm_Reset(Selected_Axis);
            }
            catch (Exception ex) { }
        }

        private void tmrMotionStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                gMotion.GetAllStatus(out tAllStatus);

                txtCMD_POS.Text = tAllStatus.tServo[(short)Selected_Axis].dCMDPos.ToString();
                txtENC_POS.Text = tAllStatus.tServo[(short)Selected_Axis].dENCPos.ToString();
                txtENC_SPD.Text = tAllStatus.tServo[(short)Selected_Axis].dENCSpeed.ToString();
                txtTRQ.Text = tAllStatus.tServo[(short)Selected_Axis].dTorque.ToString();

                txtPos_X.Text = tAllStatus.tServo[(short)axis.X].dENCPos.ToString();
                txtPos_Y.Text = tAllStatus.tServo[(short)axis.Y].dENCPos.ToString();
                txtPos_T.Text = tAllStatus.tServo[(short)axis.T].dENCPos.ToString();
                txtPos_Z1.Text = tAllStatus.tServo[(short)axis.Z1].dENCPos.ToString();
                txtPos_Z2.Text = tAllStatus.tServo[(short)axis.Z2].dENCPos.ToString();

                IO_Change(IO_X.Servo_On, tAllStatus.tServo[(short)axis.X].nServoOn);
                IO_Change(IO_X.Busy, tAllStatus.tServo[(short)axis.X].nBusy);
                IO_Change(IO_X.InPos, tAllStatus.tServo[(short)axis.X].nINP);
                IO_Change(IO_X.Alarm, tAllStatus.tServo[(short)axis.X].nAlarm);
                IO_Change(IO_X.Home, tAllStatus.tServo[(short)axis.X].nHome);
                IO_Change(IO_X.N_Limit, tAllStatus.tServo[(short)axis.X].nLimitM);
                IO_Change(IO_X.P_Limit, tAllStatus.tServo[(short)axis.X].nLimitP);
                IO_Change(IO_X.Torq_Limit, tAllStatus.tServo[(short)axis.X].nT_Limit);
                if (tAllStatus.tServo[(short)axis.X].nHomeStatus == 1)
                    IsHome_X = true;
                else
                    IsHome_X = false;

                IO_Change(IO_Y.Servo_On, tAllStatus.tServo[(short)axis.Y].nServoOn);
                IO_Change(IO_Y.Busy, tAllStatus.tServo[(short)axis.Y].nBusy);
                IO_Change(IO_Y.InPos, tAllStatus.tServo[(short)axis.Y].nINP);
                IO_Change(IO_Y.Alarm, tAllStatus.tServo[(short)axis.Y].nAlarm);
                IO_Change(IO_Y.Home, tAllStatus.tServo[(short)axis.Y].nHome);
                IO_Change(IO_Y.N_Limit, tAllStatus.tServo[(short)axis.Y].nLimitM);
                IO_Change(IO_Y.P_Limit, tAllStatus.tServo[(short)axis.Y].nLimitP);
                IO_Change(IO_Y.Torq_Limit, tAllStatus.tServo[(short)axis.Y].nT_Limit);
                if (tAllStatus.tServo[(short)axis.Y].nHomeStatus == 1)
                    IsHome_Y = true;
                else
                    IsHome_Y = false;

                IO_Change(IO_T.Servo_On, tAllStatus.tServo[(short)axis.T].nServoOn);
                IO_Change(IO_T.Busy, tAllStatus.tServo[(short)axis.T].nBusy);
                IO_Change(IO_T.InPos, tAllStatus.tServo[(short)axis.T].nINP);
                IO_Change(IO_T.Alarm, tAllStatus.tServo[(short)axis.T].nAlarm);
                IO_Change(IO_T.Home, tAllStatus.tServo[(short)axis.T].nHome);
                IO_Change(IO_T.N_Limit, tAllStatus.tServo[(short)axis.T].nLimitM);
                IO_Change(IO_T.P_Limit, tAllStatus.tServo[(short)axis.T].nLimitP);
                IO_Change(IO_T.Torq_Limit, tAllStatus.tServo[(short)axis.T].nT_Limit);
                if (tAllStatus.tServo[(short)axis.T].nHomeStatus == 1)
                    IsHome_T = true;
                else
                    IsHome_T = false;

                IO_Change(IO_Z1.Servo_On, tAllStatus.tServo[(short)axis.Z1].nServoOn);
                IO_Change(IO_Z1.Busy, tAllStatus.tServo[(short)axis.Z1].nBusy);
                IO_Change(IO_Z1.InPos, tAllStatus.tServo[(short)axis.Z1].nINP);
                IO_Change(IO_Z1.Alarm, tAllStatus.tServo[(short)axis.Z1].nAlarm);
                IO_Change(IO_Z1.Home, tAllStatus.tServo[(short)axis.Z1].nHome);
                IO_Change(IO_Z1.N_Limit, tAllStatus.tServo[(short)axis.Z1].nLimitM);
                IO_Change(IO_Z1.P_Limit, tAllStatus.tServo[(short)axis.Z1].nLimitP);
                IO_Change(IO_Z1.Torq_Limit, tAllStatus.tServo[(short)axis.Z1].nT_Limit);
                if (tAllStatus.tServo[(short)axis.Z1].nHomeStatus == 1)
                    IsHome_Z1 = true;
                else
                    IsHome_Z1 = false;

                IO_Change(IO_Z2.Servo_On, tAllStatus.tServo[(short)axis.Z2].nServoOn);
                IO_Change(IO_Z2.Busy, tAllStatus.tServo[(short)axis.Z2].nBusy);
                IO_Change(IO_Z2.InPos, tAllStatus.tServo[(short)axis.Z2].nINP);
                IO_Change(IO_Z2.Alarm, tAllStatus.tServo[(short)axis.Z2].nAlarm);
                IO_Change(IO_Z2.Home, tAllStatus.tServo[(short)axis.Z2].nHome);
                IO_Change(IO_Z2.N_Limit, tAllStatus.tServo[(short)axis.Z2].nLimitM);
                IO_Change(IO_Z2.P_Limit, tAllStatus.tServo[(short)axis.Z2].nLimitP);
                IO_Change(IO_Z2.Torq_Limit, tAllStatus.tServo[(short)axis.Z2].nT_Limit);
                if (tAllStatus.tServo[(short)axis.Z2].nHomeStatus == 1)
                    IsHome_Z2 = true;
                else
                    IsHome_Z2 = false;
            }
            catch (Exception ex) { }
        }

        private void IO_Change(Label lbl, short status)
        {
            try
            {
                if (status == 1)
                {
                    lbl.BackColor = Color.Lime;
                    lbl.Text = "ON";
                }
                else
                {
                    lbl.BackColor = Color.Crimson;
                    lbl.Text = "OFF";
                }
            }
            catch (Exception ex) { }
        }

        public struct Motion_IO
        {
            public Label Servo_On;
            public Label Busy;
            public Label InPos;
            public Label Alarm;
            public Label Home;
            public Label N_Limit;
            public Label P_Limit;
            public Label Torq_Limit;
        }

        private void Add_Label(Label axis, string index, bool type)
        {
            try
            {
                string strLabel = axis.Name;
                if (type == true)
                {
                    switch (strLabel.Substring(10, 1))
                    {
                        case "X":
                            switch (index)
                            {
                                case "0":
                                    IO_X.Servo_On = axis;
                                    break;
                                case "1":
                                    IO_X.Busy = axis;
                                    break;
                                case "2":
                                    IO_X.InPos = axis;
                                    break;
                                case "3":
                                    IO_X.Alarm = axis;
                                    break;
                                case "4":
                                    IO_X.Home = axis;
                                    break;
                                case "5":
                                    IO_X.N_Limit = axis;
                                    break;
                                case "6":
                                    IO_X.P_Limit = axis;
                                    break;
                                case "7":
                                    IO_X.Torq_Limit = axis;
                                    break;
                            }
                            break;
                        case "Y":
                            switch (index)
                            {
                                case "0":
                                    IO_Y.Servo_On = axis;
                                    break;
                                case "1":
                                    IO_Y.Busy = axis;
                                    break;
                                case "2":
                                    IO_Y.InPos = axis;
                                    break;
                                case "3":
                                    IO_Y.Alarm = axis;
                                    break;
                                case "4":
                                    IO_Y.Home = axis;
                                    break;
                                case "5":
                                    IO_Y.N_Limit = axis;
                                    break;
                                case "6":
                                    IO_Y.P_Limit = axis;
                                    break;
                                case "7":
                                    IO_Y.Torq_Limit = axis;
                                    break;
                            }
                            break;
                        case "T":
                            switch (index)
                            {
                                case "0":
                                    IO_T.Servo_On = axis;
                                    break;
                                case "1":
                                    IO_T.Busy = axis;
                                    break;
                                case "2":
                                    IO_T.InPos = axis;
                                    break;
                                case "3":
                                    IO_T.Alarm = axis;
                                    break;
                                case "4":
                                    IO_T.Home = axis;
                                    break;
                                case "5":
                                    IO_T.N_Limit = axis;
                                    break;
                                case "6":
                                    IO_T.P_Limit = axis;
                                    break;
                                case "7":
                                    IO_T.Torq_Limit = axis;
                                    break;
                            }
                            break;
                    }
                }
                else
                {
                    switch (strLabel.Substring(10, 2))
                    {
                        case "Z1":
                            switch (index)
                            {
                                case "0":
                                    IO_Z1.Servo_On = axis;
                                    break;
                                case "1":
                                    IO_Z1.Busy = axis;
                                    break;
                                case "2":
                                    IO_Z1.InPos = axis;
                                    break;
                                case "3":
                                    IO_Z1.Alarm = axis;
                                    break;
                                case "4":
                                    IO_Z1.Home = axis;
                                    break;
                                case "5":
                                    IO_Z1.N_Limit = axis;
                                    break;
                                case "6":
                                    IO_Z1.P_Limit = axis;
                                    break;
                                case "7":
                                    IO_Z1.Torq_Limit = axis;
                                    break;
                            }
                            break;

                        case "Z2":
                            switch (index)
                            {
                                case "0":
                                    IO_Z2.Servo_On = axis;
                                    break;
                                case "1":
                                    IO_Z2.Busy = axis;
                                    break;
                                case "2":
                                    IO_Z2.InPos = axis;
                                    break;
                                case "3":
                                    IO_Z2.Alarm = axis;
                                    break;
                                case "4":
                                    IO_Z2.Home = axis;
                                    break;
                                case "5":
                                    IO_Z2.N_Limit = axis;
                                    break;
                                case "6":
                                    IO_Z2.P_Limit = axis;
                                    break;
                                case "7":
                                    IO_Z2.Torq_Limit = axis;
                                    break;
                            }
                            break;
                    }
                }
            }
            catch (Exception ex) { }
        }

        //private void Axis_Status(axis Axis)
        //{
        private void Axis_Status()
        {
            //Label[] labels = new Label[8];
            string strLbl = "lblInput";
            int i = 0;

            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control gb in item.Controls)
                    {
                        if (gb is GroupBox)
                        {
                            foreach (Control gb2 in gb.Controls)
                            {
                                if (gb2 is GroupBox)
                                {
                                    //foreach (Control gb3 in gb2.Controls)
                                    //{
                                    //    if (gb3 is GroupBox)
                                    //    {
                                    foreach (Control lbl in gb2.Controls)
                                    {
                                        if (lbl is Label)
                                        {
                                            if (lbl.Name.Length > 8)
                                            {
                                                if (lbl.Name.Substring(0, 8) == strLbl)
                                                {
                                                    lbLbl[i] = (Label)lbl;
                                                    //lbLbl[i] = lbl.Name;

                                                    if (lbLbl[i].Name.Length == 11)
                                                    {
                                                        Add_Label(lbLbl[i], lbLbl[i].Name.Substring(8, 1), true);
                                                    }
                                                    else
                                                    {
                                                        Add_Label(lbLbl[i], lbLbl[i].Name.Substring(8, 1), false);
                                                    }

                                                    i++;
                                                }
                                            }
                                        }
                                    }
                                    //}
                                    //}
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
