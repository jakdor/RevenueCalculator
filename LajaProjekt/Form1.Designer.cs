namespace LajaProjekt
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label kategoriaLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new LajaProjekt.DatabaseDataSet();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.kategoriaTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MenuCount = new System.Windows.Forms.Label();
            this.AddToSales = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.d3 = new System.Windows.Forms.RadioButton();
            this.d2 = new System.Windows.Forms.RadioButton();
            this.d1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.AddQuantity = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SalesDeleteEntry = new System.Windows.Forms.Button();
            this.SalesCount = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.f1 = new System.Windows.Forms.RadioButton();
            this.f3 = new System.Windows.Forms.RadioButton();
            this.f2 = new System.Windows.Forms.RadioButton();
            this.f0 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SalesDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.query1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ExpO3 = new System.Windows.Forms.CheckBox();
            this.ExpO1 = new System.Windows.Forms.CheckBox();
            this.ExpO2 = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ExpS2 = new System.Windows.Forms.RadioButton();
            this.ExpS1 = new System.Windows.Forms.RadioButton();
            this.getPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uCat5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uCat4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uCat3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uCat2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uCat1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uSum = new System.Windows.Forms.TextBox();
            this.query1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new LajaProjekt.DatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new LajaProjekt.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.query1TableAdapter = new LajaProjekt.DatabaseDataSetTableAdapters.query1TableAdapter();
            this.table2TableAdapter = new LajaProjekt.DatabaseDataSetTableAdapters.Table2TableAdapter();
            this.queriesTableAdapter1 = new LajaProjekt.DatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.exp1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exp1TableAdapter = new LajaProjekt.DatabaseDataSetTableAdapters.Exp1TableAdapter();
            this.settingsTableAdapter1 = new LajaProjekt.DatabaseDataSetTableAdapters.SettingsTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            kategoriaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(31, 31);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Nr:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(31, 63);
            nazwaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(54, 17);
            nazwaLabel.TabIndex = 3;
            nazwaLabel.Text = "Nazwa:";
            // 
            // kategoriaLabel
            // 
            kategoriaLabel.AutoSize = true;
            kategoriaLabel.Location = new System.Drawing.Point(31, 95);
            kategoriaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kategoriaLabel.Name = "kategoriaLabel";
            kategoriaLabel.Size = new System.Drawing.Size(73, 17);
            kategoriaLabel.TabIndex = 5;
            kategoriaLabel.Text = "Kategoria:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(31, 127);
            cenaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(45, 17);
            cenaLabel.TabIndex = 7;
            cenaLabel.Text = "Cena:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.kategoriaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(587, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Nr";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            this.kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            this.kategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.cenaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena(PLN)";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaDataGridViewTextBoxColumn.Width = 80;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(112, 27);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(288, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(112, 59);
            this.nazwaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nazwaTextBox.MaxLength = 30;
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(288, 22);
            this.nazwaTextBox.TabIndex = 4;
            // 
            // kategoriaTextBox
            // 
            this.kategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Kategoria", true));
            this.kategoriaTextBox.Enabled = false;
            this.kategoriaTextBox.Location = new System.Drawing.Point(112, 91);
            this.kategoriaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kategoriaTextBox.MaxLength = 20;
            this.kategoriaTextBox.Name = "kategoriaTextBox";
            this.kategoriaTextBox.ReadOnly = true;
            this.kategoriaTextBox.Size = new System.Drawing.Size(288, 22);
            this.kategoriaTextBox.TabIndex = 6;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(112, 123);
            this.cenaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(288, 22);
            this.cenaTextBox.TabIndex = 8;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(429, 21);
            this.NewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(133, 28);
            this.NewButton.TabIndex = 9;
            this.NewButton.Text = "Dodaj nowy";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(429, 92);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(133, 53);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Zapisz zmiany";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Szukaj:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(76, 31);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(256, 22);
            this.SearchBox.TabIndex = 12;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CategoryComboBox);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.cenaTextBox);
            this.groupBox1.Controls.Add(cenaLabel);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.kategoriaTextBox);
            this.groupBox1.Controls.Add(this.NewButton);
            this.groupBox1.Controls.Add(kategoriaLabel);
            this.groupBox1.Controls.Add(this.nazwaTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(nazwaLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 359);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(605, 167);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edytuj menu";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "HERBATY",
            "POSIŁKI",
            "SKLEP",
            "FAJKI",
            "INNE"});
            this.CategoryComboBox.Location = new System.Drawing.Point(112, 90);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(288, 24);
            this.CategoryComboBox.TabIndex = 0;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(429, 57);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(133, 28);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "usuń";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MenuCount
            // 
            this.MenuCount.AutoSize = true;
            this.MenuCount.Location = new System.Drawing.Point(5, 306);
            this.MenuCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MenuCount.Name = "MenuCount";
            this.MenuCount.Size = new System.Drawing.Size(46, 17);
            this.MenuCount.TabIndex = 14;
            this.MenuCount.Text = "label2";
            // 
            // AddToSales
            // 
            this.AddToSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddToSales.Location = new System.Drawing.Point(364, 28);
            this.AddToSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToSales.Name = "AddToSales";
            this.AddToSales.Size = new System.Drawing.Size(199, 28);
            this.AddToSales.TabIndex = 15;
            this.AddToSales.Text = "DODAJ DO UTARGU";
            this.AddToSales.UseVisualStyleBackColor = true;
            this.AddToSales.Click += new System.EventHandler(this.AddToSales_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AddQuantity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AddToSales);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.MenuCount);
            this.groupBox2.Controls.Add(this.SearchBox);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(605, 337);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.d3);
            this.groupBox6.Controls.Add(this.d2);
            this.groupBox6.Controls.Add(this.d1);
            this.groupBox6.Location = new System.Drawing.Point(237, 63);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(325, 48);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Zniżki";
            // 
            // d3
            // 
            this.d3.AutoSize = true;
            this.d3.Location = new System.Drawing.Point(232, 20);
            this.d3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(62, 21);
            this.d3.TabIndex = 2;
            this.d3.Text = "-30%";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.AutoSize = true;
            this.d2.Location = new System.Drawing.Point(135, 20);
            this.d2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(62, 21);
            this.d2.TabIndex = 1;
            this.d2.Text = "-20%";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.AutoSize = true;
            this.d1.Checked = true;
            this.d1.Location = new System.Drawing.Point(32, 20);
            this.d1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(66, 21);
            this.d1.TabIndex = 0;
            this.d1.TabStop = true;
            this.d1.Text = "BRAK";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ilość:";
            // 
            // AddQuantity
            // 
            this.AddQuantity.Location = new System.Drawing.Point(76, 74);
            this.AddQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddQuantity.Name = "AddQuantity";
            this.AddQuantity.Size = new System.Drawing.Size(132, 22);
            this.AddQuantity.TabIndex = 16;
            this.AddQuantity.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SalesDeleteEntry);
            this.groupBox3.Controls.Add(this.SalesCount);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.SalesDate);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(643, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(681, 437);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Utarg";
            // 
            // SalesDeleteEntry
            // 
            this.SalesDeleteEntry.Location = new System.Drawing.Point(485, 401);
            this.SalesDeleteEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalesDeleteEntry.Name = "SalesDeleteEntry";
            this.SalesDeleteEntry.Size = new System.Drawing.Size(188, 28);
            this.SalesDeleteEntry.TabIndex = 5;
            this.SalesDeleteEntry.Text = "Usuń wybrany wpis";
            this.SalesDeleteEntry.UseVisualStyleBackColor = true;
            this.SalesDeleteEntry.Click += new System.EventHandler(this.SalesDeleteEntry_Click);
            // 
            // SalesCount
            // 
            this.SalesCount.AutoSize = true;
            this.SalesCount.Location = new System.Drawing.Point(9, 400);
            this.SalesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesCount.Name = "SalesCount";
            this.SalesCount.Size = new System.Drawing.Size(54, 17);
            this.SalesCount.TabIndex = 4;
            this.SalesCount.Text = "label10";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.f1);
            this.groupBox7.Controls.Add(this.f3);
            this.groupBox7.Controls.Add(this.f2);
            this.groupBox7.Controls.Add(this.f0);
            this.groupBox7.Location = new System.Drawing.Point(285, 15);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(388, 50);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Filtruj";
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Location = new System.Drawing.Point(132, 18);
            this.f1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(54, 21);
            this.f1.TabIndex = 3;
            this.f1.TabStop = true;
            this.f1.Text = "Rok";
            this.f1.UseVisualStyleBackColor = true;
            // 
            // f3
            // 
            this.f3.AutoSize = true;
            this.f3.Checked = true;
            this.f3.Location = new System.Drawing.Point(291, 18);
            this.f3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(65, 21);
            this.f3.TabIndex = 2;
            this.f3.TabStop = true;
            this.f3.Text = "Dzień";
            this.f3.UseVisualStyleBackColor = true;
            this.f3.CheckedChanged += new System.EventHandler(this.f3_CheckedChanged);
            // 
            // f2
            // 
            this.f2.AutoSize = true;
            this.f2.Location = new System.Drawing.Point(200, 18);
            this.f2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(76, 21);
            this.f2.TabIndex = 1;
            this.f2.Text = "Miesiąc";
            this.f2.UseVisualStyleBackColor = true;
            this.f2.CheckedChanged += new System.EventHandler(this.f2_CheckedChanged);
            // 
            // f0
            // 
            this.f0.AutoSize = true;
            this.f0.Location = new System.Drawing.Point(29, 20);
            this.f0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f0.Name = "f0";
            this.f0.Size = new System.Drawing.Size(89, 21);
            this.f0.TabIndex = 0;
            this.f0.Text = "Wszystko";
            this.f0.UseVisualStyleBackColor = true;
            this.f0.CheckedChanged += new System.EventHandler(this.f0_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // SalesDate
            // 
            this.SalesDate.Location = new System.Drawing.Point(75, 30);
            this.SalesDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalesDate.Name = "SalesDate";
            this.SalesDate.Size = new System.Drawing.Size(191, 22);
            this.SalesDate.TabIndex = 1;
            this.SalesDate.ValueChanged += new System.EventHandler(this.SalesDate_ValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nazwaDataGridViewTextBoxColumn1,
            this.kategoriaDataGridViewTextBoxColumn1,
            this.iloscDataGridViewTextBoxColumn,
            this.discount,
            this.Cena,
            this.kwotaDataGridViewTextBoxColumn,
            this.data});
            this.dataGridView2.DataSource = this.query1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 73);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(665, 322);
            this.dataGridView2.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // nazwaDataGridViewTextBoxColumn1
            // 
            this.nazwaDataGridViewTextBoxColumn1.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn1.Name = "nazwaDataGridViewTextBoxColumn1";
            this.nazwaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn1.Width = 118;
            // 
            // kategoriaDataGridViewTextBoxColumn1
            // 
            this.kategoriaDataGridViewTextBoxColumn1.DataPropertyName = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn1.HeaderText = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn1.Name = "kategoriaDataGridViewTextBoxColumn1";
            this.kategoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.kategoriaDataGridViewTextBoxColumn1.Width = 70;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.ReadOnly = true;
            this.iloscDataGridViewTextBoxColumn.Width = 48;
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            dataGridViewCellStyle2.Format = "P0";
            dataGridViewCellStyle2.NullValue = null;
            this.discount.DefaultCellStyle = dataGridViewCellStyle2;
            this.discount.HeaderText = "-%";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 40;
            // 
            // Cena
            // 
            this.Cena.DataPropertyName = "Cena";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Cena.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cena.HeaderText = "Cena(PLN)";
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            this.Cena.Width = 70;
            // 
            // kwotaDataGridViewTextBoxColumn
            // 
            this.kwotaDataGridViewTextBoxColumn.DataPropertyName = "kwota";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.kwotaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.kwotaDataGridViewTextBoxColumn.HeaderText = "Kwota(PLN)";
            this.kwotaDataGridViewTextBoxColumn.Name = "kwotaDataGridViewTextBoxColumn";
            this.kwotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kwotaDataGridViewTextBoxColumn.Width = 70;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data.Width = 63;
            // 
            // query1BindingSource
            // 
            this.query1BindingSource.DataMember = "query1";
            this.query1BindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Controls.Add(this.getPath);
            this.groupBox4.Location = new System.Drawing.Point(16, 540);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(605, 133);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eksport";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ExpO3);
            this.groupBox8.Controls.Add(this.ExpO1);
            this.groupBox8.Controls.Add(this.ExpO2);
            this.groupBox8.Location = new System.Drawing.Point(16, 20);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(325, 101);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Opcje";
            // 
            // ExpO3
            // 
            this.ExpO3.AutoSize = true;
            this.ExpO3.Checked = true;
            this.ExpO3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExpO3.Location = new System.Drawing.Point(60, 48);
            this.ExpO3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpO3.Name = "ExpO3";
            this.ExpO3.Size = new System.Drawing.Size(175, 21);
            this.ExpO3.TabIndex = 2;
            this.ExpO3.Text = "Ignoruj puste kategorie";
            this.ExpO3.UseVisualStyleBackColor = true;
            // 
            // ExpO1
            // 
            this.ExpO1.AutoSize = true;
            this.ExpO1.Location = new System.Drawing.Point(60, 20);
            this.ExpO1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpO1.Name = "ExpO1";
            this.ExpO1.Size = new System.Drawing.Size(220, 21);
            this.ExpO1.TabIndex = 1;
            this.ExpO1.Text = "Kategorie w osobnych kartach";
            this.ExpO1.UseVisualStyleBackColor = true;
            // 
            // ExpO2
            // 
            this.ExpO2.AutoSize = true;
            this.ExpO2.Checked = true;
            this.ExpO2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExpO2.Location = new System.Drawing.Point(60, 76);
            this.ExpO2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpO2.Name = "ExpO2";
            this.ExpO2.Size = new System.Drawing.Size(125, 21);
            this.ExpO2.TabIndex = 0;
            this.ExpO2.Text = "Podsumowanie";
            this.ExpO2.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ExpS2);
            this.groupBox9.Controls.Add(this.ExpS1);
            this.groupBox9.Location = new System.Drawing.Point(349, 20);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(247, 48);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Źródło";
            // 
            // ExpS2
            // 
            this.ExpS2.AutoSize = true;
            this.ExpS2.Checked = true;
            this.ExpS2.Location = new System.Drawing.Point(145, 20);
            this.ExpS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpS2.Name = "ExpS2";
            this.ExpS2.Size = new System.Drawing.Size(64, 21);
            this.ExpS2.TabIndex = 1;
            this.ExpS2.TabStop = true;
            this.ExpS2.Text = "Utarg";
            this.ExpS2.UseVisualStyleBackColor = true;
            // 
            // ExpS1
            // 
            this.ExpS1.AutoSize = true;
            this.ExpS1.Location = new System.Drawing.Point(40, 20);
            this.ExpS1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpS1.Name = "ExpS1";
            this.ExpS1.Size = new System.Drawing.Size(64, 21);
            this.ExpS1.TabIndex = 0;
            this.ExpS1.Text = "Menu";
            this.ExpS1.UseVisualStyleBackColor = true;
            // 
            // getPath
            // 
            this.getPath.Location = new System.Drawing.Point(349, 75);
            this.getPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getPath.Name = "getPath";
            this.getPath.Size = new System.Drawing.Size(247, 46);
            this.getPath.TabIndex = 1;
            this.getPath.Text = "Wygeneruj";
            this.getPath.UseVisualStyleBackColor = true;
            this.getPath.Click += new System.EventHandler(this.getPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Suma";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart1);
            this.groupBox5.Controls.Add(this.uCat5);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.uCat4);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.uCat3);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.uCat2);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.uCat1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.uSum);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(643, 460);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(681, 213);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Podsumowanie";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.chart1.BackImageTransparentColor = System.Drawing.SystemColors.AppWorkspace;
            this.chart1.BackSecondaryColor = System.Drawing.SystemColors.AppWorkspace;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisY.LabelStyle.Format = "C0";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(285, 16);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Dochód";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(388, 190);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // uCat5
            // 
            this.uCat5.Location = new System.Drawing.Point(133, 176);
            this.uCat5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uCat5.Name = "uCat5";
            this.uCat5.ReadOnly = true;
            this.uCat5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uCat5.Size = new System.Drawing.Size(132, 22);
            this.uCat5.TabIndex = 11;
            this.uCat5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "INNE";
            // 
            // uCat4
            // 
            this.uCat4.Location = new System.Drawing.Point(133, 150);
            this.uCat4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uCat4.Name = "uCat4";
            this.uCat4.ReadOnly = true;
            this.uCat4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uCat4.Size = new System.Drawing.Size(132, 22);
            this.uCat4.TabIndex = 9;
            this.uCat4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "FAJKI";
            // 
            // uCat3
            // 
            this.uCat3.Location = new System.Drawing.Point(133, 123);
            this.uCat3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uCat3.Name = "uCat3";
            this.uCat3.ReadOnly = true;
            this.uCat3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uCat3.Size = new System.Drawing.Size(132, 22);
            this.uCat3.TabIndex = 7;
            this.uCat3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "SKLEP";
            // 
            // uCat2
            // 
            this.uCat2.Location = new System.Drawing.Point(133, 96);
            this.uCat2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uCat2.Name = "uCat2";
            this.uCat2.ReadOnly = true;
            this.uCat2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uCat2.Size = new System.Drawing.Size(132, 22);
            this.uCat2.TabIndex = 5;
            this.uCat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "POSIŁKI";
            // 
            // uCat1
            // 
            this.uCat1.Location = new System.Drawing.Point(133, 69);
            this.uCat1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uCat1.Name = "uCat1";
            this.uCat1.ReadOnly = true;
            this.uCat1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uCat1.Size = new System.Drawing.Size(132, 22);
            this.uCat1.TabIndex = 3;
            this.uCat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "HERBATY";
            // 
            // uSum
            // 
            this.uSum.Location = new System.Drawing.Point(133, 27);
            this.uSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uSum.Name = "uSum";
            this.uSum.ReadOnly = true;
            this.uSum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uSum.Size = new System.Drawing.Size(132, 22);
            this.uSum.TabIndex = 1;
            this.uSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // query1BindingSource1
            // 
            this.query1BindingSource1.DataMember = "query1";
            this.query1BindingSource1.DataSource = this.databaseDataSetBindingSource;
            // 
            // table2BindingSource
            // 
            this.table2BindingSource.DataMember = "Table2";
            this.table2BindingSource.DataSource = this.databaseDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SettingsTableAdapter = null;
            this.tableAdapterManager.Table2TableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = LajaProjekt.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // query1TableAdapter
            // 
            this.query1TableAdapter.ClearBeforeFill = true;
            // 
            // table2TableAdapter
            // 
            this.table2TableAdapter.ClearBeforeFill = true;
            // 
            // exp1BindingSource
            // 
            this.exp1BindingSource.DataMember = "Exp1";
            this.exp1BindingSource.DataSource = this.databaseDataSet;
            // 
            // exp1TableAdapter
            // 
            this.exp1TableAdapter.ClearBeforeFill = true;
            // 
            // settingsTableAdapter1
            // 
            this.settingsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 688);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laja Utarg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox kategoriaTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label MenuCount;
        private System.Windows.Forms.Button AddToSales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox AddQuantity;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton d3;
        private System.Windows.Forms.RadioButton d2;
        private System.Windows.Forms.RadioButton d1;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource query1BindingSource;
        private DatabaseDataSetTableAdapters.query1TableAdapter query1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource table2BindingSource;
        private DatabaseDataSetTableAdapters.Table2TableAdapter table2TableAdapter;
        private System.Windows.Forms.DateTimePicker SalesDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton f3;
        private System.Windows.Forms.RadioButton f2;
        private System.Windows.Forms.RadioButton f0;
        private System.Windows.Forms.RadioButton f1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label4;
        private DatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.TextBox uSum;
        private System.Windows.Forms.TextBox uCat1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uCat2;
        private System.Windows.Forms.TextBox uCat5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uCat4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uCat3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource query1BindingSource1;
        private System.Windows.Forms.Label SalesCount;
        private System.Windows.Forms.Button SalesDeleteEntry;
        private System.Windows.Forms.Button getPath;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.BindingSource exp1BindingSource;
        private DatabaseDataSetTableAdapters.Exp1TableAdapter exp1TableAdapter;
        private System.Windows.Forms.RadioButton ExpS2;
        private System.Windows.Forms.RadioButton ExpS1;
        private System.Windows.Forms.CheckBox ExpO1;
        private System.Windows.Forms.CheckBox ExpO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.CheckBox ExpO3;
        private DatabaseDataSetTableAdapters.SettingsTableAdapter settingsTableAdapter1;
    }
}

