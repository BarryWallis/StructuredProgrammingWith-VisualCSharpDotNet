namespace My_Book_List;

public partial class MainForm : Form
{
    private int _indexNumber;

    public MainForm() => InitializeComponent();

    private void LstBooks_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtListItem.Text = lstBooks.SelectedItem?.ToString();
        _indexNumber = lstBooks.Items.IndexOf(txtListItem.Text);
    }

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

    private void BtnAddItem_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtListItem.Text))
        {
            _ = lstBooks.Items.Add(txtListItem.Text);
            txtListItem.Clear();
        }

        _ = txtListItem.Focus();
    }

    private void BtnCountItems_Click(object sender, EventArgs e) => txtListItem.Text = $"Total number of books: {lstBooks.Items.Count}";

    private void TxtListItem_TextChanged(object sender, EventArgs e)
    {

    }

    private void BtnExit_Click(object sender, EventArgs e) => Close();

    private void BtnClearItems_Click(object sender, EventArgs e) => lstBooks.Items.Clear();

    private void BtnClear_Click(object sender, EventArgs e) => txtListItem.Clear();
}
