namespace My_Calculator;

/// <summary>
/// Represents the main calculator form. This partial class contains user-authored
/// event handler stubs for calculator button interactions. The visual layout and
/// control field declarations are defined in the designer-generated partial class.
/// </summary>
public partial class MainForm : Form
{
    /// <summary>
    /// Represents the calculator operation currently selected.
    /// Using an enum improves readability and maintainability over magic integers.
    /// </summary>
    private enum MathOperation
    {
        /// <summary>
        /// No operation selected.
        /// </summary>
        None = 0,

        /// <summary>
        /// Add two numbers.
        /// </summary>
        Addition = 1,

        /// <summary>
        /// Subtract the second number from the first.
        /// </summary>
        Subtraction = 2,

        /// <summary>
        /// Multiply two numbers.
        /// </summary>
        Multiplication = 3,

        /// <summary>
        /// Divide the first number by the second.
        /// </summary>
        Division = 4
    }

    private double _number1 = 0.0;
    private double _number2 = 0.0;
    private MathOperation _math = MathOperation.None;
    private bool _results = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class and wires up UI components.
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Appends the digit '0' to the current input.
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
    /// Appends the digit '1' to the current input.
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
    /// Appends the digit '2' to the current input.
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
    /// Appends the digit '3' to the current input.
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
    /// Appends the digit '4' to the current input.
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
    /// Appends the digit '5' to the current input.
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
    /// Appends the digit '6' to the current input.
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
    /// Appends the digit '7' to the current input.
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
    /// Appends the digit '8' to the current input.
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
    /// Appends the digit '9' to the current input.
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
    /// Resets the current input and any stored state.
    /// </summary>
    /// <param name="sender">The control that raised the event.</param>
    /// <param name="e">Event arguments.</param>
    private void ButtonClear_Click(object sender, EventArgs e)
    {
        txtResult.Text = "0";
        _math = MathOperation.None;
    }

    /// <summary>
    /// Queues a division operation.
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
        _math = MathOperation.Division; // Division

    }

    /// <summary>
    /// Appends a decimal point to the current input.
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
    /// Evaluates the current expression and displays the result.
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
                    case MathOperation.Addition: // Addition
                        txtResult.Text = (_number1 + _number2).ToString();
                        break;
                    case MathOperation.Subtraction: // Subtraction
                        txtResult.Text = (_number1 - _number2).ToString();
                        break;
                    case MathOperation.Multiplication: // Multiplication
                        txtResult.Text = (_number1 * _number2).ToString();
                        break;
                    case MathOperation.Division: // Division
                        txtResult.Text = (_number1 / _number2).ToString();
                        break;
                    default:
                        break;
                }

                _math = MathOperation.None;
                _results = true;
            }
            else
            {
                _ = MessageBox.Show("Invalid input. Please click Clear and enter a valid number.", "Input Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Clear();
                _math = MathOperation.Addition; // Default to addition
            }
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtResult.Text = "0";
            _math = MathOperation.None;
            _results = true;
        }
    }

    /// <summary>
    /// Queues a subtraction operation.
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
        _math = MathOperation.Subtraction; // Subtraction
    }

    /// <summary>
    /// Queues a multiplication operation.
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
        _math = MathOperation.Multiplication; // Multiplication

    }

    /// <summary>
    /// Queues an addition operation.
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
        _math = MathOperation.Addition; // Addition
    }

    /// <summary>
    /// Computes the square root of the current value.
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
