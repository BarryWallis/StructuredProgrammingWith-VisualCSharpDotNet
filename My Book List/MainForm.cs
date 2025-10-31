namespace My_Book_List;

/// <summary>
/// The main Windows Forms UI for the "My Book List" sample.
/// Provides simple list management: add, update, count, clear, and exit.
/// </summary>
public partial class MainForm : Form
{
    /// <summary>
    /// Holds the index of the currently selected item in <see cref="lstBooks"/>.
    /// A value of -1 indicates no selection.
    /// </summary>
    private int _indexNumber;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class and
    /// sets up the form's components.
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Synchronizes <see cref="txtListItem"/> with the selected item and tracks its index
    /// whenever the selection in <see cref="lstBooks"/> changes.
    /// </summary>
    /// <param name="sender">The source of the event (books list box).</param>
    /// <param name="e">Standard event data.</param>
    private void LstBooks_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtListItem.Text = lstBooks.SelectedItem?.ToString();
        _indexNumber = lstBooks.Items.IndexOf(txtListItem.Text);
    }

    /// <summary>
    /// Replaces the currently selected list item with the text in <see cref="txtListItem"/>.
    /// If no item is selected, an informational message is shown to the user.
    /// </summary>
    /// <param name="sender">The source of the event (Submit button).</param>
    /// <param name="e">Standard event data.</param>
    private void BtnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtListItem.Text))
        {
            if (_indexNumber < 0)
            {
                _ = MessageBox.Show("Please select an item to update from the list.", "No Item Selected", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
            }
            else
            {
                lstBooks.Items.Insert(_indexNumber, txtListItem.Text);
                lstBooks.Items.RemoveAt(_indexNumber + 1);
            }

        }
    }

    /// <summary>
    /// Adds the text in <see cref="txtListItem"/> to <see cref="lstBooks"/> if it is not empty,
    /// clears the input box, and returns focus to it.
    /// </summary>
    /// <param name="sender">The source of the event (Add Item button).</param>
    /// <param name="e">Standard event data.</param>
    private void BtnAddItem_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtListItem.Text))
        {
            _ = lstBooks.Items.Add(txtListItem.Text);
            txtListItem.Clear();
        }

        _ = txtListItem.Focus();
    }

    /// <summary>
    /// Displays the current number of items in <see cref="lstBooks"/> by writing the count
    /// into <see cref="txtListItem"/>.
    /// </summary>
    /// <param name="sender">The source of the event (Count Items button).</param>
    /// <param name="e">Standard event data.</param>
    private void BtnCountItems_Click(object sender, EventArgs e) => txtListItem.Text = $"Total number of books: {lstBooks.Items.Count}";

    /// <summary>
    /// Placeholder for handling text changes in <see cref="txtListItem"/>.
    /// Useful for future validation or enabling/disabling buttons.
    /// </summary>
    /// <param name="sender">The source of the event (text box).</param>
    /// <param name="e">Standard event data.</param>
    private void TxtListItem_TextChanged(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Closes the application window.
    /// </summary>
    /// <param name="sender">The source of the event (Exit button).</param>
    /// <param name="e">Standard event data.</param>
    private void BtnExit_Click(object sender, EventArgs e) => Close();

    /// <summary>
    /// Removes all items from <see cref="lstBooks"/>.
    /// </summary>
    /// <param name="sender">The source of the event (Clear Items button).</param>
    /// <param name="e">Standard event data.</param>
    private void BtnClearItems_Click(object sender, EventArgs e) => lstBooks.Items.Clear();

    /// <summary>
    /// Clears the text from <see cref="txtListItem"/>.
    /// </summary>
    /// <param name="sender">The source of the event (Clear button).</param>
    /// <param name="e">Standard event data.</param>
    private void BtnClear_Click(object sender, EventArgs e) => txtListItem.Clear();
}
