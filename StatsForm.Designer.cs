namespace Yahtzee
{
    partial class StatsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statsTabControl = new System.Windows.Forms.TabControl();
            this.gameHistoryTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gameDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scorecardListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreTotalsTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scoringDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollsDataGridView = new System.Windows.Forms.DataGridView();
            this.rollTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fivesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sixesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.resetStatsButton = new System.Windows.Forms.Button();
            this.statsTabControl.SuspendLayout();
            this.gameHistoryTab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.scoreTotalsTab.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoringDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statsTabControl
            // 
            this.statsTabControl.Controls.Add(this.gameHistoryTab);
            this.statsTabControl.Controls.Add(this.scoreTotalsTab);
            this.statsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsTabControl.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTabControl.Location = new System.Drawing.Point(0, 0);
            this.statsTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statsTabControl.Multiline = true;
            this.statsTabControl.Name = "statsTabControl";
            this.statsTabControl.SelectedIndex = 0;
            this.statsTabControl.Size = new System.Drawing.Size(839, 669);
            this.statsTabControl.TabIndex = 0;
            // 
            // gameHistoryTab
            // 
            this.gameHistoryTab.BackColor = System.Drawing.Color.Maroon;
            this.gameHistoryTab.Controls.Add(this.panel2);
            this.gameHistoryTab.Controls.Add(this.panel1);
            this.gameHistoryTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameHistoryTab.Location = new System.Drawing.Point(4, 40);
            this.gameHistoryTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gameHistoryTab.Name = "gameHistoryTab";
            this.gameHistoryTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gameHistoryTab.Size = new System.Drawing.Size(831, 625);
            this.gameHistoryTab.TabIndex = 0;
            this.gameHistoryTab.Text = "Game History";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.gameDataGridView);
            this.panel2.Location = new System.Drawing.Point(22, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 607);
            this.panel2.TabIndex = 4;
            // 
            // gameDataGridView
            // 
            this.gameDataGridView.AllowUserToAddRows = false;
            this.gameDataGridView.AllowUserToDeleteRows = false;
            this.gameDataGridView.AllowUserToResizeColumns = false;
            this.gameDataGridView.AllowUserToResizeRows = false;
            this.gameDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gameDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gameDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gameDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.gameDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameDataGridView.Location = new System.Drawing.Point(15, 12);
            this.gameDataGridView.Name = "gameDataGridView";
            this.gameDataGridView.ReadOnly = true;
            this.gameDataGridView.RowHeadersVisible = false;
            this.gameDataGridView.RowHeadersWidth = 40;
            this.gameDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.gameDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gameDataGridView.RowTemplate.Height = 24;
            this.gameDataGridView.RowTemplate.ReadOnly = true;
            this.gameDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gameDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gameDataGridView.ShowCellErrors = false;
            this.gameDataGridView.ShowCellToolTips = false;
            this.gameDataGridView.ShowEditingIcon = false;
            this.gameDataGridView.ShowRowErrors = false;
            this.gameDataGridView.Size = new System.Drawing.Size(392, 581);
            this.gameDataGridView.TabIndex = 5;
            this.gameDataGridView.SelectionChanged += new System.EventHandler(this.gameDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Game";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Date";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn6.Width = 115;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Time";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn8.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn8.Width = 135;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.scorecardListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(476, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 519);
            this.panel1.TabIndex = 3;
            // 
            // scorecardListBox
            // 
            this.scorecardListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scorecardListBox.FormattingEnabled = true;
            this.scorecardListBox.ItemHeight = 31;
            this.scorecardListBox.Location = new System.Drawing.Point(40, 92);
            this.scorecardListBox.Name = "scorecardListBox";
            this.scorecardListBox.Size = new System.Drawing.Size(257, 405);
            this.scorecardListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click on Any Game Listed to View the Scorecard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreTotalsTab
            // 
            this.scoreTotalsTab.BackColor = System.Drawing.Color.Maroon;
            this.scoreTotalsTab.Controls.Add(this.panel3);
            this.scoreTotalsTab.Location = new System.Drawing.Point(4, 40);
            this.scoreTotalsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreTotalsTab.Name = "scoreTotalsTab";
            this.scoreTotalsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreTotalsTab.Size = new System.Drawing.Size(831, 625);
            this.scoreTotalsTab.TabIndex = 1;
            this.scoreTotalsTab.Text = "Score and Roll Totals";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.scoringDataGridView);
            this.panel3.Controls.Add(this.rollsDataGridView);
            this.panel3.Location = new System.Drawing.Point(68, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 581);
            this.panel3.TabIndex = 4;
            // 
            // scoringDataGridView
            // 
            this.scoringDataGridView.AllowUserToAddRows = false;
            this.scoringDataGridView.AllowUserToDeleteRows = false;
            this.scoringDataGridView.AllowUserToResizeColumns = false;
            this.scoringDataGridView.AllowUserToResizeRows = false;
            this.scoringDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.scoringDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scoringDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.scoringDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoringDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scoringDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.scoringDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.scoringDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoringDataGridView.Location = new System.Drawing.Point(12, 3);
            this.scoringDataGridView.Name = "scoringDataGridView";
            this.scoringDataGridView.ReadOnly = true;
            this.scoringDataGridView.RowHeadersVisible = false;
            this.scoringDataGridView.RowHeadersWidth = 40;
            this.scoringDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoringDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.scoringDataGridView.RowTemplate.Height = 24;
            this.scoringDataGridView.RowTemplate.ReadOnly = true;
            this.scoringDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scoringDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.scoringDataGridView.ShowCellErrors = false;
            this.scoringDataGridView.ShowCellToolTips = false;
            this.scoringDataGridView.ShowEditingIcon = false;
            this.scoringDataGridView.ShowRowErrors = false;
            this.scoringDataGridView.Size = new System.Drawing.Size(660, 395);
            this.scoringDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Score Type";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Times Scored";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn2.Width = 133;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn3.Width = 133;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.HeaderText = "Average Score Per Game";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn4.Width = 235;
            // 
            // rollsDataGridView
            // 
            this.rollsDataGridView.AllowUserToAddRows = false;
            this.rollsDataGridView.AllowUserToDeleteRows = false;
            this.rollsDataGridView.AllowUserToResizeColumns = false;
            this.rollsDataGridView.AllowUserToResizeRows = false;
            this.rollsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.rollsDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rollsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.rollsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rollsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollTypeColumn,
            this.acesColumn,
            this.twosColumn,
            this.threesColumn,
            this.foursColumn,
            this.fivesColumn,
            this.sixesColumn});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rollsDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.rollsDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rollsDataGridView.Location = new System.Drawing.Point(12, 423);
            this.rollsDataGridView.Name = "rollsDataGridView";
            this.rollsDataGridView.ReadOnly = true;
            this.rollsDataGridView.RowHeadersVisible = false;
            this.rollsDataGridView.RowHeadersWidth = 40;
            this.rollsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rollsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.rollsDataGridView.RowTemplate.Height = 24;
            this.rollsDataGridView.RowTemplate.ReadOnly = true;
            this.rollsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rollsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.rollsDataGridView.ShowCellErrors = false;
            this.rollsDataGridView.ShowCellToolTips = false;
            this.rollsDataGridView.ShowEditingIcon = false;
            this.rollsDataGridView.ShowRowErrors = false;
            this.rollsDataGridView.Size = new System.Drawing.Size(660, 155);
            this.rollsDataGridView.TabIndex = 4;
            // 
            // rollTypeColumn
            // 
            this.rollTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.rollTypeColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.rollTypeColumn.Frozen = true;
            this.rollTypeColumn.HeaderText = "Roll Type:";
            this.rollTypeColumn.MinimumWidth = 6;
            this.rollTypeColumn.Name = "rollTypeColumn";
            this.rollTypeColumn.ReadOnly = true;
            this.rollTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rollTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rollTypeColumn.Width = 287;
            // 
            // acesColumn
            // 
            this.acesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.acesColumn.Frozen = true;
            this.acesColumn.HeaderText = "Aces";
            this.acesColumn.MinimumWidth = 6;
            this.acesColumn.Name = "acesColumn";
            this.acesColumn.ReadOnly = true;
            this.acesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.acesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.acesColumn.Width = 60;
            // 
            // twosColumn
            // 
            this.twosColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.twosColumn.Frozen = true;
            this.twosColumn.HeaderText = "Twos";
            this.twosColumn.MinimumWidth = 6;
            this.twosColumn.Name = "twosColumn";
            this.twosColumn.ReadOnly = true;
            this.twosColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.twosColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.twosColumn.Width = 60;
            // 
            // threesColumn
            // 
            this.threesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.threesColumn.HeaderText = "Threes";
            this.threesColumn.MinimumWidth = 6;
            this.threesColumn.Name = "threesColumn";
            this.threesColumn.ReadOnly = true;
            this.threesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.threesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.threesColumn.Width = 70;
            // 
            // foursColumn
            // 
            this.foursColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.foursColumn.HeaderText = "Fours";
            this.foursColumn.MinimumWidth = 6;
            this.foursColumn.Name = "foursColumn";
            this.foursColumn.ReadOnly = true;
            this.foursColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.foursColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.foursColumn.Width = 58;
            // 
            // fivesColumn
            // 
            this.fivesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fivesColumn.HeaderText = "Fives";
            this.fivesColumn.MinimumWidth = 6;
            this.fivesColumn.Name = "fivesColumn";
            this.fivesColumn.ReadOnly = true;
            this.fivesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fivesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fivesColumn.Width = 60;
            // 
            // sixesColumn
            // 
            this.sixesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sixesColumn.HeaderText = "Sixes";
            this.sixesColumn.MinimumWidth = 6;
            this.sixesColumn.Name = "sixesColumn";
            this.sixesColumn.ReadOnly = true;
            this.sixesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sixesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.sixesColumn.Width = 70;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(568, 688);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(188, 121);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Main Menu";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(72, 688);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(188, 121);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "&Play Game";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // resetStatsButton
            // 
            this.resetStatsButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetStatsButton.Location = new System.Drawing.Point(317, 688);
            this.resetStatsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetStatsButton.Name = "resetStatsButton";
            this.resetStatsButton.Size = new System.Drawing.Size(188, 121);
            this.resetStatsButton.TabIndex = 3;
            this.resetStatsButton.Text = "&Reset All Stats";
            this.resetStatsButton.UseVisualStyleBackColor = true;
            this.resetStatsButton.Click += new System.EventHandler(this.resetStatsButton_Click);
            // 
            // StatsForm
            // 
            this.AcceptButton = this.playButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(839, 831);
            this.ControlBox = false;
            this.Controls.Add(this.resetStatsButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statsTabControl);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.statsTabControl.ResumeLayout(false);
            this.gameHistoryTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.scoreTotalsTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scoringDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl statsTabControl;
        private System.Windows.Forms.TabPage scoreTotalsTab;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TabPage gameHistoryTab;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button resetStatsButton;
        private System.Windows.Forms.ListBox scorecardListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView rollsDataGridView;
        private System.Windows.Forms.DataGridView scoringDataGridView;
        private System.Windows.Forms.DataGridView gameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn threesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foursColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fivesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sixesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}