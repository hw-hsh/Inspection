using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HFR_Inspection
{
    public partial class ucRecipe2 : UserControl
    {
        double dbX, dbY, dbT, dbZ1, dbZ2;
        double dbSpdX, dbSpdY, dbSpdT, dbSpdZ1, dbSpdZ2;
        int nSelectRow;

        string strFilePath;

        static RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("HFR_Inspection");

        string strSelect_HotKey, strSelect_HotKey_Name;

        protected Form MainForm;

        public Form MainForm2
        {
            get { return MainForm; }
            set { MainForm = value; }
        }

        protected ucRecipe1 Recipe;
        public ucRecipe1 Recipe2
        {
            get { return Recipe; }
            set { Recipe = value; }
        }

        public ucRecipe2()
        {
            InitializeComponent();

            DataGriView_Init();

            strFilePath = regKey.GetValue("Recipe_Path", "경로를 지정해 주세요.").ToString();

            Listbox_Init();
        }

        private void dgvRecipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nSelectRow = dgvRecipe.SelectedRows[0].Index;
            numDelete.Value = Convert.ToDecimal(nSelectRow) + 1;
            numIndex.Value = Convert.ToDecimal(nSelectRow) + 1;
        }

        private void btnRecipe_New_Click(object sender, EventArgs e)
        {
            DataGriView_Init();
        }

        private void dgvRecipe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Update_dgv();
            }
            catch (Exception ex) { }
        }

        private void btnHotKey_Folder_Click(object sender, EventArgs e)
        {
            try
            {
                //FolderBrowserDialog dialog = new FolderBrowserDialog();
                //var result = dialog.ShowDialog();
                //if (result == DialogResult.OK)
                //{
                //    DirectoryInfo di = new DirectoryInfo(dialog.SelectedPath);

                //    foreach (FileInfo file in di.GetFiles())
                //    {
                //        if (file.Extension.ToLower().CompareTo(".hwr") == 0)
                //        {
                //            lstRecipe.Items.Add(Haewon.Module.Common.Mid(file.Name, 0, file.Name.Length - 4));
                //        }
                //    }

                //}

                DirectoryInfo di = new DirectoryInfo(strFilePath);

                foreach (FileInfo file in di.GetFiles())
                {
                    if (file.Extension.ToLower().CompareTo(".hwr") == 0)
                    {
                        lstRecipe.Items.Add(Haewon.Module.Common.Mid(file.Name, 0, file.Name.Length - 4));
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void Listbox_Init()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(strFilePath);

                foreach (FileInfo file in di.GetFiles())
                {
                    if (file.Extension.ToLower().CompareTo(".hwr") == 0)
                    {
                        lstRecipe.Items.Add(Haewon.Module.Common.Mid(file.Name, 0, file.Name.Length - 4));
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnHotKey_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (optHotKey_1.Checked == false && optHotKey_2.Checked == false && optHotKey_3.Checked == false && optHotKey_4.Checked == false)
                {
                    MessageBox.Show("핫 키를 선택 하셔야 합니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("핫키를 등록 하시겠습니까?", "물음", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //regKey.SetValue("HotKey_" + strSelect_HotKey, strFilePath + "\\" + strSelect_HotKey_Name + ".hwr");
                        regKey.SetValue("HotKey_" + strSelect_HotKey, strSelect_HotKey_Name);
                        regKey.SetValue("Update_HotKey", 1);
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void optHotKey_1_Click(object sender, EventArgs e)
        {
            try
            {
                strSelect_HotKey = "A";
            }
            catch (Exception ex) { }
        }

        private void optHotKey_2_Click(object sender, EventArgs e)
        {
            try
            {
                strSelect_HotKey = "B";
            }
            catch (Exception ex) { }
        }

        private void optHotKey_3_Click(object sender, EventArgs e)
        {
            try
            {
                strSelect_HotKey = "C";
            }
            catch (Exception ex) { }
        }

        private void optHotKey_4_Click(object sender, EventArgs e)
        {
            try
            {
                strSelect_HotKey = "D";
            }
            catch (Exception ex) { }
        }

        private void lstRecipe_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                strSelect_HotKey_Name = lstRecipe.SelectedItem.ToString();
            }
            catch (Exception ex) { }
        }

        private void dgvRecipe_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Update_dgv();
            }
            catch (Exception ex) { }
        }

        private void Update_dgv()
        {
            try
            {
                int nCnt = dgvRecipe.Rows.Count;

                for (int i = 0; i < nCnt; i++)
                {
                    dgvRecipe.Rows[i].Cells[0].Value = i;
                }
            }
            catch (Exception ex) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog svFile = new SaveFileDialog
                {
                    InitialDirectory = strFilePath,
                    DefaultExt = "hwr",
                    FileName = "*.hwr",
                    Filter = "레시피 파일 (*.hwr)|*.hwr|모든 파일 (*.*)|*.*"
                };

                if (svFile.ShowDialog() == DialogResult.OK)
                {
                    TextWriter sw = new StreamWriter(svFile.FileName);
                    for (int i = 0; i < dgvRecipe.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvRecipe.Columns.Count; j++)
                        {
                            if (j != dgvRecipe.Columns.Count - 1)
                                sw.Write(dgvRecipe.Rows[i].Cells[j].Value.ToString() + ",");
                            else
                                sw.Write(dgvRecipe.Rows[i].Cells[j].Value.ToString());
                        }
                        sw.WriteLine("");
                    }
                    sw.Close();
                }
                Listbox_Init();
            }
            catch (Exception ex) { }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opFile = new OpenFileDialog
                {
                    InitialDirectory = strFilePath,
                    DefaultExt = "hwr",
                    FileName = "*.hwr",
                    Filter = "레시피 파일 (*.hwr)|*.hwr|모든 파일 (*.*)|*.*"
                };

                if (opFile.ShowDialog() == DialogResult.OK)
                {
                    DataGriView_Init();

                    StreamReader rd = new StreamReader(opFile.FileName, Encoding.GetEncoding("euc-kr"));

                    while (!rd.EndOfStream)
                    {
                        string line = rd.ReadLine();
                        string[] cols = line.Split(',');

                        dgvRecipe.Rows.Add(cols[0], cols[1], cols[2], cols[3], cols[4]);
                    }
                    rd.Close();
                }

                txtLoad_JobName.Text = Path.GetFileNameWithoutExtension(opFile.FileName);
            }
            catch (Exception ex) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nCnt = dgvRecipe.Rows.Count;
            if (optMove.Checked == true)
            {
                dbX = Convert.ToDouble(Recipe.txtRecipe_X.Text);
                dbY = Convert.ToDouble(Recipe.txtRecipe_Y.Text);
                dbT = Convert.ToDouble(Recipe.txtRecipe_T.Text);
                dbZ1 = Convert.ToDouble(Recipe.txtRecipe_Z1.Text);
                dbZ2 = Convert.ToDouble(Recipe.txtRecipe_Z2.Text);

                dbSpdX = Convert.ToDouble(Recipe.txtRecipe_Speed_X.Text);
                dbSpdY = Convert.ToDouble(Recipe.txtRecipe_Speed_Y.Text);
                dbSpdT = Convert.ToDouble(Recipe.txtRecipe_Speed_T.Text);
                dbSpdZ1 = Convert.ToDouble(Recipe.txtRecipe_Speed_Z1.Text);
                dbSpdZ2 = Convert.ToDouble(Recipe.txtRecipe_Speed_Z2.Text);

                dgvRecipe.Rows.Add(nCnt, "X", "Move", dbX, dbSpdX);
                nCnt++;
                dgvRecipe.Rows.Add(nCnt, "Y", "Move", dbY, dbSpdY);
                nCnt++;
                dgvRecipe.Rows.Add(nCnt, "T", "Move", dbT, dbSpdT);
                nCnt++;
                dgvRecipe.Rows.Add(nCnt, "Z1", "Move", dbZ1, dbSpdZ1);
                nCnt++;
                dgvRecipe.Rows.Add(nCnt, "Z2", "Move", dbZ2, dbSpdZ2);
            }
            else
            {
                if (Recipe.chkRecipe_Cam1.Checked == true)
                {
                    dgvRecipe.Rows.Add(nCnt, "Cam1", "Inspection", "-", "-");
                    nCnt++;
                }
                if (Recipe.chkRecipe_Cam2.Checked == true)
                {
                    dgvRecipe.Rows.Add(nCnt, "Cam2", "Inspection", "-", "-");
                }
            }
        }

        private void DataGriView_Init()
        {
            try
            {
                dgvRecipe.Columns.Clear();
                dgvRecipe.Rows.Clear();
                dgvRecipe.Refresh();

                dgvRecipe.Columns.Add("Index", "Index");
                dgvRecipe.Columns.Add("Unit", "Unit");
                dgvRecipe.Columns.Add("Action", "Action");
                dgvRecipe.Columns.Add("Location", "Location");
                dgvRecipe.Columns.Add("Velocity", "Velocity");

                //dgvLog.Columns[0].HeaderText = "Time";
                dgvRecipe.Columns[0].Width = 50;
                //dgvLog.Columns[1].HeaderText = "Record Information";
                dgvRecipe.Columns[1].Width = 100;
                dgvRecipe.Columns[2].Width = 100;
                dgvRecipe.Columns[3].Width = 100;
                dgvRecipe.Columns[3].Width = 100;

                dgvRecipe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRecipe.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvRecipe.DefaultCellStyle.Font = new Font("Arial", 12);
            }
            catch (Exception ex) { }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int nIndex = Convert.ToInt16(numIndex.Value);

                if (optMove.Checked == true)
                {
                    dbX = Convert.ToDouble(Recipe.txtRecipe_X.Text);
                    dbY = Convert.ToDouble(Recipe.txtRecipe_Y.Text);
                    dbT = Convert.ToDouble(Recipe.txtRecipe_T.Text);
                    dbZ1 = Convert.ToDouble(Recipe.txtRecipe_Z1.Text);
                    dbZ2 = Convert.ToDouble(Recipe.txtRecipe_Z2.Text);

                    dbSpdX = Convert.ToDouble(Recipe.txtRecipe_Speed_X.Text);
                    dbSpdY = Convert.ToDouble(Recipe.txtRecipe_Speed_Y.Text);
                    dbSpdT = Convert.ToDouble(Recipe.txtRecipe_Speed_T.Text);
                    dbSpdZ1 = Convert.ToDouble(Recipe.txtRecipe_Speed_Z1.Text);
                    dbSpdZ2 = Convert.ToDouble(Recipe.txtRecipe_Speed_Z2.Text);

                    dgvRecipe.Rows.Insert(nIndex, nIndex, "X", "Move", dbX, dbSpdX);
                    nIndex++;
                    dgvRecipe.Rows.Insert(nIndex, nIndex, "Y", "Move", dbY, dbSpdY);
                    nIndex++;
                    dgvRecipe.Rows.Insert(nIndex, nIndex, "T", "Move", dbT, dbSpdT);
                    nIndex++;
                    dgvRecipe.Rows.Insert(nIndex, nIndex, "Z1", "Move", dbZ1, dbSpdZ1);
                    nIndex++;
                    dgvRecipe.Rows.Insert(nIndex, nIndex, "Z2", "Move", dbZ2, dbSpdZ2);
                }
                else
                {
                    if (Recipe.chkRecipe_Cam1.Checked == true)
                    {
                        dgvRecipe.Rows.Insert(nIndex, nIndex, "Cam1", "Inspection", "-", "-");
                        nIndex++;
                    }
                    if (Recipe.chkRecipe_Cam2.Checked == true)
                    {
                        dgvRecipe.Rows.Insert(nIndex, nIndex, "Cam2", "Inspection", "-", "-");
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int nCnt = Convert.ToInt16(numDelete.Value);
                dgvRecipe.Rows.Remove(dgvRecipe.Rows[nCnt - 1]);
            }
            catch (Exception ex) { }
        }
    }
}
