namespace GuildBank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageGuildInfoGuildBankBanklogsBanklogItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabConfigs = new System.Windows.Forms.TabPage();
            this.buttonSaveConfigs = new System.Windows.Forms.Button();
            this.tabPageCache = new System.Windows.Forms.TabPage();
            this.dgvCachedItems = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAddToCache = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPageGuildBank = new System.Windows.Forms.TabPage();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.buttonCompileSelected = new System.Windows.Forms.Button();
            this.buttonFileLoad = new System.Windows.Forms.Button();
            this.checkBoxCacheItems = new System.Windows.Forms.CheckBox();
            this.tabControlGuildBank = new System.Windows.Forms.TabControl();
            this.tabPageNewItems = new System.Windows.Forms.TabPage();
            this.dgvParsedItems = new System.Windows.Forms.DataGridView();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.subtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPagePlayerSummary = new System.Windows.Forms.TabPage();
            this.dgvPlayerSumary = new System.Windows.Forms.DataGridView();
            this.tabPageLogList = new System.Windows.Forms.TabPage();
            this.dgvLogList = new System.Windows.Forms.DataGridView();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageGuildInfoGuildBankBanklogsBanklogItemBindingSource)).BeginInit();
            this.tabConfigs.SuspendLayout();
            this.tabPageCache.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachedItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageGuildBank.SuspendLayout();
            this.tabControlGuildBank.SuspendLayout();
            this.tabPageNewItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParsedItems)).BeginInit();
            this.tabPagePlayerSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerSumary)).BeginInit();
            this.tabPageLogList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "*.xml";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadFromFileToolStripMenuItem.Text = "Load Bank Log";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.LoadFileEvent_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Save File";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.SaveLogEvent_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileSelectedToolStripMenuItem,
            this.eraseSelectedToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // compileSelectedToolStripMenuItem
            // 
            this.compileSelectedToolStripMenuItem.Name = "compileSelectedToolStripMenuItem";
            this.compileSelectedToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.compileSelectedToolStripMenuItem.Text = "Compile Selected";
            this.compileSelectedToolStripMenuItem.Click += new System.EventHandler(this.CompileSelectedEvent_Click);
            // 
            // eraseSelectedToolStripMenuItem
            // 
            this.eraseSelectedToolStripMenuItem.Name = "eraseSelectedToolStripMenuItem";
            this.eraseSelectedToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.eraseSelectedToolStripMenuItem.Text = "Erase Selected";
            // 
            // pageGuildInfoGuildBankBanklogsBanklogItemBindingSource
            // 
            this.pageGuildInfoGuildBankBanklogsBanklogItemBindingSource.DataSource = typeof(BanklogItem);
            // 
            // tabConfigs
            // 
            this.tabConfigs.Controls.Add(this.buttonSaveConfigs);
            this.tabConfigs.Location = new System.Drawing.Point(4, 22);
            this.tabConfigs.Name = "tabConfigs";
            this.tabConfigs.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigs.Size = new System.Drawing.Size(808, 502);
            this.tabConfigs.TabIndex = 3;
            this.tabConfigs.Text = "Configuration";
            this.tabConfigs.UseVisualStyleBackColor = true;
            // 
            // buttonSaveConfigs
            // 
            this.buttonSaveConfigs.Location = new System.Drawing.Point(6, 173);
            this.buttonSaveConfigs.Name = "buttonSaveConfigs";
            this.buttonSaveConfigs.Size = new System.Drawing.Size(88, 23);
            this.buttonSaveConfigs.TabIndex = 15;
            this.buttonSaveConfigs.Text = "Save Configs";
            this.buttonSaveConfigs.UseVisualStyleBackColor = true;
            this.buttonSaveConfigs.Click += new System.EventHandler(this.buttonSaveConfigs_Click);
            // 
            // tabPageCache
            // 
            this.tabPageCache.Controls.Add(this.groupBox1);
            this.tabPageCache.Controls.Add(this.dgvCachedItems);
            this.tabPageCache.Location = new System.Drawing.Point(4, 22);
            this.tabPageCache.Name = "tabPageCache";
            this.tabPageCache.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCache.Size = new System.Drawing.Size(808, 502);
            this.tabPageCache.TabIndex = 2;
            this.tabPageCache.Text = "Cache";
            this.tabPageCache.UseVisualStyleBackColor = true;
            // 
            // dgvCachedItems
            // 
            this.dgvCachedItems.AllowUserToAddRows = false;
            this.dgvCachedItems.AllowUserToDeleteRows = false;
            this.dgvCachedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCachedItems.Location = new System.Drawing.Point(7, 6);
            this.dgvCachedItems.Name = "dgvCachedItems";
            this.dgvCachedItems.ReadOnly = true;
            this.dgvCachedItems.Size = new System.Drawing.Size(795, 113);
            this.dgvCachedItems.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Controls.Add(this.buttonAddToCache);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Location = new System.Drawing.Point(7, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(588, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(482, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonAddToCache
            // 
            this.buttonAddToCache.Location = new System.Drawing.Point(588, 49);
            this.buttonAddToCache.Name = "buttonAddToCache";
            this.buttonAddToCache.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToCache.TabIndex = 3;
            this.buttonAddToCache.Text = "Add";
            this.buttonAddToCache.UseVisualStyleBackColor = true;
            this.buttonAddToCache.Click += new System.EventHandler(this.buttonAddToCache_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(323, 307);
            this.webBrowser1.TabIndex = 4;
            // 
            // tabPageGuildBank
            // 
            this.tabPageGuildBank.Controls.Add(this.tabControlGuildBank);
            this.tabPageGuildBank.Controls.Add(this.checkBoxCacheItems);
            this.tabPageGuildBank.Controls.Add(this.buttonFileLoad);
            this.tabPageGuildBank.Controls.Add(this.buttonCompileSelected);
            this.tabPageGuildBank.Controls.Add(this.buttonSaveXML);
            this.tabPageGuildBank.Location = new System.Drawing.Point(4, 22);
            this.tabPageGuildBank.Name = "tabPageGuildBank";
            this.tabPageGuildBank.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuildBank.Size = new System.Drawing.Size(808, 502);
            this.tabPageGuildBank.TabIndex = 0;
            this.tabPageGuildBank.Text = "page Analyzer";
            this.tabPageGuildBank.UseVisualStyleBackColor = true;
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Location = new System.Drawing.Point(191, 13);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveXML.TabIndex = 6;
            this.buttonSaveXML.Text = "Save XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.SaveLogEvent_Click);
            // 
            // buttonCompileSelected
            // 
            this.buttonCompileSelected.AutoSize = true;
            this.buttonCompileSelected.Location = new System.Drawing.Point(87, 13);
            this.buttonCompileSelected.Name = "buttonCompileSelected";
            this.buttonCompileSelected.Size = new System.Drawing.Size(99, 23);
            this.buttonCompileSelected.TabIndex = 0;
            this.buttonCompileSelected.Text = "Compile Selected";
            this.buttonCompileSelected.UseVisualStyleBackColor = true;
            this.buttonCompileSelected.Click += new System.EventHandler(this.CompileSelectedEvent_Click);
            // 
            // buttonFileLoad
            // 
            this.buttonFileLoad.Location = new System.Drawing.Point(6, 13);
            this.buttonFileLoad.Name = "buttonFileLoad";
            this.buttonFileLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonFileLoad.TabIndex = 2;
            this.buttonFileLoad.Text = "Load File";
            this.buttonFileLoad.UseVisualStyleBackColor = true;
            this.buttonFileLoad.Click += new System.EventHandler(this.LoadFileEvent_Click);
            // 
            // checkBoxCacheItems
            // 
            this.checkBoxCacheItems.AutoSize = true;
            this.checkBoxCacheItems.Location = new System.Drawing.Point(6, 42);
            this.checkBoxCacheItems.Name = "checkBoxCacheItems";
            this.checkBoxCacheItems.Size = new System.Drawing.Size(99, 17);
            this.checkBoxCacheItems.TabIndex = 17;
            this.checkBoxCacheItems.Text = "Cache All Items";
            this.checkBoxCacheItems.UseVisualStyleBackColor = true;
            this.checkBoxCacheItems.CheckedChanged += new System.EventHandler(this.checkBoxCacheItems_CheckedChanged);
            // 
            // tabControlGuildBank
            // 
            this.tabControlGuildBank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlGuildBank.Controls.Add(this.tabPageLogList);
            this.tabControlGuildBank.Controls.Add(this.tabPagePlayerSummary);
            this.tabControlGuildBank.Controls.Add(this.tabPageNewItems);
            this.tabControlGuildBank.Location = new System.Drawing.Point(6, 70);
            this.tabControlGuildBank.Name = "tabControlGuildBank";
            this.tabControlGuildBank.SelectedIndex = 0;
            this.tabControlGuildBank.Size = new System.Drawing.Size(796, 426);
            this.tabControlGuildBank.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlGuildBank.TabIndex = 2;
            // 
            // tabPageNewItems
            // 
            this.tabPageNewItems.Controls.Add(this.dgvParsedItems);
            this.tabPageNewItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewItems.Name = "tabPageNewItems";
            this.tabPageNewItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewItems.Size = new System.Drawing.Size(788, 400);
            this.tabPageNewItems.TabIndex = 2;
            this.tabPageNewItems.Text = "Items";
            this.tabPageNewItems.UseVisualStyleBackColor = true;
            // 
            // dgvParsedItems
            // 
            this.dgvParsedItems.AutoGenerateColumns = false;
            this.dgvParsedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParsedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.qiDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.subtypeDataGridViewTextBoxColumn,
            this.Link});
            this.dgvParsedItems.DataSource = this.pageGuildInfoGuildBankBanklogsBanklogItemBindingSource;
            this.dgvParsedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParsedItems.Location = new System.Drawing.Point(3, 3);
            this.dgvParsedItems.Name = "dgvParsedItems";
            this.dgvParsedItems.Size = new System.Drawing.Size(782, 394);
            this.dgvParsedItems.TabIndex = 12;
            // 
            // Link
            // 
            this.Link.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = "wowhead";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.Link.DefaultCellStyle = dataGridViewCellStyle1;
            this.Link.HeaderText = "Link";
            this.Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Link.Name = "Link";
            this.Link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Link.Text = "wowhead";
            // 
            // subtypeDataGridViewTextBoxColumn
            // 
            this.subtypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subtypeDataGridViewTextBoxColumn.DataPropertyName = "subtype";
            this.subtypeDataGridViewTextBoxColumn.HeaderText = "subtype";
            this.subtypeDataGridViewTextBoxColumn.Name = "subtypeDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // qiDataGridViewTextBoxColumn
            // 
            this.qiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qiDataGridViewTextBoxColumn.DataPropertyName = "qi";
            this.qiDataGridViewTextBoxColumn.HeaderText = "Item Quality";
            this.qiDataGridViewTextBoxColumn.Name = "qiDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPagePlayerSummary
            // 
            this.tabPagePlayerSummary.Controls.Add(this.dgvPlayerSumary);
            this.tabPagePlayerSummary.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayerSummary.Name = "tabPagePlayerSummary";
            this.tabPagePlayerSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayerSummary.Size = new System.Drawing.Size(788, 400);
            this.tabPagePlayerSummary.TabIndex = 1;
            this.tabPagePlayerSummary.Text = "Player Summary";
            this.tabPagePlayerSummary.UseVisualStyleBackColor = true;
            // 
            // dgvPlayerSumary
            // 
            this.dgvPlayerSumary.AllowUserToOrderColumns = true;
            this.dgvPlayerSumary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerSumary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlayerSumary.Location = new System.Drawing.Point(3, 3);
            this.dgvPlayerSumary.Name = "dgvPlayerSumary";
            this.dgvPlayerSumary.Size = new System.Drawing.Size(782, 394);
            this.dgvPlayerSumary.TabIndex = 11;
            // 
            // tabPageLogList
            // 
            this.tabPageLogList.Controls.Add(this.dgvLogList);
            this.tabPageLogList.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogList.Name = "tabPageLogList";
            this.tabPageLogList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogList.Size = new System.Drawing.Size(788, 400);
            this.tabPageLogList.TabIndex = 0;
            this.tabPageLogList.Text = "Bank Logs";
            this.tabPageLogList.UseVisualStyleBackColor = true;
            // 
            // dgvLogList
            // 
            this.dgvLogList.AllowUserToAddRows = false;
            this.dgvLogList.AllowUserToDeleteRows = false;
            this.dgvLogList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheckBox,
            this.ColumnFrom,
            this.ColumnTo,
            this.ColumnCount});
            this.dgvLogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogList.Location = new System.Drawing.Point(3, 3);
            this.dgvLogList.Name = "dgvLogList";
            this.dgvLogList.Size = new System.Drawing.Size(782, 394);
            this.dgvLogList.TabIndex = 1;
            // 
            // ColumnCount
            // 
            this.ColumnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCount.HeaderText = "Transaction Count";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            // 
            // ColumnTo
            // 
            this.ColumnTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTo.HeaderText = "To";
            this.ColumnTo.Name = "ColumnTo";
            this.ColumnTo.ReadOnly = true;
            // 
            // ColumnFrom
            // 
            this.ColumnFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFrom.HeaderText = "From";
            this.ColumnFrom.Name = "ColumnFrom";
            this.ColumnFrom.ReadOnly = true;
            // 
            // ColumnCheckBox
            // 
            this.ColumnCheckBox.HeaderText = "";
            this.ColumnCheckBox.Name = "ColumnCheckBox";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageGuildBank);
            this.tabControl1.Controls.Add(this.tabPageCache);
            this.tabControl1.Controls.Add(this.tabConfigs);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 528);
            this.tabControl1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(840, 558);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "page Bank Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageGuildInfoGuildBankBanklogsBanklogItemBindingSource)).EndInit();
            this.tabConfigs.ResumeLayout(false);
            this.tabPageCache.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachedItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageGuildBank.ResumeLayout(false);
            this.tabPageGuildBank.PerformLayout();
            this.tabControlGuildBank.ResumeLayout(false);
            this.tabPageNewItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParsedItems)).EndInit();
            this.tabPagePlayerSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerSumary)).EndInit();
            this.tabPageLogList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource pageGuildInfoGuildBankBanklogsBanklogItemBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseSelectedToolStripMenuItem;
        private System.Windows.Forms.TabPage tabConfigs;
        private System.Windows.Forms.Button buttonSaveConfigs;
        private System.Windows.Forms.TabPage tabPageCache;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonAddToCache;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dgvCachedItems;
        private System.Windows.Forms.TabPage tabPageGuildBank;
        private System.Windows.Forms.TabControl tabControlGuildBank;
        private System.Windows.Forms.TabPage tabPageLogList;
        private System.Windows.Forms.DataGridView dgvLogList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.TabPage tabPagePlayerSummary;
        private System.Windows.Forms.DataGridView dgvPlayerSumary;
        private System.Windows.Forms.TabPage tabPageNewItems;
        private System.Windows.Forms.DataGridView dgvParsedItems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.CheckBox checkBoxCacheItems;
        private System.Windows.Forms.Button buttonFileLoad;
        private System.Windows.Forms.Button buttonCompileSelected;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

