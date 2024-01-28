namespace XFEFileEditor
{
    partial class XFEDownloaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFEDownloaderForm));
            tableLayoutPanel = new TableLayoutPanel();
            downloadUrlTextBox = new TextBox();
            downloadUrlLabel = new Label();
            downloadButton = new Button();
            label3 = new Label();
            downloadProgressBar = new ProgressBar();
            menuStrip = new MenuStrip();
            settingToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            threadCountTrackBar = new TrackBar();
            label2 = new Label();
            downloadFileNameTextBox = new TextBox();
            fileDownloadPathLabel = new Label();
            downloadProcessLabel = new Label();
            choicePathButton = new Button();
            openFolderButton = new Button();
            tableLayoutPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)threadCountTrackBar).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Controls.Add(downloadUrlTextBox, 1, 4);
            tableLayoutPanel.Controls.Add(downloadUrlLabel, 0, 4);
            tableLayoutPanel.Controls.Add(downloadButton, 1, 6);
            tableLayoutPanel.Controls.Add(label3, 0, 5);
            tableLayoutPanel.Controls.Add(downloadProgressBar, 1, 5);
            tableLayoutPanel.Controls.Add(menuStrip, 0, 0);
            tableLayoutPanel.Controls.Add(label1, 0, 3);
            tableLayoutPanel.Controls.Add(threadCountTrackBar, 1, 3);
            tableLayoutPanel.Controls.Add(label2, 0, 1);
            tableLayoutPanel.Controls.Add(downloadFileNameTextBox, 1, 1);
            tableLayoutPanel.Controls.Add(fileDownloadPathLabel, 0, 2);
            tableLayoutPanel.Controls.Add(downloadProcessLabel, 3, 5);
            tableLayoutPanel.Controls.Add(choicePathButton, 2, 2);
            tableLayoutPanel.Controls.Add(openFolderButton, 3, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 7;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(657, 375);
            tableLayoutPanel.TabIndex = 0;
            // 
            // downloadUrlTextBox
            // 
            tableLayoutPanel.SetColumnSpan(downloadUrlTextBox, 3);
            downloadUrlTextBox.Dock = DockStyle.Fill;
            downloadUrlTextBox.Location = new Point(164, 196);
            downloadUrlTextBox.Margin = new Padding(0, 3, 30, 3);
            downloadUrlTextBox.Name = "downloadUrlTextBox";
            downloadUrlTextBox.Size = new Size(463, 30);
            downloadUrlTextBox.TabIndex = 0;
            downloadUrlTextBox.TextChanged += DownloadUrlTextBox_TextChanged;
            // 
            // downloadUrlLabel
            // 
            downloadUrlLabel.AutoSize = true;
            downloadUrlLabel.Dock = DockStyle.Fill;
            downloadUrlLabel.Font = new Font("Microsoft YaHei UI", 10F);
            downloadUrlLabel.Location = new Point(30, 193);
            downloadUrlLabel.Margin = new Padding(30, 0, 3, 30);
            downloadUrlLabel.Name = "downloadUrlLabel";
            downloadUrlLabel.Size = new Size(131, 27);
            downloadUrlLabel.TabIndex = 3;
            downloadUrlLabel.Text = "下载地址：";
            // 
            // downloadButton
            // 
            tableLayoutPanel.SetColumnSpan(downloadButton, 2);
            downloadButton.Location = new Point(194, 310);
            downloadButton.Margin = new Padding(30, 20, 30, 20);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(268, 45);
            downloadButton.TabIndex = 1;
            downloadButton.Text = "开始下载";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += DownloadButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft YaHei UI", 10F);
            label3.Location = new Point(30, 250);
            label3.Margin = new Padding(30, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 40);
            label3.TabIndex = 4;
            label3.Text = "下载进度：";
            // 
            // downloadProgressBar
            // 
            tableLayoutPanel.SetColumnSpan(downloadProgressBar, 2);
            downloadProgressBar.Dock = DockStyle.Fill;
            downloadProgressBar.Location = new Point(164, 253);
            downloadProgressBar.Margin = new Padding(0, 3, 30, 3);
            downloadProgressBar.Name = "downloadProgressBar";
            downloadProgressBar.Size = new Size(298, 34);
            downloadProgressBar.TabIndex = 5;
            // 
            // menuStrip
            // 
            tableLayoutPanel.SetColumnSpan(menuStrip, 4);
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(657, 24);
            menuStrip.TabIndex = 6;
            menuStrip.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(62, 28);
            settingToolStripMenuItem.Text = "设置";
            settingToolStripMenuItem.Visible = false;
            settingToolStripMenuItem.Click += SettingToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft YaHei UI", 10F);
            label1.Location = new Point(30, 118);
            label1.Margin = new Padding(30, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 75);
            label1.TabIndex = 7;
            label1.Text = "线程数：";
            // 
            // threadCountTrackBar
            // 
            tableLayoutPanel.SetColumnSpan(threadCountTrackBar, 3);
            threadCountTrackBar.Dock = DockStyle.Top;
            threadCountTrackBar.LargeChange = 2;
            threadCountTrackBar.Location = new Point(167, 121);
            threadCountTrackBar.Margin = new Padding(3, 3, 30, 3);
            threadCountTrackBar.Minimum = 1;
            threadCountTrackBar.Name = "threadCountTrackBar";
            threadCountTrackBar.Size = new Size(460, 69);
            threadCountTrackBar.TabIndex = 8;
            threadCountTrackBar.Value = 1;
            threadCountTrackBar.Scroll += ThreadCountTrackBar_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft YaHei UI", 10F);
            label2.Location = new Point(30, 24);
            label2.Margin = new Padding(30, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 36);
            label2.TabIndex = 9;
            label2.Text = "文件名：";
            // 
            // downloadFileNameTextBox
            // 
            tableLayoutPanel.SetColumnSpan(downloadFileNameTextBox, 3);
            downloadFileNameTextBox.Dock = DockStyle.Fill;
            downloadFileNameTextBox.Location = new Point(167, 27);
            downloadFileNameTextBox.Margin = new Padding(3, 3, 30, 3);
            downloadFileNameTextBox.Name = "downloadFileNameTextBox";
            downloadFileNameTextBox.Size = new Size(460, 30);
            downloadFileNameTextBox.TabIndex = 10;
            // 
            // fileDownloadPathLabel
            // 
            tableLayoutPanel.SetColumnSpan(fileDownloadPathLabel, 2);
            fileDownloadPathLabel.Dock = DockStyle.Fill;
            fileDownloadPathLabel.Font = new Font("Microsoft YaHei UI", 10F);
            fileDownloadPathLabel.Location = new Point(30, 60);
            fileDownloadPathLabel.Margin = new Padding(30, 0, 3, 0);
            fileDownloadPathLabel.Name = "fileDownloadPathLabel";
            fileDownloadPathLabel.Size = new Size(295, 58);
            fileDownloadPathLabel.TabIndex = 9;
            fileDownloadPathLabel.Text = "根目录：";
            // 
            // downloadProcessLabel
            // 
            downloadProcessLabel.AutoSize = true;
            downloadProcessLabel.Dock = DockStyle.Fill;
            downloadProcessLabel.Font = new Font("Microsoft YaHei UI", 11F);
            downloadProcessLabel.Location = new Point(495, 250);
            downloadProcessLabel.Name = "downloadProcessLabel";
            downloadProcessLabel.Size = new Size(159, 40);
            downloadProcessLabel.TabIndex = 12;
            downloadProcessLabel.Text = "0KB/0KB";
            // 
            // choicePathButton
            // 
            choicePathButton.Dock = DockStyle.Fill;
            choicePathButton.Location = new Point(331, 63);
            choicePathButton.Name = "choicePathButton";
            choicePathButton.Size = new Size(158, 52);
            choicePathButton.TabIndex = 13;
            choicePathButton.Text = "选择文件夹";
            choicePathButton.UseVisualStyleBackColor = true;
            choicePathButton.Click += ChoicePathButton_Click;
            // 
            // openFolderButton
            // 
            openFolderButton.Dock = DockStyle.Fill;
            openFolderButton.Location = new Point(495, 63);
            openFolderButton.Name = "openFolderButton";
            openFolderButton.Size = new Size(159, 52);
            openFolderButton.TabIndex = 14;
            openFolderButton.Text = "打开文件夹";
            openFolderButton.UseVisualStyleBackColor = true;
            openFolderButton.Click += OpenFolderButton_Click;
            // 
            // XFEDownloaderForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 375);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "XFEDownloaderForm";
            Text = "XFE下载器";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)threadCountTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private TextBox downloadUrlTextBox;
        private Button downloadButton;
        private Label downloadUrlLabel;
        private Label label3;
        private ProgressBar downloadProgressBar;
        private MenuStrip menuStrip;
        private ToolStripMenuItem settingToolStripMenuItem;
        private Label label1;
        private TrackBar threadCountTrackBar;
        private Label label2;
        private TextBox downloadFileNameTextBox;
        private Label fileDownloadPathLabel;
        private Label downloadProcessLabel;
        private Button choicePathButton;
        private Button openFolderButton;
    }
}