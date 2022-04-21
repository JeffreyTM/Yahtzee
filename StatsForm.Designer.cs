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
            this.statsTabControl = new System.Windows.Forms.TabControl();
            this.gameHistoryTab = new System.Windows.Forms.TabPage();
            this.scorecardListBox = new System.Windows.Forms.ListBox();
            this.gameHistoryListView = new System.Windows.Forms.ListView();
            this.gameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreTotalsTab = new System.Windows.Forms.TabPage();
            this.scoreTotalsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rollTotalsTab = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.resetStatsButton = new System.Windows.Forms.Button();
            this.rollTotalsListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.statsTabControl.SuspendLayout();
            this.gameHistoryTab.SuspendLayout();
            this.scoreTotalsTab.SuspendLayout();
            this.rollTotalsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // statsTabControl
            // 
            this.statsTabControl.Controls.Add(this.gameHistoryTab);
            this.statsTabControl.Controls.Add(this.scoreTotalsTab);
            this.statsTabControl.Controls.Add(this.rollTotalsTab);
            this.statsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsTabControl.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTabControl.Location = new System.Drawing.Point(0, 0);
            this.statsTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statsTabControl.Multiline = true;
            this.statsTabControl.Name = "statsTabControl";
            this.statsTabControl.SelectedIndex = 0;
            this.statsTabControl.Size = new System.Drawing.Size(839, 661);
            this.statsTabControl.TabIndex = 0;
            // 
            // gameHistoryTab
            // 
            this.gameHistoryTab.BackColor = System.Drawing.Color.Maroon;
            this.gameHistoryTab.Controls.Add(this.label1);
            this.gameHistoryTab.Controls.Add(this.scorecardListBox);
            this.gameHistoryTab.Controls.Add(this.gameHistoryListView);
            this.gameHistoryTab.ForeColor = System.Drawing.SystemColors.Control;
            this.gameHistoryTab.Location = new System.Drawing.Point(4, 40);
            this.gameHistoryTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gameHistoryTab.Name = "gameHistoryTab";
            this.gameHistoryTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gameHistoryTab.Size = new System.Drawing.Size(831, 617);
            this.gameHistoryTab.TabIndex = 0;
            this.gameHistoryTab.Text = "Game History";
            // 
            // scorecardListBox
            // 
            this.scorecardListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scorecardListBox.FormattingEnabled = true;
            this.scorecardListBox.ItemHeight = 31;
            this.scorecardListBox.Location = new System.Drawing.Point(485, 142);
            this.scorecardListBox.Name = "scorecardListBox";
            this.scorecardListBox.Size = new System.Drawing.Size(257, 405);
            this.scorecardListBox.TabIndex = 1;
            // 
            // gameHistoryListView
            // 
            this.gameHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gameColumn,
            this.dateColumn,
            this.timeColumn,
            this.scoreColumn});
            this.gameHistoryListView.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameHistoryListView.FullRowSelect = true;
            this.gameHistoryListView.HideSelection = false;
            this.gameHistoryListView.Location = new System.Drawing.Point(6, 5);
            this.gameHistoryListView.MultiSelect = false;
            this.gameHistoryListView.Name = "gameHistoryListView";
            this.gameHistoryListView.Size = new System.Drawing.Size(377, 610);
            this.gameHistoryListView.TabIndex = 0;
            this.gameHistoryListView.UseCompatibleStateImageBehavior = false;
            this.gameHistoryListView.View = System.Windows.Forms.View.Details;
            this.gameHistoryListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.gameHistoryListView_ColumnWidthChanging);
            this.gameHistoryListView.SelectedIndexChanged += new System.EventHandler(this.gameHistoryListView_SelectedIndexChanged);
            // 
            // gameColumn
            // 
            this.gameColumn.Text = "Game";
            this.gameColumn.Width = 65;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Date";
            this.dateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateColumn.Width = 100;
            // 
            // timeColumn
            // 
            this.timeColumn.Text = "Time";
            this.timeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeColumn.Width = 80;
            // 
            // scoreColumn
            // 
            this.scoreColumn.Text = "Total Score";
            this.scoreColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scoreColumn.Width = 110;
            // 
            // scoreTotalsTab
            // 
            this.scoreTotalsTab.BackColor = System.Drawing.Color.Maroon;
            this.scoreTotalsTab.Controls.Add(this.scoreTotalsListView);
            this.scoreTotalsTab.Location = new System.Drawing.Point(4, 40);
            this.scoreTotalsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreTotalsTab.Name = "scoreTotalsTab";
            this.scoreTotalsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreTotalsTab.Size = new System.Drawing.Size(831, 617);
            this.scoreTotalsTab.TabIndex = 1;
            this.scoreTotalsTab.Text = "Score Totals";
            // 
            // scoreTotalsListView
            // 
            this.scoreTotalsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.scoreTotalsListView.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTotalsListView.FullRowSelect = true;
            this.scoreTotalsListView.HideSelection = false;
            this.scoreTotalsListView.Location = new System.Drawing.Point(8, 3);
            this.scoreTotalsListView.MultiSelect = false;
            this.scoreTotalsListView.Name = "scoreTotalsListView";
            this.scoreTotalsListView.Size = new System.Drawing.Size(815, 610);
            this.scoreTotalsListView.TabIndex = 1;
            this.scoreTotalsListView.UseCompatibleStateImageBehavior = false;
            this.scoreTotalsListView.View = System.Windows.Forms.View.Details;
            this.scoreTotalsListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.scoreTotalsListView_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Score Type";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Times Scored";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 194;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Score";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 156;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Average Score per Game";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 251;
            // 
            // rollTotalsTab
            // 
            this.rollTotalsTab.Controls.Add(this.rollTotalsListView);
            this.rollTotalsTab.Location = new System.Drawing.Point(4, 40);
            this.rollTotalsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rollTotalsTab.Name = "rollTotalsTab";
            this.rollTotalsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rollTotalsTab.Size = new System.Drawing.Size(831, 617);
            this.rollTotalsTab.TabIndex = 2;
            this.rollTotalsTab.Text = "Roll Totals";
            this.rollTotalsTab.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(567, 686);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(188, 121);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Main Menu";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(71, 686);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(188, 121);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // resetStatsButton
            // 
            this.resetStatsButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetStatsButton.Location = new System.Drawing.Point(316, 686);
            this.resetStatsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetStatsButton.Name = "resetStatsButton";
            this.resetStatsButton.Size = new System.Drawing.Size(188, 121);
            this.resetStatsButton.TabIndex = 3;
            this.resetStatsButton.Text = "Reset All Stats";
            this.resetStatsButton.UseVisualStyleBackColor = true;
            this.resetStatsButton.Click += new System.EventHandler(this.resetStatsButton_Click);
            // 
            // rollTotalsListView
            // 
            this.rollTotalsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.rollTotalsListView.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollTotalsListView.FullRowSelect = true;
            this.rollTotalsListView.HideSelection = false;
            this.rollTotalsListView.Location = new System.Drawing.Point(8, 3);
            this.rollTotalsListView.MultiSelect = false;
            this.rollTotalsListView.Name = "rollTotalsListView";
            this.rollTotalsListView.Size = new System.Drawing.Size(815, 610);
            this.rollTotalsListView.TabIndex = 2;
            this.rollTotalsListView.UseCompatibleStateImageBehavior = false;
            this.rollTotalsListView.View = System.Windows.Forms.View.Details;
            this.rollTotalsListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.rollTotalsListView_ColumnWidthChanging);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Roll Type";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Times Rolled";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 124;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Turns Held";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 113;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Average Times Rolled";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 201;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Most Times Rolled";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 175;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Least Times Rolled";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 181;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(485, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click on Any Game to View the Scorecard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
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
            this.scoreTotalsTab.ResumeLayout(false);
            this.rollTotalsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl statsTabControl;
        private System.Windows.Forms.TabPage scoreTotalsTab;
        private System.Windows.Forms.TabPage rollTotalsTab;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TabPage gameHistoryTab;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button resetStatsButton;
        private System.Windows.Forms.ListView gameHistoryListView;
        private System.Windows.Forms.ColumnHeader gameColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader timeColumn;
        private System.Windows.Forms.ColumnHeader scoreColumn;
        private System.Windows.Forms.ListBox scorecardListBox;
        private System.Windows.Forms.ListView scoreTotalsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView rollTotalsListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
    }
}