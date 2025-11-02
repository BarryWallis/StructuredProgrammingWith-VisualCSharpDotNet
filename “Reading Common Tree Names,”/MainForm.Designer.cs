namespace _Reading_Common_Tree_Names__;

partial class MainForm
{
 /// <summary>
 /// Required designer variable.
 /// </summary>
 private System.ComponentModel.IContainer components = null;

 // Added controls
 private Label TitleLabel;
 private ListBox TreeNamesListBox;
 private Button ReadButton;
 private Button ExitButton;

 /// <summary>
 /// Clean up any resources being used.
 /// </summary>
 /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
 protected override void Dispose(bool disposing)
 {
 if (disposing && (components is not null))
 {
 components.Dispose();
 }
 base.Dispose(disposing);
 }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        TitleLabel = new Label();
        TreeNamesListBox = new ListBox();
        ReadButton = new Button();
        ExitButton = new Button();
        SuspendLayout();
        // 
        // TitleLabel
        // 
        TitleLabel.AutoSize = true;
        TitleLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        TitleLabel.Location = new Point(93, 46);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new Size(214, 19);
        TitleLabel.TabIndex = 0;
        TitleLabel.Text = "Reading Common Tree Names";
        TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TreeNamesListBox
        // 
        TreeNamesListBox.Font = new Font("Times New Roman", 12F);
        TreeNamesListBox.FormattingEnabled = true;
        TreeNamesListBox.Items.AddRange(new object[] { "Red Mulberry", "Tupelo Gum", "Black Gum", "Hop Hornbeam", "Sycamore", "Cottonwood", "White Oak", "Swamp White Oak" });
        TreeNamesListBox.Location = new Point(85, 77);
        TreeNamesListBox.Name = "TreeNamesListBox";
        TreeNamesListBox.Size = new Size(230, 175);
        TreeNamesListBox.TabIndex = 1;
        // 
        // ReadButton
        // 
        ReadButton.Font = new Font("Times New Roman", 12F);
        ReadButton.Location = new Point(60, 269);
        ReadButton.Name = "ReadButton";
        ReadButton.Size = new Size(120, 35);
        ReadButton.TabIndex = 2;
        ReadButton.Text = "Read Names";
        ReadButton.UseVisualStyleBackColor = true;
        ReadButton.Click += ReadButton_Click;
        // 
        // ExitButton
        // 
        ExitButton.Font = new Font("Times New Roman", 12F);
        ExitButton.Location = new Point(220, 269);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new Size(120, 35);
        ExitButton.TabIndex = 3;
        ExitButton.Text = "Exit";
        ExitButton.UseVisualStyleBackColor = true;
        ExitButton.Click += ExitButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(401, 351);
        Controls.Add(ExitButton);
        Controls.Add(ReadButton);
        Controls.Add(TreeNamesListBox);
        Controls.Add(TitleLabel);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Reading using a foreach-loop,";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
