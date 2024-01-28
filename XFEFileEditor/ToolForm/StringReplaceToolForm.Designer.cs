namespace XFEFileEditor
{
    partial class StringReplaceToolForm
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
            label1 = new Label();
            originalTextBox = new TextBox();
            label2 = new Label();
            targetTextBox = new TextBox();
            label3 = new Label();
            fileTypeTextBox = new TextBox();
            choseFileButton = new Button();
            choseFolderButton = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialog = new OpenFileDialog();
            label4 = new Label();
            encodingComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "待替换文本";
            // 
            // originalTextBox
            // 
            originalTextBox.AcceptsReturn = true;
            originalTextBox.AcceptsTab = true;
            originalTextBox.Location = new Point(12, 47);
            originalTextBox.Multiline = true;
            originalTextBox.Name = "originalTextBox";
            originalTextBox.Size = new Size(780, 98);
            originalTextBox.TabIndex = 1;
            originalTextBox.TextChanged += OriginalTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 2;
            label2.Text = "目标文本";
            // 
            // targetTextBox
            // 
            targetTextBox.AcceptsReturn = true;
            targetTextBox.AcceptsTab = true;
            targetTextBox.Location = new Point(12, 212);
            targetTextBox.Multiline = true;
            targetTextBox.Name = "targetTextBox";
            targetTextBox.Size = new Size(780, 98);
            targetTextBox.TabIndex = 3;
            targetTextBox.TextChanged += TargetTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 347);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 4;
            label3.Text = "文件格式";
            // 
            // fileTypeTextBox
            // 
            fileTypeTextBox.Location = new Point(566, 343);
            fileTypeTextBox.Name = "fileTypeTextBox";
            fileTypeTextBox.Size = new Size(104, 30);
            fileTypeTextBox.TabIndex = 5;
            fileTypeTextBox.Text = "*.*";
            fileTypeTextBox.TextChanged += FileTypeTextBox_TextChanged;
            // 
            // choseFileButton
            // 
            choseFileButton.Location = new Point(121, 386);
            choseFileButton.Name = "choseFileButton";
            choseFileButton.Size = new Size(192, 52);
            choseFileButton.TabIndex = 6;
            choseFileButton.Text = "选择 文件 并替换";
            choseFileButton.UseVisualStyleBackColor = true;
            choseFileButton.Click += ChoseFileButton_Click;
            // 
            // choseFolderButton
            // 
            choseFolderButton.Location = new Point(478, 386);
            choseFolderButton.Name = "choseFolderButton";
            choseFolderButton.Size = new Size(192, 52);
            choseFolderButton.TabIndex = 7;
            choseFolderButton.Text = "选择 文件夹 并替换";
            choseFolderButton.UseVisualStyleBackColor = true;
            choseFolderButton.Click += ChoseFolderButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 347);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 8;
            label4.Text = "编码格式";
            // 
            // encodingComboBox
            // 
            encodingComboBox.FormattingEnabled = true;
            encodingComboBox.Location = new Point(209, 343);
            encodingComboBox.Name = "encodingComboBox";
            encodingComboBox.Size = new Size(104, 32);
            encodingComboBox.TabIndex = 9;
            encodingComboBox.SelectedIndexChanged += EncodingComboBox_SelectedIndexChanged;
            // 
            // StringReplaceToolForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(encodingComboBox);
            Controls.Add(label4);
            Controls.Add(choseFolderButton);
            Controls.Add(choseFileButton);
            Controls.Add(fileTypeTextBox);
            Controls.Add(label3);
            Controls.Add(targetTextBox);
            Controls.Add(label2);
            Controls.Add(originalTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "StringReplaceToolForm";
            Text = "文档字符串替换工具";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox originalTextBox;
        private Label label2;
        private TextBox targetTextBox;
        private Label label3;
        private TextBox fileTypeTextBox;
        private Button choseFileButton;
        private Button choseFolderButton;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog;
        private Label label4;
        private ComboBox encodingComboBox;
    }
}