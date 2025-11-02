namespace Looping_and_Looping;

/// <summary>
/// Windows Form that demonstrates repetition structures (<c>while</c>, <c>for</c>, and <c>do-while</c>)
/// by computing the arithmetic mean of numeric items listed in a <see cref="ListBox"/>.
/// </summary>
/// <remarks>
/// Click the corresponding buttons to compute the mean of the values in <c>lbNumbers</c> and
/// display the result in <c>lblOutPut</c>.
/// <para>
/// Robustness: If the list is empty, the handlers inform the user and output "N/A". If any item is not a valid
/// integer, the handlers display a message indicating the invalid item and abort the calculation.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// [STAThread]
/// ApplicationConfiguration.Initialize();
/// Application.Run(new MainForm());
/// </code>
/// </example>
public partial class MainForm : Form
{
    /// <summary>
    /// Holds the initial text of <see cref="lblOutPut"/> used as a prefix when displaying results.
    /// </summary>
    private readonly string _prefixText;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();

        _prefixText = lblOutPut.Text;
    }

    /// <summary>
    /// Validates that <see cref="lbNumbers"/> contains at least one valid integer item and returns the parsed values.
    /// </summary>
    /// <param name="numbers">The parsed numbers from <see cref="lbNumbers"/> when validation succeeds.</param>
    /// <returns><c>true</c> if validation succeeds; otherwise, <c>false</c>.</returns>
    /// <remarks>
    /// On failure, an informative message is shown and <see cref="lblOutPut"/> is set to the prefix followed by "N/A".
    /// </remarks>
    private bool TryGetNumbers(out List<int> numbers)
    {
        numbers = new List<int>(lbNumbers.Items.Count);

        if (lbNumbers.Items.Count == 0)
        {
            _ = MessageBox.Show(this, "The list is empty. Add numeric items before computing the mean.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblOutPut.Text = $"{_prefixText}N/A";
            return false;
        }

        for (int i = 0; i < lbNumbers.Items.Count; i++)
        {
            string? text = lbNumbers.Items[i]?.ToString();
            if (!int.TryParse(text, out int n))
            {
                _ = MessageBox.Show(this, $"Item at index {i} is not a valid integer: \"{text}\".", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblOutPut.Text = $"{_prefixText}N/A";
                return false;
            }

            numbers.Add(n);
        }

        return true;
    }

    /// <summary>
    /// Computes and displays the arithmetic mean using a <c>while</c> loop.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event data.</param>
    /// <remarks>
    /// Uses <see cref="TryGetNumbers(out System.Collections.Generic.List{int})"/> for validation before computing.
    /// </remarks>
    private void ButtonWhile_Click(object sender, EventArgs e)
    {
        if (!TryGetNumbers(out List<int>? numbers))
        {
            return;
        }

        int counter = 0;
        int total = 0;

        while (counter < numbers.Count)
        {
            total += numbers[counter];
            counter++;
        }

        lblOutPut.Text = $"while-loop{Environment.NewLine}{_prefixText}{(double)total / numbers.Count:n3}";
    }

    /// <summary>
    /// Computes and displays the arithmetic mean using a <c>for</c> loop.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event data.</param>
    /// <remarks>
    /// Uses <see cref="TryGetNumbers(out System.Collections.Generic.List{int})"/> for validation before computing.
    /// </remarks>
    private void ButtonFor_Click(object sender, EventArgs e)
    {
        if (!TryGetNumbers(out List<int>? numbers))
        {
            return;
        }

        int total = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];
        }

        lblOutPut.Text = $"for-loop{Environment.NewLine}{_prefixText}{(double)total / numbers.Count:n3}";
    }

    /// <summary>
    /// Computes and displays the arithmetic mean using a <c>do-while</c> loop.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event data.</param>
    /// <remarks>
    /// Uses <see cref="TryGetNumbers(out System.Collections.Generic.List{int})"/> for validation before computing.
    /// </remarks>
    private void ButtonDoWhile_Click(object sender, EventArgs e)
    {
        if (!TryGetNumbers(out List<int>? numbers))
        {
            return;
        }

        int total = 0;
        int counter = 0;

        do
        {
            total += numbers[counter];
            counter++;
        } while (counter < numbers.Count);

        lblOutPut.Text = $"do-while{Environment.NewLine}{_prefixText}{(double)total / numbers.Count:n3}";
    }

    /// <summary>
    /// Clears the output label by restoring its initial prefix text.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event data.</param>
    private void BtnClear_Click(object sender, EventArgs e) => lblOutPut.Text = _prefixText;

    /// <summary>
    /// Closes the form and exits the application.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event data.</param>
    private void BtnExit_Click(object sender, EventArgs e) => Close();
}
