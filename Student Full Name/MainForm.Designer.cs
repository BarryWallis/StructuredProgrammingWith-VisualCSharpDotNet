namespace Student_Full_Name;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        pictureBoxMain = new PictureBox();
        labelTitle = new Label();
        labelFirstPrompt = new Label();
        labelLastPrompt = new Label();
        textBoxFirstName = new TextBox();
        textBoxLastName = new TextBox();
        labelOutput = new Label();
        ButtonSubmit = new Button();
        ButtonExit = new Button();
        ButtonClear = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
        SuspendLayout();
        // 
        // pictureBoxMain
        // 
        pictureBoxMain.Image = (Image)resources.GetObject("pictureBoxMain.Image");
        pictureBoxMain.Location = new Point(86, 12);
        pictureBoxMain.Name = "pictureBoxMain";
        pictureBoxMain.Size = new Size(68, 50);
        pictureBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxMain.TabIndex = 0;
        pictureBoxMain.TabStop = false;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        labelTitle.Location = new Point(160, 28);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(120, 19);
        labelTitle.TabIndex = 1;
        labelTitle.Text = "Student Records";
        // 
        // labelFirstPrompt
        // 
        labelFirstPrompt.AutoSize = true;
        labelFirstPrompt.Font = new Font("Times New Roman", 12F);
        labelFirstPrompt.Location = new Point(11, 82);
        labelFirstPrompt.Name = "labelFirstPrompt";
        labelFirstPrompt.Size = new Size(175, 19);
        labelFirstPrompt.TabIndex = 2;
        labelFirstPrompt.Text = "Enter Student's First Name:";
        // 
        // labelLastPrompt
        // 
        labelLastPrompt.AutoSize = true;
        labelLastPrompt.Font = new Font("Times New Roman", 12F);
        labelLastPrompt.Location = new Point(12, 123);
        labelLastPrompt.Name = "labelLastPrompt";
        labelLastPrompt.Size = new Size(174, 19);
        labelLastPrompt.TabIndex = 3;
        labelLastPrompt.Text = "Enter Student's Last Name:";
        // 
        // textBoxFirstName
        // 
        textBoxFirstName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBoxFirstName.Location = new Point(192, 79);
        textBoxFirstName.Name = "textBoxFirstName";
        textBoxFirstName.Size = new Size(162, 26);
        textBoxFirstName.TabIndex = 4;
        // 
        // textBoxLastName
        // 
        textBoxLastName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBoxLastName.Location = new Point(192, 120);
        textBoxLastName.Name = "textBoxLastName";
        textBoxLastName.Size = new Size(162, 26);
        textBoxLastName.TabIndex = 5;
        // 
        // labelOutput
        // 
        labelOutput.BorderStyle = BorderStyle.FixedSingle;
        labelOutput.Font = new Font("Times New Roman", 12F);
        labelOutput.Location = new Point(12, 168);
        labelOutput.Name = "labelOutput";
        labelOutput.Size = new Size(342, 23);
        labelOutput.TabIndex = 6;
        labelOutput.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ButtonSubmit
        // 
        ButtonSubmit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ButtonSubmit.Location = new Point(105, 212);
        ButtonSubmit.Name = "ButtonSubmit";
        ButtonSubmit.Size = new Size(75, 23);
        ButtonSubmit.TabIndex = 7;
        ButtonSubmit.Text = "Submit";
        ButtonSubmit.UseVisualStyleBackColor = true;
        ButtonSubmit.Click += ButtonSubmit_Click;
        // 
        // ButtonExit
        // 
        ButtonExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ButtonExit.Location = new Point(186, 212);
        ButtonExit.Name = "ButtonExit";
        ButtonExit.Size = new Size(75, 23);
        ButtonExit.TabIndex = 8;
        ButtonExit.Text = "Exit";
        ButtonExit.UseVisualStyleBackColor = true;
        ButtonExit.Click += ButtonExit_Click;
        // 
        // ButtonClear
        // 
        ButtonClear.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ButtonClear.Location = new Point(24, 212);
        ButtonClear.Name = "ButtonClear";
        ButtonClear.Size = new Size(75, 23);
        ButtonClear.TabIndex = 9;
        ButtonClear.Text = "Clear";
        ButtonClear.UseVisualStyleBackColor = true;
        ButtonClear.Click += ButtonClear_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(366, 247);
        Controls.Add(ButtonClear);
        Controls.Add(ButtonExit);
        Controls.Add(ButtonSubmit);
        Controls.Add(labelOutput);
        Controls.Add(textBoxLastName);
        Controls.Add(textBoxFirstName);
        Controls.Add(labelLastPrompt);
        Controls.Add(labelFirstPrompt);
        Controls.Add(labelTitle);
        Controls.Add(pictureBoxMain);
        Name = "MainForm";
        Text = "Outputting the Student's Full Name";
        ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxMain;
    private Label labelTitle;
    private Label labelFirstPrompt;
    private Label labelLastPrompt;
    private TextBox textBoxFirstName;
    private TextBox textBoxLastName;
    private Label labelOutput;
    private Button ButtonSubmit;
    private Button ButtonExit;
    private Button ButtonClear;
}
