namespace Testing_Inc_Dec_Operators;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // Controls
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Button btnExit;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        labelTitle = new Label();
        pictureBox = new PictureBox();
        btnCalculate = new Button();
        btnExit = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Dock = DockStyle.Top;
        labelTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        labelTitle.Location = new Point(0, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(484, 60);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Testing the Increment/Decrement Operators with\r\nPrefix and Postfix Modes";
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pictureBox
        // 
        pictureBox.BorderStyle = BorderStyle.FixedSingle;
        pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
        pictureBox.Location = new Point(60, 95);
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new Size(200, 150);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.TabIndex = 1;
        pictureBox.TabStop = false;
        // 
        // btnCalculate
        // 
        btnCalculate.Location = new Point(300, 110);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Size = new Size(120, 45);
        btnCalculate.TabIndex = 2;
        btnCalculate.Text = "Calculate";
        btnCalculate.UseVisualStyleBackColor = true;
        btnCalculate.Click += BtnCalculate_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(300, 185);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(120, 45);
        btnExit.TabIndex = 3;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 286);
        Controls.Add(btnExit);
        Controls.Add(btnCalculate);
        Controls.Add(pictureBox);
        Controls.Add(labelTitle);
        Font = new Font("Times New Roman", 12F);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Testing Prefix and Postfix Modes";
        ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
        ResumeLayout(false);
    }

    #endregion
}
