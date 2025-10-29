namespace ISCT_Survey;

/// <summary>
/// Represents the main ISCT Survey form that collects user selections for class year,
/// gender, and areas of interest, provides submission handling, and shows aggregated
/// results. This form ensures that no radio buttons or checkboxes are selected when
/// first displayed and after each submission.
/// </summary>
public partial class MainForm : Form
{
    private int _senior;
    private int _junior;
    private int _sophomore;
    private int _freshmen;

    private int _female;
    private int _male;

    private int _database;
    private int _bigData;
    private int _businessIntelligence;
    private int _dataWarehousing;
    private int _operatingSystems;
    private int _networking;

    private int _counter;

    private double _averageSeniors;
    private double _averageJuniors;
    private double _averageSophomores;
    private double _averageFreshmen;

    private double _averageFemales;
    private double _averageMales;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class and wires up UI components.
    /// Ensures that no radio buttons or checkboxes are selected on initial display.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();
        // Clear any pre-selected options created by designer defaults.
        ResetSelections();
        // On first show, move focus away from radio buttons to prevent auto-checking
        // and clear selections again in case focus changed them.
        Shown += MainForm_Shown;
    }

    /// <summary>
    /// Handles the Shown event for the form.
    /// Moves focus to a non-radio control and ensures nothing is selected. This prevents
    /// the first radio button from auto-checking when it receives initial focus.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event data.</param>
    private void MainForm_Shown(object? sender, EventArgs e)
    {
        // Set focus to a neutral control so no radio button is auto-selected.
        ActiveControl = btnSubmit;
        // Ensure all selections remain cleared after focus is moved.
        ResetSelections();
    }

    /// <summary>
    /// Closes the application.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event data.</param>
    private void BtnExit_Click(object? sender, EventArgs e) => Close();

    /// <summary>
    /// Displays a simple summary of the current aggregated selections and averages.
    /// Shows a friendly message if no submissions have been made yet to avoid divide-by-zero.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event data.</param>
    private void BtnResults_Click(object? sender, EventArgs e)
    {
        // Guard against divide-by-zero when no submissions have been made yet.
        if (_counter == 0)
        {
            _ = MessageBox.Show(
            "No submissions yet. Please submit at least one response before viewing results.",
            "ISCT Survey",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            return;
        }

        _averageSeniors = (double)_senior / _counter;
        _averageJuniors = (double)_junior / _counter;
        _averageSophomores = (double)_sophomore / _counter;
        _averageFreshmen = (double)_freshmen / _counter;

        _averageFemales = (double)_female / _counter;
        _averageMales = (double)_male / _counter;

        _ = MessageBox.Show($"Survey Result{Environment.NewLine}" +
        $"Average Seniors = {_averageSeniors:P1}{Environment.NewLine}" +
        $"Average Juniors = {_averageJuniors:P1}{Environment.NewLine}" +
        $"Average Sophomores = {_averageSophomores:P1}{Environment.NewLine}" +
        $"Average Freshmen = {_averageFreshmen:P1}{Environment.NewLine}" +
        $"{Environment.NewLine}" +
        $"Average number of Females = {_averageFemales:P1}{Environment.NewLine}" +
        $"Average number of Males = {_averageMales:P1}{Environment.NewLine}" +
        $"{Environment.NewLine}" +
        $"{_database} students selected Database{Environment.NewLine}" +
        $"{_businessIntelligence} students selected Business Intelligence{Environment.NewLine}" +
        $"{_operatingSystems} students selected Operating Systems{Environment.NewLine}" +
        $"{_bigData} students selected Big Data{Environment.NewLine}" +
        $"{_networking} students selected Networking{Environment.NewLine}" +
        $"{_dataWarehousing} students selected Data Warehousing",
        "ISCT Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Handles the Submit action: increments counters based on current selections, then
    /// clears all selections for the next respondent.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event data.</param>
    private void BtnSubmit_Click(object? sender, EventArgs e)
    {
        if (rbSenior.Checked)
        {
            _senior++;
        }

        if (rbJunior.Checked)
        {
            _junior++;
        }

        if (rbSophomore.Checked)
        {
            _sophomore++;
        }

        if (rbFreshmen.Checked)
        {
            _freshmen++;
        }

        if (rbFemale.Checked)
        {
            _female++;
        }

        if (rbMale.Checked)
        {
            _male++;
        }

        if (cbDatabase.Checked)
        {
            _database++;
        }

        if (cbBigData.Checked)
        {
            _bigData++;
        }

        if (cbBusinessIntelligence.Checked)
        {
            _businessIntelligence++;
        }

        if (cbDataWarehousing.Checked)
        {
            _dataWarehousing++;
        }

        if (cbOperatingSystems.Checked)
        {
            _operatingSystems++;
        }

        if (cbNetworking.Checked)
        {
            _networking++;
        }

        _counter++;

        ResetSelections();
    }

    /// <summary>
    /// Clears all radio buttons and checkboxes across the entire form to ensure no selections are active.
    /// Uses a recursive traversal to find and reset <see cref="RadioButton"/> and <see cref="CheckBox"/> controls
    /// within any nested containers (e.g., <see cref="GroupBox"/>).
    /// </summary>
    private void ResetSelections() => UncheckToggleControls(this);

    /// <summary>
    /// Recursively traverses the control tree starting at <paramref name="root"/> and unchecks any
    /// <see cref="RadioButton"/> or <see cref="CheckBox"/> encountered. This avoids having to update this method
    /// when controls are added or rearranged in the designer.
    /// </summary>
    /// <param name="root">The root control to start traversal from.</param>
    private static void UncheckToggleControls(Control root)
    {
        foreach (Control child in root.Controls)
        {
            if (child is RadioButton radio)
            {
                radio.Checked = false;
            }
            else if (child is CheckBox checkBox)
            {
                checkBox.Checked = false;
            }

            if (child.HasChildren)
            {
                UncheckToggleControls(child);
            }
        }
    }
}
