using System.Text;
using XFEFileEditor.Profiles;

namespace XFEFileEditor
{
    public partial class StringReplaceToolForm : Form
    {
        public static StringReplaceToolForm? Current { get; private set; }
        public StringReplaceToolForm()
        {
            InitializeComponent();
            encodingComboBox.Items.AddRange(GetAllEncodingNames());
            encodingComboBox.SelectedIndex = ToolFormProfile.ReplaceFileSelectedEncoding;
            originalTextBox.Text = ToolFormProfile.OriginalTextToReplace;
            targetTextBox.Text = ToolFormProfile.TargetTextToReplace;
            fileTypeTextBox.Text = ToolFormProfile.ReplaceFileType;
            Current = this;
        }

        private void ChoseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ReplaceInFile(openFileDialog.FileName, Encoding.GetEncoding(encodingComboBox.SelectedItem?.ToString()!) ?? Encoding.UTF8, originalTextBox.Text, targetTextBox.Text);
                MessageBox.Show("替换完成！");
            }
        }

        private void ChoseFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ReplaceInFolder(folderBrowserDialog.SelectedPath, fileTypeTextBox.Text, Encoding.GetEncoding(encodingComboBox.SelectedItem?.ToString()!) ?? Encoding.UTF8, originalTextBox.Text, targetTextBox.Text);
                MessageBox.Show("替换完成！");
            }
        }
        public static void ReplaceInFolder(string folderPath, string fileType, Encoding encoding, string searchString, string replacementString)
        {
            var filePaths = Directory.GetFiles(folderPath, fileType, SearchOption.AllDirectories);
            foreach (var filePath in filePaths)
                ReplaceInFile(filePath, encoding, searchString, replacementString);
        }
        public static void ReplaceInFile(string filePath, Encoding encoding, string searchString, string replacementString)
        {
            try
            {
                var content = File.ReadAllText(filePath);
                content = content.Replace(searchString, replacementString);
                File.WriteAllText(filePath, content, encoding);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误: {ex.Message}");
            }
        }

        public static string[] GetAllEncodingNames()
        {
            EncodingInfo[] encodingInfos = Encoding.GetEncodings();
            string[] encodingNames = new string[encodingInfos.Length];
            for (int i = 0; i < encodingInfos.Length; i++)
                encodingNames[i] = encodingInfos[i].Name;
            return encodingNames;
        }

        private void OriginalTextBox_TextChanged(object sender, EventArgs e) => ToolFormProfile.OriginalTextToReplace = originalTextBox.Text;

        private void TargetTextBox_TextChanged(object sender, EventArgs e) => ToolFormProfile.TargetTextToReplace = targetTextBox.Text;

        private void FileTypeTextBox_TextChanged(object sender, EventArgs e) => ToolFormProfile.ReplaceFileType = fileTypeTextBox.Text;

        private void EncodingComboBox_SelectedIndexChanged(object sender, EventArgs e) => ToolFormProfile.ReplaceFileSelectedEncoding = encodingComboBox.SelectedIndex;
    }
}
