namespace Guess_the_Number_Game;

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
        components = new System.ComponentModel.Container();
        lblTitle = new Label();
        lblPrompt = new Label();
        textBox1 = new TextBox();
        btnEvaluate = new Button();
        btnExit = new Button();
        bindingSource1 = new BindingSource(components);
        txtGuess = new TextBox();
        ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(81, 19);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(266, 26);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Guess the Number Game";
        // 
        // lblPrompt
        // 
        lblPrompt.AutoSize = true;
        lblPrompt.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPrompt.Location = new Point(11, 109);
        lblPrompt.Name = "lblPrompt";
        lblPrompt.Size = new Size(348, 81);
        lblPrompt.TabIndex = 1;
        lblPrompt.Text = "I am thinking of a number between\r\n1 and 10. Enter your guess and \r\nclick Evaluate.";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(697, 116);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(91, 31);
        textBox1.TabIndex = 2;
        // 
        // btnEvaluate
        // 
        btnEvaluate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnEvaluate.Location = new Point(91, 242);
        btnEvaluate.Name = "btnEvaluate";
        btnEvaluate.Size = new Size(112, 34);
        btnEvaluate.TabIndex = 3;
        btnEvaluate.Text = "Evaluate";
        btnEvaluate.UseVisualStyleBackColor = true;
        btnEvaluate.Click += BtnEvaluate_Click;
        // 
        // btnExit
        // 
        btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnExit.Location = new Point(225, 242);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(112, 34);
        btnExit.TabIndex = 4;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // txtGuess
        // 
        txtGuess.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtGuess.Location = new Point(365, 132);
        txtGuess.Name = "txtGuess";
        txtGuess.Size = new Size(52, 35);
        txtGuess.TabIndex = 5;
        txtGuess.TextAlign = HorizontalAlignment.Center;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(428, 344);
        Controls.Add(txtGuess);
        Controls.Add(btnExit);
        Controls.Add(btnEvaluate);
        Controls.Add(textBox1);
        Controls.Add(lblPrompt);
        Controls.Add(lblTitle);
        MaximumSize = new Size(450, 400);
        Name = "MainForm";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private Label lblPrompt;
    private TextBox textBox1;
    private Button btnEvaluate;
    private Button btnExit;
    private BindingSource bindingSource1;
    private TextBox txtGuess;
}
