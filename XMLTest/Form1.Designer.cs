namespace XMLTest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonConsolidate = new System.Windows.Forms.Button();
            this.buttonWebLoad = new System.Windows.Forms.Button();
            this.buttonFileLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPlayerSumary = new System.Windows.Forms.DataGridView();
            this.buttonSaveConfigs = new System.Windows.Forms.Button();
            this.checkBoxCacheItems = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlayerSumary = new System.Windows.Forms.TabPage();
            this.tabParsedItems = new System.Windows.Forms.TabPage();
            this.dgvParsedItems = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPageCache = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonAddToCache = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dgvCachedItems = new System.Windows.Forms.DataGridView();
            this.tabConfigs = new System.Windows.Forms.TabPage();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGuildInfoGuildBankBanklogsBanklogItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerSumary)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPlayerSumary.SuspendLayout();
            this.tabParsedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParsedItems)).BeginInit();
            this.tabPageCache.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachedItems)).BeginInit();
            this.tabConfigs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageGuildInfoGuildBankBanklogsBanklogItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConsolidate
            // 
            this.buttonConsolidate.Location = new System.Drawing.Point(6, 76);
            this.buttonConsolidate.Name = "buttonConsolidate";
            this.buttonConsolidate.Size = new System.Drawing.Size(75, 23);
            this.buttonConsolidate.TabIndex = 0;
            this.buttonConsolidate.Text = "Consolidate";
            this.buttonConsolidate.UseVisualStyleBackColor = true;
            this.buttonConsolidate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWebLoad
            // 
            this.buttonWebLoad.Location = new System.Drawing.Point(6, 47);
            this.buttonWebLoad.Name = "buttonWebLoad";
            this.buttonWebLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonWebLoad.TabIndex = 1;
            this.buttonWebLoad.Text = "Web";
            this.buttonWebLoad.UseVisualStyleBackColor = true;
            this.buttonWebLoad.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFileLoad
            // 
            this.buttonFileLoad.Location = new System.Drawing.Point(6, 13);
            this.buttonFileLoad.Name = "buttonFileLoad";
            this.buttonFileLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonFileLoad.TabIndex = 2;
            this.buttonFileLoad.Text = "File";
            this.buttonFileLoad.UseVisualStyleBackColor = true;
            this.buttonFileLoad.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.xml";
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Location = new System.Drawing.Point(6, 105);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveXML.TabIndex = 6;
            this.buttonSaveXML.Text = "Save XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.button4_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "*.xml";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // dgvPlayerSumary
            // 
            this.dgvPlayerSumary.AllowUserToOrderColumns = true;
            this.dgvPlayerSumary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerSumary.Location = new System.Drawing.Point(6, 180);
            this.dgvPlayerSumary.Name = "dgvPlayerSumary";
            this.dgvPlayerSumary.Size = new System.Drawing.Size(796, 331);
            this.dgvPlayerSumary.TabIndex = 11;
            // 
            // buttonSaveConfigs
            // 
            this.buttonSaveConfigs.Location = new System.Drawing.Point(35, 55);
            this.buttonSaveConfigs.Name = "buttonSaveConfigs";
            this.buttonSaveConfigs.Size = new System.Drawing.Size(88, 23);
            this.buttonSaveConfigs.TabIndex = 15;
            this.buttonSaveConfigs.Text = "Save Configs";
            this.buttonSaveConfigs.UseVisualStyleBackColor = true;
            this.buttonSaveConfigs.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBoxCacheItems
            // 
            this.checkBoxCacheItems.AutoSize = true;
            this.checkBoxCacheItems.Location = new System.Drawing.Point(6, 134);
            this.checkBoxCacheItems.Name = "checkBoxCacheItems";
            this.checkBoxCacheItems.Size = new System.Drawing.Size(99, 17);
            this.checkBoxCacheItems.TabIndex = 17;
            this.checkBoxCacheItems.Text = "Cache All Items";
            this.checkBoxCacheItems.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlayerSumary);
            this.tabControl1.Controls.Add(this.tabParsedItems);
            this.tabControl1.Controls.Add(this.tabPageCache);
            this.tabControl1.Controls.Add(this.tabConfigs);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 543);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPlayerSumary
            // 
            this.tabPlayerSumary.Controls.Add(this.dgvPlayerSumary);
            this.tabPlayerSumary.Controls.Add(this.checkBoxCacheItems);
            this.tabPlayerSumary.Controls.Add(this.label3);
            this.tabPlayerSumary.Controls.Add(this.buttonFileLoad);
            this.tabPlayerSumary.Controls.Add(this.label2);
            this.tabPlayerSumary.Controls.Add(this.label1);
            this.tabPlayerSumary.Controls.Add(this.buttonWebLoad);
            this.tabPlayerSumary.Controls.Add(this.buttonConsolidate);
            this.tabPlayerSumary.Controls.Add(this.buttonSaveXML);
            this.tabPlayerSumary.Location = new System.Drawing.Point(4, 22);
            this.tabPlayerSumary.Name = "tabPlayerSumary";
            this.tabPlayerSumary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayerSumary.Size = new System.Drawing.Size(808, 517);
            this.tabPlayerSumary.TabIndex = 0;
            this.tabPlayerSumary.Text = "Guild Analyzer";
            this.tabPlayerSumary.UseVisualStyleBackColor = true;
            // 
            // tabParsedItems
            // 
            this.tabParsedItems.Controls.Add(this.dgvParsedItems);
            this.tabParsedItems.Location = new System.Drawing.Point(4, 22);
            this.tabParsedItems.Name = "tabParsedItems";
            this.tabParsedItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabParsedItems.Size = new System.Drawing.Size(808, 517);
            this.tabParsedItems.TabIndex = 1;
            this.tabParsedItems.Text = "New Items";
            this.tabParsedItems.UseVisualStyleBackColor = true;
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
            this.dgvParsedItems.Location = new System.Drawing.Point(6, 6);
            this.dgvParsedItems.Name = "dgvParsedItems";
            this.dgvParsedItems.Size = new System.Drawing.Size(796, 306);
            this.dgvParsedItems.TabIndex = 12;
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            // 
            // Link
            // 
            dataGridViewCellStyle2.NullValue = "wowhead";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.Link.DefaultCellStyle = dataGridViewCellStyle2;
            this.Link.HeaderText = "Link";
            this.Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Link.Name = "Link";
            this.Link.Text = "wowhead";
            // 
            // tabPageCache
            // 
            this.tabPageCache.Controls.Add(this.groupBox1);
            this.tabPageCache.Controls.Add(this.dgvCachedItems);
            this.tabPageCache.Location = new System.Drawing.Point(4, 22);
            this.tabPageCache.Name = "tabPageCache";
            this.tabPageCache.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCache.Size = new System.Drawing.Size(808, 517);
            this.tabPageCache.TabIndex = 2;
            this.tabPageCache.Text = "Cache";
            this.tabPageCache.UseVisualStyleBackColor = true;
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
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(323, 307);
            this.webBrowser1.TabIndex = 4;
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
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(482, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 2;
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
            // tabConfigs
            // 
            this.tabConfigs.Controls.Add(this.buttonSaveConfigs);
            this.tabConfigs.Location = new System.Drawing.Point(4, 22);
            this.tabConfigs.Name = "tabConfigs";
            this.tabConfigs.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigs.Size = new System.Drawing.Size(808, 517);
            this.tabConfigs.TabIndex = 3;
            this.tabConfigs.Text = "Configuration";
            this.tabConfigs.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // qiDataGridViewTextBoxColumn
            // 
            this.qiDataGridViewTextBoxColumn.DataPropertyName = "qi";
            this.qiDataGridViewTextBoxColumn.HeaderText = "Item Quality";
            this.qiDataGridViewTextBoxColumn.Name = "qiDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // subtypeDataGridViewTextBoxColumn
            // 
            this.subtypeDataGridViewTextBoxColumn.DataPropertyName = "subtype";
            this.subtypeDataGridViewTextBoxColumn.HeaderText = "subtype";
            this.subtypeDataGridViewTextBoxColumn.Name = "subtypeDataGridViewTextBoxColumn";
            // 
            // pageGuildInfoGuildBankBanklogsBanklogItemBindingSource
            // 
            this.pageGuildInfoGuildBankBanklogsBanklogItemBindingSource.DataSource = typeof(pageGuildInfoGuildBankBanklogsBanklogItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Guild Bank Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerSumary)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPlayerSumary.ResumeLayout(false);
            this.tabPlayerSumary.PerformLayout();
            this.tabParsedItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParsedItems)).EndInit();
            this.tabPageCache.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachedItems)).EndInit();
            this.tabConfigs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageGuildInfoGuildBankBanklogsBanklogItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConsolidate;
        private System.Windows.Forms.Button buttonWebLoad;
        private System.Windows.Forms.Button buttonFileLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPlayerSumary;
        private System.Windows.Forms.Button buttonSaveConfigs;
        private System.Windows.Forms.CheckBox checkBoxCacheItems;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPlayerSumary;
        private System.Windows.Forms.TabPage tabParsedItems;
        private System.Windows.Forms.DataGridView dgvParsedItems;
        private System.Windows.Forms.TabPage tabPageCache;
        private System.Windows.Forms.DataGridView dgvCachedItems;
        private System.Windows.Forms.BindingSource pageGuildInfoGuildBankBanklogsBanklogItemBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAddToCache;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabConfigs;
    }
}

