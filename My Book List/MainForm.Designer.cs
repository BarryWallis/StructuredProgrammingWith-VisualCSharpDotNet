namespace My_Book_List;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private Label lblTitle;
    private ListBox lstBooks;
    private Label lblListItem;
    private TextBox txtListItem;
    private Button btnSubmit;
    private Button btnAddItem;
    private Button btnCountItems;
    private Button btnClearItems;
    private Button btnClear;
    private Button btnExit;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitle = new Label();
        lstBooks = new ListBox();
        lblListItem = new Label();
        txtListItem = new TextBox();
        btnSubmit = new Button();
        btnAddItem = new Button();
        btnCountItems = new Button();
        btnClearItems = new Button();
        btnClear = new Button();
        btnExit = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        lblTitle.Location = new Point(27, 9);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(529, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "My Book List";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lstBooks
        // 
        lstBooks.FormattingEnabled = true;
        lstBooks.Items.AddRange(new object[] { "Information Technology Project Management", "Starting out with Visual C#", "Microsoft Office365 Office2016" });
        lstBooks.Location = new Point(70, 48);
        lstBooks.Margin = new Padding(4);
        lstBooks.Name = "lstBooks";
        lstBooks.Size = new Size(465, 194);
        lstBooks.TabIndex = 0;
        lstBooks.SelectedIndexChanged += LstBooks_SelectedIndexChanged;
        // 
        // lblListItem
        // 
        lblListItem.AutoSize = true;
        lblListItem.Font = new Font("Times New Roman", 12F);
        lblListItem.Location = new Point(70, 266);
        lblListItem.Margin = new Padding(4, 0, 4, 0);
        lblListItem.Name = "lblListItem";
        lblListItem.Size = new Size(62, 19);
        lblListItem.TabIndex = 1;
        lblListItem.Text = "List Item";
        // 
        // txtListItem
        // 
        txtListItem.Location = new Point(140, 263);
        txtListItem.Margin = new Padding(4);
        txtListItem.Name = "txtListItem";
        txtListItem.Size = new Size(395, 26);
        txtListItem.TabIndex = 1;
        txtListItem.TextChanged += TxtListItem_TextChanged;
        // 
        // btnSubmit
        // 
        btnSubmit.Location = new Point(52, 306);
        btnSubmit.Margin = new Padding(4);
        btnSubmit.Name = "btnSubmit";
        btnSubmit.Size = new Size(141, 51);
        btnSubmit.TabIndex = 2;
        btnSubmit.Text = "Submit";
        btnSubmit.UseVisualStyleBackColor = true;
        btnSubmit.Click += BtnSubmit_Click;
        // 
        // btnAddItem
        // 
        btnAddItem.Location = new Point(232, 306);
        btnAddItem.Margin = new Padding(4);
        btnAddItem.Name = "btnAddItem";
        btnAddItem.Size = new Size(141, 51);
        btnAddItem.TabIndex = 3;
        btnAddItem.Text = "Add Item";
        btnAddItem.UseVisualStyleBackColor = true;
        btnAddItem.Click += BtnAddItem_Click;
        // 
        // btnCountItems
        // 
        btnCountItems.Location = new Point(412, 306);
        btnCountItems.Margin = new Padding(4);
        btnCountItems.Name = "btnCountItems";
        btnCountItems.Size = new Size(141, 51);
        btnCountItems.TabIndex = 4;
        btnCountItems.Text = "Count Items";
        btnCountItems.UseVisualStyleBackColor = true;
        btnCountItems.Click += BtnCountItems_Click;
        // 
        // btnClearItems
        // 
        btnClearItems.Location = new Point(52, 369);
        btnClearItems.Margin = new Padding(4);
        btnClearItems.Name = "btnClearItems";
        btnClearItems.Size = new Size(141, 51);
        btnClearItems.TabIndex = 5;
        btnClearItems.Text = "Clear Items";
        btnClearItems.UseVisualStyleBackColor = true;
        btnClearItems.Click += BtnClearItems_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(232, 369);
        btnClear.Margin = new Padding(4);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(141, 51);
        btnClear.TabIndex = 6;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += BtnClear_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(412, 369);
        btnExit.Margin = new Padding(4);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(141, 51);
        btnExit.TabIndex = 7;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(584, 461);
        Controls.Add(lblTitle);
        Controls.Add(lstBooks);
        Controls.Add(lblListItem);
        Controls.Add(txtListItem);
        Controls.Add(btnSubmit);
        Controls.Add(btnAddItem);
        Controls.Add(btnCountItems);
        Controls.Add(btnClearItems);
        Controls.Add(btnClear);
        Controls.Add(btnExit);
        Font = new Font("Times New Roman", 12F);
        Margin = new Padding(4);
        MaximumSize = new Size(600, 500);
        MinimumSize = new Size(600, 500);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "My Book List";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
