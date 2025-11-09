namespace Rolling_Heart;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null!;

    private Label LabelTitle = null!;
    private PictureBox PictureBoxHeart1 = null!;
    private Button ButtonRoll = null!;
    private Button ButtonReSet = null!;
    private Button ButtonExit = null!;
    private System.Windows.Forms.Timer Timer1 = null!;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components is not null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Initialize the form and controls per specification so they are editable in the designer.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        LabelTitle = new Label();
        PictureBoxHeart1 = new PictureBox();
        ButtonRoll = new Button();
        ButtonReSet = new Button();
        ButtonExit = new Button();
        Timer1 = new System.Windows.Forms.Timer(components);
        PictureBoxHeart3 = new PictureBox();
        PictureBoxHeart2 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)PictureBoxHeart1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PictureBoxHeart3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PictureBoxHeart2).BeginInit();
        SuspendLayout();
        // 
        // LabelTitle
        // 
        LabelTitle.AutoSize = true;
        LabelTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        LabelTitle.Location = new Point(130, 30);
        LabelTitle.Name = "LabelTitle";
        LabelTitle.Size = new Size(211, 19);
        LabelTitle.TabIndex = 0;
        LabelTitle.Text = "Welcome to the Rolling Heart.";
        // 
        // PictureBoxHeart1
        // 
        PictureBoxHeart1.ImageLocation = "";
        PictureBoxHeart1.InitialImage = (Image)resources.GetObject("PictureBoxHeart1.InitialImage");
        PictureBoxHeart1.Location = new Point(63, 78);
        PictureBoxHeart1.Name = "PictureBoxHeart1";
        PictureBoxHeart1.Size = new Size(54, 54);
        PictureBoxHeart1.SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBoxHeart1.TabIndex = 1;
        PictureBoxHeart1.TabStop = false;
        // 
        // ButtonRoll
        // 
        ButtonRoll.Font = new Font("Times New Roman", 12F);
        ButtonRoll.Location = new Point(30, 163);
        ButtonRoll.Name = "ButtonRoll";
        ButtonRoll.Size = new Size(120, 45);
        ButtonRoll.TabIndex = 4;
        ButtonRoll.Text = "Roll My Heart";
        ButtonRoll.UseVisualStyleBackColor = true;
        ButtonRoll.Click += ButtonRoll_Click;
        // 
        // ButtonReSet
        // 
        ButtonReSet.Font = new Font("Times New Roman", 12F);
        ButtonReSet.Location = new Point(175, 163);
        ButtonReSet.Name = "ButtonReSet";
        ButtonReSet.Size = new Size(120, 45);
        ButtonReSet.TabIndex = 5;
        ButtonReSet.Text = "Re-Set";
        ButtonReSet.UseVisualStyleBackColor = true;
        ButtonReSet.Click += ButtonReSet_Click;
        // 
        // ButtonExit
        // 
        ButtonExit.Font = new Font("Times New Roman", 12F);
        ButtonExit.Location = new Point(320, 163);
        ButtonExit.Name = "ButtonExit";
        ButtonExit.Size = new Size(120, 45);
        ButtonExit.TabIndex = 6;
        ButtonExit.Text = "Exit";
        ButtonExit.UseVisualStyleBackColor = true;
        ButtonExit.Click += ButtonExit_Click;
        // 
        // Timer1
        // 
        Timer1.Interval = 200;
        Timer1.Tick += Timer1_Tick;
        // 
        // PictureBoxHeart3
        // 
        PictureBoxHeart3.ImageLocation = "";
        PictureBoxHeart3.InitialImage = (Image)resources.GetObject("PictureBoxHeart3.InitialImage");
        PictureBoxHeart3.Location = new Point(353, 78);
        PictureBoxHeart3.Name = "PictureBoxHeart3";
        PictureBoxHeart3.Size = new Size(54, 54);
        PictureBoxHeart3.SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBoxHeart3.TabIndex = 3;
        PictureBoxHeart3.TabStop = false;
        // 
        // PictureBoxHeart2
        // 
        PictureBoxHeart2.ImageLocation = "";
        PictureBoxHeart2.InitialImage = (Image)resources.GetObject("PictureBoxHeart2.InitialImage");
        PictureBoxHeart2.Location = new Point(208, 78);
        PictureBoxHeart2.Name = "PictureBoxHeart2";
        PictureBoxHeart2.Size = new Size(54, 54);
        PictureBoxHeart2.SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBoxHeart2.TabIndex = 2;
        PictureBoxHeart2.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(470, 242);
        Controls.Add(LabelTitle);
        Controls.Add(PictureBoxHeart1);
        Controls.Add(PictureBoxHeart2);
        Controls.Add(PictureBoxHeart3);
        Controls.Add(ButtonRoll);
        Controls.Add(ButtonReSet);
        Controls.Add(ButtonExit);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Testing a Time Loop";
        ((System.ComponentModel.ISupportInitialize)PictureBoxHeart1).EndInit();
        ((System.ComponentModel.ISupportInitialize)PictureBoxHeart3).EndInit();
        ((System.ComponentModel.ISupportInitialize)PictureBoxHeart2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox PictureBoxHeart3;
    private PictureBox PictureBoxHeart2;
}
