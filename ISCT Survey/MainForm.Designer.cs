namespace ISCT_Survey;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // UI controls
    private Label lblTitle;
    private GroupBox grpClassYear;
    private RadioButton rbSenior;
    private RadioButton rbJunior;
    private RadioButton rbSophomore;
    private RadioButton rbFreshmen;
    private PictureBox pbPhoto;
    private GroupBox grpGender;
    private RadioButton rbFemale;
    private RadioButton rbMale;
    private GroupBox grpAreas;
    private CheckBox cbDatabase;
    private CheckBox cbBigData;
    private CheckBox cbBusinessIntelligence;
    private CheckBox cbDataWarehousing;
    private CheckBox cbOperatingSystems;
    private CheckBox cbNetworking;
    private Button btnSubmit;
    private Button btnResults;
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
        grpClassYear = new GroupBox();
        rbFreshmen = new RadioButton();
        rbSophomore = new RadioButton();
        rbJunior = new RadioButton();
        rbSenior = new RadioButton();
        pbPhoto = new PictureBox();
        grpGender = new GroupBox();
        rbMale = new RadioButton();
        rbFemale = new RadioButton();
        grpAreas = new GroupBox();
        cbNetworking = new CheckBox();
        cbOperatingSystems = new CheckBox();
        cbDataWarehousing = new CheckBox();
        cbBusinessIntelligence = new CheckBox();
        cbBigData = new CheckBox();
        cbDatabase = new CheckBox();
        btnSubmit = new Button();
        btnResults = new Button();
        btnExit = new Button();
        grpClassYear.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
        grpGender.SuspendLayout();
        grpAreas.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.Location = new Point(101, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(558, 25);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Information Science and Computer Technology (ISCT) Survey";
        // 
        // grpClassYear
        // 
        grpClassYear.Controls.Add(rbFreshmen);
        grpClassYear.Controls.Add(rbSophomore);
        grpClassYear.Controls.Add(rbJunior);
        grpClassYear.Controls.Add(rbSenior);
        grpClassYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        grpClassYear.Location = new Point(90, 72);
        grpClassYear.Name = "grpClassYear";
        grpClassYear.Size = new Size(240, 200);
        grpClassYear.TabIndex = 1;
        grpClassYear.TabStop = false;
        grpClassYear.Text = "Class Year";
        // 
        // rbFreshmen
        // 
        rbFreshmen.AutoSize = true;
        rbFreshmen.Font = new Font("Segoe UI", 12F);
        rbFreshmen.Location = new Point(24, 152);
        rbFreshmen.Name = "rbFreshmen";
        rbFreshmen.Size = new Size(97, 25);
        rbFreshmen.TabIndex = 3;
        rbFreshmen.TabStop = true;
        rbFreshmen.Text = "Freshmen";
        rbFreshmen.UseVisualStyleBackColor = true;
        // 
        // rbSophomore
        // 
        rbSophomore.AutoSize = true;
        rbSophomore.Font = new Font("Segoe UI", 12F);
        rbSophomore.Location = new Point(24, 112);
        rbSophomore.Name = "rbSophomore";
        rbSophomore.Size = new Size(110, 25);
        rbSophomore.TabIndex = 2;
        rbSophomore.TabStop = true;
        rbSophomore.Text = "Sophomore";
        rbSophomore.UseVisualStyleBackColor = true;
        // 
        // rbJunior
        // 
        rbJunior.AutoSize = true;
        rbJunior.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        rbJunior.Location = new Point(24, 72);
        rbJunior.Name = "rbJunior";
        rbJunior.Size = new Size(71, 25);
        rbJunior.TabIndex = 1;
        rbJunior.TabStop = true;
        rbJunior.Text = "Junior";
        rbJunior.UseVisualStyleBackColor = true;
        // 
        // rbSenior
        // 
        rbSenior.AutoSize = true;
        rbSenior.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        rbSenior.Location = new Point(24, 32);
        rbSenior.Name = "rbSenior";
        rbSenior.Size = new Size(73, 25);
        rbSenior.TabIndex = 0;
        rbSenior.TabStop = true;
        rbSenior.Text = "Senior";
        rbSenior.UseVisualStyleBackColor = true;
        // 
        // pbPhoto
        // 
        pbPhoto.BorderStyle = BorderStyle.FixedSingle;
        pbPhoto.Image = (Image)resources.GetObject("pbPhoto.Image");
        pbPhoto.Location = new Point(370, 72);
        pbPhoto.Name = "pbPhoto";
        pbPhoto.Size = new Size(300, 200);
        pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        pbPhoto.TabIndex = 2;
        pbPhoto.TabStop = false;
        // 
        // grpGender
        // 
        grpGender.Controls.Add(rbMale);
        grpGender.Controls.Add(rbFemale);
        grpGender.Font = new Font("Segoe UI", 12F);
        grpGender.Location = new Point(90, 296);
        grpGender.Name = "grpGender";
        grpGender.Size = new Size(580, 72);
        grpGender.TabIndex = 3;
        grpGender.TabStop = false;
        grpGender.Text = "Which gender are you?";
        // 
        // rbMale
        // 
        rbMale.AutoSize = true;
        rbMale.Font = new Font("Segoe UI", 12F);
        rbMale.Location = new Point(328, 32);
        rbMale.Name = "rbMale";
        rbMale.Size = new Size(62, 25);
        rbMale.TabIndex = 1;
        rbMale.TabStop = true;
        rbMale.Text = "Male";
        rbMale.UseVisualStyleBackColor = true;
        // 
        // rbFemale
        // 
        rbFemale.AutoSize = true;
        rbFemale.Font = new Font("Segoe UI", 12F);
        rbFemale.Location = new Point(72, 32);
        rbFemale.Name = "rbFemale";
        rbFemale.Size = new Size(78, 25);
        rbFemale.TabIndex = 0;
        rbFemale.TabStop = true;
        rbFemale.Text = "Female";
        rbFemale.UseVisualStyleBackColor = true;
        // 
        // grpAreas
        // 
        grpAreas.Controls.Add(cbNetworking);
        grpAreas.Controls.Add(cbOperatingSystems);
        grpAreas.Controls.Add(cbDataWarehousing);
        grpAreas.Controls.Add(cbBusinessIntelligence);
        grpAreas.Controls.Add(cbBigData);
        grpAreas.Controls.Add(cbDatabase);
        grpAreas.Font = new Font("Segoe UI", 12F);
        grpAreas.Location = new Point(60, 384);
        grpAreas.Name = "grpAreas";
        grpAreas.Size = new Size(640, 168);
        grpAreas.TabIndex = 4;
        grpAreas.TabStop = false;
        grpAreas.Text = "What area of Information Technology are you interested in, check all that apply.";
        // 
        // cbNetworking
        // 
        cbNetworking.AutoSize = true;
        cbNetworking.Font = new Font("Segoe UI", 12F);
        cbNetworking.Location = new Point(352, 120);
        cbNetworking.Name = "cbNetworking";
        cbNetworking.Size = new Size(111, 25);
        cbNetworking.TabIndex = 5;
        cbNetworking.Text = "Networking";
        cbNetworking.UseVisualStyleBackColor = true;
        // 
        // cbOperatingSystems
        // 
        cbOperatingSystems.AutoSize = true;
        cbOperatingSystems.Font = new Font("Segoe UI", 12F);
        cbOperatingSystems.Location = new Point(48, 120);
        cbOperatingSystems.Name = "cbOperatingSystems";
        cbOperatingSystems.Size = new Size(161, 25);
        cbOperatingSystems.TabIndex = 4;
        cbOperatingSystems.Text = "Operating Systems";
        cbOperatingSystems.UseVisualStyleBackColor = true;
        // 
        // cbDataWarehousing
        // 
        cbDataWarehousing.AutoSize = true;
        cbDataWarehousing.Font = new Font("Segoe UI", 12F);
        cbDataWarehousing.Location = new Point(352, 80);
        cbDataWarehousing.Name = "cbDataWarehousing";
        cbDataWarehousing.Size = new Size(157, 25);
        cbDataWarehousing.TabIndex = 3;
        cbDataWarehousing.Text = "Data Warehousing";
        cbDataWarehousing.UseVisualStyleBackColor = true;
        // 
        // cbBusinessIntelligence
        // 
        cbBusinessIntelligence.AutoSize = true;
        cbBusinessIntelligence.Font = new Font("Segoe UI", 12F);
        cbBusinessIntelligence.Location = new Point(48, 80);
        cbBusinessIntelligence.Name = "cbBusinessIntelligence";
        cbBusinessIntelligence.Size = new Size(172, 25);
        cbBusinessIntelligence.TabIndex = 2;
        cbBusinessIntelligence.Text = "Business Intelligence";
        cbBusinessIntelligence.UseVisualStyleBackColor = true;
        // 
        // cbBigData
        // 
        cbBigData.AutoSize = true;
        cbBigData.Font = new Font("Segoe UI", 12F);
        cbBigData.Location = new Point(352, 40);
        cbBigData.Name = "cbBigData";
        cbBigData.Size = new Size(87, 25);
        cbBigData.TabIndex = 1;
        cbBigData.Text = "Big Data";
        cbBigData.UseVisualStyleBackColor = true;
        // 
        // cbDatabase
        // 
        cbDatabase.AutoSize = true;
        cbDatabase.Font = new Font("Segoe UI", 12F);
        cbDatabase.Location = new Point(48, 40);
        cbDatabase.Name = "cbDatabase";
        cbDatabase.Size = new Size(93, 25);
        cbDatabase.TabIndex = 0;
        cbDatabase.Text = "Database";
        cbDatabase.UseVisualStyleBackColor = true;
        // 
        // btnSubmit
        // 
        btnSubmit.Font = new Font("Segoe UI", 12F);
        btnSubmit.Location = new Point(172, 576);
        btnSubmit.Name = "btnSubmit";
        btnSubmit.Size = new Size(96, 32);
        btnSubmit.TabIndex = 5;
        btnSubmit.Text = "Submit";
        btnSubmit.UseVisualStyleBackColor = true;
        btnSubmit.Click += BtnSubmit_Click;
        // 
        // btnResults
        // 
        btnResults.Font = new Font("Segoe UI", 12F);
        btnResults.Location = new Point(332, 576);
        btnResults.Name = "btnResults";
        btnResults.Size = new Size(96, 32);
        btnResults.TabIndex = 6;
        btnResults.Text = "Results";
        btnResults.UseVisualStyleBackColor = true;
        btnResults.Click += BtnResults_Click;
        // 
        // btnExit
        // 
        btnExit.Font = new Font("Segoe UI", 12F);
        btnExit.Location = new Point(492, 576);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(96, 32);
        btnExit.TabIndex = 7;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(760, 640);
        Controls.Add(btnExit);
        Controls.Add(btnResults);
        Controls.Add(btnSubmit);
        Controls.Add(grpAreas);
        Controls.Add(grpGender);
        Controls.Add(pbPhoto);
        Controls.Add(grpClassYear);
        Controls.Add(lblTitle);
        MinimumSize = new Size(776, 679);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ISCT Survey";
        grpClassYear.ResumeLayout(false);
        grpClassYear.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
        grpGender.ResumeLayout(false);
        grpGender.PerformLayout();
        grpAreas.ResumeLayout(false);
        grpAreas.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
