namespace Testing_the_Math_Class_Methods;

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
        lblTitle = new Label();
        pictureBox1 = new PictureBox();
        lblPrompt1 = new Label();
        lblPrompt3 = new Label();
        txtBoxX = new TextBox();
        txtBoxY = new TextBox();
        panel1 = new Panel();
        lblMin = new Label();
        lblMax = new Label();
        lblLog = new Label();
        lblAbs = new Label();
        panel2 = new Panel();
        lblSqrt = new Label();
        lblRound = new Label();
        lblPow = new Label();
        lblPI = new Label();
        btnCalculate = new Button();
        btnClear = new Button();
        btnExit = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(175, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(234, 19);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Testing The Math Class Methods";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(89, 45);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(100, 50);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // lblPrompt1
        // 
        lblPrompt1.AutoSize = true;
        lblPrompt1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPrompt1.Location = new Point(195, 45);
        lblPrompt1.Name = "lblPrompt1";
        lblPrompt1.Size = new Size(198, 19);
        lblPrompt1.TabIndex = 2;
        lblPrompt1.Text = "Enter a number (x) to evaluate: ";
        // 
        // lblPrompt3
        // 
        lblPrompt3.AutoSize = true;
        lblPrompt3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPrompt3.Location = new Point(195, 76);
        lblPrompt3.Name = "lblPrompt3";
        lblPrompt3.Size = new Size(198, 19);
        lblPrompt3.TabIndex = 3;
        lblPrompt3.Text = "Enter a number (y) to evaluate: ";
        // 
        // txtBoxX
        // 
        txtBoxX.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtBoxX.Location = new Point(427, 45);
        txtBoxX.Name = "txtBoxX";
        txtBoxX.Size = new Size(100, 26);
        txtBoxX.TabIndex = 4;
        txtBoxX.TextAlign = HorizontalAlignment.Right;
        // 
        // txtBoxY
        // 
        txtBoxY.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtBoxY.Location = new Point(427, 76);
        txtBoxY.Name = "txtBoxY";
        txtBoxY.Size = new Size(100, 26);
        txtBoxY.TabIndex = 5;
        txtBoxY.TextAlign = HorizontalAlignment.Right;
        // 
        // panel1
        // 
        panel1.BackColor = Color.WhiteSmoke;
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(lblMin);
        panel1.Controls.Add(lblMax);
        panel1.Controls.Add(lblLog);
        panel1.Controls.Add(lblAbs);
        panel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        panel1.Location = new Point(24, 113);
        panel1.Name = "panel1";
        panel1.Size = new Size(265, 137);
        panel1.TabIndex = 6;
        // 
        // lblMin
        // 
        lblMin.AutoSize = true;
        lblMin.Location = new Point(14, 100);
        lblMin.Name = "lblMin";
        lblMin.Size = new Size(122, 19);
        lblMin.TabIndex = 3;
        lblMin.Text = "Math.Min (x, y) = ";
        // 
        // lblMax
        // 
        lblMax.AutoSize = true;
        lblMax.Location = new Point(14, 74);
        lblMax.Name = "lblMax";
        lblMax.Size = new Size(126, 19);
        lblMax.TabIndex = 2;
        lblMax.Text = "Math.Max (x, y) = ";
        // 
        // lblLog
        // 
        lblLog.AutoSize = true;
        lblLog.Location = new Point(14, 49);
        lblLog.Name = "lblLog";
        lblLog.Size = new Size(107, 19);
        lblLog.TabIndex = 1;
        lblLog.Text = "Math.Log (x) = ";
        // 
        // lblAbs
        // 
        lblAbs.AutoSize = true;
        lblAbs.Location = new Point(14, 25);
        lblAbs.Name = "lblAbs";
        lblAbs.Size = new Size(108, 19);
        lblAbs.TabIndex = 0;
        lblAbs.Text = "Math.Abs (x) = ";
        // 
        // panel2
        // 
        panel2.BackColor = Color.WhiteSmoke;
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Controls.Add(lblSqrt);
        panel2.Controls.Add(lblRound);
        panel2.Controls.Add(lblPow);
        panel2.Controls.Add(lblPI);
        panel2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        panel2.Location = new Point(295, 113);
        panel2.Name = "panel2";
        panel2.Size = new Size(265, 137);
        panel2.TabIndex = 7;
        // 
        // lblSqrt
        // 
        lblSqrt.AutoSize = true;
        lblSqrt.Location = new Point(17, 100);
        lblSqrt.Name = "lblSqrt";
        lblSqrt.Size = new Size(109, 19);
        lblSqrt.TabIndex = 7;
        lblSqrt.Text = "Math.Sqrt (x) = ";
        // 
        // lblRound
        // 
        lblRound.AutoSize = true;
        lblRound.Location = new Point(17, 74);
        lblRound.Name = "lblRound";
        lblRound.Size = new Size(123, 19);
        lblRound.TabIndex = 6;
        lblRound.Text = "Math.Round (x) = ";
        // 
        // lblPow
        // 
        lblPow.AutoSize = true;
        lblPow.Location = new Point(17, 49);
        lblPow.Name = "lblPow";
        lblPow.Size = new Size(126, 19);
        lblPow.TabIndex = 5;
        lblPow.Text = "Math.Pow (x, y) = ";
        // 
        // lblPI
        // 
        lblPI.AutoSize = true;
        lblPI.Location = new Point(17, 25);
        lblPI.Name = "lblPI";
        lblPI.Size = new Size(97, 19);
        lblPI.TabIndex = 4;
        lblPI.Text = "Math.PI (x) = ";
        // 
        // btnCalculate
        // 
        btnCalculate.Location = new Point(174, 256);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Size = new Size(75, 23);
        btnCalculate.TabIndex = 8;
        btnCalculate.Text = "Calculate";
        btnCalculate.UseVisualStyleBackColor = true;
        btnCalculate.Click += BtnCalculate_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(255, 256);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(75, 23);
        btnClear.TabIndex = 9;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += BtnClear_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(336, 256);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(75, 23);
        btnExit.TabIndex = 10;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(584, 293);
        Controls.Add(btnExit);
        Controls.Add(btnClear);
        Controls.Add(btnCalculate);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(txtBoxY);
        Controls.Add(txtBoxX);
        Controls.Add(lblPrompt3);
        Controls.Add(lblPrompt1);
        Controls.Add(pictureBox1);
        Controls.Add(lblTitle);
        Margin = new Padding(2);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Testing the Math Class Methods";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private PictureBox pictureBox1;
    private Label lblPrompt1;
    private Label lblPrompt3;
    private TextBox txtBoxX;
    private TextBox txtBoxY;
    private Panel panel1;
    private Panel panel2;
    private Label lblMin;
    private Label lblMax;
    private Label lblLog;
    private Label lblAbs;
    private Label lblSqrt;
    private Label lblRound;
    private Label lblPow;
    private Label lblPI;
    private Button btnCalculate;
    private Button btnClear;
    private Button btnExit;
}
