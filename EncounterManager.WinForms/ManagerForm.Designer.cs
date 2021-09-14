namespace EncounterManager
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this._addBtn = new System.Windows.Forms.Button();
            this._updateBtn = new System.Windows.Forms.Button();
            this._delBtn = new System.Windows.Forms.Button();
            this._nextTurnBtn = new System.Windows.Forms.Button();
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEncounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveEncounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._loadEncounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._addEncounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._encounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._rollInitiativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rollAsGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._resetInitiativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._resetHitPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._dataGridViewManager = new System.Windows.Forms.DataGridView();
            this.turnBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CurrIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniBonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._slideUpBtn = new System.Windows.Forms.Button();
            this._slideDownBtn = new System.Windows.Forms.Button();
            this._rollInitiativeBtn = new System.Windows.Forms.Button();
            this._copyBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnResetHp = new System.Windows.Forms.Button();
            this._mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _addBtn
            // 
            this._addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addBtn.Location = new System.Drawing.Point(24, 842);
            this._addBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this._addBtn.Name = "_addBtn";
            this._addBtn.Size = new System.Drawing.Size(149, 45);
            this._addBtn.TabIndex = 0;
            this._addBtn.Text = "Add";
            this._addBtn.UseVisualStyleBackColor = true;
            this._addBtn.Click += new System.EventHandler(this._addBtn_Click);
            // 
            // _updateBtn
            // 
            this._updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._updateBtn.Location = new System.Drawing.Point(187, 842);
            this._updateBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this._updateBtn.Name = "_updateBtn";
            this._updateBtn.Size = new System.Drawing.Size(149, 45);
            this._updateBtn.TabIndex = 1;
            this._updateBtn.Text = "Update";
            this._updateBtn.UseVisualStyleBackColor = true;
            this._updateBtn.Click += new System.EventHandler(this._updateBtn_Click);
            // 
            // _delBtn
            // 
            this._delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._delBtn.Location = new System.Drawing.Point(509, 842);
            this._delBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this._delBtn.Name = "_delBtn";
            this._delBtn.Size = new System.Drawing.Size(149, 45);
            this._delBtn.TabIndex = 2;
            this._delBtn.Text = "Delete";
            this._delBtn.UseVisualStyleBackColor = true;
            this._delBtn.Click += new System.EventHandler(this._delBtn_Click);
            // 
            // _nextTurnBtn
            // 
            this._nextTurnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._nextTurnBtn.Location = new System.Drawing.Point(1445, 842);
            this._nextTurnBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this._nextTurnBtn.Name = "_nextTurnBtn";
            this._nextTurnBtn.Size = new System.Drawing.Size(213, 45);
            this._nextTurnBtn.TabIndex = 3;
            this._nextTurnBtn.Text = "Next Turn";
            this._nextTurnBtn.UseVisualStyleBackColor = true;
            this._nextTurnBtn.Click += new System.EventHandler(this._nextTurnBtn_Click);
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this._mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._encounterToolStripMenuItem,
            this._characterToolStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Padding = new System.Windows.Forms.Padding(11, 5, 0, 5);
            this._mainMenuStrip.Size = new System.Drawing.Size(1904, 60);
            this._mainMenuStrip.TabIndex = 4;
            this._mainMenuStrip.Text = "menuStrip1";
            this._mainMenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this._mainMenuStrip_MouseDown);
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEncounterToolStripMenuItem,
            this._saveEncounterToolStripMenuItem,
            this._loadEncounterToolStripMenuItem,
            this._addEncounterToolStripMenuItem,
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(87, 50);
            this._fileToolStripMenuItem.Text = "&File";
            // 
            // newEncounterToolStripMenuItem
            // 
            this.newEncounterToolStripMenuItem.Name = "newEncounterToolStripMenuItem";
            this.newEncounterToolStripMenuItem.Size = new System.Drawing.Size(413, 54);
            this.newEncounterToolStripMenuItem.Text = "&New Encounter";
            this.newEncounterToolStripMenuItem.Click += new System.EventHandler(this._newEncounterToolStripMenuItem_Click);
            // 
            // _saveEncounterToolStripMenuItem
            // 
            this._saveEncounterToolStripMenuItem.Name = "_saveEncounterToolStripMenuItem";
            this._saveEncounterToolStripMenuItem.Size = new System.Drawing.Size(413, 54);
            this._saveEncounterToolStripMenuItem.Text = "&Save Encounter";
            this._saveEncounterToolStripMenuItem.Click += new System.EventHandler(this._saveEncounterToolStripMenuItem_Click);
            // 
            // _loadEncounterToolStripMenuItem
            // 
            this._loadEncounterToolStripMenuItem.Name = "_loadEncounterToolStripMenuItem";
            this._loadEncounterToolStripMenuItem.Size = new System.Drawing.Size(413, 54);
            this._loadEncounterToolStripMenuItem.Text = "&Load Encounter";
            this._loadEncounterToolStripMenuItem.Click += new System.EventHandler(this._loadEncounterToolStripMenuItem_Click);
            // 
            // _addEncounterToolStripMenuItem
            // 
            this._addEncounterToolStripMenuItem.Name = "_addEncounterToolStripMenuItem";
            this._addEncounterToolStripMenuItem.Size = new System.Drawing.Size(413, 54);
            this._addEncounterToolStripMenuItem.Text = "&Merge Encounter";
            this._addEncounterToolStripMenuItem.Click += new System.EventHandler(this._mergeEncounterToolStripMenuItem_Click);
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(413, 54);
            this._exitToolStripMenuItem.Text = "E&xit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this._exitToolStripMenuItem_Click);
            // 
            // _encounterToolStripMenuItem
            // 
            this._encounterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._rollInitiativeToolStripMenuItem,
            this.rollAsGroupToolStripMenuItem,
            this._resetInitiativeToolStripMenuItem,
            this._resetHitPointsToolStripMenuItem});
            this._encounterToolStripMenuItem.Name = "_encounterToolStripMenuItem";
            this._encounterToolStripMenuItem.Size = new System.Drawing.Size(176, 50);
            this._encounterToolStripMenuItem.Text = "&Encounter";
            // 
            // _rollInitiativeToolStripMenuItem
            // 
            this._rollInitiativeToolStripMenuItem.Name = "_rollInitiativeToolStripMenuItem";
            this._rollInitiativeToolStripMenuItem.Size = new System.Drawing.Size(424, 54);
            this._rollInitiativeToolStripMenuItem.Text = "Roll Only Selected";
            this._rollInitiativeToolStripMenuItem.Click += new System.EventHandler(this._rollSelectedInitiativeToolStripMenuItem_Click);
            // 
            // rollAsGroupToolStripMenuItem
            // 
            this.rollAsGroupToolStripMenuItem.Name = "rollAsGroupToolStripMenuItem";
            this.rollAsGroupToolStripMenuItem.Size = new System.Drawing.Size(424, 54);
            this.rollAsGroupToolStripMenuItem.Text = "Roll As Group";
            this.rollAsGroupToolStripMenuItem.Click += new System.EventHandler(this.rollAsGroupToolStripMenuItem_Click);
            // 
            // _resetInitiativeToolStripMenuItem
            // 
            this._resetInitiativeToolStripMenuItem.Name = "_resetInitiativeToolStripMenuItem";
            this._resetInitiativeToolStripMenuItem.Size = new System.Drawing.Size(424, 54);
            this._resetInitiativeToolStripMenuItem.Text = "&Reset Initiative";
            this._resetInitiativeToolStripMenuItem.Click += new System.EventHandler(this._resetInitiativeToolStripMenuItem_Click);
            // 
            // _resetHitPointsToolStripMenuItem
            // 
            this._resetHitPointsToolStripMenuItem.Name = "_resetHitPointsToolStripMenuItem";
            this._resetHitPointsToolStripMenuItem.Size = new System.Drawing.Size(424, 54);
            this._resetHitPointsToolStripMenuItem.Text = "Reset &Hit Points";
            this._resetHitPointsToolStripMenuItem.Click += new System.EventHandler(this._resetHitPointsToolStripMenuItem_Click);
            // 
            // _characterToolStripMenuItem
            // 
            this._characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addToolStripMenuItem,
            this._updateToolStripMenuItem,
            this.copySelectedToolStripMenuItem,
            this._deleteToolStripMenuItem});
            this._characterToolStripMenuItem.Name = "_characterToolStripMenuItem";
            this._characterToolStripMenuItem.Size = new System.Drawing.Size(168, 50);
            this._characterToolStripMenuItem.Text = "&Character";
            // 
            // _addToolStripMenuItem
            // 
            this._addToolStripMenuItem.Name = "_addToolStripMenuItem";
            this._addToolStripMenuItem.Size = new System.Drawing.Size(403, 54);
            this._addToolStripMenuItem.Text = "&Add New";
            this._addToolStripMenuItem.Click += new System.EventHandler(this._addToolStripMenuItem_Click);
            // 
            // _updateToolStripMenuItem
            // 
            this._updateToolStripMenuItem.Name = "_updateToolStripMenuItem";
            this._updateToolStripMenuItem.Size = new System.Drawing.Size(403, 54);
            this._updateToolStripMenuItem.Text = "&Update Selected";
            this._updateToolStripMenuItem.Click += new System.EventHandler(this._updateToolStripMenuItem_Click);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(403, 54);
            this.copySelectedToolStripMenuItem.Text = "Copy Selected";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // _deleteToolStripMenuItem
            // 
            this._deleteToolStripMenuItem.Name = "_deleteToolStripMenuItem";
            this._deleteToolStripMenuItem.Size = new System.Drawing.Size(403, 54);
            this._deleteToolStripMenuItem.Text = "&Delete Selected";
            this._deleteToolStripMenuItem.Click += new System.EventHandler(this._deleteToolStripMenuItem_Click);
            // 
            // _dataGridViewManager
            // 
            this._dataGridViewManager.AllowDrop = true;
            this._dataGridViewManager.AllowUserToAddRows = false;
            this._dataGridViewManager.AllowUserToDeleteRows = false;
            this._dataGridViewManager.AllowUserToOrderColumns = true;
            this._dataGridViewManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridViewManager.AutoGenerateColumns = false;
            this._dataGridViewManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._dataGridViewManager.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridViewManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turnBox,
            this.CurrIni,
            this.nameDataGridViewTextBoxColumn,
            this.iniBonusDataGridViewTextBoxColumn,
            this.MaxHP,
            this.CurrHP,
            this.AC,
            this.notesBox});
            this._dataGridViewManager.DataSource = this.characterBindingSource;
            this._dataGridViewManager.Location = new System.Drawing.Point(24, 60);
            this._dataGridViewManager.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this._dataGridViewManager.Name = "_dataGridViewManager";
            this._dataGridViewManager.RowHeadersVisible = false;
            this._dataGridViewManager.RowHeadersWidth = 82;
            this._dataGridViewManager.RowTemplate.Height = 24;
            this._dataGridViewManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewManager.Size = new System.Drawing.Size(1856, 768);
            this._dataGridViewManager.TabIndex = 5;
            this._dataGridViewManager.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._dataGridViewManager_CellMouseDoubleClick);
            this._dataGridViewManager.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._dataGridViewManager_ColumnHeaderMouseClick);
            this._dataGridViewManager.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this._dataGridViewManager_DataError);
            this._dataGridViewManager.DragDrop += new System.Windows.Forms.DragEventHandler(this._dataGridViewManager_DragDrop);
            this._dataGridViewManager.DragOver += new System.Windows.Forms.DragEventHandler(this._dataGridViewManager_DragOver);
            this._dataGridViewManager.KeyDown += new System.Windows.Forms.KeyEventHandler(this._dataGridViewManager_KeyDown);
            this._dataGridViewManager.MouseDown += new System.Windows.Forms.MouseEventHandler(this._dataGridViewManager_MouseDown);
            this._dataGridViewManager.MouseMove += new System.Windows.Forms.MouseEventHandler(this._dataGridViewManager_MouseMove);
            // 
            // turnBox
            // 
            this.turnBox.Frozen = true;
            this.turnBox.HeaderText = "Turn";
            this.turnBox.MinimumWidth = 10;
            this.turnBox.Name = "turnBox";
            this.turnBox.ReadOnly = true;
            this.turnBox.Width = 76;
            // 
            // CurrIni
            // 
            this.CurrIni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CurrIni.DataPropertyName = "CurrIni";
            this.CurrIni.HeaderText = "Initiative";
            this.CurrIni.MinimumWidth = 10;
            this.CurrIni.Name = "CurrIni";
            this.CurrIni.Visible = false;
            this.CurrIni.Width = 250;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 140;
            // 
            // iniBonusDataGridViewTextBoxColumn
            // 
            this.iniBonusDataGridViewTextBoxColumn.DataPropertyName = "IniBonus";
            this.iniBonusDataGridViewTextBoxColumn.HeaderText = "Initiative";
            this.iniBonusDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iniBonusDataGridViewTextBoxColumn.Name = "iniBonusDataGridViewTextBoxColumn";
            this.iniBonusDataGridViewTextBoxColumn.Width = 169;
            // 
            // MaxHP
            // 
            this.MaxHP.DataPropertyName = "MaxHP";
            this.MaxHP.HeaderText = "Max HP";
            this.MaxHP.MinimumWidth = 10;
            this.MaxHP.Name = "MaxHP";
            this.MaxHP.Width = 163;
            // 
            // CurrHP
            // 
            this.CurrHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CurrHP.DataPropertyName = "CurrHP";
            this.CurrHP.HeaderText = "HP";
            this.CurrHP.MinimumWidth = 10;
            this.CurrHP.Name = "CurrHP";
            this.CurrHP.Width = 106;
            // 
            // AC
            // 
            this.AC.DataPropertyName = "AC";
            this.AC.HeaderText = "AC";
            this.AC.MinimumWidth = 10;
            this.AC.Name = "AC";
            this.AC.Width = 106;
            // 
            // notesBox
            // 
            this.notesBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesBox.DataPropertyName = "Notes";
            this.notesBox.HeaderText = "Notes";
            this.notesBox.MinimumWidth = 10;
            this.notesBox.Name = "notesBox";
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(EncounterManager.Data.Character);
            // 
            // _slideUpBtn
            // 
            this._slideUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._slideUpBtn.Location = new System.Drawing.Point(776, 842);
            this._slideUpBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this._slideUpBtn.Name = "_slideUpBtn";
            this._slideUpBtn.Size = new System.Drawing.Size(213, 45);
            this._slideUpBtn.TabIndex = 6;
            this._slideUpBtn.Text = "Slide Up";
            this._slideUpBtn.UseVisualStyleBackColor = true;
            this._slideUpBtn.Click += new System.EventHandler(this._slideUpBtn_Click);
            // 
            // _slideDownBtn
            // 
            this._slideDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._slideDownBtn.Location = new System.Drawing.Point(1005, 842);
            this._slideDownBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this._slideDownBtn.Name = "_slideDownBtn";
            this._slideDownBtn.Size = new System.Drawing.Size(213, 45);
            this._slideDownBtn.TabIndex = 7;
            this._slideDownBtn.Text = "Slide Down";
            this._slideDownBtn.UseVisualStyleBackColor = true;
            this._slideDownBtn.Click += new System.EventHandler(this._slideDownBtn_Click);
            // 
            // _rollInitiativeBtn
            // 
            this._rollInitiativeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._rollInitiativeBtn.Location = new System.Drawing.Point(1669, 842);
            this._rollInitiativeBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this._rollInitiativeBtn.Name = "_rollInitiativeBtn";
            this._rollInitiativeBtn.Size = new System.Drawing.Size(213, 45);
            this._rollInitiativeBtn.TabIndex = 8;
            this._rollInitiativeBtn.Text = "Roll Initiative!";
            this._rollInitiativeBtn.UseVisualStyleBackColor = true;
            this._rollInitiativeBtn.Click += new System.EventHandler(this._rollInitiativeBtn_Click);
            // 
            // _copyBtn
            // 
            this._copyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._copyBtn.Location = new System.Drawing.Point(347, 842);
            this._copyBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this._copyBtn.Name = "_copyBtn";
            this._copyBtn.Size = new System.Drawing.Size(149, 45);
            this._copyBtn.TabIndex = 9;
            this._copyBtn.Text = "Copy";
            this._copyBtn.UseVisualStyleBackColor = true;
            this._copyBtn.Click += new System.EventHandler(this._copyBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnResetHp
            // 
            this.btnResetHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetHp.Location = new System.Drawing.Point(1232, 842);
            this.btnResetHp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnResetHp.Name = "btnResetHp";
            this.btnResetHp.Size = new System.Drawing.Size(200, 45);
            this.btnResetHp.TabIndex = 10;
            this.btnResetHp.Text = "Reset Hp";
            this.btnResetHp.UseVisualStyleBackColor = true;
            this.btnResetHp.Click += new System.EventHandler(this.btnResetHp_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 909);
            this.Controls.Add(this.btnResetHp);
            this.Controls.Add(this._copyBtn);
            this.Controls.Add(this._rollInitiativeBtn);
            this.Controls.Add(this._slideDownBtn);
            this.Controls.Add(this._slideUpBtn);
            this.Controls.Add(this._dataGridViewManager);
            this.Controls.Add(this._nextTurnBtn);
            this.Controls.Add(this._delBtn);
            this.Controls.Add(this._updateBtn);
            this.Controls.Add(this._addBtn);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimumSize = new System.Drawing.Size(1685, 827);
            this.Name = "Manager";
            this.Text = "Encounter Manager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Manager_MouseDown);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _addBtn;
        private System.Windows.Forms.Button _updateBtn;
        private System.Windows.Forms.Button _delBtn;
        private System.Windows.Forms.Button _nextTurnBtn;
        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _addEncounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _saveEncounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _loadEncounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _encounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _rollInitiativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _resetInitiativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _resetHitPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView _dataGridViewManager;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private System.Windows.Forms.ToolStripMenuItem newEncounterToolStripMenuItem;
        private System.Windows.Forms.Button _slideUpBtn;
        private System.Windows.Forms.Button _slideDownBtn;
        private System.Windows.Forms.Button _rollInitiativeBtn;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.Button _copyBtn;
        private System.Windows.Forms.ToolStripMenuItem rollAsGroupToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewCheckBoxColumn turnBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniBonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AC;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesBox;
        private System.Windows.Forms.Button btnResetHp;
    }
}

