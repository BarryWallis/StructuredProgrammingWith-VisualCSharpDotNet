namespace My_Savings_Account;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // Form Controls
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label lblAccountBalance;
    private System.Windows.Forms.Label lblInterestRate;
    private System.Windows.Forms.Label lblNumberOfMonths;
    private System.Windows.Forms.TextBox txtAccountBalance;
    private System.Windows.Forms.TextBox txtInterestRate;
    private System.Windows.Forms.TextBox txtNumberOfMonths;
    private System.Windows.Forms.Label lblResults;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Button btnClear;
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
        labelTitle = new Label();
        lblAccountBalance = new Label();
        lblInterestRate = new Label();
        lblNumberOfMonths = new Label();
        txtAccountBalance = new TextBox();
        txtInterestRate = new TextBox();
        txtNumberOfMonths = new TextBox();
        lblResults = new Label();
        btnCalculate = new Button();
        btnClear = new Button();
        btnExit = new Button();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Dock = DockStyle.Top;
        labelTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        labelTitle.Location = new Point(0, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(460, 50);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Savings Account";
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblAccountBalance
        // 
        lblAccountBalance.AutoSize = true;
        lblAccountBalance.Location = new Point(50, 80);
        lblAccountBalance.Name = "lblAccountBalance";
        lblAccountBalance.Size = new Size(115, 19);
        lblAccountBalance.TabIndex = 1;
        lblAccountBalance.Text = "Account Balance:";
        // 
        // lblInterestRate
        // 
        lblInterestRate.AutoSize = true;
        lblInterestRate.Location = new Point(50, 120);
        lblInterestRate.Name = "lblInterestRate";
        lblInterestRate.Size = new Size(89, 19);
        lblInterestRate.TabIndex = 2;
        lblInterestRate.Text = "Interest Rate:";
        // 
        // lblNumberOfMonths
        // 
        lblNumberOfMonths.AutoSize = true;
        lblNumberOfMonths.Location = new Point(50, 160);
        lblNumberOfMonths.Name = "lblNumberOfMonths";
        lblNumberOfMonths.Size = new Size(128, 19);
        lblNumberOfMonths.TabIndex = 3;
        lblNumberOfMonths.Text = "Number of Months:";
        // 
        // txtAccountBalance
        // 
        txtAccountBalance.Location = new Point(240, 77);
        txtAccountBalance.Name = "txtAccountBalance";
        txtAccountBalance.Size = new Size(170, 26);
        txtAccountBalance.TabIndex = 4;
        // 
        // txtInterestRate
        // 
        txtInterestRate.Location = new Point(240, 117);
        txtInterestRate.Name = "txtInterestRate";
        txtInterestRate.Size = new Size(170, 26);
        txtInterestRate.TabIndex = 5;
        // 
        // txtNumberOfMonths
        // 
        txtNumberOfMonths.Location = new Point(240, 157);
        txtNumberOfMonths.Name = "txtNumberOfMonths";
        txtNumberOfMonths.Size = new Size(170, 26);
        txtNumberOfMonths.TabIndex = 6;
        // 
        // lblResults
        // 
        lblResults.BorderStyle = BorderStyle.FixedSingle;
        lblResults.Location = new Point(50, 205);
        lblResults.Name = "lblResults";
        lblResults.Size = new Size(360, 220);
        lblResults.TabIndex = 7;
        // 
        // btnCalculate
        // 
        btnCalculate.Location = new Point(50, 445);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Size = new Size(100, 40);
        btnCalculate.TabIndex = 8;
        btnCalculate.Text = "Calculate";
        btnCalculate.UseVisualStyleBackColor = true;
        btnCalculate.Click += BtnCalculate_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(180, 445);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(100, 40);
        btnClear.TabIndex = 9;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += BtnClear_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(310, 445);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(100, 40);
        btnExit.TabIndex = 10;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(460, 525);
        Controls.Add(btnExit);
        Controls.Add(btnClear);
        Controls.Add(btnCalculate);
        Controls.Add(lblResults);
        Controls.Add(txtNumberOfMonths);
        Controls.Add(txtInterestRate);
        Controls.Add(txtAccountBalance);
        Controls.Add(lblNumberOfMonths);
        Controls.Add(lblInterestRate);
        Controls.Add(lblAccountBalance);
        Controls.Add(labelTitle);
        Font = new Font("Times New Roman", 12F);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "My Savings Account";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
