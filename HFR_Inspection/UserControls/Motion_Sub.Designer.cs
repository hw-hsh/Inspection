namespace HFR_Inspection
{
    partial class ucRecipe2
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRecipe = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optInspection = new System.Windows.Forms.RadioButton();
            this.optMove = new System.Windows.Forms.RadioButton();
            this.btnRecipe_New = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numIndex = new System.Windows.Forms.NumericUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numDelete = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoad_JobName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHotKey_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHotKey_Folder = new System.Windows.Forms.Button();
            this.lstRecipe = new System.Windows.Forms.ListBox();
            this.optHotKey_4 = new System.Windows.Forms.RadioButton();
            this.optHotKey_3 = new System.Windows.Forms.RadioButton();
            this.optHotKey_2 = new System.Windows.Forms.RadioButton();
            this.optHotKey_1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelete)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecipe
            // 
            this.dgvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Unit,
            this.Action,
            this.Param1,
            this.Param2});
            this.dgvRecipe.Location = new System.Drawing.Point(3, 102);
            this.dgvRecipe.Name = "dgvRecipe";
            this.dgvRecipe.RowTemplate.Height = 23;
            this.dgvRecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipe.Size = new System.Drawing.Size(461, 287);
            this.dgvRecipe.TabIndex = 0;
            this.dgvRecipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipe_CellClick);
            this.dgvRecipe.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRecipe_RowsAdded);
            this.dgvRecipe.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvRecipe_RowsRemoved);
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.Width = 50;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // Param1
            // 
            this.Param1.HeaderText = "Location";
            this.Param1.Name = "Param1";
            // 
            // Param2
            // 
            this.Param2.HeaderText = "Velocity";
            this.Param2.Name = "Param2";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(303, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 38);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "추  가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optInspection);
            this.groupBox1.Controls.Add(this.optMove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(3, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 69);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "동작";
            // 
            // optInspection
            // 
            this.optInspection.Appearance = System.Windows.Forms.Appearance.Button;
            this.optInspection.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optInspection.Location = new System.Drawing.Point(140, 20);
            this.optInspection.Name = "optInspection";
            this.optInspection.Size = new System.Drawing.Size(90, 38);
            this.optInspection.TabIndex = 1;
            this.optInspection.TabStop = true;
            this.optInspection.Text = "검  사";
            this.optInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optInspection.UseVisualStyleBackColor = true;
            // 
            // optMove
            // 
            this.optMove.Appearance = System.Windows.Forms.Appearance.Button;
            this.optMove.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optMove.Location = new System.Drawing.Point(15, 20);
            this.optMove.Name = "optMove";
            this.optMove.Size = new System.Drawing.Size(90, 38);
            this.optMove.TabIndex = 0;
            this.optMove.TabStop = true;
            this.optMove.Text = "이  동";
            this.optMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optMove.UseVisualStyleBackColor = true;
            // 
            // btnRecipe_New
            // 
            this.btnRecipe_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipe_New.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnRecipe_New.Location = new System.Drawing.Point(3, 3);
            this.btnRecipe_New.Name = "btnRecipe_New";
            this.btnRecipe_New.Size = new System.Drawing.Size(89, 55);
            this.btnRecipe_New.TabIndex = 22;
            this.btnRecipe_New.Text = "새 작업";
            this.btnRecipe_New.UseVisualStyleBackColor = true;
            this.btnRecipe_New.Click += new System.EventHandler(this.btnRecipe_New_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(98, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 55);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "작업\r\n저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Location = new System.Drawing.Point(193, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 55);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "작업\r\n불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.numIndex);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Location = new System.Drawing.Point(3, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 69);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "행 삽입";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 27);
            this.label13.TabIndex = 27;
            this.label13.Text = "행 번호(Index)";
            // 
            // numIndex
            // 
            this.numIndex.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.numIndex.Location = new System.Drawing.Point(141, 23);
            this.numIndex.Name = "numIndex";
            this.numIndex.Size = new System.Drawing.Size(90, 29);
            this.numIndex.TabIndex = 21;
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnInsert.Location = new System.Drawing.Point(303, 20);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 38);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "삽  입";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numDelete);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(3, 541);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 69);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "행 삭제";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "행 번호(Index)";
            // 
            // numDelete
            // 
            this.numDelete.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.numDelete.Location = new System.Drawing.Point(141, 23);
            this.numDelete.Name = "numDelete";
            this.numDelete.Size = new System.Drawing.Size(90, 29);
            this.numDelete.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(303, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 38);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "삭  제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "현재 작업 : ";
            // 
            // txtLoad_JobName
            // 
            this.txtLoad_JobName.BackColor = System.Drawing.Color.White;
            this.txtLoad_JobName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoad_JobName.Location = new System.Drawing.Point(98, 65);
            this.txtLoad_JobName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoad_JobName.Name = "txtLoad_JobName";
            this.txtLoad_JobName.ReadOnly = true;
            this.txtLoad_JobName.Size = new System.Drawing.Size(366, 26);
            this.txtLoad_JobName.TabIndex = 29;
            this.txtLoad_JobName.Text = "-";
            this.txtLoad_JobName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHotKey_Add);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnHotKey_Folder);
            this.groupBox4.Controls.Add(this.lstRecipe);
            this.groupBox4.Controls.Add(this.optHotKey_4);
            this.groupBox4.Controls.Add(this.optHotKey_3);
            this.groupBox4.Controls.Add(this.optHotKey_2);
            this.groupBox4.Controls.Add(this.optHotKey_1);
            this.groupBox4.Location = new System.Drawing.Point(3, 616);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 248);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "작업 핫 키 등록";
            // 
            // btnHotKey_Add
            // 
            this.btnHotKey_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotKey_Add.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnHotKey_Add.Location = new System.Drawing.Point(243, 162);
            this.btnHotKey_Add.Name = "btnHotKey_Add";
            this.btnHotKey_Add.Size = new System.Drawing.Size(90, 38);
            this.btnHotKey_Add.TabIndex = 32;
            this.btnHotKey_Add.Text = "등  록";
            this.btnHotKey_Add.UseVisualStyleBackColor = true;
            this.btnHotKey_Add.Click += new System.EventHandler(this.btnHotKey_Add_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(103, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "폴더 선택  :";
            this.label3.Visible = false;
            // 
            // btnHotKey_Folder
            // 
            this.btnHotKey_Folder.BackgroundImage = global::HFR_Inspection.Properties.Resources.Foler;
            this.btnHotKey_Folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHotKey_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotKey_Folder.Location = new System.Drawing.Point(206, 206);
            this.btnHotKey_Folder.Name = "btnHotKey_Folder";
            this.btnHotKey_Folder.Size = new System.Drawing.Size(31, 26);
            this.btnHotKey_Folder.TabIndex = 30;
            this.btnHotKey_Folder.UseVisualStyleBackColor = true;
            this.btnHotKey_Folder.Visible = false;
            this.btnHotKey_Folder.Click += new System.EventHandler(this.btnHotKey_Folder_Click);
            // 
            // lstRecipe
            // 
            this.lstRecipe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecipe.FormattingEnabled = true;
            this.lstRecipe.ItemHeight = 22;
            this.lstRecipe.Location = new System.Drawing.Point(6, 64);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(231, 136);
            this.lstRecipe.TabIndex = 29;
            this.lstRecipe.SelectedValueChanged += new System.EventHandler(this.lstRecipe_SelectedValueChanged);
            // 
            // optHotKey_4
            // 
            this.optHotKey_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.optHotKey_4.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.optHotKey_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optHotKey_4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optHotKey_4.Location = new System.Drawing.Point(294, 20);
            this.optHotKey_4.Name = "optHotKey_4";
            this.optHotKey_4.Size = new System.Drawing.Size(90, 38);
            this.optHotKey_4.TabIndex = 28;
            this.optHotKey_4.Text = "D";
            this.optHotKey_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optHotKey_4.UseVisualStyleBackColor = true;
            this.optHotKey_4.Click += new System.EventHandler(this.optHotKey_4_Click);
            // 
            // optHotKey_3
            // 
            this.optHotKey_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.optHotKey_3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.optHotKey_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optHotKey_3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optHotKey_3.Location = new System.Drawing.Point(198, 20);
            this.optHotKey_3.Name = "optHotKey_3";
            this.optHotKey_3.Size = new System.Drawing.Size(90, 38);
            this.optHotKey_3.TabIndex = 27;
            this.optHotKey_3.Text = "C";
            this.optHotKey_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optHotKey_3.UseVisualStyleBackColor = true;
            this.optHotKey_3.Click += new System.EventHandler(this.optHotKey_3_Click);
            // 
            // optHotKey_2
            // 
            this.optHotKey_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.optHotKey_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.optHotKey_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optHotKey_2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optHotKey_2.Location = new System.Drawing.Point(102, 20);
            this.optHotKey_2.Name = "optHotKey_2";
            this.optHotKey_2.Size = new System.Drawing.Size(90, 38);
            this.optHotKey_2.TabIndex = 26;
            this.optHotKey_2.Text = "B";
            this.optHotKey_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optHotKey_2.UseVisualStyleBackColor = true;
            this.optHotKey_2.Click += new System.EventHandler(this.optHotKey_2_Click);
            // 
            // optHotKey_1
            // 
            this.optHotKey_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.optHotKey_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.optHotKey_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optHotKey_1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.optHotKey_1.Location = new System.Drawing.Point(6, 20);
            this.optHotKey_1.Name = "optHotKey_1";
            this.optHotKey_1.Size = new System.Drawing.Size(90, 38);
            this.optHotKey_1.TabIndex = 25;
            this.optHotKey_1.Text = "A";
            this.optHotKey_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optHotKey_1.UseVisualStyleBackColor = true;
            this.optHotKey_1.Click += new System.EventHandler(this.optHotKey_1_Click);
            // 
            // ucRecipe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtLoad_JobName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRecipe_New);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRecipe);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucRecipe2";
            this.Size = new System.Drawing.Size(467, 867);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDelete)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecipe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optInspection;
        private System.Windows.Forms.RadioButton optMove;
        private System.Windows.Forms.Button btnRecipe_New;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numIndex;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoad_JobName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstRecipe;
        private System.Windows.Forms.RadioButton optHotKey_4;
        private System.Windows.Forms.RadioButton optHotKey_3;
        private System.Windows.Forms.RadioButton optHotKey_2;
        private System.Windows.Forms.RadioButton optHotKey_1;
        public System.Windows.Forms.Button btnHotKey_Folder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHotKey_Add;
    }
}
