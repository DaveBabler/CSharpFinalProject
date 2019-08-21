namespace MadonnaChecker
{
    partial class DataLoading
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataLoading));
            this.dataGridViewCSV = new System.Windows.Forms.DataGridView();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadCSVButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LoadCSVLabel = new System.Windows.Forms.Label();
            this.musicDataSet = new MadonnaChecker.musicDataSet();
            this.tablelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_listTableAdapter = new MadonnaChecker.musicDataSetTableAdapters.table_listTableAdapter();
            this.tablelistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseTablePicker1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseTablePickerLabel1 = new System.Windows.Forms.Label();
            this.generateMatches = new System.Windows.Forms.Button();
            this.updateSQLButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.debugLabel1 = new System.Windows.Forms.Label();
            this.instructions1 = new System.Windows.Forms.Label();
            this.instructions2 = new System.Windows.Forms.Label();
            this.beginMatchGenerator = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.madonnaThrone = new System.Windows.Forms.PictureBox();
            this.gsEroticaPointRightImage = new System.Windows.Forms.PictureBox();
            this.gsEroticaLeftPoint = new System.Windows.Forms.PictureBox();
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            this.loadFinalForm = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelistBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madonnaThrone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsEroticaPointRightImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsEroticaLeftPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCSV
            // 
            this.dataGridViewCSV.AllowUserToAddRows = false;
            this.dataGridViewCSV.AllowUserToDeleteRows = false;
            this.dataGridViewCSV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongName,
            this.Column2,
            this.Album});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCSV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCSV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCSV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewCSV.Location = new System.Drawing.Point(32, 75);
            this.dataGridViewCSV.MultiSelect = false;
            this.dataGridViewCSV.Name = "dataGridViewCSV";
            this.dataGridViewCSV.ReadOnly = true;
            this.dataGridViewCSV.RowHeadersVisible = false;
            this.dataGridViewCSV.Size = new System.Drawing.Size(406, 280);
            this.dataGridViewCSV.TabIndex = 0;
            this.dataGridViewCSV.Visible = false;
            this.dataGridViewCSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCSV_CellContentClick);
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "Title";
            dataGridViewCellStyle1.Format = "mm:ss";
            dataGridViewCellStyle1.NullValue = null;
            this.SongName.DefaultCellStyle = dataGridViewCellStyle1;
            this.SongName.Frozen = true;
            this.SongName.HeaderText = "Song Name";
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            this.SongName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Length";
            dataGridViewCellStyle2.Format = "mm:ss";
            dataGridViewCellStyle2.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Length";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Album
            // 
            this.Album.DataPropertyName = "Album";
            this.Album.Frozen = true;
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Album.Width = 250;
            // 
            // loadCSVButton
            // 
            this.loadCSVButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.loadCSVButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.loadCSVButton.FlatAppearance.BorderSize = 2;
            this.loadCSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadCSVButton.Font = new System.Drawing.Font("Semplicita", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCSVButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.loadCSVButton.Location = new System.Drawing.Point(298, 36);
            this.loadCSVButton.Name = "loadCSVButton";
            this.loadCSVButton.Size = new System.Drawing.Size(144, 34);
            this.loadCSVButton.TabIndex = 1;
            this.loadCSVButton.Text = "Click to Load CSV ";
            this.loadCSVButton.UseVisualStyleBackColor = false;
            this.loadCSVButton.Visible = false;
            this.loadCSVButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Fix these ones!";
            // 
            // LoadCSVLabel
            // 
            this.LoadCSVLabel.AutoSize = true;
            this.LoadCSVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCSVLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.LoadCSVLabel.Location = new System.Drawing.Point(99, 43);
            this.LoadCSVLabel.Name = "LoadCSVLabel";
            this.LoadCSVLabel.Size = new System.Drawing.Size(123, 20);
            this.LoadCSVLabel.TabIndex = 2;
            this.LoadCSVLabel.Text = "Load Backups";
            this.LoadCSVLabel.Visible = false;
            this.LoadCSVLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // musicDataSet
            // 
            this.musicDataSet.DataSetName = "musicDataSet";
            this.musicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablelistBindingSource
            // 
            this.tablelistBindingSource.DataMember = "table_list";
            this.tablelistBindingSource.DataSource = this.musicDataSet;
            // 
            // table_listTableAdapter
            // 
            this.table_listTableAdapter.ClearBeforeFill = true;
            // 
            // tablelistBindingSource1
            // 
            this.tablelistBindingSource1.DataMember = "table_list";
            this.tablelistBindingSource1.DataSource = this.musicDataSet;
            // 
            // databaseTablePicker1
            // 
            this.databaseTablePicker1.BackColor = System.Drawing.SystemColors.GrayText;
            this.databaseTablePicker1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.databaseTablePicker1.Font = new System.Drawing.Font("Semplicita", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseTablePicker1.FormattingEnabled = true;
            this.databaseTablePicker1.Location = new System.Drawing.Point(799, 39);
            this.databaseTablePicker1.Name = "databaseTablePicker1";
            this.databaseTablePicker1.Size = new System.Drawing.Size(232, 29);
            this.databaseTablePicker1.TabIndex = 6;
            this.databaseTablePicker1.Visible = false;
            this.databaseTablePicker1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(798, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(417, 280);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // databaseTablePickerLabel1
            // 
            this.databaseTablePickerLabel1.AutoSize = true;
            this.databaseTablePickerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseTablePickerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.databaseTablePickerLabel1.Location = new System.Drawing.Point(1032, 43);
            this.databaseTablePickerLabel1.Name = "databaseTablePickerLabel1";
            this.databaseTablePickerLabel1.Size = new System.Drawing.Size(190, 20);
            this.databaseTablePickerLabel1.TabIndex = 8;
            this.databaseTablePickerLabel1.Text = "Database Table Picker";
            this.databaseTablePickerLabel1.Visible = false;
            // 
            // generateMatches
            // 
            this.generateMatches.BackColor = System.Drawing.Color.Transparent;
            this.generateMatches.Cursor = System.Windows.Forms.Cursors.Default;
            this.generateMatches.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.generateMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateMatches.Font = new System.Drawing.Font("Semplicita", 12F, System.Drawing.FontStyle.Bold);
            this.generateMatches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(244)))));
            this.generateMatches.Location = new System.Drawing.Point(329, 179);
            this.generateMatches.Name = "generateMatches";
            this.generateMatches.Size = new System.Drawing.Size(106, 58);
            this.generateMatches.TabIndex = 13;
            this.generateMatches.Text = "Generate Matches";
            this.generateMatches.UseVisualStyleBackColor = false;
            this.generateMatches.Visible = false;
            this.generateMatches.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateSQLButton
            // 
            this.updateSQLButton.BackColor = System.Drawing.Color.Transparent;
            this.updateSQLButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateSQLButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.updateSQLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSQLButton.Font = new System.Drawing.Font("Semplicita", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSQLButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(244)))));
            this.updateSQLButton.Location = new System.Drawing.Point(798, 179);
            this.updateSQLButton.Name = "updateSQLButton";
            this.updateSQLButton.Size = new System.Drawing.Size(143, 34);
            this.updateSQLButton.TabIndex = 29;
            this.updateSQLButton.Text = "Approve Fix";
            this.updateSQLButton.UseVisualStyleBackColor = false;
            this.updateSQLButton.Visible = false;
            this.updateSQLButton.Click += new System.EventHandler(this.updateSQLButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(289, 463);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 44);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.checkBox2.Location = new System.Drawing.Point(289, 510);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 44);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.checkBox3.Location = new System.Drawing.Point(289, 557);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(140, 44);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(125, 23);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(19, 11);
            this.grid.TabIndex = 22;
            this.grid.Visible = false;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // debugLabel1
            // 
            this.debugLabel1.AutoSize = true;
            this.debugLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.debugLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.debugLabel1.Location = new System.Drawing.Point(804, 248);
            this.debugLabel1.Name = "debugLabel1";
            this.debugLabel1.Size = new System.Drawing.Size(152, 20);
            this.debugLabel1.TabIndex = 33;
            this.debugLabel1.Text = "debugLabel1.Text";
            this.debugLabel1.Visible = false;
            // 
            // instructions1
            // 
            this.instructions1.AutoSize = true;
            this.instructions1.BackColor = System.Drawing.Color.Transparent;
            this.instructions1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.instructions1.Location = new System.Drawing.Point(32, 357);
            this.instructions1.Name = "instructions1";
            this.instructions1.Size = new System.Drawing.Size(419, 100);
            this.instructions1.TabIndex = 34;
            this.instructions1.Text = "Instructions:\r\n1. Load a CSV value for an Album; \r\n2. Select the Album from the S" +
    "QL list.\r\n3. Carefully review BOTH tables.\r\n3. When Ready, press the Match Gener" +
    "ator button.\r\n";
            this.instructions1.Visible = false;
            this.instructions1.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // instructions2
            // 
            this.instructions2.AutoSize = true;
            this.instructions2.BackColor = System.Drawing.Color.Transparent;
            this.instructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.instructions2.Location = new System.Drawing.Point(868, 357);
            this.instructions2.Name = "instructions2";
            this.instructions2.Size = new System.Drawing.Size(325, 100);
            this.instructions2.TabIndex = 35;
            this.instructions2.Text = "5. Choose the correct matching pair.\r\n6. Press the button to Approve (the) Fix\r\n7" +
    ". Continue repeating steps 3 - 6\r\n    until there are no more matches.\r\n8. Check" +
    " your work.\r\n";
            this.instructions2.Visible = false;
            this.instructions2.Click += new System.EventHandler(this.instructions2_Click);
            // 
            // beginMatchGenerator
            // 
            this.beginMatchGenerator.BackColor = System.Drawing.SystemColors.ControlText;
            this.beginMatchGenerator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.beginMatchGenerator.FlatAppearance.BorderSize = 2;
            this.beginMatchGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginMatchGenerator.Font = new System.Drawing.Font("Semplicita", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginMatchGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.beginMatchGenerator.Location = new System.Drawing.Point(540, 357);
            this.beginMatchGenerator.Name = "beginMatchGenerator";
            this.beginMatchGenerator.Size = new System.Drawing.Size(143, 107);
            this.beginMatchGenerator.TabIndex = 36;
            this.beginMatchGenerator.Text = "Begin \r\nMatch\r\nGenerator";
            this.beginMatchGenerator.UseVisualStyleBackColor = false;
            this.beginMatchGenerator.Visible = false;
            this.beginMatchGenerator.Click += new System.EventHandler(this.beginMatchGenerator_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // madonnaThrone
            // 
            this.madonnaThrone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("madonnaThrone.BackgroundImage")));
            this.madonnaThrone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.madonnaThrone.Location = new System.Drawing.Point(464, 12);
            this.madonnaThrone.Name = "madonnaThrone";
            this.madonnaThrone.Size = new System.Drawing.Size(303, 425);
            this.madonnaThrone.TabIndex = 39;
            this.madonnaThrone.TabStop = false;
            this.madonnaThrone.Visible = false;
            this.madonnaThrone.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gsEroticaPointRightImage
            // 
            this.gsEroticaPointRightImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gsEroticaPointRightImage.BackgroundImage")));
            this.gsEroticaPointRightImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gsEroticaPointRightImage.Location = new System.Drawing.Point(520, 121);
            this.gsEroticaPointRightImage.Name = "gsEroticaPointRightImage";
            this.gsEroticaPointRightImage.Size = new System.Drawing.Size(201, 188);
            this.gsEroticaPointRightImage.TabIndex = 38;
            this.gsEroticaPointRightImage.TabStop = false;
            this.gsEroticaPointRightImage.Visible = false;
            // 
            // gsEroticaLeftPoint
            // 
            this.gsEroticaLeftPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gsEroticaLeftPoint.BackgroundImage")));
            this.gsEroticaLeftPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gsEroticaLeftPoint.Location = new System.Drawing.Point(520, 121);
            this.gsEroticaLeftPoint.Name = "gsEroticaLeftPoint";
            this.gsEroticaLeftPoint.Size = new System.Drawing.Size(201, 188);
            this.gsEroticaLeftPoint.TabIndex = 40;
            this.gsEroticaLeftPoint.TabStop = false;
            this.gsEroticaLeftPoint.Visible = false;
            // 
            // timerAnimate
            // 
            this.timerAnimate.Interval = 1;
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // loadFinalForm
            // 
            this.loadFinalForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.loadFinalForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFinalForm.Font = new System.Drawing.Font("Semplicita", 12F, System.Drawing.FontStyle.Bold);
            this.loadFinalForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(244)))));
            this.loadFinalForm.Location = new System.Drawing.Point(172, 248);
            this.loadFinalForm.Name = "loadFinalForm";
            this.loadFinalForm.Size = new System.Drawing.Size(266, 61);
            this.loadFinalForm.TabIndex = 41;
            this.loadFinalForm.Text = "Done? \r\nCheck your work here.";
            this.loadFinalForm.UseVisualStyleBackColor = true;
            this.loadFinalForm.Visible = false;
            this.loadFinalForm.Click += new System.EventHandler(this.loadFinalForm_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(913, 531);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 43;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // DataLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1235, 632);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.updateSQLButton);
            this.Controls.Add(this.generateMatches);
            this.Controls.Add(this.debugLabel1);
            this.Controls.Add(this.loadFinalForm);
            this.Controls.Add(this.beginMatchGenerator);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.databaseTablePickerLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.databaseTablePicker1);
            this.Controls.Add(this.LoadCSVLabel);
            this.Controls.Add(this.loadCSVButton);
            this.Controls.Add(this.dataGridViewCSV);
            this.Controls.Add(this.gsEroticaLeftPoint);
            this.Controls.Add(this.madonnaThrone);
            this.Controls.Add(this.gsEroticaPointRightImage);
            this.Controls.Add(this.instructions1);
            this.Controls.Add(this.instructions2);
            this.Name = "DataLoading";
            this.Text = "DataLoading";
            this.Load += new System.EventHandler(this.DataLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelistBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madonnaThrone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsEroticaPointRightImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsEroticaLeftPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCSV;
        private System.Windows.Forms.Button loadCSVButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LoadCSVLabel;
        private musicDataSet musicDataSet;
        private System.Windows.Forms.BindingSource tablelistBindingSource;
        private musicDataSetTableAdapters.table_listTableAdapter table_listTableAdapter;
        private System.Windows.Forms.BindingSource tablelistBindingSource1;
        private System.Windows.Forms.ComboBox databaseTablePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label databaseTablePickerLabel1;
        private System.Windows.Forms.Button generateMatches;
        private System.Windows.Forms.Button updateSQLButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label debugLabel1;
        private System.Windows.Forms.Label instructions1;
        private System.Windows.Forms.Label instructions2;
        private System.Windows.Forms.Button beginMatchGenerator;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox madonnaThrone;
        private System.Windows.Forms.PictureBox gsEroticaPointRightImage;
        private System.Windows.Forms.PictureBox gsEroticaLeftPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.Timer timerAnimate;
        private System.Windows.Forms.Button loadFinalForm;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}