using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFR_Inspection
{
    public partial class frmPassword : Form
    {
        public frmMain form;

        RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("HFR_Inspection");

        string strpass;

        public frmPassword()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;

            //txtPass.Text = regKey.GetValue("Password", "0000").ToString();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strpass = regKey.GetValue("Password", "0000").ToString();
                form.strPass = txtPass.Text;
                if (strpass == txtPass.Text)
                {
                    form.Islogin = true;
                    form.btnChange_Pass.Visible = true;
                    form.btnLogout.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("암호가 일치 하지 않습니다.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Text = "";
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            strpass = regKey.GetValue("Password", "0000").ToString();
            form.strPass = txtPass.Text;
            if (strpass == txtPass.Text)
            {
                form.Islogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("암호가 일치 하지 않습니다.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
            }
        }

        private void btnPassClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
