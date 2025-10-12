namespace Exception_Handling_Example;

public partial class MainForm : Form
{
    /// <summary>
    /// Initializes a new instance of the MainForm and its UI components.
    /// </summary>
    /// <remarks>
    /// Calls InitializeComponent to set up the Windows Forms controls.
    /// </remarks>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Handles the Calculate button click and displays the sum of two integers entered by the user.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    /// <remarks>
    /// Reads text from txtNumber1 and txtNumber2, attempts to parse them as integers, computes the sum,
    /// and shows the result in a message box using lblTitle as the caption. Format errors and other
    /// exceptions are caught and displayed to the user.
    /// </remarks>
    private void ButtonCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            int number1 = int.Parse(txtNumber1.Text);
            int number2 = int.Parse(txtNumber2.Text);
            int sum = number1 + number2;
            _ = MessageBox.Show($"{number1} + {number2} = {sum}", lblTitle.Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        catch (FormatException ex)
        {
            _ = MessageBox.Show(ex.Message);
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show(ex.Message);
        }
    }

    /// <summary>
    /// Handles the Clear button click and clears the input text boxes.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void ButtonClear_Click(object sender, EventArgs e)
    {
        txtNumber1.Text = string.Empty;
        txtNumber2.Text = string.Empty;
    }

    /// <summary>
    /// Handles the Exit button click and closes the form.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}
