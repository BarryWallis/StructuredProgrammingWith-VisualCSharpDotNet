namespace ISCT_Survey;

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
    /// Initializes a new instance of the MainForm and wires up UI components.
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Close the application.
    /// </summary>
    private void BtnExit_Click(object? sender, EventArgs e) => Close();

    /// <summary>
    /// Show a simple summary of the current selections.
    /// </summary>
    private void BtnResults_Click(object? sender, EventArgs e)
    {
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
    /// Simulate submit - currently just confirms the form is submitted.
    /// </summary>
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
        
        rbSenior.Checked = false;
        rbJunior.Checked = false;  
        rbSophomore.Checked = false;
        rbFreshmen.Checked = false;

        rbFemale.Checked = false;
        rbMale.Checked = false;

        cbDatabase.Checked = false;
        cbBigData.Checked = false;
        cbBusinessIntelligence.Checked = false;
        cbDataWarehousing.Checked = false;
        cbOperatingSystems.Checked = false;
        cbNetworking.Checked = false;
    }
}
