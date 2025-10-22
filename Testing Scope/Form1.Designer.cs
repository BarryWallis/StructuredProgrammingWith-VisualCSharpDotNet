namespace Testing_Scope;

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
        btnScope1 = new Button();
        btnScope2 = new Button();
        btnExit = new Button();
        lblTitle = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(21, 45);
        pictureBox1.Margin = new Padding(2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(205, 180);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // btnScope1
        // 
        btnScope1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnScope1.Location = new Point(248, 97);
        btnScope1.Name = "btnScope1";
        btnScope1.Size = new Size(145, 50);
        btnScope1.TabIndex = 2;
        btnScope1.Text = "Testing Scope 1";
        btnScope1.UseVisualStyleBackColor = true;
        btnScope1.Click += BtnScope1_Click;
        // 
        // btnScope2
        // 
        btnScope2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnScope2.Location = new Point(248, 153);
        btnScope2.Name = "btnScope2";
        btnScope2.Size = new Size(145, 50);
        btnScope2.TabIndex = 3;
        btnScope2.Text = "Testing Scope 2";
        btnScope2.UseVisualStyleBackColor = true;
        btnScope2.Click += BtnScope2_Click;
        // 
        // btnExit
        // 
        btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnExit.Location = new Point(248, 209);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(145, 50);
        btnExit.TabIndex = 4;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(269, 45);
        lblTitle.Margin = new Padding(2, 0, 2, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(102, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Testing Scope";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(414, 271);
        Controls.Add(btnExit);
        Controls.Add(btnScope2);
        Controls.Add(btnScope1);
        Controls.Add(lblTitle);
        Controls.Add(pictureBox1);
        Margin = new Padding(2);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Testing Scope";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private Button btnScope1;
    private Button btnScope2;
    private Button btnExit;
    private Label lblTitle;
}
