namespace Word;

public partial class IndentDialog : Form
{
    public int IndentValue;

    public IndentDialog(int currentIndent = 0)
    {
        InitializeComponent();
        IndentValue = currentIndent;
    }

    private void IndentDialog_Load(object sender, EventArgs e)
    {
        numericUpDownIndent.Value = IndentValue;
        numericUpDownIndent.Focus();
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        IndentValue = (int)numericUpDownIndent.Value;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
