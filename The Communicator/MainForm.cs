using System.Speech.Synthesis;

namespace The_Communicator;

public partial class MainForm : Form
{
    private readonly SpeechSynthesizer _read = new();

    public MainForm() => InitializeComponent();

    // Exit the application when Exit button is clicked.
    private void btnExit_Click(object? sender, EventArgs e) => Close();

    private void MainForm_Load(object sender, EventArgs e) => _read.SpeakAsync(lblPrompt.Text);

    private void BtnYes_Click(object sender, EventArgs e)
        => _read.SpeakAsync($"{rtbRead.Text}Thank you for allowubg ne to prove my LOVE to thee!");

    private void BtnExit_Click_1(object sender, EventArgs e) => Close();
}
