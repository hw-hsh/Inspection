using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Text;

namespace HFR_Inspection.UserControls
{
    public partial class ucLog : UserControl
    {
        RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("HFR_Inspection");


        public class QuickDataGridView : DataGridView
        {
            public QuickDataGridView()
            {
                DoubleBuffered = true;
            }
        }
        public ucLog()
        {
            InitializeComponent();

            DataGriView_Init();
        }

        private void optLog_System_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optLog_System.Checked == true)
                {
                    optLog_System.BackColor = Color.Gray;
                    optLog_Inspection.BackColor = Color.White;

                    Load_Log(LogType.System);
                }
            }
            catch (Exception ex) { }
        }

        private void optLog_Inspection_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optLog_Inspection.Checked == true)
                {
                    optLog_System.BackColor = Color.White;
                    optLog_Inspection.BackColor = Color.Gray;

                    Load_Log(LogType.Inspection);
                }
            }
            catch (Exception ex) { }
        }

        private void DataGriView_Init()
        {
            dgvLog.Columns.Clear();
            dgvLog.Rows.Clear();
            dgvLog.Refresh();

            dgvLog.Columns.Add("Time", "시  간");
            dgvLog.Columns.Add("Record", "내        용");

            //dgvLog.Columns[0].HeaderText = "Time";
            dgvLog.Columns[0].Width = 300;
            //dgvLog.Columns[1].HeaderText = "Record Information";
            dgvLog.Columns[1].Width = 1500;

            dgvLog.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLog.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);
            dgvLog.DefaultCellStyle.Font = new Font("Arial", 15);
        }

        private void Load_Log(LogType type)
        {
            try
            {
                string date = "";
                string strPath = "";

                date = string.Format("{0:0000}{1:00}{2:00}.log", dtpCalendar.Value.Year, dtpCalendar.Value.Month, dtpCalendar.Value.Day);

                if (type == LogType.System)
                {
                    strPath = regKey.GetValue("Log_Path", "경로를 지정해 주세요.").ToString() + @"\System\";
                }
                else
                {
                    strPath = regKey.GetValue("Log_Path", "경로를 지정해 주세요.").ToString() + @"\Inspection\";
                }

                DataGriView_Init();

                StreamReader rd = new StreamReader(strPath + date, Encoding.GetEncoding("euc-kr"));

                while (!rd.EndOfStream)
                {
                    string line = rd.ReadLine();
                    string[] cols = line.Split('-');

                    dgvLog.Rows.Add(cols[0], cols[1]);
                }
                rd.Close();
            }
            catch (Exception ex) { }
        }

        enum LogType
        {
            System,
            Inspection
        }
    }
}
