using System.Xml;

namespace Retirement_Eligibility_Application;

/// <summary>
/// Represents the main Windows Form for the Retirement Eligibility Application.
/// </summary>
/// <remarks>
/// Provides UI event handlers to calculate retirement and Social Security eligibility,
/// clear inputs, and close the form.
/// </remarks>
public partial class Form1 : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Form1"/> class.
    /// </summary>
    /// <remarks>
    /// Invokes <see cref="InitializeComponent"/> to construct and configure the form controls.
    /// </remarks>
    public Form1() => InitializeComponent();

    /// <summary>
    /// Handles the Calculate button click to evaluate retirement and Social Security eligibility.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    /// <remarks>
    /// Reads values from <c>txtYearsWorked</c> and <c>txtBirthday</c>, computes eligibility based on
    /// years of service and age, and shows the result in a message box.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Example of wiring the event handler in code (typically done in the designer):
    /// // btnCalculate.Click += BtnCalculate_Click;
    /// </code>
    /// </example>
    private void BtnCalculate_Click(object sender, EventArgs e)
    {
        int yearsOnJob = int.Parse(txtYearsWorked.Text);
        DateTime birthdate = DateTime.Parse(txtBirthday.Text);

        _ = yearsOnJob >= 5
            ? birthdate <= DateTime.Today.AddYears(-65)
                ? MessageBox.Show("You are eligible for retirement & Social Security")
                : MessageBox.Show("You are eligible for retirement, but not Social Security")
            : birthdate <= DateTime.Today.AddYears(-65)
                ? MessageBox.Show("You are not vested in the retirement system, but you are eligible for Social Security")
                : MessageBox.Show("You are not vested in the retirement system nor qualified for Social Security");
    }

    /// <summary>
    /// Handles the Clear button click to reset input fields on the form.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    /// <remarks>
    /// Clears the contents of <c>txtBirthday</c> and <c>txtYearsWorked</c>.
    /// </remarks>
    private void BtnClear_Click(object sender, EventArgs e)
    {
        txtBirthday.Clear();
        txtYearsWorked.Clear();
    }

    /// <summary>
    /// Handles the Close button click to exit the form.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    /// <remarks>
    /// Calls <see cref="Form.Close"/> to close the window.
    /// </remarks>
    private void Button3_Click(object sender, EventArgs e) => Close();
}
