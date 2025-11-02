using System.Speech.Synthesis;

namespace _Reading_Common_Tree_Names__;

public partial class MainForm : Form
{
    // Text-to-speech engine used to read the selected tree names aloud.
    private readonly SpeechSynthesizer _read = new();

    public MainForm()
    {
        InitializeComponent();

        // Make the form non-resizable without modifying designer-generated code
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;

        // Wire events here (not in designer) to follow repository guidance about generated code.
        ReadButton.Click += ReadButton_Click;
        ExitButton.Click += ExitButton_Click;

        // Improve UX: Enter triggers Read; Esc triggers Exit.
        AcceptButton = ReadButton;
        CancelButton = ExitButton;
    }

    /// <summary>
    /// Reads each item in <see cref="TreeNamesListBox"/> using the speech synthesizer.
    /// Shows a friendly message when the list is empty.
    /// </summary>
    private void ReadButton_Click(object? sender, EventArgs e)
    {
        if (TreeNamesListBox.Items.Count is 0)
        {
            _ = MessageBox.Show(this, "No tree names to read.", nameof(MainForm), MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        foreach (object? item in TreeNamesListBox.Items)
        {
            string text = item?.ToString() ?? string.Empty;
            if (text.Length is 0)
            {
                continue;
            }

            // Using SpeakAsync to avoid blocking the UI thread while speaking.
            _ = _read.SpeakAsync(text);
        }
    }

    /// <summary>
    /// Closes the form and exits the application.
    /// </summary>
    private void ExitButton_Click(object? sender, EventArgs e) => Close();
}
