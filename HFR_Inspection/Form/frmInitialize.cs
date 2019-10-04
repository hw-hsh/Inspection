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
    public partial class frmInitialize : Form
    {
        public frmInitialize()
        {
            InitializeComponent();
        }

        public void UpdateinitCompletion(int value)
        {
            pgbInit.Value = value;
            lblCompletionRate.Text = value.ToString();
        }
    }
}
