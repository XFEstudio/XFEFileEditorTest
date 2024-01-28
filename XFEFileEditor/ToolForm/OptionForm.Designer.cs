namespace XFEFileEditor
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            tableLayoutPanel = new TableLayoutPanel();
            cancelButton = new Button();
            confirmButton = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.FromArgb(30, 30, 30);
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(cancelButton, 1, 3);
            tableLayoutPanel.Controls.Add(confirmButton, 0, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ForeColor = Color.White;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Size = new Size(800, 450);
            tableLayoutPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(50, 50, 50);
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Location = new Point(460, 366);
            cancelButton.Margin = new Padding(60, 30, 60, 30);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(280, 54);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "取消";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(50, 50, 50);
            confirmButton.Dock = DockStyle.Fill;
            confirmButton.Location = new Point(60, 366);
            confirmButton.Margin = new Padding(60, 30, 60, 30);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(280, 54);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "确认";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // OptionForm
            // 
            AcceptButton = confirmButton;
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OptionForm";
            StartPosition = FormStartPosition.Manual;
            Text = "选项设置";
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Button confirmButton;
        private Button cancelButton;
    }
}