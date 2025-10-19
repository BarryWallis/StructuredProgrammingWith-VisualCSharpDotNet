namespace Testing_the_Math_Class_Methods;

/// <summary>
/// Main application form that demonstrates several <see cref="Math"/> class methods.
/// </summary>
/// <remarks>
/// This form parses numeric input values and displays the results of common mathematical
/// operations using labels on the UI.
/// </remarks>
public partial class MainForm : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Handles Calculate button clicks: parses inputs and displays results of various
    /// <see cref="Math"/> methods in the corresponding labels.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event data.</param>
    private void BtnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            // Parse input values from text boxes; throws if text is not a valid number
            double x = double.Parse(txtBoxX.Text);
            double y = double.Parse(txtBoxY.Text);

            // Display outputs for several Math operations using the input values
            lblAbs.Text = $"Math.Abs({x}) = {Math.Abs(x)}";
            lblLog.Text = $"Math.Log({x}) = {Math.Log(x):n3}"; // natural logarithm
            lblMax.Text = $"Math.Max({x}, {y}) = {Math.Max(x, y)}";
            lblMin.Text = $"Math.Min({x}, {y}) = {Math.Min(x, y)}";
            lblPI.Text = $"Math.PI = {Math.PI}";
            lblPow.Text = $"Math.Pow({x}, {y}) = {Math.Pow(x, y)}";
            lblRound.Text = $"Math.Round({x}) = {Math.Round(x)}";
            lblSqrt.Text = $"Math.Sqrt({x}) = {Math.Sqrt(x):n3}";
        }
        catch (FormatException)
        {
            // Show a friendly message if any input is not numeric
            _ = MessageBox.Show("Invalid input. Please enter numeric values for X and Y.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            // General fallback to surface unexpected errors to the user
            _ = MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Handles Clear button clicks: clears input text boxes and result labels.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event data.</param>
    private void BtnClear_Click(object sender, EventArgs e)
    {
        txtBoxX.Clear();
        txtBoxY.Clear();

        // Reset all result labels
        lblAbs.Text = string.Empty;
        lblLog.Text = string.Empty;
        lblMax.Text = string.Empty;
        lblMin.Text = string.Empty;
        lblPI.Text = string.Empty;
        lblPow.Text = string.Empty;
        lblRound.Text = string.Empty;
        lblSqrt.Text = string.Empty;
    }

    /// <summary>
    /// Handles Exit button clicks: closes the form.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event data.</param>
    private void BtnExit_Click(object sender, EventArgs e) => Close();
}
