namespace BirthdayMapper
{
    partial class PeopleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleForm));
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbDOB = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.dataGridPeople = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayMapperDBDataSet = new BirthdayMapper.BirthdayMapperDBDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.peopleTableAdapter = new BirthdayMapper.BirthdayMapperDBDataSetTableAdapters.PeopleTableAdapter();
            this.btnClearData = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbFilterName = new System.Windows.Forms.Label();
            this.tbFilterName = new System.Windows.Forms.TextBox();
            this.lbFilterLastName = new System.Windows.Forms.Label();
            this.tbFilterLastName = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBirthThisMonth = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayMapperDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // lbLastName
            // 
            resources.ApplyResources(this.lbLastName, "lbLastName");
            this.lbLastName.Name = "lbLastName";
            // 
            // lbDOB
            // 
            resources.ApplyResources(this.lbDOB, "lbDOB");
            this.lbDOB.Name = "lbDOB";
            // 
            // lbAge
            // 
            resources.ApplyResources(this.lbAge, "lbAge");
            this.lbAge.Name = "lbAge";
            // 
            // tbFirstName
            // 
            resources.ApplyResources(this.tbFirstName, "tbFirstName");
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstName_KeyPress);
            // 
            // tbLastName
            // 
            resources.ApplyResources(this.tbLastName, "tbLastName");
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLastName_KeyPress);
            // 
            // tbDOB
            // 
            resources.ApplyResources(this.tbDOB, "tbDOB");
            this.tbDOB.Name = "tbDOB";
            this.tbDOB.TextChanged += new System.EventHandler(this.tbDOB_TextChanged);
            this.tbDOB.Leave += new System.EventHandler(this.tbDOB_Leave);
            // 
            // tbAge
            // 
            resources.ApplyResources(this.tbAge, "tbAge");
            this.tbAge.Name = "tbAge";
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // dataGridPeople
            // 
            this.dataGridPeople.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dataGridPeople, "dataGridPeople");
            this.dataGridPeople.AutoGenerateColumns = false;
            this.dataGridPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridPeople.DataSource = this.bindingSource1;
            this.dataGridPeople.MultiSelect = false;
            this.dataGridPeople.Name = "dataGridPeople";
            this.dataGridPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPeople_CellClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "People";
            this.bindingSource1.DataSource = this.birthdayMapperDBDataSet;
            // 
            // birthdayMapperDBDataSet
            // 
            this.birthdayMapperDBDataSet.DataSetName = "BirthdayMapperDBDataSet";
            this.birthdayMapperDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtpBirth
            // 
            this.dtpBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpBirth, "dtpBirth");
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.ValueChanged += new System.EventHandler(this.dtpBirth_ValueChanged);
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // btnClearData
            // 
            this.btnClearData.BackColor = System.Drawing.Color.Teal;
            this.btnClearData.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnClearData, "btnClearData");
            this.btnClearData.ForeColor = System.Drawing.Color.White;
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // tbId
            // 
            resources.ApplyResources(this.tbId, "tbId");
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            // 
            // lbId
            // 
            resources.ApplyResources(this.lbId, "lbId");
            this.lbId.Name = "lbId";
            // 
            // lbFilterName
            // 
            resources.ApplyResources(this.lbFilterName, "lbFilterName");
            this.lbFilterName.Name = "lbFilterName";
            // 
            // tbFilterName
            // 
            resources.ApplyResources(this.tbFilterName, "tbFilterName");
            this.tbFilterName.Name = "tbFilterName";
            this.tbFilterName.TextChanged += new System.EventHandler(this.tbFilterName_TextChanged);
            this.tbFilterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterName_KeyPress);
            // 
            // lbFilterLastName
            // 
            resources.ApplyResources(this.lbFilterLastName, "lbFilterLastName");
            this.lbFilterLastName.Name = "lbFilterLastName";
            // 
            // tbFilterLastName
            // 
            resources.ApplyResources(this.tbFilterLastName, "tbFilterLastName");
            this.tbFilterLastName.Name = "tbFilterLastName";
            this.tbFilterLastName.TextChanged += new System.EventHandler(this.tbFilterLastName_TextChanged);
            this.tbFilterLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterLastName_KeyPress);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            resources.ApplyResources(this.firstNameDataGridViewTextBoxColumn, "firstNameDataGridViewTextBoxColumn");
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            resources.ApplyResources(this.lastNameDataGridViewTextBoxColumn, "lastNameDataGridViewTextBoxColumn");
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            resources.ApplyResources(this.dOBDataGridViewTextBoxColumn, "dOBDataGridViewTextBoxColumn");
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            resources.ApplyResources(this.ageDataGridViewTextBoxColumn, "ageDataGridViewTextBoxColumn");
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // btnBirthThisMonth
            // 
            this.btnBirthThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnBirthThisMonth, "btnBirthThisMonth");
            this.btnBirthThisMonth.Name = "btnBirthThisMonth";
            this.btnBirthThisMonth.UseVisualStyleBackColor = false;
            this.btnBirthThisMonth.Click += new System.EventHandler(this.btnBirthThisMonth_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PeopleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBirthThisMonth);
            this.Controls.Add(this.tbFilterLastName);
            this.Controls.Add(this.lbFilterLastName);
            this.Controls.Add(this.tbFilterName);
            this.Controls.Add(this.lbFilterName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridPeople);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbDOB);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbDOB);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PeopleForm";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayMapperDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbDOB;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.DataGridView dataGridPeople;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private BirthdayMapperDBDataSet birthdayMapperDBDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BirthdayMapperDBDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbFilterName;
        private System.Windows.Forms.TextBox tbFilterName;
        private System.Windows.Forms.Label lbFilterLastName;
        private System.Windows.Forms.TextBox tbFilterLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBirthThisMonth;
        private System.Windows.Forms.Button btnReset;
    }
}

