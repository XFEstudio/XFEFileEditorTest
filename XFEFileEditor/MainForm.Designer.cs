namespace XFEFileEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bottomPanel = new FlowLayoutPanel();
            fontSizeLabel = new Label();
            fontSizeNumericUpDown = new NumericUpDown();
            saveStateLabel = new Label();
            menuStrip = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileAsToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            optionSettingToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem = new ToolStripMenuItem();
            xFEDownloaderToolStripMenuItem = new ToolStripMenuItem();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // bottomPanel
            // 
            bottomPanel.AutoSize = true;
            bottomPanel.BackColor = Color.FromArgb(50, 50, 50);
            bottomPanel.Controls.Add(fontSizeLabel);
            bottomPanel.Controls.Add(fontSizeNumericUpDown);
            bottomPanel.Controls.Add(saveStateLabel);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 550);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(906, 36);
            bottomPanel.TabIndex = 0;
            // 
            // fontSizeLabel
            // 
            fontSizeLabel.AutoSize = true;
            fontSizeLabel.Font = new Font("Microsoft YaHei UI", 10F);
            fontSizeLabel.Location = new Point(3, 3);
            fontSizeLabel.Margin = new Padding(3, 3, 3, 0);
            fontSizeLabel.Name = "fontSizeLabel";
            fontSizeLabel.Size = new Size(92, 27);
            fontSizeLabel.TabIndex = 1;
            fontSizeLabel.Text = "字体大小";
            // 
            // fontSizeNumericUpDown
            // 
            fontSizeNumericUpDown.Anchor = AnchorStyles.Left;
            fontSizeNumericUpDown.BackColor = Color.FromArgb(30, 30, 30);
            fontSizeNumericUpDown.ForeColor = Color.White;
            fontSizeNumericUpDown.Location = new Point(101, 3);
            fontSizeNumericUpDown.Margin = new Padding(3, 3, 15, 3);
            fontSizeNumericUpDown.Name = "fontSizeNumericUpDown";
            fontSizeNumericUpDown.Size = new Size(90, 30);
            fontSizeNumericUpDown.TabIndex = 0;
            fontSizeNumericUpDown.ValueChanged += FontSizeNumericUpDown_ValueChanged;
            // 
            // saveStateLabel
            // 
            saveStateLabel.AutoSize = true;
            saveStateLabel.Font = new Font("Microsoft YaHei UI", 10F);
            saveStateLabel.Location = new Point(221, 3);
            saveStateLabel.Margin = new Padding(15, 3, 15, 0);
            saveStateLabel.Name = "saveStateLabel";
            saveStateLabel.Size = new Size(32, 27);
            saveStateLabel.TabIndex = 2;
            saveStateLabel.Text = "无";
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(50, 50, 50);
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, settingToolStripMenuItem, toolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(906, 32);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.BackColor = Color.FromArgb(50, 50, 50);
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem, saveFileAsToolStripMenuItem });
            文件ToolStripMenuItem.ForeColor = Color.White;
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(62, 28);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.BackColor = Color.FromArgb(70, 70, 70);
            openFileToolStripMenuItem.ForeColor = Color.White;
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openFileToolStripMenuItem.Size = new Size(280, 34);
            openFileToolStripMenuItem.Text = "打开";
            openFileToolStripMenuItem.Click += OpenFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.BackColor = Color.FromArgb(70, 70, 70);
            saveFileToolStripMenuItem.ForeColor = Color.White;
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveFileToolStripMenuItem.Size = new Size(280, 34);
            saveFileToolStripMenuItem.Text = "保存";
            saveFileToolStripMenuItem.Click += SaveFileToolStripMenuItem_Click;
            // 
            // saveFileAsToolStripMenuItem
            // 
            saveFileAsToolStripMenuItem.BackColor = Color.FromArgb(70, 70, 70);
            saveFileAsToolStripMenuItem.ForeColor = Color.White;
            saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            saveFileAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveFileAsToolStripMenuItem.Size = new Size(280, 34);
            saveFileAsToolStripMenuItem.Text = "另存为";
            saveFileAsToolStripMenuItem.Click += SaveFileAsToolStripMenuItem_Click;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.BackColor = Color.FromArgb(50, 50, 50);
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionSettingToolStripMenuItem });
            settingToolStripMenuItem.ForeColor = Color.White;
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(62, 28);
            settingToolStripMenuItem.Text = "设置";
            // 
            // optionSettingToolStripMenuItem
            // 
            optionSettingToolStripMenuItem.BackColor = Color.FromArgb(70, 70, 70);
            optionSettingToolStripMenuItem.ForeColor = Color.White;
            optionSettingToolStripMenuItem.Name = "optionSettingToolStripMenuItem";
            optionSettingToolStripMenuItem.Size = new Size(182, 34);
            optionSettingToolStripMenuItem.Text = "选项设置";
            optionSettingToolStripMenuItem.Click += OptionSettingToolStripMenuItem_Click;
            // 
            // toolStripMenuItem
            // 
            toolStripMenuItem.BackColor = Color.FromArgb(50, 50, 50);
            toolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xFEDownloaderToolStripMenuItem });
            toolStripMenuItem.ForeColor = Color.White;
            toolStripMenuItem.Name = "toolStripMenuItem";
            toolStripMenuItem.Size = new Size(62, 28);
            toolStripMenuItem.Text = "工具";
            // 
            // xFEDownloaderToolStripMenuItem
            // 
            xFEDownloaderToolStripMenuItem.BackColor = Color.FromArgb(70, 70, 70);
            xFEDownloaderToolStripMenuItem.ForeColor = Color.White;
            xFEDownloaderToolStripMenuItem.Name = "xFEDownloaderToolStripMenuItem";
            xFEDownloaderToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            xFEDownloaderToolStripMenuItem.Size = new Size(270, 34);
            xFEDownloaderToolStripMenuItem.Text = "XFE下载器";
            xFEDownloaderToolStripMenuItem.Click += XFEDownloaderToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(906, 586);
            Controls.Add(bottomPanel);
            Controls.Add(menuStrip);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XFE文件编辑器";
            FormClosing += MainForm_FormClosing;
            SizeChanged += MainForm_SizeChanged;
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown fontSizeNumericUpDown;
        private Label fontSizeLabel;
        private FlowLayoutPanel bottomPanel;
        private SplitContainer splitContainer1;
        private Label saveStateLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem saveFileAsToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem optionSettingToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem;
        private ToolStripMenuItem xFEDownloaderToolStripMenuItem;
    }
}
