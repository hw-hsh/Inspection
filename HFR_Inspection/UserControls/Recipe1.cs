using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFR_Inspection
{
    public partial class ucRecipe1 : UserControl
    {
        protected Form MainForm;
        public Form MainForm2
        {
            get { return MainForm; }
            set { MainForm = value; }
        }

        protected ucMotion Motion;
        public ucMotion Motion2
        {
            get { return Motion; }
            set { Motion = value; }
        }

        double dbRel_Dst;
        short nRel_SPD, nJog_SPD;

        //public Haewon.Module.PaixMotion gMotion;

        public ucRecipe1()
        {
            InitializeComponent();

            //gMotion = Motion2.gMotion;
        }

        private void optX_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optX.Checked == true)
                    Motion.Selected_Axis = ucMotion.axis.X;
            }
            catch (Exception ex) { }
        }

        private void optY_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optY.Checked == true)
                    Motion.Selected_Axis = ucMotion.axis.Y;
            }
            catch (Exception ex) { }

        }

        private void optT_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optT.Checked == true)
                    Motion.Selected_Axis = ucMotion.axis.T;
            }
            catch (Exception ex) { }

        }

        private void optZ1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optZ1.Checked == true)
                    Motion.Selected_Axis = ucMotion.axis.Z1;
            }
            catch (Exception ex) { }

        }

        private void optZ2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optZ2.Checked == true)
                    Motion.Selected_Axis = ucMotion.axis.Z2;
            }
            catch (Exception ex) { }

        }

        private void btnABS_Move_Click(object sender, EventArgs e)
        {
            try
            {
                double pos = Convert.ToDouble(txtABS_Pos.Text);
                Motion.Move_ABS(Motion.Selected_Axis, pos);
            }
            catch (Exception ex) { }

        }

        private void btnABS_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                Motion.Move_Stop(Motion.Selected_Axis);
            }
            catch (Exception ex) { }

        }

        private void btnJog_CCW_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Motion.MoveJog(Motion.Selected_Axis, 1); // CCW
            }
            catch (Exception ex) { }

        }

        private void btnJog_CCW_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Motion.Move_Stop(Motion.Selected_Axis);
            }
            catch (Exception ex) { }

        }

        private void btnJog_CW_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Motion.MoveJog(Motion.Selected_Axis, 0); // CCW
            }
            catch (Exception ex) { }

        }

        private void btnJog_CW_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Motion.Move_Stop(Motion.Selected_Axis);
            }
            catch (Exception ex) { }

        }

        private void btnJogE_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                Motion.Move_Stop_E(Motion.Selected_Axis);
            }
            catch (Exception ex) { }

        }

        private void btnRel_CCW_Click(object sender, EventArgs e)
        {
            try
            {
                double tmpPos = dbRel_Dst * -1;
                Motion.Move_Rel(Motion.Selected_Axis, tmpPos);
            }
            catch (Exception ex) { }

        }

        private void btnRel_CW_Click(object sender, EventArgs e)
        {
            try
            {
                double tmpPos = dbRel_Dst;
                Motion.Move_Rel(Motion.Selected_Axis, tmpPos);
            }
            catch (Exception ex) { }

        }

        private void btnRelStop_Click(object sender, EventArgs e)
        {
            try
            {
                Motion.Move_Stop(Motion.Selected_Axis);
            }
            catch (Exception ex) { }

        }

        private void optJogSpeed_10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optJogSpeed_10.Checked == true)
                {
                    nJog_SPD = 10;
                    Motion.SpeedSet(Motion.Selected_Axis, 0, nJog_SPD);
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
                    Motion.SpeedSet(Motion.Selected_Axis, 0, nJog_SPD);
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
                    nJog_SPD = Convert.ToInt16(optJogSpeed_Manual.Text);
                    Motion.SpeedSet(Motion.Selected_Axis, 0, nJog_SPD);
                }
            }
            catch (Exception ex) { }

        }

        private void optRelSpeed_10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelSpeed_10.Checked == true)
                {
                    nRel_SPD = 10;
                    Motion.SpeedSet(Motion.Selected_Axis, 0, nRel_SPD);
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
                    Motion.SpeedSet(Motion.Selected_Axis, 0, nRel_SPD);
                }
            }
            catch (Exception ex) { }
        }

        private void optRelSpeed_Manual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelSpeed_Manual.Checked == true)
                {
                    nRel_SPD = Convert.ToInt16(txtRelSpeed_Manual.Text);
                    Motion.SpeedSet(Motion.Selected_Axis, 0, nRel_SPD);
                }
            }
            catch (Exception ex) { }
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

        private void optRelDistance_Manual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRelDistance_Manual.Checked == true)
                {
                    dbRel_Dst = Convert.ToDouble(optRelDistance_Manual.Text);
                }
            }
            catch (Exception ex) { }
        }

        private void tmStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                if (frmMain.bInit_Motion == true)
                {
                    txtPos_X.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.X].dENCPos.ToString();
                    txtPos_Y.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.Y].dENCPos.ToString();
                    txtPos_T.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.T].dENCPos.ToString();
                    txtPos_Z1.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.Z1].dENCPos.ToString();
                    txtPos_Z2.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.Z2].dENCPos.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void btnRecipe_Current_Click(object sender, EventArgs e)
        {
            try
            {
                txtRecipe_X.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.X].dENCPos.ToString();
                txtRecipe_Y.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.Y].dENCPos.ToString();
                txtRecipe_T.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.T].dENCPos.ToString();
                txtRecipe_Z1.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.Z1].dENCPos.ToString();
                txtRecipe_Z2.Text = Motion.tAllStatus.tServo[(short)ucMotion.axis.Z2].dENCPos.ToString();
            }
            catch (Exception ex) { }
        }
    }
}
