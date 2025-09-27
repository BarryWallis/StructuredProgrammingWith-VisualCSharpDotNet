namespace My_PictureBox_Application_;

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
        ButtonExit = new Button();
        PictureBoxSwan = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)PictureBoxSwan).BeginInit();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        labelTitle.Location = new Point(162, 9);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(107, 19);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Stewart's Park";
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ButtonExit
        // 
        ButtonExit.Location = new Point(173, 376);
        ButtonExit.Name = "ButtonExit";
        ButtonExit.Size = new Size(75, 23);
        ButtonExit.TabIndex = 1;
        ButtonExit.Text = "Exit";
        ButtonExit.UseVisualStyleBackColor = true;
        ButtonExit.Click += ButtonExit_Click;
        // 
        // PictureBoxSwan
        // 
        PictureBoxSwan.Image = Properties.Resources.Swan;
        PictureBoxSwan.Location = new Point(12, 31);
        PictureBoxSwan.Name = "PictureBoxSwan";
        PictureBoxSwan.Size = new Size(410, 339);
        PictureBoxSwan.SizeMode = PictureBoxSizeMode.Zoom;
        PictureBoxSwan.TabIndex = 2;
        PictureBoxSwan.TabStop = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(434, 411);
        Controls.Add(PictureBoxSwan);
        Controls.Add(ButtonExit);
        Controls.Add(labelTitle);
        Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "My Picture Application";
        ((System.ComponentModel.ISupportInitialize)PictureBoxSwan).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelTitle;
    private Button ButtonExit;
    private PictureBox PictureBoxSwan;
}
