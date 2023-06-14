namespace DailyCashDeposite.Screens
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.insertButton = new System.Windows.Forms.Button();
            this.refreshGridButton = new System.Windows.Forms.Button();
            this.importedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.companyCodeTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.cashDepositeLable = new System.Windows.Forms.Label();
            this.depositGrid = new System.Windows.Forms.DataGridView();
            this.deleteGrid = new System.Windows.Forms.Button();
            this.updateGridButton = new System.Windows.Forms.Button();
            this.bodyContainer = new System.Windows.Forms.SplitContainer();
            this.entryTxtbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.offsetCombobox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.closePanal1Button = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.depositdatepicker = new System.Windows.Forms.DateTimePicker();
            this.transtotaltxtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.credittxtbox = new System.Windows.Forms.TextBox();
            this.debittxtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buntxtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.descriptiontxtbox = new System.Windows.Forms.TextBox();
            this.periodpostingtxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.journalTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.navBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyContainer)).BeginInit();
            this.bodyContainer.Panel1.SuspendLayout();
            this.bodyContainer.Panel2.SuspendLayout();
            this.bodyContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.CadetBlue;
            this.navBar.CanOverflow = false;
            this.navBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.navBar.GripMargin = new System.Windows.Forms.Padding(6);
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.navBar.Name = "navBar";
            this.navBar.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.navBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.navBar.Size = new System.Drawing.Size(1682, 43);
            this.navBar.TabIndex = 1;
            this.navBar.Text = "NavBar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(74, 26);
            this.toolStripButton1.Text = "Deposit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(134, 26);
            this.toolStripButton2.Text = "Company Setting";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(64, 26);
            this.toolStripButton3.Text = "Setup";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.insertButton);
            this.panel1.Controls.Add(this.refreshGridButton);
            this.panel1.Controls.Add(this.importedDatePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.companyCodeTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.transactionDatePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.importButton);
            this.panel1.Controls.Add(this.cashDepositeLable);
            this.panel1.Location = new System.Drawing.Point(13, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1657, 95);
            this.panel1.TabIndex = 3;
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.AutoSize = true;
            this.insertButton.BackColor = System.Drawing.Color.LimeGreen;
            this.insertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Image = ((System.Drawing.Image)(resources.GetObject("insertButton.Image")));
            this.insertButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertButton.Location = new System.Drawing.Point(1223, 56);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(141, 32);
            this.insertButton.TabIndex = 5;
            this.insertButton.Text = "Insert Record";
            this.insertButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.insertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // refreshGridButton
            // 
            this.refreshGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshGridButton.AutoSize = true;
            this.refreshGridButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.refreshGridButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshGridButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshGridButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshGridButton.Image")));
            this.refreshGridButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshGridButton.Location = new System.Drawing.Point(1366, 56);
            this.refreshGridButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshGridButton.Name = "refreshGridButton";
            this.refreshGridButton.Size = new System.Drawing.Size(141, 32);
            this.refreshGridButton.TabIndex = 26;
            this.refreshGridButton.Text = "Refresh Grid";
            this.refreshGridButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.refreshGridButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.refreshGridButton.UseVisualStyleBackColor = false;
            this.refreshGridButton.Click += new System.EventHandler(this.refreshGridButton_Click);
            // 
            // importedDatePicker
            // 
            this.importedDatePicker.CalendarFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importedDatePicker.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importedDatePicker.Location = new System.Drawing.Point(773, 59);
            this.importedDatePicker.Name = "importedDatePicker";
            this.importedDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.importedDatePicker.Size = new System.Drawing.Size(248, 27);
            this.importedDatePicker.TabIndex = 4;
            this.importedDatePicker.CloseUp += new System.EventHandler(this.importedDatePicker_CloseUp);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Imported Date";
            // 
            // companyCodeTextbox
            // 
            this.companyCodeTextbox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyCodeTextbox.Location = new System.Drawing.Point(520, 59);
            this.companyCodeTextbox.Name = "companyCodeTextbox";
            this.companyCodeTextbox.Size = new System.Drawing.Size(129, 27);
            this.companyCodeTextbox.TabIndex = 3;
            this.companyCodeTextbox.TextChanged += new System.EventHandler(this.companyCodeTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Company Code";
            // 
            // transactionDatePicker
            // 
            this.transactionDatePicker.CalendarFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDatePicker.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDatePicker.Location = new System.Drawing.Point(143, 58);
            this.transactionDatePicker.Name = "transactionDatePicker";
            this.transactionDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transactionDatePicker.Size = new System.Drawing.Size(250, 27);
            this.transactionDatePicker.TabIndex = 2;
            this.transactionDatePicker.CloseUp += new System.EventHandler(this.transactionDatePicker_CloseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Transaction Date";
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.Color.Black;
            this.line.Location = new System.Drawing.Point(-1, 48);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1657, 1);
            this.line.TabIndex = 14;
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.BackColor = System.Drawing.Color.GreenYellow;
            this.importButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importButton.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Image = ((System.Drawing.Image)(resources.GetObject("importButton.Image")));
            this.importButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importButton.Location = new System.Drawing.Point(1510, 56);
            this.importButton.Margin = new System.Windows.Forms.Padding(4);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(141, 31);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import";
            this.importButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.importButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // cashDepositeLable
            // 
            this.cashDepositeLable.AutoSize = true;
            this.cashDepositeLable.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashDepositeLable.Location = new System.Drawing.Point(11, 7);
            this.cashDepositeLable.Name = "cashDepositeLable";
            this.cashDepositeLable.Size = new System.Drawing.Size(109, 37);
            this.cashDepositeLable.TabIndex = 0;
            this.cashDepositeLable.Text = "Deposite";
            // 
            // depositGrid
            // 
            this.depositGrid.AllowUserToAddRows = false;
            this.depositGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depositGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depositGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depositGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.depositGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.depositGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.depositGrid.Location = new System.Drawing.Point(-1, -1);
            this.depositGrid.Name = "depositGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depositGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.depositGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositGrid.Size = new System.Drawing.Size(1657, 446);
            this.depositGrid.TabIndex = 15;
            this.depositGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.depositGrid_CellValueChanged);
            // 
            // deleteGrid
            // 
            this.deleteGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.deleteGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteGrid.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGrid.Location = new System.Drawing.Point(1529, 691);
            this.deleteGrid.Margin = new System.Windows.Forms.Padding(4);
            this.deleteGrid.Name = "deleteGrid";
            this.deleteGrid.Size = new System.Drawing.Size(141, 48);
            this.deleteGrid.TabIndex = 17;
            this.deleteGrid.Text = "Delete ";
            this.deleteGrid.UseVisualStyleBackColor = false;
            this.deleteGrid.Click += new System.EventHandler(this.deleteGrid_Click);
            // 
            // updateGridButton
            // 
            this.updateGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateGridButton.BackColor = System.Drawing.Color.SkyBlue;
            this.updateGridButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateGridButton.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGridButton.Location = new System.Drawing.Point(1380, 691);
            this.updateGridButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateGridButton.Name = "updateGridButton";
            this.updateGridButton.Size = new System.Drawing.Size(141, 48);
            this.updateGridButton.TabIndex = 16;
            this.updateGridButton.Text = "Update";
            this.updateGridButton.UseVisualStyleBackColor = false;
            this.updateGridButton.Click += new System.EventHandler(this.updateGridButton_Click);
            // 
            // bodyContainer
            // 
            this.bodyContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.bodyContainer.IsSplitterFixed = true;
            this.bodyContainer.Location = new System.Drawing.Point(13, 149);
            this.bodyContainer.Name = "bodyContainer";
            this.bodyContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // bodyContainer.Panel1
            // 
            this.bodyContainer.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.bodyContainer.Panel1.Controls.Add(this.clearButton);
            this.bodyContainer.Panel1.Controls.Add(this.entryTxtbox);
            this.bodyContainer.Panel1.Controls.Add(this.label12);
            this.bodyContainer.Panel1.Controls.Add(this.offsetCombobox);
            this.bodyContainer.Panel1.Controls.Add(this.label14);
            this.bodyContainer.Panel1.Controls.Add(this.closePanal1Button);
            this.bodyContainer.Panel1.Controls.Add(this.addButton);
            this.bodyContainer.Panel1.Controls.Add(this.depositdatepicker);
            this.bodyContainer.Panel1.Controls.Add(this.transtotaltxtbox);
            this.bodyContainer.Panel1.Controls.Add(this.label11);
            this.bodyContainer.Panel1.Controls.Add(this.credittxtbox);
            this.bodyContainer.Panel1.Controls.Add(this.debittxtbox);
            this.bodyContainer.Panel1.Controls.Add(this.label10);
            this.bodyContainer.Panel1.Controls.Add(this.label9);
            this.bodyContainer.Panel1.Controls.Add(this.buntxtbox);
            this.bodyContainer.Panel1.Controls.Add(this.label8);
            this.bodyContainer.Panel1.Controls.Add(this.descriptiontxtbox);
            this.bodyContainer.Panel1.Controls.Add(this.periodpostingtxtbox);
            this.bodyContainer.Panel1.Controls.Add(this.label6);
            this.bodyContainer.Panel1.Controls.Add(this.label7);
            this.bodyContainer.Panel1.Controls.Add(this.journalTxtbox);
            this.bodyContainer.Panel1.Controls.Add(this.label5);
            this.bodyContainer.Panel1.Controls.Add(this.label4);
            // 
            // bodyContainer.Panel2
            // 
            this.bodyContainer.Panel2.Controls.Add(this.depositGrid);
            this.bodyContainer.Size = new System.Drawing.Size(1657, 535);
            this.bodyContainer.SplitterDistance = 85;
            this.bodyContainer.TabIndex = 13;
            // 
            // entryTxtbox
            // 
            this.entryTxtbox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryTxtbox.Location = new System.Drawing.Point(284, 8);
            this.entryTxtbox.Name = "entryTxtbox";
            this.entryTxtbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.entryTxtbox.Size = new System.Drawing.Size(120, 27);
            this.entryTxtbox.TabIndex = 7;
            this.entryTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entryTxtbox_KeyPress);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(235, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 24);
            this.label12.TabIndex = 48;
            this.label12.Text = "Entry";
            // 
            // offsetCombobox
            // 
            this.offsetCombobox.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offsetCombobox.FormattingEnabled = true;
            this.offsetCombobox.Location = new System.Drawing.Point(595, 47);
            this.offsetCombobox.MaxLength = 20;
            this.offsetCombobox.Name = "offsetCombobox";
            this.offsetCombobox.Size = new System.Drawing.Size(153, 27);
            this.offsetCombobox.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(470, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 24);
            this.label14.TabIndex = 47;
            this.label14.Text = "Offset GL Account";
            // 
            // closePanal1Button
            // 
            this.closePanal1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePanal1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closePanal1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePanal1Button.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closePanal1Button.Image = ((System.Drawing.Image)(resources.GetObject("closePanal1Button.Image")));
            this.closePanal1Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closePanal1Button.Location = new System.Drawing.Point(1366, 6);
            this.closePanal1Button.Margin = new System.Windows.Forms.Padding(4);
            this.closePanal1Button.Name = "closePanal1Button";
            this.closePanal1Button.Size = new System.Drawing.Size(141, 32);
            this.closePanal1Button.TabIndex = 28;
            this.closePanal1Button.Text = "Close ";
            this.closePanal1Button.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.closePanal1Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.closePanal1Button.UseVisualStyleBackColor = false;
            this.closePanal1Button.Click += new System.EventHandler(this.closePanal1Button_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.PaleGreen;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(1510, 6);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 33);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // depositdatepicker
            // 
            this.depositdatepicker.CalendarFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositdatepicker.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.depositdatepicker.Location = new System.Drawing.Point(510, 8);
            this.depositdatepicker.Name = "depositdatepicker";
            this.depositdatepicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.depositdatepicker.Size = new System.Drawing.Size(129, 27);
            this.depositdatepicker.TabIndex = 8;
            // 
            // transtotaltxtbox
            // 
            this.transtotaltxtbox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transtotaltxtbox.Location = new System.Drawing.Point(1064, 8);
            this.transtotaltxtbox.Name = "transtotaltxtbox";
            this.transtotaltxtbox.ReadOnly = true;
            this.transtotaltxtbox.Size = new System.Drawing.Size(129, 27);
            this.transtotaltxtbox.TabIndex = 42;
            this.transtotaltxtbox.Text = "0.00";
            this.transtotaltxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(938, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 41;
            this.label11.Text = "Transaction Total";
            // 
            // credittxtbox
            // 
            this.credittxtbox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credittxtbox.Location = new System.Drawing.Point(1004, 47);
            this.credittxtbox.Name = "credittxtbox";
            this.credittxtbox.Size = new System.Drawing.Size(129, 27);
            this.credittxtbox.TabIndex = 14;
            this.credittxtbox.Text = "0.00";
            this.credittxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.credittxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.credittxtbox_KeyPress);
            this.credittxtbox.Leave += new System.EventHandler(this.credittxtbox_Leave);
            // 
            // debittxtbox
            // 
            this.debittxtbox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debittxtbox.Location = new System.Drawing.Point(813, 47);
            this.debittxtbox.Name = "debittxtbox";
            this.debittxtbox.Size = new System.Drawing.Size(129, 27);
            this.debittxtbox.TabIndex = 13;
            this.debittxtbox.Text = "0.00";
            this.debittxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.debittxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debittxtbox_KeyPress);
            this.debittxtbox.Leave += new System.EventHandler(this.debittxtbox_Leave);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(950, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Credit";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(759, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Debit";
            // 
            // buntxtbox
            // 
            this.buntxtbox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buntxtbox.Location = new System.Drawing.Point(346, 47);
            this.buntxtbox.Name = "buntxtbox";
            this.buntxtbox.Size = new System.Drawing.Size(118, 27);
            this.buntxtbox.TabIndex = 11;
            this.buntxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buntxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buntxtbox_KeyPress);
            this.buntxtbox.Leave += new System.EventHandler(this.buntxtbox_Leave);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "BUN";
            // 
            // descriptiontxtbox
            // 
            this.descriptiontxtbox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontxtbox.Location = new System.Drawing.Point(100, 47);
            this.descriptiontxtbox.MaxLength = 20;
            this.descriptiontxtbox.Name = "descriptiontxtbox";
            this.descriptiontxtbox.Size = new System.Drawing.Size(195, 27);
            this.descriptiontxtbox.TabIndex = 10;
            this.descriptiontxtbox.Text = "Bank Deposit";
            // 
            // periodpostingtxtbox
            // 
            this.periodpostingtxtbox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodpostingtxtbox.Location = new System.Drawing.Point(794, 8);
            this.periodpostingtxtbox.Name = "periodpostingtxtbox";
            this.periodpostingtxtbox.Size = new System.Drawing.Size(129, 27);
            this.periodpostingtxtbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Period Posting Date";
            // 
            // journalTxtbox
            // 
            this.journalTxtbox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journalTxtbox.Location = new System.Drawing.Point(100, 8);
            this.journalTxtbox.MaxLength = 2;
            this.journalTxtbox.Name = "journalTxtbox";
            this.journalTxtbox.Size = new System.Drawing.Size(129, 27);
            this.journalTxtbox.TabIndex = 6;
            this.journalTxtbox.Text = "99";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Deposit Date";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Journal";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearButton.Location = new System.Drawing.Point(1222, 6);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(141, 32);
            this.clearButton.TabIndex = 49;
            this.clearButton.Text = "Clear";
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1682, 746);
            this.Controls.Add(this.bodyContainer);
            this.Controls.Add(this.deleteGrid);
            this.Controls.Add(this.updateGridButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositGrid)).EndInit();
            this.bodyContainer.Panel1.ResumeLayout(false);
            this.bodyContainer.Panel1.PerformLayout();
            this.bodyContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bodyContainer)).EndInit();
            this.bodyContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cashDepositeLable;
        private System.Windows.Forms.DataGridView depositGrid;
        private System.Windows.Forms.Button deleteGrid;
        private System.Windows.Forms.Button updateGridButton;
        private System.Windows.Forms.Button importButton;
        public System.Windows.Forms.ToolStrip navBar;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker transactionDatePicker;
        private System.Windows.Forms.TextBox companyCodeTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker importedDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button refreshGridButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.SplitContainer bodyContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptiontxtbox;
        private System.Windows.Forms.TextBox periodpostingtxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox journalTxtbox;
        private System.Windows.Forms.TextBox buntxtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox credittxtbox;
        private System.Windows.Forms.TextBox debittxtbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox transtotaltxtbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker depositdatepicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closePanal1Button;
        private System.Windows.Forms.ComboBox offsetCombobox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox entryTxtbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button clearButton;
    }
}