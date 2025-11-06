namespace Code_Generator
{
    partial class CodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeGenerator));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.checkBoxAllowNulls = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxColumnName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCopyQurey = new System.Windows.Forms.Button();
            this.labelTableQurey = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCopyStoredProceduresQurey = new System.Windows.Forms.Button();
            this.labelStoredProceduresQurey = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCopyDataAccessScript = new System.Windows.Forms.Button();
            this.labelDataAccessScript = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCopyBusinessLogocScript = new System.Windows.Forms.Button();
            this.labelBusinessLogocScript = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlParent = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBoxExistDataBaseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonNextTabToTablesTab = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDataBaseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonChooseTheFolderDirectory = new System.Windows.Forms.Button();
            this.textBoxFloderDirectory = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelTables = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonSaveQureysAndScriptsToProjectFolder = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControlParent.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(327, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name:";
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxTableName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTableName.Location = new System.Drawing.Point(417, 10);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(388, 22);
            this.textBoxTableName.TabIndex = 4;
            this.textBoxTableName.Validated += new System.EventHandler(this.textBoxTableName_Validated);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(330, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(475, 329);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRow.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAddRow.Location = new System.Drawing.Point(706, 39);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(99, 45);
            this.buttonAddRow.TabIndex = 4;
            this.buttonAddRow.Text = "Add Row";
            this.buttonAddRow.UseVisualStyleBackColor = false;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBoxDataType.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Items.AddRange(new object[] {
            "bit",
            "char(10)",
            "date",
            "datetime",
            "datetime2(7)",
            "float",
            "int",
            "money",
            "nchar(10)",
            "nvarchar(50)",
            "nvarchar(MAX)",
            "smallint",
            "varchar(50)",
            "varchar(100)",
            "varchar(200)",
            "varchar(MAX)"});
            this.comboBoxDataType.Location = new System.Drawing.Point(503, 59);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDataType.TabIndex = 3;
            this.comboBoxDataType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxDataType_Validating);
            this.comboBoxDataType.Validated += new System.EventHandler(this.comboBoxDataType_Validated);
            // 
            // checkBoxAllowNulls
            // 
            this.checkBoxAllowNulls.AutoSize = true;
            this.checkBoxAllowNulls.Checked = true;
            this.checkBoxAllowNulls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllowNulls.Location = new System.Drawing.Point(676, 63);
            this.checkBoxAllowNulls.Name = "checkBoxAllowNulls";
            this.checkBoxAllowNulls.Size = new System.Drawing.Size(18, 17);
            this.checkBoxAllowNulls.TabIndex = 3;
            this.checkBoxAllowNulls.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(500, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data Type";
            // 
            // textBoxColumnName
            // 
            this.textBoxColumnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxColumnName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxColumnName.Location = new System.Drawing.Point(330, 58);
            this.textBoxColumnName.Name = "textBoxColumnName";
            this.textBoxColumnName.Size = new System.Drawing.Size(141, 22);
            this.textBoxColumnName.TabIndex = 2;
            this.textBoxColumnName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxColumnName_Validating);
            this.textBoxColumnName.Validated += new System.EventHandler(this.textBoxColumnName_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(327, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Column Name";
            // 
            // buttonCopyQurey
            // 
            this.buttonCopyQurey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCopyQurey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyQurey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyQurey.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCopyQurey.Location = new System.Drawing.Point(950, 3);
            this.buttonCopyQurey.Name = "buttonCopyQurey";
            this.buttonCopyQurey.Size = new System.Drawing.Size(141, 45);
            this.buttonCopyQurey.TabIndex = 17;
            this.buttonCopyQurey.Text = "Copy";
            this.buttonCopyQurey.UseVisualStyleBackColor = false;
            this.buttonCopyQurey.Click += new System.EventHandler(this.buttonCopyQurey_Click);
            // 
            // labelTableQurey
            // 
            this.labelTableQurey.AllowDrop = true;
            this.labelTableQurey.AutoEllipsis = true;
            this.labelTableQurey.AutoSize = true;
            this.labelTableQurey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelTableQurey.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTableQurey.Location = new System.Drawing.Point(3, 3);
            this.labelTableQurey.Name = "labelTableQurey";
            this.labelTableQurey.Size = new System.Drawing.Size(54, 16);
            this.labelTableQurey.TabIndex = 16;
            this.labelTableQurey.Text = "<Code>";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonCopyQurey);
            this.panel1.Controls.Add(this.labelTableQurey);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 419);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.buttonCopyStoredProceduresQurey);
            this.panel2.Controls.Add(this.labelStoredProceduresQurey);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 419);
            this.panel2.TabIndex = 19;
            // 
            // buttonCopyStoredProceduresQurey
            // 
            this.buttonCopyStoredProceduresQurey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCopyStoredProceduresQurey.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCopyStoredProceduresQurey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyStoredProceduresQurey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyStoredProceduresQurey.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCopyStoredProceduresQurey.Location = new System.Drawing.Point(950, 3);
            this.buttonCopyStoredProceduresQurey.Name = "buttonCopyStoredProceduresQurey";
            this.buttonCopyStoredProceduresQurey.Size = new System.Drawing.Size(141, 45);
            this.buttonCopyStoredProceduresQurey.TabIndex = 20;
            this.buttonCopyStoredProceduresQurey.Text = "Copy";
            this.buttonCopyStoredProceduresQurey.UseVisualStyleBackColor = false;
            this.buttonCopyStoredProceduresQurey.Click += new System.EventHandler(this.buttonCopyStoredProceduresQurey_Click);
            // 
            // labelStoredProceduresQurey
            // 
            this.labelStoredProceduresQurey.AllowDrop = true;
            this.labelStoredProceduresQurey.AutoEllipsis = true;
            this.labelStoredProceduresQurey.AutoSize = true;
            this.labelStoredProceduresQurey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelStoredProceduresQurey.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStoredProceduresQurey.Location = new System.Drawing.Point(3, 3);
            this.labelStoredProceduresQurey.Name = "labelStoredProceduresQurey";
            this.labelStoredProceduresQurey.Size = new System.Drawing.Size(54, 16);
            this.labelStoredProceduresQurey.TabIndex = 16;
            this.labelStoredProceduresQurey.Text = "<Code>";
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.buttonCopyDataAccessScript);
            this.panel3.Controls.Add(this.labelDataAccessScript);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1141, 419);
            this.panel3.TabIndex = 23;
            // 
            // buttonCopyDataAccessScript
            // 
            this.buttonCopyDataAccessScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCopyDataAccessScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyDataAccessScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyDataAccessScript.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCopyDataAccessScript.Location = new System.Drawing.Point(950, 3);
            this.buttonCopyDataAccessScript.Name = "buttonCopyDataAccessScript";
            this.buttonCopyDataAccessScript.Size = new System.Drawing.Size(141, 45);
            this.buttonCopyDataAccessScript.TabIndex = 23;
            this.buttonCopyDataAccessScript.Text = "Copy";
            this.buttonCopyDataAccessScript.UseVisualStyleBackColor = false;
            this.buttonCopyDataAccessScript.Click += new System.EventHandler(this.buttonCopyDataAccessScript_Click);
            // 
            // labelDataAccessScript
            // 
            this.labelDataAccessScript.AllowDrop = true;
            this.labelDataAccessScript.AutoEllipsis = true;
            this.labelDataAccessScript.AutoSize = true;
            this.labelDataAccessScript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelDataAccessScript.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDataAccessScript.Location = new System.Drawing.Point(3, 3);
            this.labelDataAccessScript.Name = "labelDataAccessScript";
            this.labelDataAccessScript.Size = new System.Drawing.Size(54, 16);
            this.labelDataAccessScript.TabIndex = 16;
            this.labelDataAccessScript.Text = "<Code>";
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.buttonCopyBusinessLogocScript);
            this.panel4.Controls.Add(this.labelBusinessLogocScript);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1141, 423);
            this.panel4.TabIndex = 23;
            // 
            // buttonCopyBusinessLogocScript
            // 
            this.buttonCopyBusinessLogocScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCopyBusinessLogocScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyBusinessLogocScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyBusinessLogocScript.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCopyBusinessLogocScript.Location = new System.Drawing.Point(950, 3);
            this.buttonCopyBusinessLogocScript.Name = "buttonCopyBusinessLogocScript";
            this.buttonCopyBusinessLogocScript.Size = new System.Drawing.Size(141, 45);
            this.buttonCopyBusinessLogocScript.TabIndex = 24;
            this.buttonCopyBusinessLogocScript.Text = "Copy";
            this.buttonCopyBusinessLogocScript.UseVisualStyleBackColor = false;
            this.buttonCopyBusinessLogocScript.Click += new System.EventHandler(this.buttonCopyBusinessLogocScript_Click);
            // 
            // labelBusinessLogocScript
            // 
            this.labelBusinessLogocScript.AllowDrop = true;
            this.labelBusinessLogocScript.AutoEllipsis = true;
            this.labelBusinessLogocScript.AutoSize = true;
            this.labelBusinessLogocScript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelBusinessLogocScript.ForeColor = System.Drawing.SystemColors.Window;
            this.labelBusinessLogocScript.Location = new System.Drawing.Point(3, 3);
            this.labelBusinessLogocScript.Name = "labelBusinessLogocScript";
            this.labelBusinessLogocScript.Size = new System.Drawing.Size(54, 16);
            this.labelBusinessLogocScript.TabIndex = 16;
            this.labelBusinessLogocScript.Text = "<Code>";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 21);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1153, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data Table Qurey";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1153, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stored Procedures Qurey";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1153, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Data Access Class Script";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1153, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Business Logic Class Script";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(628, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Allow Nulls";
            // 
            // tabControlParent
            // 
            this.tabControlParent.Controls.Add(this.tabPage5);
            this.tabControlParent.Controls.Add(this.tabPage6);
            this.tabControlParent.Controls.Add(this.tabPage7);
            this.tabControlParent.ItemSize = new System.Drawing.Size(200, 21);
            this.tabControlParent.Location = new System.Drawing.Point(0, 0);
            this.tabControlParent.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlParent.Name = "tabControlParent";
            this.tabControlParent.Padding = new System.Drawing.Point(0, 0);
            this.tabControlParent.SelectedIndex = 0;
            this.tabControlParent.Size = new System.Drawing.Size(1178, 554);
            this.tabControlParent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlParent.TabIndex = 35;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage5.Controls.Add(this.textBoxExistDataBaseName);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.buttonContinue);
            this.tabPage5.Controls.Add(this.buttonNextTabToTablesTab);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.buttonNewProject);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.textBoxDataBaseName);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.buttonChooseTheFolderDirectory);
            this.tabPage5.Controls.Add(this.textBoxFloderDirectory);
            this.tabPage5.ForeColor = System.Drawing.Color.MediumPurple;
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1170, 525);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Project";
            // 
            // textBoxExistDataBaseName
            // 
            this.textBoxExistDataBaseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxExistDataBaseName.Enabled = false;
            this.textBoxExistDataBaseName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxExistDataBaseName.Location = new System.Drawing.Point(14, 222);
            this.textBoxExistDataBaseName.Name = "textBoxExistDataBaseName";
            this.textBoxExistDataBaseName.Size = new System.Drawing.Size(261, 22);
            this.textBoxExistDataBaseName.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(14, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Exist DataBase Name:";
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonContinue.Location = new System.Drawing.Point(996, 458);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(167, 57);
            this.buttonContinue.TabIndex = 41;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonNextTabToTablesTab
            // 
            this.buttonNextTabToTablesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonNextTabToTablesTab.Enabled = false;
            this.buttonNextTabToTablesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextTabToTablesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextTabToTablesTab.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonNextTabToTablesTab.Location = new System.Drawing.Point(181, 458);
            this.buttonNextTabToTablesTab.Name = "buttonNextTabToTablesTab";
            this.buttonNextTabToTablesTab.Size = new System.Drawing.Size(167, 57);
            this.buttonNextTabToTablesTab.TabIndex = 40;
            this.buttonNextTabToTablesTab.Text = "Next";
            this.buttonNextTabToTablesTab.UseVisualStyleBackColor = false;
            this.buttonNextTabToTablesTab.Click += new System.EventHandler(this.buttonNextTabToTablesTab_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 32);
            this.label6.TabIndex = 39;
            this.label6.Text = "Create New Project";
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.BackColor = System.Drawing.SystemColors.Window;
            this.buttonNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewProject.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonNewProject.Location = new System.Drawing.Point(8, 458);
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Size = new System.Drawing.Size(167, 57);
            this.buttonNewProject.TabIndex = 1;
            this.buttonNewProject.Text = "New Project";
            this.buttonNewProject.UseVisualStyleBackColor = false;
            this.buttonNewProject.Click += new System.EventHandler(this.buttonNewProject_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(14, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(355, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Choose project directory or create new project";
            // 
            // textBoxDataBaseName
            // 
            this.textBoxDataBaseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxDataBaseName.Enabled = false;
            this.textBoxDataBaseName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxDataBaseName.Location = new System.Drawing.Point(14, 166);
            this.textBoxDataBaseName.Name = "textBoxDataBaseName";
            this.textBoxDataBaseName.Size = new System.Drawing.Size(261, 22);
            this.textBoxDataBaseName.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(14, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "New DataBase Name:";
            // 
            // buttonChooseTheFolderDirectory
            // 
            this.buttonChooseTheFolderDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonChooseTheFolderDirectory.Enabled = false;
            this.buttonChooseTheFolderDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseTheFolderDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseTheFolderDirectory.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonChooseTheFolderDirectory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChooseTheFolderDirectory.Location = new System.Drawing.Point(420, 107);
            this.buttonChooseTheFolderDirectory.Name = "buttonChooseTheFolderDirectory";
            this.buttonChooseTheFolderDirectory.Size = new System.Drawing.Size(53, 33);
            this.buttonChooseTheFolderDirectory.TabIndex = 198;
            this.buttonChooseTheFolderDirectory.Text = "...";
            this.buttonChooseTheFolderDirectory.UseVisualStyleBackColor = false;
            this.buttonChooseTheFolderDirectory.Click += new System.EventHandler(this.buttonChooseTheFolderDirectory_Click);
            // 
            // textBoxFloderDirectory
            // 
            this.textBoxFloderDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxFloderDirectory.Enabled = false;
            this.textBoxFloderDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFloderDirectory.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFloderDirectory.Location = new System.Drawing.Point(14, 107);
            this.textBoxFloderDirectory.Multiline = true;
            this.textBoxFloderDirectory.Name = "textBoxFloderDirectory";
            this.textBoxFloderDirectory.ReadOnly = true;
            this.textBoxFloderDirectory.Size = new System.Drawing.Size(400, 33);
            this.textBoxFloderDirectory.TabIndex = 24;
            this.textBoxFloderDirectory.Validated += new System.EventHandler(this.textBoxFloderDirectory_Validated);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage6.Controls.Add(this.tabControl3);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1170, 525);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Tables";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.ItemSize = new System.Drawing.Size(200, 21);
            this.tabControl3.Location = new System.Drawing.Point(5, 6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1158, 523);
            this.tabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl3.TabIndex = 30;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage10.Controls.Add(this.buttonAddTable);
            this.tabPage10.Controls.Add(this.textBoxTableName);
            this.tabPage10.Controls.Add(this.dataGridView1);
            this.tabPage10.Controls.Add(this.label1);
            this.tabPage10.Controls.Add(this.label4);
            this.tabPage10.Controls.Add(this.comboBoxDataType);
            this.tabPage10.Controls.Add(this.checkBoxAllowNulls);
            this.tabPage10.Controls.Add(this.textBoxColumnName);
            this.tabPage10.Controls.Add(this.buttonAddRow);
            this.tabPage10.Controls.Add(this.label2);
            this.tabPage10.Controls.Add(this.label3);
            this.tabPage10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1150, 494);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Add Taple";
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTable.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAddTable.Location = new System.Drawing.Point(330, 425);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(475, 45);
            this.buttonAddTable.TabIndex = 13;
            this.buttonAddTable.Text = "Add Table";
            this.buttonAddTable.UseVisualStyleBackColor = false;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage11.Controls.Add(this.flowLayoutPanelTables);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1150, 494);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Tables List";
            // 
            // flowLayoutPanelTables
            // 
            this.flowLayoutPanelTables.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelTables.Name = "flowLayoutPanelTables";
            this.flowLayoutPanelTables.Size = new System.Drawing.Size(1144, 488);
            this.flowLayoutPanelTables.TabIndex = 6;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage7.Controls.Add(this.buttonSaveQureysAndScriptsToProjectFolder);
            this.tabPage7.Controls.Add(this.tabControl1);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1170, 525);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Qureys / Scripts";
            // 
            // buttonSaveQureysAndScriptsToProjectFolder
            // 
            this.buttonSaveQureysAndScriptsToProjectFolder.Enabled = false;
            this.buttonSaveQureysAndScriptsToProjectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveQureysAndScriptsToProjectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveQureysAndScriptsToProjectFolder.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSaveQureysAndScriptsToProjectFolder.Location = new System.Drawing.Point(7, 462);
            this.buttonSaveQureysAndScriptsToProjectFolder.Name = "buttonSaveQureysAndScriptsToProjectFolder";
            this.buttonSaveQureysAndScriptsToProjectFolder.Size = new System.Drawing.Size(497, 54);
            this.buttonSaveQureysAndScriptsToProjectFolder.TabIndex = 24;
            this.buttonSaveQureysAndScriptsToProjectFolder.Text = "Save Qureys And Scripts To Project Folder";
            this.buttonSaveQureysAndScriptsToProjectFolder.UseVisualStyleBackColor = false;
            this.buttonSaveQureysAndScriptsToProjectFolder.Click += new System.EventHandler(this.buttonSaveQureysAndScriptsToProjectFolder_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonClose.Location = new System.Drawing.Point(1128, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 28);
            this.buttonClose.TabIndex = 36;
            this.buttonClose.Text = "X";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.Location = new System.Drawing.Point(920, 1);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 20);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel2.Location = new System.Drawing.Point(1013, 1);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(93, 20);
            this.linkLabel2.TabIndex = 38;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "@Linked In";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // CodeGenerator
            // 
            this.AcceptButton = this.buttonChooseTheFolderDirectory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1180, 555);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControlParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 555);
            this.MinimumSize = new System.Drawing.Size(1180, 555);
            this.Name = "CodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anruki Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControlParent.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.ComboBox comboBoxDataType;
        private System.Windows.Forms.CheckBox checkBoxAllowNulls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxColumnName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button buttonCopyQurey;
        private System.Windows.Forms.Label labelTableQurey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelStoredProceduresQurey;
        private System.Windows.Forms.Button buttonCopyStoredProceduresQurey;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCopyDataAccessScript;
        private System.Windows.Forms.Label labelDataAccessScript;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCopyBusinessLogocScript;
        private System.Windows.Forms.Label labelBusinessLogocScript;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControlParent;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTables;
        private System.Windows.Forms.Button buttonSaveQureysAndScriptsToProjectFolder;
        private System.Windows.Forms.Button buttonChooseTheFolderDirectory;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBoxExistDataBaseName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonNextTabToTablesTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonNewProject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDataBaseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFloderDirectory;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

