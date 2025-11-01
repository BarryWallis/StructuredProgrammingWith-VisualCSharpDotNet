namespace My_Savings_Account;

/// <summary>
/// Represents the main Windows Form for the "My Savings Account" application.
/// </summary>
/// <remarks>
/// This form collects the initial account balance, an annual interest rate, and a number of months
/// to calculate and display the month-by-month account balance using a simple monthly compounding model.
/// </remarks>
public partial class MainForm : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class and its UI components.
    /// </summary>
    /// <remarks>
    /// The UI elements are created and laid out in the associated designer file. Event handlers for
    /// buttons are expected to call the methods defined in this class.
    /// </remarks>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Handles calculation of the month-by-month account balance based on the provided inputs.
    /// </summary>
    /// <param name="sender">The source of the event (typically the Calculate button).</param>
    /// <param name="e">Event data associated with the click action.</param>
    /// <remarks>
    /// Expects the following inputs:
    /// - Account Balance: positive decimal representing the initial principal.
    /// - Interest Rate: annual interest rate as a decimal (e.g.,0.06 for6%).
    /// - Number of Months: positive decimal that is interpreted as an integer number of months.
    ///
    /// The calculation applies a simple monthly compounding model: <c>balance += (rate /12) * balance</c>
    /// for each month, and appends each month's ending balance to the results label.
    ///
    /// Input values are validated using <see cref="decimal.TryParse(string?, out decimal)"/>. If a value is invalid,
    /// a message box is shown to the user and the calculation stops.
    /// </remarks>
    private void BtnCalculate_Click(object sender, EventArgs e)
    {
        int counter = 1;

        if (decimal.TryParse(txtAccountBalance.Text, out decimal balance) && balance > 0)
        {
            if (decimal.TryParse(txtInterestRate.Text, out decimal rate) && rate > 0)
            {
                if (decimal.TryParse(txtNumberOfMonths.Text, out decimal months) && months > 0)
                {
                    lblResults.Text = string.Empty;

                    while (counter <= months)
                    {
                        balance += rate / 12 * balance;
                        lblResults.Text += $"Balance for end of month {counter++} = {balance:C2}{Environment.NewLine}";
                    }
                }
                else
                {
                    _ = MessageBox.Show("Invalid months.");
                }
            }
            else
            {
                _ = MessageBox.Show("Invalid rate.");
            }
        }
        else
        {
            _ = MessageBox.Show("Invalid balance.");
        }
    }

    /// <summary>
    /// Clears all input fields and the results display.
    /// </summary>
    /// <param name="sender">The source of the event (typically the Clear button).</param>
    /// <param name="e">Event data associated with the click action.</param>
    private void BtnClear_Click(object sender, EventArgs e)
    {
        txtAccountBalance.Clear();
        txtInterestRate.Clear();
        txtNumberOfMonths.Clear();
        lblResults.Text = string.Empty;
    }

    /// <summary>
    /// Closes the application.
    /// </summary>
    /// <param name="sender">The source of the event (typically the Exit button).</param>
    /// <param name="e">Event data associated with the click action.</param>
    private void BtnExit_Click(object sender, EventArgs e) => Close();
}
