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
            bottomPanel = new Panel();
            fontSizeNumericUpDown = new NumericUpDown();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(50, 50, 50);
            bottomPanel.Controls.Add(fontSizeNumericUpDown);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 550);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(906, 36);
            bottomPanel.TabIndex = 0;
            // 
            // fontSizeNumericUpDown
            // 
            fontSizeNumericUpDown.BackColor = Color.FromArgb(30, 30, 30);
            fontSizeNumericUpDown.Dock = DockStyle.Left;
            fontSizeNumericUpDown.ForeColor = Color.White;
            fontSizeNumericUpDown.Location = new Point(0, 0);
            fontSizeNumericUpDown.Name = "fontSizeNumericUpDown";
            fontSizeNumericUpDown.Size = new Size(125, 30);
            fontSizeNumericUpDown.TabIndex = 0;
            fontSizeNumericUpDown.ValueChanged += FontSizeNumericUpDown_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(906, 586);
            Controls.Add(bottomPanel);
            ForeColor = Color.White;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XFE文件编辑器";
            SizeChanged += MainForm_SizeChanged;
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomPanel;
        private NumericUpDown fontSizeNumericUpDown;
    }
}
