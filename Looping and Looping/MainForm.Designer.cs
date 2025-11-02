namespace Looping_and_Looping;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // Controls
    private Label lblTitle;
    private Label lblTitle2;
    private Label lblOutPut;
    private ListBox lbNumbers;
    private Button ButtonWhile;
    private Button btnFor;
    private Button btnDoWhile;
    private Button btnClear;
    private Button btnExit;

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
        lblTitle = new Label();
        lblTitle2 = new Label();
        lblOutPut = new Label();
        lbNumbers = new ListBox();
        ButtonWhile = new Button();
        btnFor = new Button();
        btnDoWhile = new Button();
        btnClear = new Button();
        btnExit = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        lblTitle.Location = new Point(250, 40);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(300, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Looping, Looping, and Looping.";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTitle2
        // 
        lblTitle2.AutoSize = true;
        lblTitle2.Font = new Font("Times New Roman", 12F);
        lblTitle2.Location = new Point(53, 25);
        lblTitle2.Name = "lblTitle2";
        lblTitle2.Size = new Size(84, 19);
        lblTitle2.TabIndex = 1;
        lblTitle2.Text = "NUMBERS";
        // 
        // lblOutPut
        // 
        lblOutPut.BorderStyle = BorderStyle.FixedSingle;
        lblOutPut.Font = new Font("Times New Roman", 12F);
        lblOutPut.Location = new Point(250, 120);
        lblOutPut.Name = "lblOutPut";
        lblOutPut.Size = new Size(300, 80);
        lblOutPut.TabIndex = 2;
        lblOutPut.Text = "Arithmetic Mean = ";
        lblOutPut.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbNumbers
        // 
        lbNumbers.Font = new Font("Times New Roman", 12F);
        lbNumbers.FormattingEnabled = true;
        lbNumbers.Items.AddRange(new object[] { "6", "1", "3", "6", "2", "5", "8" });
        lbNumbers.Location = new Point(35, 50);
        lbNumbers.Name = "lbNumbers";
        lbNumbers.Size = new Size(120, 175);
        lbNumbers.TabIndex = 3;
        // 
        // ButtonWhile
        // 
        ButtonWhile.Font = new Font("Times New Roman", 12F);
        ButtonWhile.Location = new Point(20, 260);
        ButtonWhile.Name = "ButtonWhile";
        ButtonWhile.Size = new Size(115, 40);
        ButtonWhile.TabIndex = 4;
        ButtonWhile.Text = "while-loop";
        ButtonWhile.UseVisualStyleBackColor = true;
        ButtonWhile.Click += ButtonWhile_Click;
        // 
        // btnFor
        // 
        btnFor.Font = new Font("Times New Roman", 12F);
        btnFor.Location = new Point(145, 260);
        btnFor.Name = "btnFor";
        btnFor.Size = new Size(115, 40);
        btnFor.TabIndex = 5;
        btnFor.Text = "for-loop";
        btnFor.UseVisualStyleBackColor = true;
        btnFor.Click += ButtonFor_Click;
        // 
        // btnDoWhile
        // 
        btnDoWhile.Font = new Font("Times New Roman", 12F);
        btnDoWhile.Location = new Point(270, 260);
        btnDoWhile.Name = "btnDoWhile";
        btnDoWhile.Size = new Size(115, 40);
        btnDoWhile.TabIndex = 6;
        btnDoWhile.Text = "do-while";
        btnDoWhile.UseVisualStyleBackColor = true;
        btnDoWhile.Click += ButtonDoWhile_Click;
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Times New Roman", 12F);
        btnClear.Location = new Point(395, 260);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(115, 40);
        btnClear.TabIndex = 7;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += BtnClear_Click;
        // 
        // btnExit
        // 
        btnExit.Font = new Font("Times New Roman", 12F);
        btnExit.Location = new Point(520, 260);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(115, 40);
        btnExit.TabIndex = 8;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Times New Roman", 12F);
        label1.Location = new Point(35, 89);
        label1.Name = "label1";
        label1.Size = new Size(84, 19);
        label1.TabIndex = 1;
        label1.Text = "NUMBERS";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(640, 350);
        Controls.Add(btnExit);
        Controls.Add(btnClear);
        Controls.Add(btnDoWhile);
        Controls.Add(btnFor);
        Controls.Add(ButtonWhile);
        Controls.Add(lbNumbers);
        Controls.Add(lblOutPut);
        Controls.Add(label1);
        Controls.Add(lblTitle2);
        Controls.Add(lblTitle);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Testing Repetition Structures";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
}
