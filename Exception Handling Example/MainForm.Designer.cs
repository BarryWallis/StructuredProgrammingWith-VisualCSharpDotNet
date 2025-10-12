namespace Exception_Handling_Example;

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
        pictureBox1 = new PictureBox();
        labelPronpt1 = new Label();
        labelPrompt2 = new Label();
        textBox1 = new TextBox();
        txtNumber2 = new TextBox();
        ButtonCalculate = new Button();
        ButtonClear = new Button();
        ButtonExit = new Button();
        lblTitle = new Label();
        labelPrompt1 = new Label();
        txtNumber1 = new TextBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(53, 29);
        pictureBox1.Margin = new Padding(2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(105, 45);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // labelPronpt1
        // 
        labelPronpt1.AutoSize = true;
        labelPronpt1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelPronpt1.Location = new Point(32, 96);
        labelPronpt1.Margin = new Padding(2, 0, 2, 0);
        labelPronpt1.Name = "labelPronpt1";
        labelPronpt1.Size = new Size(145, 19);
        labelPronpt1.TabIndex = 2;
        labelPronpt1.Text = "Enter an Integer Value:";
        // 
        // labelPrompt2
        // 
        labelPrompt2.AutoSize = true;
        labelPrompt2.Font = new Font("Times New Roman", 12F);
        labelPrompt2.Location = new Point(32, 136);
        labelPrompt2.Margin = new Padding(2, 0, 2, 0);
        labelPrompt2.Name = "labelPrompt2";
        labelPrompt2.Size = new Size(145, 19);
        labelPrompt2.TabIndex = 3;
        labelPrompt2.Text = "Enter an Integer Value:";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Times New Roman", 12F);
        textBox1.Location = new Point(184, 96);
        textBox1.Margin = new Padding(2);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(106, 26);
        textBox1.TabIndex = 4;
        textBox1.TextAlign = HorizontalAlignment.Center;
        // 
        // txtNumber2
        // 
        txtNumber2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNumber2.Location = new Point(184, 134);
        txtNumber2.Margin = new Padding(2);
        txtNumber2.Name = "txtNumber2";
        txtNumber2.Size = new Size(106, 26);
        txtNumber2.TabIndex = 5;
        txtNumber2.TextAlign = HorizontalAlignment.Center;
        // 
        // ButtonCalculate
        // 
        ButtonCalculate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ButtonCalculate.Location = new Point(39, 171);
        ButtonCalculate.Margin = new Padding(2);
        ButtonCalculate.Name = "ButtonCalculate";
        ButtonCalculate.Size = new Size(78, 25);
        ButtonCalculate.TabIndex = 6;
        ButtonCalculate.Text = "Calculate";
        ButtonCalculate.UseVisualStyleBackColor = true;
        ButtonCalculate.Click += ButtonCalculate_Click;
        // 
        // ButtonClear
        // 
        ButtonClear.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ButtonClear.Location = new Point(121, 169);
        ButtonClear.Margin = new Padding(2);
        ButtonClear.Name = "ButtonClear";
        ButtonClear.Size = new Size(78, 28);
        ButtonClear.TabIndex = 7;
        ButtonClear.Text = "Clear";
        ButtonClear.UseVisualStyleBackColor = true;
        ButtonClear.Click += ButtonClear_Click;
        // 
        // ButtonExit
        // 
        ButtonExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ButtonExit.Location = new Point(203, 168);
        ButtonExit.Margin = new Padding(2);
        ButtonExit.Name = "ButtonExit";
        ButtonExit.Size = new Size(78, 31);
        ButtonExit.TabIndex = 8;
        ButtonExit.Text = "Exit";
        ButtonExit.UseVisualStyleBackColor = true;
        ButtonExit.Click += ButtonExit_Click;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(162, 48);
        lblTitle.Margin = new Padding(2, 0, 2, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(118, 19);
        lblTitle.TabIndex = 9;
        lblTitle.Text = "A Little Addition";
        // 
        // labelPrompt1
        // 
        labelPrompt1.AutoSize = true;
        labelPrompt1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelPrompt1.Location = new Point(32, 100);
        labelPrompt1.Margin = new Padding(2, 0, 2, 0);
        labelPrompt1.Name = "labelPrompt1";
        labelPrompt1.Size = new Size(145, 19);
        labelPrompt1.TabIndex = 2;
        labelPrompt1.Text = "Enter an Integer Value:";
        // 
        // txtNumber1
        // 
        txtNumber1.Font = new Font("Times New Roman", 12F);
        txtNumber1.Location = new Point(184, 96);
        txtNumber1.Margin = new Padding(2);
        txtNumber1.Name = "txtNumber1";
        txtNumber1.Size = new Size(106, 26);
        txtNumber1.TabIndex = 4;
        txtNumber1.TextAlign = HorizontalAlignment.Center;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(321, 225);
        Controls.Add(lblTitle);
        Controls.Add(ButtonExit);
        Controls.Add(ButtonClear);
        Controls.Add(ButtonCalculate);
        Controls.Add(txtNumber2);
        Controls.Add(txtNumber1);
        Controls.Add(textBox1);
        Controls.Add(labelPrompt1);
        Controls.Add(labelPrompt2);
        Controls.Add(labelPronpt1);
        Controls.Add(pictureBox1);
        Margin = new Padding(2);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Exception Handling Example";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label labelPronpt1;
    private Label labelPrompt2;
    private TextBox textBox1;
    private TextBox txtNumber2;
    private Button ButtonCalculate;
    private Button ButtonClear;
    private Button ButtonExit;
    private Label lblTitle;
    private Label labelPrompt1;
    private TextBox txtNumber1;
}
