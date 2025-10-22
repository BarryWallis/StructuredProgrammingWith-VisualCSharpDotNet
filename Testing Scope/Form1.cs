namespace Testing_Scope;

/// <summary>
/// Represents the main form for the Testing Scope application.
/// Demonstrates variable scope using local constants inside event handlers.
/// </summary>
public partial class MainForm : Form
{
    private const int Number1 = 5;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Handles the click event for the scope example button that uses a local constant of 7.
    /// Sets the title label background and displays the sum of the class-level and local constants.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">Event data associated with the click.</param>
    private void BtnScope1_Click(object sender, EventArgs e)
    {
        lblTitle.BackColor = Color.PeachPuff;
        const int Number2 = 7;
        _ = MessageBox.Show($"{Number1 + Number2}", "Answer");
    }

    /// <summary>
    /// Handles the click event for the scope example button that uses a local constant of 10.
    /// Sets the title label background and displays the sum of the class-level and local constants.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">Event data associated with the click.</param>
    private void BtnScope2_Click(object sender, EventArgs e)
    {
        lblTitle.BackColor = Color.LightPink;
        const int Number2 = 10;
        _ = MessageBox.Show($"{Number1 + Number2}", "Answer");
    }

    /// <summary>
    /// Handles the exit button click and closes the form.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">Event data associated with the click.</param>
    private void BtnExit_Click(object sender, EventArgs e) => Close();
}
