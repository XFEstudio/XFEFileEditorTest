namespace XFEFileEditor;

public partial class OptionForm : Form
{
    public static OptionForm? Current { get; private set; }
    public OptionForm()
    {
        InitializeComponent();
        Current = this;
    }

    private void ConfirmButton_Click(object sender, EventArgs e)
    {
        //TODO:
        Close();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
