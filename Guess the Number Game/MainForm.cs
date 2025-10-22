namespace Guess_the_Number_Game;

/// <summary>
/// Represents the main form for the Guess the Number game.
/// </summary>
/// <remarks>
/// This simple example reads the user's numeric input from <c>txtGuess</c>, compares it to a fixed
/// answer, and displays feedback using message boxes. The answer is intentionally hard-coded to keep
/// the example focused on basic event handling and control interaction in Windows Forms.
/// </remarks>
public partial class MainForm : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    /// <remarks>
    /// Calls <see cref="InitializeComponent"/> to set up the form's controls.
    /// </remarks>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Handles the Evaluate button click to assess the user's guess against the answer.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    /// <remarks>
    /// Reads the text from <c>txtGuess</c> and parses it as an integer. Displays a message indicating
    /// whether the guess is too high, too low, or correct, then clears the input field. The answer is
    /// fixed to the value <c>7</c> for demonstration purposes.
    /// Explicit exception handling is used to provide clear feedback for invalid or out-of-range input.
    /// </remarks>
    private void BtnEvaluate_Click(object sender, EventArgs e)
    {
        try
        {
            int guess = int.Parse(txtGuess.Text);
            int answer = 7;
            if (guess > answer)
            {
                _ = MessageBox.Show("Too high!");
            }

            if (guess < answer)
            {
                _ = MessageBox.Show("Too low!");
            }

            if (guess == answer)
            {
                _ = MessageBox.Show("You got it!");
            }
        }
        catch (FormatException)
        {
            // Occurs when the input is not a valid integer representation (e.g., empty or non-numeric text).
            _ = MessageBox.Show("Please enter a valid whole number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (OverflowException)
        {
            // Occurs when the numeric input is outside the range of Int32.
            _ = MessageBox.Show("The number entered is too large or too small.", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            // Fallback for unexpected errors to avoid crashing the application and to aid troubleshooting.
            _ = MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            txtGuess.Clear();
        }
    }

    /// <summary>
    /// Handles the Exit button click to close the application.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void BtnExit_Click(object sender, EventArgs e) => Close();
}
