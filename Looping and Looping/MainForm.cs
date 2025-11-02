namespace Looping_and_Looping;

/// <summary>
/// Windows Form that demonstrates repetition structures (<c>while</c>, <c>for</c>, and <c>do-while</c>)
/// by computing the arithmetic mean of numeric items listed in a <see cref="ListBox"/>.
/// </summary>
/// <remarks>
/// Click the corresponding buttons to compute the mean of the values in <c>lbNumbers</c> and
/// display the result in <c>lblOutPut</c>.
/// <para>
/// This demo assumes that all items in <c>lbNumbers</c> are numeric and that the list is not empty.
/// Handlers will throw on invalid items and will divide by zero for an empty list; this is intentional for
/// teaching purposes and can be hardened as a next step.
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
 /// Computes and displays the arithmetic mean using a <c>while</c> loop.
 /// </summary>
 /// <param name="sender">The control that raised the event.</param>
 /// <param name="e">Event data.</param>
 /// <remarks>
 /// Assumes all items in <see cref="lbNumbers"/> are numeric strings or boxed numeric values.
 /// </remarks>
 private void ButtonWhile_Click(object sender, EventArgs e)
 {
 int counter =0;
 int total =0;

 while (counter < lbNumbers.Items.Count)
 {
 total += Convert.ToInt32(lbNumbers.Items[counter]);
 counter++;
 }

 lblOutPut.Text = $"while-loop{Environment.NewLine}{_prefixText}{(double)total / lbNumbers.Items.Count:n3}";
 }

 /// <summary>
 /// Computes and displays the arithmetic mean using a <c>for</c> loop.
 /// </summary>
 /// <param name="sender">The control that raised the event.</param>
 /// <param name="e">Event data.</param>
 /// <remarks>
 /// Assumes all items in <see cref="lbNumbers"/> are numeric strings or boxed numeric values.
 /// </remarks>
 private void ButtonFor_Click(object sender, EventArgs e)
 {
 int total =0;
 for (int i =0; i < lbNumbers.Items.Count; i++)
 {
 total += Convert.ToInt32(lbNumbers.Items[i]);
 }

 lblOutPut.Text = $"for-loop{Environment.NewLine}{_prefixText}{(double)total / lbNumbers.Items.Count:n3}";
 }

 /// <summary>
 /// Computes and displays the arithmetic mean using a <c>do-while</c> loop.
 /// </summary>
 /// <param name="sender">The control that raised the event.</param>
 /// <param name="e">Event data.</param>
 /// <remarks>
 /// Assumes all items in <see cref="lbNumbers"/> are numeric strings or boxed numeric values.
 /// </remarks>
 private void ButtonDoWhile_Click(object sender, EventArgs e)
 {
 int total =0;
 int counter =0;

 do
 {
 total += Convert.ToInt32(lbNumbers.Items[counter]);
 counter++;
 } while (counter < lbNumbers.Items.Count);

 lblOutPut.Text = $"do-while{Environment.NewLine}{_prefixText}{(double)total / lbNumbers.Items.Count:n3}";
 }

 /// <summary>
 /// Clears the output label by restoring its initial prefix text.
 /// </summary>
 /// <param name="sender">The control that raised the event.</param>
 /// <param name="e">Event data.</param>
 private void BtnClear_Click(object sender, EventArgs e)
 {
 lblOutPut.Text = _prefixText;
 }

 /// <summary>
 /// Closes the form and exits the application.
 /// </summary>
 /// <param name="sender">The control that raised the event.</param>
 /// <param name="e">Event data.</param>
 private void BtnExit_Click(object sender, EventArgs e) => Close();
}
