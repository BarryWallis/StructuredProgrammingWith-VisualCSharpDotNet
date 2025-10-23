namespace My_Calculator;

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
        labelTitle = new Label();
        Button7 = new Button();
        Button8 = new Button();
        Button9 = new Button();
        Button6 = new Button();
        Button5 = new Button();
        Button4 = new Button();
        Button3 = new Button();
        Button2 = new Button();
        Button1 = new Button();
        Button0 = new Button();
        ButtonDot = new Button();
        ButtonMultiply = new Button();
        ButtonDivide = new Button();
        ButtonMinus = new Button();
        ButtonPlus = new Button();
        ButtonClear = new Button();
        ButtonEquals = new Button();
        ButtonSqrt = new Button();
        txtResult = new TextBox();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        labelTitle.Location = new Point(12, 9);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(399, 31);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "My Calculator";
        labelTitle.TextAlign = ContentAlignment.TopCenter;
        // 
        // Button7
        // 
        Button7.BackColor = Color.LightGray;
        Button7.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button7.Location = new Point(12, 87);
        Button7.Name = "Button7";
        Button7.Size = new Size(75, 65);
        Button7.TabIndex = 17;
        Button7.Text = "7";
        Button7.UseVisualStyleBackColor = false;
        Button7.Click += Button7_Click;
        // 
        // Button8
        // 
        Button8.BackColor = Color.LightGray;
        Button8.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button8.Location = new Point(93, 87);
        Button8.Name = "Button8";
        Button8.Size = new Size(75, 65);
        Button8.TabIndex = 18;
        Button8.Text = "8";
        Button8.UseVisualStyleBackColor = false;
        Button8.Click += Button8_Click;
        // 
        // Button9
        // 
        Button9.BackColor = Color.LightGray;
        Button9.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button9.Location = new Point(174, 87);
        Button9.Name = "Button9";
        Button9.Size = new Size(75, 65);
        Button9.TabIndex = 19;
        Button9.Text = "9";
        Button9.UseVisualStyleBackColor = false;
        Button9.Click += Button9_Click;
        // 
        // Button6
        // 
        Button6.BackColor = Color.LightGray;
        Button6.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button6.Location = new Point(174, 158);
        Button6.Name = "Button6";
        Button6.Size = new Size(75, 65);
        Button6.TabIndex = 16;
        Button6.Text = "6";
        Button6.UseVisualStyleBackColor = false;
        Button6.Click += Button6_Click;
        // 
        // Button5
        // 
        Button5.BackColor = Color.LightGray;
        Button5.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button5.Location = new Point(93, 158);
        Button5.Name = "Button5";
        Button5.Size = new Size(75, 65);
        Button5.TabIndex = 15;
        Button5.Text = "5";
        Button5.UseVisualStyleBackColor = false;
        Button5.Click += Button5_Click;
        // 
        // Button4
        // 
        Button4.BackColor = Color.LightGray;
        Button4.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button4.Location = new Point(12, 158);
        Button4.Name = "Button4";
        Button4.Size = new Size(75, 65);
        Button4.TabIndex = 14;
        Button4.Text = "4";
        Button4.UseVisualStyleBackColor = false;
        Button4.Click += Button4_Click;
        // 
        // Button3
        // 
        Button3.BackColor = Color.LightGray;
        Button3.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button3.Location = new Point(174, 229);
        Button3.Name = "Button3";
        Button3.Size = new Size(75, 65);
        Button3.TabIndex = 13;
        Button3.Text = "3";
        Button3.UseVisualStyleBackColor = false;
        Button3.Click += Button3_Click;
        // 
        // Button2
        // 
        Button2.BackColor = Color.LightGray;
        Button2.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button2.Location = new Point(93, 229);
        Button2.Name = "Button2";
        Button2.Size = new Size(75, 65);
        Button2.TabIndex = 12;
        Button2.Text = "2";
        Button2.UseVisualStyleBackColor = false;
        Button2.Click += Button2_Click;
        // 
        // Button1
        // 
        Button1.BackColor = Color.LightGray;
        Button1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button1.Location = new Point(12, 229);
        Button1.Name = "Button1";
        Button1.Size = new Size(75, 65);
        Button1.TabIndex = 11;
        Button1.Text = "1";
        Button1.UseVisualStyleBackColor = false;
        Button1.Click += Button1_Click;
        // 
        // Button0
        // 
        Button0.BackColor = Color.LightGray;
        Button0.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Button0.Location = new Point(12, 300);
        Button0.Name = "Button0";
        Button0.Size = new Size(75, 65);
        Button0.TabIndex = 10;
        Button0.Text = "0";
        Button0.UseVisualStyleBackColor = false;
        Button0.Click += Button0_Click;
        // 
        // ButtonDot
        // 
        ButtonDot.BackColor = Color.LightGray;
        ButtonDot.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ButtonDot.Location = new Point(93, 300);
        ButtonDot.Name = "ButtonDot";
        ButtonDot.Size = new Size(75, 65);
        ButtonDot.TabIndex = 9;
        ButtonDot.Text = ".";
        ButtonDot.UseVisualStyleBackColor = false;
        ButtonDot.Click += ButtonDot_Click;
        // 
        // ButtonMultiply
        // 
        ButtonMultiply.BackColor = Color.LightGray;
        ButtonMultiply.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ButtonMultiply.Location = new Point(174, 300);
        ButtonMultiply.Name = "ButtonMultiply";
        ButtonMultiply.Size = new Size(75, 65);
        ButtonMultiply.TabIndex = 5;
        ButtonMultiply.Text = "*";
        ButtonMultiply.UseVisualStyleBackColor = false;
        ButtonMultiply.Click += ButtonMultiply_Click;
        // 
        // ButtonDivide
        // 
        ButtonDivide.BackColor = Color.LightGray;
        ButtonDivide.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ButtonDivide.Location = new Point(255, 87);
        ButtonDivide.Name = "ButtonDivide";
        ButtonDivide.Size = new Size(75, 65);
        ButtonDivide.TabIndex = 2;
        ButtonDivide.Text = "/";
        ButtonDivide.UseVisualStyleBackColor = false;
        ButtonDivide.Click += ButtonDivide_Click;
        // 
        // ButtonMinus
        // 
        ButtonMinus.BackColor = Color.LightGray;
        ButtonMinus.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ButtonMinus.Location = new Point(255, 158);
        ButtonMinus.Name = "ButtonMinus";
        ButtonMinus.Size = new Size(75, 65);
        ButtonMinus.TabIndex = 3;
        ButtonMinus.Text = "-";
        ButtonMinus.UseVisualStyleBackColor = false;
        ButtonMinus.Click += ButtonMinus_Click;
        // 
        // ButtonPlus
        // 
        ButtonPlus.BackColor = Color.LightGray;
        ButtonPlus.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ButtonPlus.Location = new Point(255, 229);
        ButtonPlus.Name = "ButtonPlus";
        ButtonPlus.Size = new Size(75, 65);
        ButtonPlus.TabIndex = 4;
        ButtonPlus.Text = "+";
        ButtonPlus.UseVisualStyleBackColor = false;
        ButtonPlus.Click += ButtonPlus_Click;
        // 
        // ButtonClear
        // 
        ButtonClear.BackColor = Color.LightGray;
        ButtonClear.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ButtonClear.Location = new Point(336, 87);
        ButtonClear.Name = "ButtonClear";
        ButtonClear.Size = new Size(75, 65);
        ButtonClear.TabIndex = 6;
        ButtonClear.Text = "C";
        ButtonClear.UseVisualStyleBackColor = false;
        ButtonClear.Click += ButtonClear_Click;
        // 
        // ButtonEquals
        // 
        ButtonEquals.BackColor = Color.LightGray;
        ButtonEquals.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ButtonEquals.Location = new Point(336, 158);
        ButtonEquals.Name = "ButtonEquals";
        ButtonEquals.Size = new Size(75, 136);
        ButtonEquals.TabIndex = 7;
        ButtonEquals.Text = "=";
        ButtonEquals.UseVisualStyleBackColor = false;
        ButtonEquals.Click += ButtonEquals_Click;
        // 
        // ButtonSqrt
        // 
        ButtonSqrt.BackColor = Color.LightGray;
        ButtonSqrt.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ButtonSqrt.Location = new Point(255, 300);
        ButtonSqrt.Name = "ButtonSqrt";
        ButtonSqrt.Size = new Size(156, 65);
        ButtonSqrt.TabIndex = 8;
        ButtonSqrt.Text = "Sqrt";
        ButtonSqrt.UseVisualStyleBackColor = false;
        ButtonSqrt.Click += ButtonSqrt_Click;
        // 
        // txtResult
        // 
        txtResult.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        txtResult.Location = new Point(12, 43);
        txtResult.Name = "txtResult";
        txtResult.Size = new Size(395, 38);
        txtResult.TabIndex = 1;
        txtResult.Text = "0";
        txtResult.TextAlign = HorizontalAlignment.Right;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.PeachPuff;
        ClientSize = new Size(419, 374);
        Controls.Add(txtResult);
        Controls.Add(ButtonSqrt);
        Controls.Add(ButtonEquals);
        Controls.Add(ButtonClear);
        Controls.Add(ButtonPlus);
        Controls.Add(ButtonMinus);
        Controls.Add(ButtonDivide);
        Controls.Add(ButtonMultiply);
        Controls.Add(ButtonDot);
        Controls.Add(Button0);
        Controls.Add(Button3);
        Controls.Add(Button2);
        Controls.Add(Button1);
        Controls.Add(Button6);
        Controls.Add(Button5);
        Controls.Add(Button4);
        Controls.Add(Button9);
        Controls.Add(Button8);
        Controls.Add(Button7);
        Controls.Add(labelTitle);
        Margin = new Padding(2);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "My Calculator";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelTitle;
    private Button Button7;
    private Button Button8;
    private Button Button9;
    private Button Button6;
    private Button Button5;
    private Button Button4;
    private Button Button3;
    private Button Button2;
    private Button Button1;
    private Button Button0;
    private Button ButtonDot;
    private Button ButtonMultiply;
    private Button ButtonDivide;
    private Button ButtonMinus;
    private Button ButtonPlus;
    private Button ButtonClear;
    private Button ButtonEquals;
    private Button ButtonSqrt;
    private TextBox txtResult;
}
