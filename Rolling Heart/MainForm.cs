using System.Reflection;

namespace Rolling_Heart;

public partial class MainForm : Form
{
    private int _x;
    private readonly int _y;
    private readonly int _originalX;
    private readonly string _heartText = "Roll My Heart!";
    private readonly string _ballText = "Roll";

    /// <summary>
    /// Initializes the form and its components. All UI elements are defined in the designer so they remain editable.
    /// Sets initial images for picture boxes from strongly-typed resources.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();

        _x = PictureBoxHeart1.Location.X;
        _y = PictureBoxHeart1.Location.Y;
        _originalX = _x;

        PictureBoxHeart1.Image = Properties.Resources.Heart;
        PictureBoxHeart2.Image = Properties.Resources.Heart;
        PictureBoxHeart3.Image = Properties.Resources.Heart;

        ButtonRoll.Text = _heartText;
    }

    /// <summary>
    /// Handles the Roll button click by starting the timer-driven animation.
    /// </summary>
    private void ButtonRoll_Click(object? sender, EventArgs e)
    {
        PictureBoxHeart1.Visible = true;
        PictureBoxHeart2.Visible = false;
        PictureBoxHeart3.Visible = false;

        Timer1.Enabled = true;
    }

    /// <summary>
    /// Handles the Re-Set button click by stopping the animation and restoring UI state.
    /// Loads the Ball image from project resources (same approach as Heart.png).
    /// </summary>
    private void ButtonReSet_Click(object? sender, EventArgs e)
    {
        Timer1.Enabled = false;

        PictureBoxHeart1.Visible = true;
        PictureBoxHeart2.Visible = false;
        PictureBoxHeart3.Visible = false;

        // Load Ball from the resources like Heart (no reflection or manifest streams needed).
        object? obj = Properties.Resources.ResourceManager.GetObject("Ball", Properties.Resources.Culture);
        PictureBoxHeart1.Image = obj is Image ball ? ball 
                                                   : throw new InvalidOperationException("Failed to load Ball image from resources.");

        ButtonRoll.Text = _ballText;
    }

    /// <summary>
    /// Handles the Exit button click by closing the form.
    /// </summary>
    private void ButtonExit_Click(object? sender, EventArgs e) => Close();

    /// <summary>
    /// Advances the visible heart on each timer tick, creating a simple rolling effect.
    /// </summary>
    private void Timer1_Tick(object? sender, EventArgs e)
    {
        PictureBoxHeart1.Location = new Point(_x, _y);
        _x += 10;
        if (_x > ClientSize.Width)
        {
            Timer1.Enabled = false;
            _x = _originalX;
            PictureBoxHeart1.Location = new Point(_x, _y);
            PictureBoxHeart1.Image = Properties.Resources.Heart;
            PictureBoxHeart2.Visible = true;
            PictureBoxHeart3.Visible = true;
            ButtonRoll.Text = _heartText;
        }
    }
}
