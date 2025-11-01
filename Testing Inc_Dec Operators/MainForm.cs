using System;

namespace Testing_Inc_Dec_Operators;

/// <summary>
/// Main form for the "Testing Increment/Decrement Operators" demo.
/// </summary>
/// <remarks>
/// This form displays an image (assigned via the designer) and provides buttons to
/// demonstrate the behavior of prefix and postfix increment operators using message boxes.
/// </remarks>
public partial class MainForm : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    /// <remarks>
    /// UI elements and resources are created and assigned in the generated designer file.
    /// </remarks>
    public MainForm() => InitializeComponent(); // Image is loaded from resources via the designer.

    /// <summary>
    /// Demonstrates prefix and postfix increment operators with a simple counter.
    /// </summary>
    /// <param name="sender">The event source, typically the Calculate button.</param>
    /// <param name="e">Event arguments for the click event.</param>
    /// <remarks>
    /// The method starts a counter at5 and shows several message boxes that reveal the
    /// different timings of increment operations when used in expressions.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Starting counter at5
    /// Results =5 // counter++ returns original value (5), then counter becomes6
    /// Results =6 // counter now6
    /// Results =7 // ++counter increments first to7, then returns7
    /// Results =8 // counter++ (returns7), then +1 =>8; counter becomes8 afterwards
    /// Results =10 // ++counter (becomes9) +1 =>10
    /// </code>
    /// </example>
    private void BtnCalculate_Click(object sender, EventArgs e)
    {
        int counter = 5;
        _ = MessageBox.Show($"Results = {counter++}");
        _ = MessageBox.Show($"Results = {counter}");
        _ = MessageBox.Show($"Results = {++counter}");
        _ = MessageBox.Show($"Results = {counter++ + 1}");
        _ = MessageBox.Show($"Results = {++counter + 1}");
    }

    /// <summary>
    /// Closes the application when the Exit button is clicked.
    /// </summary>
    /// <param name="sender">The event source, typically the Exit button.</param>
    /// <param name="e">Event arguments for the click event.</param>
    private void BtnExit_Click(object sender, EventArgs e) => Close();
}
