namespace Retirement_Eligibility_Application;

partial class Form1
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
        lblTitle = new Label();
        lblWorked = new Label();
        txtYearsWorked = new TextBox();
        lblBirthday = new Label();
        btnCalculate = new Button();
        btnClear = new Button();
        button3 = new Button();
        txtBirthday = new TextBox();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(196, 9);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(237, 26);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Retirement Eligibility";
        // 
        // lblWorked
        // 
        lblWorked.AutoSize = true;
        lblWorked.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblWorked.Location = new Point(12, 78);
        lblWorked.Name = "lblWorked";
        lblWorked.Size = new Size(507, 27);
        lblWorked.TabIndex = 1;
        lblWorked.Text = "Enter the number of years worked at the company: ";
        // 
        // txtYearsWorked
        // 
        txtYearsWorked.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtYearsWorked.Location = new Point(524, 74);
        txtYearsWorked.Name = "txtYearsWorked";
        txtYearsWorked.Size = new Size(91, 35);
        txtYearsWorked.TabIndex = 2;
        // 
        // lblBirthday
        // 
        lblBirthday.AutoSize = true;
        lblBirthday.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblBirthday.Location = new Point(180, 141);
        lblBirthday.Name = "lblBirthday";
        lblBirthday.Size = new Size(339, 27);
        lblBirthday.TabIndex = 3;
        lblBirthday.Text = "Enter your birthday (m/dd/yyyy): ";
        // 
        // btnCalculate
        // 
        btnCalculate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnCalculate.Location = new Point(125, 215);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Size = new Size(118, 70);
        btnCalculate.TabIndex = 5;
        btnCalculate.Text = "Calculate Eligibility";
        btnCalculate.UseVisualStyleBackColor = true;
        btnCalculate.Click += BtnCalculate_Click;
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnClear.Location = new Point(260, 215);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(112, 70);
        btnClear.TabIndex = 6;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += BtnClear_Click;
        // 
        // button3
        // 
        button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button3.Location = new Point(391, 233);
        button3.Name = "button3";
        button3.Size = new Size(112, 34);
        button3.TabIndex = 7;
        button3.Text = "Exit";
        button3.UseVisualStyleBackColor = true;
        button3.Click += Button3_Click;
        // 
        // txtBirthday
        // 
        txtBirthday.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtBirthday.Location = new Point(524, 138);
        txtBirthday.Name = "txtBirthday";
        txtBirthday.Size = new Size(91, 35);
        txtBirthday.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(628, 344);
        Controls.Add(txtBirthday);
        Controls.Add(button3);
        Controls.Add(btnClear);
        Controls.Add(btnCalculate);
        Controls.Add(lblBirthday);
        Controls.Add(txtYearsWorked);
        Controls.Add(lblWorked);
        Controls.Add(lblTitle);
        MaximumSize = new Size(650, 400);
        MinimumSize = new Size(650, 400);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Retirement Eligibility Appplication";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private Label lblWorked;
    private TextBox txtYearsWorked;
    private Label lblBirthday;
    private Button btnCalculate;
    private Button btnClear;
    private Button button3;
    private TextBox txtBirthday;
}
