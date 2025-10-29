namespace The_Communicator;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // UI controls for the form layout
    private Label lblTitle;
    private Label lblPrompt;
    private RichTextBox rtbRead;
    private Button btnYes;
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        lblTitle = new Label();
        lblPrompt = new Label();
        rtbRead = new RichTextBox();
        btnYes = new Button();
        btnExit = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitle.Location = new Point(14, 17);
        lblTitle.Margin = new Padding(2, 0, 2, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(407, 17);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "All my Love to Thee";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblPrompt
        // 
        lblPrompt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblPrompt.Font = new Font("Segoe UI", 12F);
        lblPrompt.Location = new Point(14, 40);
        lblPrompt.Margin = new Padding(2, 0, 2, 0);
        lblPrompt.Name = "lblPrompt";
        lblPrompt.Size = new Size(407, 43);
        lblPrompt.TabIndex = 1;
        lblPrompt.Text = "Good Morning my love.\r\nMust I recite Shakespeare to prove my love for thee?\r\n";
        lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // rtbRead
        // 
        rtbRead.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        rtbRead.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        rtbRead.Location = new Point(14, 80);
        rtbRead.Margin = new Padding(2);
        rtbRead.Name = "rtbRead";
        rtbRead.ReadOnly = true;
        rtbRead.ScrollBars = RichTextBoxScrollBars.Vertical;
        rtbRead.Size = new Size(409, 61);
        rtbRead.TabIndex = 3;
        rtbRead.Text = resources.GetString("rtbRead.Text");
        // 
        // btnYes
        // 
        btnYes.Font = new Font("Segoe UI", 12F);
        btnYes.Location = new Point(125, 143);
        btnYes.Margin = new Padding(2);
        btnYes.Name = "btnYes";
        btnYes.Size = new Size(70, 29);
        btnYes.TabIndex = 4;
        btnYes.Text = "Yes";
        btnYes.UseVisualStyleBackColor = true;
        btnYes.Click += BtnYes_Click;
        // 
        // btnExit
        // 
        btnExit.Font = new Font("Segoe UI", 12F);
        btnExit.Location = new Point(242, 143);
        btnExit.Margin = new Padding(2);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(70, 29);
        btnExit.TabIndex = 5;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click_1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 188);
        Controls.Add(lblTitle);
        Controls.Add(lblPrompt);
        Controls.Add(rtbRead);
        Controls.Add(btnYes);
        Controls.Add(btnExit);
        Margin = new Padding(2);
        MinimumSize = new Size(456, 227);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "The Communicator";
        Load += MainForm_Load;
        ResumeLayout(false);
    }

    #endregion
}
