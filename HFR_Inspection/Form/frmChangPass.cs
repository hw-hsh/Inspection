using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HFR_Inspection
{
    public partial class frmChangPass : Form
    {
        public frmMain form;

        RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("HFR_Inspection");

        public frmChangPass()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            txtPass_New.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            txtPass_New_Check.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void chkCharEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkCharEnable.Checked == true)
                {
                    txtPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                    txtPass_New.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                    txtPass_New_Check.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                }
                else
                {
                    txtPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                    txtPass_New.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                    txtPass_New_Check.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                }
            }
            catch (Exception ex) { }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("변경 하시겠습니까?", "취소", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.OK)
                {
                    if (txtPass.Text == regKey.GetValue("Password", "0000").ToString() &&
                        txtPass_New.Text == txtPass_New_Check.Text)
                    {
                        regKey.SetValue("Password", txtPass_New.Text);
                        this.Close();
                    }
                    else if (txtPass.Text != regKey.GetValue("Password", "0000").ToString())
                    {
                        MessageBox.Show("기존 암호가 맞지 않습니다.", "안내", MessageBoxButtons.OK);
                    }
                    else if (txtPass_New.Text != txtPass_New_Check.Text)
                    {
                        MessageBox.Show("새 암호와 암호 확인이 일치 하지 않습니다.", "안내", MessageBoxButtons.OK);
                    }
                }
                else
                {

                }
            }
            catch (Exception ex) { }
        }

        private void btnPassClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex) { }
        }
    }
}
