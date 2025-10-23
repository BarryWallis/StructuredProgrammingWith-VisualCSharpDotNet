namespace My_Calculator;

/// <summary>
/// Represents the main calculator form. This partial class contains user-authored
/// event handler stubs for calculator button interactions. The visual layout and
/// control field declarations are defined in the designer-generated partial class.
/// </summary>
public partial class MainForm : Form
{
    private double _number1 = 0.0;
    private double _number2 = 0.0;
    private int _math = 0;
    private bool _results = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class and wires up UI components.
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Handles the click event for the digit '0' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button0_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text != "0")
        {
            txtResult.Text += "0";
        }
    }

    /// <summary>
    /// Handles the click event for the digit '1' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button1_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = "1";
        }
        else
        {
            txtResult.Text += "1";
        }
    }

    /// <summary>
    /// Handles the click event for the digit '2' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button2_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = "2";
        }
        else
        {
            txtResult.Text += "2";
        }
    }

    /// <summary>
    /// Handles the click event for the digit '3' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button3_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = "3";
        }
        else
        {
            txtResult.Text += "3";
        }
    }

    /// <summary>
    /// Handles the click event for the digit '4' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button4_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = "4";
        }
        else
        {
            txtResult.Text += "4";
        }
    }

    /// <summary>
    /// Handles the click event for the digit '5' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button5_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = "5";
        }
        else
        {
            txtResult.Text += "5";
        }
    }

    /// <summary>
    /// Handles the click event for the digit '6' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button6_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = "6";
        }
        else
        {
            txtResult.Text += "6";
        }
    }

    /// <summary>
    /// Handles the click event for the digit '7' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button7_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = "7";
        }
        else
        {
            txtResult.Text += "7";
        }
    }

    /// <summary>
    /// Handles the click event for the digit '8' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button8_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = "8";
        }
        else
        {
            txtResult.Text += "8";
        }
    }

    /// <summary>
    /// Handles the click event for the digit '9' button. Implement to append the digit to the current input.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void Button9_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = "9";
        }
        else
        {
            txtResult.Text += "9";
        }
    }

    /// <summary>
    /// Handles the click event for the clear button. Implement to reset the current input and any stored state.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void ButtonClear_Click(object sender, EventArgs e)
    {
        txtResult.Text = "0";
        _math = 0;
    }

    /// <summary>
    /// Handles the click event for the divide operator button. Implement to queue a division operation (with divide-by-zero handling).
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void ButtonDivide_Click(object sender, EventArgs e)
    {
        if (!double.TryParse(txtResult.Text, out _number1))
        {
            _ = MessageBox.Show("Invalid input. Please click Clear and enter a valid number.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        txtResult.Clear();
        _math = 4; // Assuming 4 represents division

    }

    /// <summary>
    /// Handles the click event for the decimal separator button. Implement to append a decimal point if one is not already present.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void ButtonDot_Click(object sender, EventArgs e)
    {
        if (_results)
        {
            txtResult.Clear();
            _results = false;
        }

        if (txtResult.Text == "0")
        {
            txtResult.Text = ".";
        }
        else
        {
            txtResult.Text += ".";
        }
    }

    /// <summary>
    /// Handles the click event for the equals button. Implement to evaluate the current expression and display the result.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void ButtonEquals_Click(object sender, EventArgs e)
    {
        try
        {
            if (double.TryParse(txtResult.Text, out _number2))
            {
                switch (_math)
                {
                    case 1: // Addition
                        txtResult.Text = (_number1 + _number2).ToString();
                        break;
                    case 2: // Subtraction
                        txtResult.Text = (_number1 - _number2).ToString();
                        break;
                    case 3: // Multiplication
                        txtResult.Text = (_number1 * _number2).ToString();
                        break;
                    case 4: // Division
                        txtResult.Text = (_number1 / _number2).ToString();
                        break;
                    default:
                        break;
                }

                _math = 0;
                _results = true;
            }
            else
            {
                _ = MessageBox.Show("Invalid input. Please click Clear and enter a valid number.", "Input Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Clear();
                _math = 1; // Assuming 1 represents addition
            }
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtResult.Text = "0";
            _math = 0;
            _results = true;
        }
    }

    /// <summary>
    /// Handles the click event for the minus operator button. Implement to queue a subtraction operation.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void ButtonMinus_Click(object sender, EventArgs e)
    {
        if (!double.TryParse(txtResult.Text, out _number1))
        {
            _ = MessageBox.Show("Invalid input. Please click Clear and enter a valid number.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        txtResult.Clear();
        _math = 2; // Assuming 2 represents subtraction
    }

    /// <summary>
    /// Handles the click event for the multiply operator button. Implement to queue a multiplication operation.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void ButtonMultiply_Click(object sender, EventArgs e)
    {
        if (!double.TryParse(txtResult.Text, out _number1))
        {
            _ = MessageBox.Show("Invalid input. Please click Clear and enter a valid number.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        txtResult.Clear();
        _math = 3; // Assuming 3 represents multiplication

    }

    /// <summary>
    /// Handles the click event for the plus operator button. Implement to queue an addition operation.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void ButtonPlus_Click(object sender, EventArgs e)
    {
        if (!double.TryParse(txtResult.Text, out _number1))
        {
            _ = MessageBox.Show("Invalid input. Please click Clear and enter a valid number.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        txtResult.Clear();
        _math = 1; // Assuming 1 represents addition
    }

    /// <summary>
    /// Handles the click event for the square root button. Implement to compute the square root of the current value (with validation for negatives).
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void ButtonSqrt_Click(object sender, EventArgs e)
    {
        try
        {
            txtResult.Text = Math.Sqrt(double.Parse(txtResult.Text)).ToString();
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show(ex.Message);
        }
    }
}
