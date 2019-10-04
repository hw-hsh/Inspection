using System;
using System.Windows.Forms;

namespace HFR_Inspection.UserControls
{
    public partial class TitleBar : UserControl
    {

        protected Form MainForm;
        public Form MainForm2
        {
            get { return MainForm; }
            set { MainForm = value; }
        }

        //protected HFR_Inspection.etc.L4Logger _logger;
        //public HFR_Inspection.etc.L4Logger logger
        //{
        //    get { return _logger; }
        //    set { _logger = value; }
        //}


        //public HFR_Inspection.etc.L4Logger logger = new etc.L4Logger("Log");

        public TitleBar()
        {
            InitializeComponent();

            //XmlConfigurator.Configure(new FileInfo("log4net.xml"));

            tmrDateTime.Start();
        }

        private void btnMain_Close_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("종료 하시겠습니까?", "종료", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.OK)
                {
                    //logger.Write("btnMain_Close_Click : Yes");
                    MainForm.Close();
                }
                else
                {
                    //logger.Write("btnMain_Close_Click : No");
                }

            }
            catch (Exception ex) { }
        }

        private void btnMain_Close_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                btnMain_Close.ImageIndex = 1;
            }
            catch { }
        }

        private void btnMain_Close_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                btnMain_Close.ImageIndex = 2;
            }
            catch { }
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = string.Format("{0}년 {1:00}월 {2:00}일", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                lblTime.Text = string.Format("{0:00}:{1:00}:{2:00}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            }
            catch { }
        }
    }
}
