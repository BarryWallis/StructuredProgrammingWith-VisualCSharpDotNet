namespace Student_Full_Name;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        // Enable Enter/Esc shortcuts.
        AcceptButton = ButtonSubmit;
        CancelButton = ButtonExit;

        // Focus the first name input on load for better UX.
        textBoxFirstName.Select();

        // Keep Submit disabled until both fields have text.
        ButtonSubmit.Enabled = HasBothNameText();

        // React to input changes to update the Submit button state.
        textBoxFirstName.TextChanged += NameTextBox_TextChanged;
        textBoxLastName.TextChanged += NameTextBox_TextChanged;

        // Configure simple tooltips for guidance.
        ToolTip tip = new();
        tip.SetToolTip(textBoxFirstName, "Enter the student's first name");
        tip.SetToolTip(textBoxLastName, "Enter the student's last name");
        tip.SetToolTip(ButtonSubmit, "Show the full name (requires both names)");
        tip.SetToolTip(ButtonExit, "Close the application");
        if (ButtonClear is not null)
        {
            tip.SetToolTip(ButtonClear, "Clear all fields");
        }
    }

    private void ButtonExit_Click(object sender, EventArgs e) => Close();

    private void ButtonSubmit_Click(object sender, EventArgs e)
        // Use helper to format and display the name in Title Case.
        => labelOutput.Text = FormatFullName(textBoxFirstName.Text, textBoxLastName.Text);

    private void ButtonClear_Click(object? sender, EventArgs e)
    {
        textBoxFirstName.Clear();
        textBoxLastName.Clear();
        labelOutput.Text = string.Empty;
        textBoxFirstName.Select();
    }

    private void NameTextBox_TextChanged(object? sender, EventArgs e)
        // Update Submit button enabled state based on current inputs.
        => ButtonSubmit.Enabled = HasBothNameText();

    private bool HasBothNameText() => !string.IsNullOrWhiteSpace(textBoxFirstName.Text)
            && !string.IsNullOrWhiteSpace(textBoxLastName.Text);

    private static string FormatFullName(string firstInput, string lastInput)
    {
        // Trim and normalize each part to Title Case; handle missing parts gracefully.
        string first = firstInput?.Trim() ?? string.Empty;
        string last = lastInput?.Trim() ?? string.Empty;

        if (first.Length == 0 && last.Length == 0)
        {
            return string.Empty;
        }

        System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
        System.Globalization.TextInfo textInfo = culture.TextInfo;

        string ToTitle(string s) => s.Length == 0 ? string.Empty : textInfo.ToTitleCase(s.ToLower(culture));

        string formattedFirst = ToTitle(first);
        string formattedLast = ToTitle(last);

        return formattedFirst.Length > 0 && formattedLast.Length > 0
            ? formattedFirst + " " + formattedLast
            : formattedFirst.Length > 0 ? formattedFirst : formattedLast;
    }
}
