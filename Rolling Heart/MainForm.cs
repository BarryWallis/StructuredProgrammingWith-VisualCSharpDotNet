using System.Reflection;

namespace Rolling_Heart;

public partial class MainForm : Form
{
    // Horizontal movement step per timer tick (animation speed).
    private const int RollStep = 10;

    // Current X position of the rolling image.
    private int _currentX;

    // Stable starting coordinates captured at construction for reset scenarios.
    private readonly int _startY;
    private readonly int _startX;

    private readonly string _heartText = "Roll My Heart!";
    private readonly string _ballText = "Roll";

    /// <summary>
    /// Initializes the form and its components.
    /// Sets initial images and prepares animation state. Double buffering reduces flicker.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();

        // Helps reduce redraw flicker when moving the PictureBox.
        DoubleBuffered = true;

        _currentX = PictureBoxHeart1.Location.X;
        _startX = _currentX;
        _startY = PictureBoxHeart1.Location.Y;

        SetAllHearts();
        ButtonRoll.Text = _heartText;
    }

    /// <summary>
    /// Starts the rolling animation (shows only first heart).
    /// </summary>
    private void ButtonRoll_Click(object? sender, EventArgs e)
    {
        PrepareRollState();
        Timer1.Start();
    }

    /// <summary>
    /// Resets UI state to the Ball variant and stops animation.
    /// Uses resource lookup with fallback to ensure compatibility if strongly-typed resource is missing.
    /// </summary>
    private void ButtonReSet_Click(object? sender, EventArgs e)
    {
        Timer1.Stop();
        PrepareRollState();

        // Attempt to load Ball image from resources.
        Image ball = GetResourceImage("Ball") ?? throw new InvalidOperationException("Failed to load Ball image from resources.");
        PictureBoxHeart1.Image = ball;

        ButtonRoll.Text = _ballText;
    }

    /// <summary>
    /// Exits the application.
    /// </summary>
    private void ButtonExit_Click(object? sender, EventArgs e) => Close();

    /// <summary>
    /// Advances the rolling image. When it fully leaves client area, completes the roll.
    /// </summary>
    private void Timer1_Tick(object? sender, EventArgs e)
    {
        PictureBoxHeart1.Location = new Point(_currentX, _startY);
        _currentX += RollStep;

        // Use Right so entire image leaves before finishing.
        if (PictureBoxHeart1.Right >= ClientSize.Width)
        {
            Timer1.Stop();
            CompleteRoll();
        }
    }

    /// <summary>
    /// Sets all picture boxes to heart images and makes them visible.
    /// </summary>
    private void SetAllHearts()
    {
        PictureBoxHeart1.Image = Properties.Resources.Heart;
        PictureBoxHeart2.Image = Properties.Resources.Heart;
        PictureBoxHeart3.Image = Properties.Resources.Heart;
        PictureBoxHeart1.Visible = true;
        PictureBoxHeart2.Visible = true;
        PictureBoxHeart3.Visible = true;
    }

    /// <summary>
    /// Prepares state for a single heart roll (only first visible, position reset).
    /// </summary>
    private void PrepareRollState()
    {
        PictureBoxHeart1.Visible = true;
        PictureBoxHeart2.Visible = false;
        PictureBoxHeart3.Visible = false;
        _currentX = PictureBoxHeart1.Location.X; // grab live X in case user moved control in designer.
    }

    /// <summary>
    /// Completes the roll: resets position, restores heart images and button text.
    /// </summary>
    private void CompleteRoll()
    {
        _currentX = _startX;
        PictureBoxHeart1.Location = new Point(_startX, _startY);
        SetAllHearts();
        ButtonRoll.Text = _heartText;
    }

    /// <summary>
    /// Helper to get an Image resource by name using the project's ResourceManager.
    /// Returns null if the named resource is not found or is not an Image.
    /// </summary>
    private static Image? GetResourceImage(string resourceName)
    {
        object? obj = Properties.Resources.ResourceManager.GetObject(resourceName, Properties.Resources.Culture);
        return obj as Image;
    }
}
