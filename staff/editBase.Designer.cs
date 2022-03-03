
namespace staff
{
    partial class editBase
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
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textAboutMe = new System.Windows.Forms.TextBox();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.textPatronymic = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAboutMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeInformation = new System.Windows.Forms.Button();
            this.DeletePerson = new System.Windows.Forms.Button();
            this.baseDataSet1 = new staff.baseDataSet();
            this.labelID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnRelTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(418, 605);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(102, 23);
            this.Exit.TabIndex = 33;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(183, 605);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(102, 23);
            this.Clear.TabIndex = 32;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Location = new System.Drawing.Point(347, 90);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(173, 23);
            this.btnFindPerson.TabIndex = 31;
            this.btnFindPerson.Text = "Find person";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "About me";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(25, 313);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(82, 17);
            this.Department.TabIndex = 29;
            this.Department.Text = "Department";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(25, 273);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(52, 17);
            this.Adress.TabIndex = 28;
            this.Adress.Text = "Adress";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(25, 228);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(69, 17);
            this.BirthDate.TabIndex = 27;
            this.BirthDate.Text = "Birth date";
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Location = new System.Drawing.Point(25, 176);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(78, 17);
            this.Patronymic.TabIndex = 26;
            this.Patronymic.Text = "Patronymic";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(25, 90);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(65, 17);
            this.Surname.TabIndex = 25;
            this.Surname.Text = "Surname";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 133);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "Name";
            // 
            // textAboutMe
            // 
            this.textAboutMe.Location = new System.Drawing.Point(125, 354);
            this.textAboutMe.Multiline = true;
            this.textAboutMe.Name = "textAboutMe";
            this.textAboutMe.Size = new System.Drawing.Size(333, 120);
            this.textAboutMe.TabIndex = 23;
            // 
            // textDepartment
            // 
            this.textDepartment.Location = new System.Drawing.Point(125, 308);
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.Size = new System.Drawing.Size(200, 22);
            this.textDepartment.TabIndex = 22;
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(125, 268);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(200, 22);
            this.textAdress.TabIndex = 21;
            // 
            // textPatronymic
            // 
            this.textPatronymic.Location = new System.Drawing.Point(125, 171);
            this.textPatronymic.Name = "textPatronymic";
            this.textPatronymic.Size = new System.Drawing.Size(200, 22);
            this.textPatronymic.TabIndex = 20;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(125, 128);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(200, 22);
            this.textName.TabIndex = 19;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(125, 85);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(200, 22);
            this.textSurname.TabIndex = 18;
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.Location = new System.Drawing.Point(125, 223);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dateBirthDate.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableID,
            this.tableSurname,
            this.tableName,
            this.tablePatronymic,
            this.tableBirthDate,
            this.tableAdress,
            this.tableDepartment,
            this.tableAboutMe});
            this.dataGridView1.Location = new System.Drawing.Point(540, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 613);
            this.dataGridView1.TabIndex = 34;
            // 
            // tableID
            // 
            this.tableID.HeaderText = "ID";
            this.tableID.MinimumWidth = 6;
            this.tableID.Name = "tableID";
            this.tableID.ReadOnly = true;
            this.tableID.Width = 125;
            // 
            // tableSurname
            // 
            this.tableSurname.HeaderText = "Surname";
            this.tableSurname.MinimumWidth = 6;
            this.tableSurname.Name = "tableSurname";
            this.tableSurname.ReadOnly = true;
            this.tableSurname.Width = 125;
            // 
            // tableName
            // 
            this.tableName.HeaderText = "Name";
            this.tableName.MinimumWidth = 6;
            this.tableName.Name = "tableName";
            this.tableName.ReadOnly = true;
            this.tableName.Width = 125;
            // 
            // tablePatronymic
            // 
            this.tablePatronymic.HeaderText = "Patronymic";
            this.tablePatronymic.MinimumWidth = 6;
            this.tablePatronymic.Name = "tablePatronymic";
            this.tablePatronymic.ReadOnly = true;
            this.tablePatronymic.Width = 125;
            // 
            // tableBirthDate
            // 
            this.tableBirthDate.HeaderText = "Birth date";
            this.tableBirthDate.MinimumWidth = 6;
            this.tableBirthDate.Name = "tableBirthDate";
            this.tableBirthDate.ReadOnly = true;
            this.tableBirthDate.Width = 125;
            // 
            // tableAdress
            // 
            this.tableAdress.HeaderText = "Adress";
            this.tableAdress.MinimumWidth = 6;
            this.tableAdress.Name = "tableAdress";
            this.tableAdress.ReadOnly = true;
            this.tableAdress.Width = 125;
            // 
            // tableDepartment
            // 
            this.tableDepartment.HeaderText = "Department";
            this.tableDepartment.MinimumWidth = 6;
            this.tableDepartment.Name = "tableDepartment";
            this.tableDepartment.ReadOnly = true;
            this.tableDepartment.Width = 125;
            // 
            // tableAboutMe
            // 
            this.tableAboutMe.HeaderText = "About me";
            this.tableAboutMe.MinimumWidth = 6;
            this.tableAboutMe.Name = "tableAboutMe";
            this.tableAboutMe.ReadOnly = true;
            this.tableAboutMe.Width = 125;
            // 
            // ChangeInformation
            // 
            this.ChangeInformation.Location = new System.Drawing.Point(347, 158);
            this.ChangeInformation.Name = "ChangeInformation";
            this.ChangeInformation.Size = new System.Drawing.Size(173, 23);
            this.ChangeInformation.TabIndex = 35;
            this.ChangeInformation.Text = "Change Information";
            this.ChangeInformation.UseVisualStyleBackColor = true;
            this.ChangeInformation.Click += new System.EventHandler(this.ChangeInformation_Click);
            // 
            // DeletePerson
            // 
            this.DeletePerson.Location = new System.Drawing.Point(347, 222);
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Size = new System.Drawing.Size(173, 23);
            this.DeletePerson.TabIndex = 36;
            this.DeletePerson.Text = "Delete person";
            this.DeletePerson.UseVisualStyleBackColor = true;
            this.DeletePerson.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // baseDataSet1
            // 
            this.baseDataSet1.DataSetName = "baseDataSet";
            this.baseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(25, 42);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 38;
            this.labelID.Text = "ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(125, 37);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(200, 22);
            this.textID.TabIndex = 37;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(347, 36);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(173, 23);
            this.btnAddPerson.TabIndex = 39;
            this.btnAddPerson.Text = "Add person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnRelTable
            // 
            this.btnRelTable.Location = new System.Drawing.Point(1505, 634);
            this.btnRelTable.Name = "btnRelTable";
            this.btnRelTable.Size = new System.Drawing.Size(102, 23);
            this.btnRelTable.TabIndex = 40;
            this.btnRelTable.Text = "Reload Table";
            this.btnRelTable.UseVisualStyleBackColor = true;
            this.btnRelTable.Click += new System.EventHandler(this.btnRelTable_Click);
            // 
            // editBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1614, 665);
            this.Controls.Add(this.btnRelTable);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.DeletePerson);
            this.Controls.Add(this.ChangeInformation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnFindPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textAboutMe);
            this.Controls.Add(this.textDepartment);
            this.Controls.Add(this.textAdress);
            this.Controls.Add(this.textPatronymic);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.dateBirthDate);
            this.MaximumSize = new System.Drawing.Size(1632, 712);
            this.MinimumSize = new System.Drawing.Size(1632, 712);
            this.Name = "editBase";
            this.Text = "Base editor";
            this.Load += new System.EventHandler(this.editBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textAboutMe;
        private System.Windows.Forms.TextBox textDepartment;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.TextBox textPatronymic;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ChangeInformation;
        private System.Windows.Forms.Button DeletePerson;
        private baseDataSet baseDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablePatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableAboutMe;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnRelTable;
    }
}