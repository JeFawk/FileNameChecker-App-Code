namespace File_Name_Checker
{
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MaxLengthCheckbox = new System.Windows.Forms.CheckBox();
            this.MaxLengthTextbox = new System.Windows.Forms.TextBox();
            this.PathToCheckTextBox = new System.Windows.Forms.TextBox();
            this.PathToCheckLabel = new System.Windows.Forms.Label();
            this.ChecksLabel = new System.Windows.Forms.Label();
            this.MaxLengthLabel = new System.Windows.Forms.Label();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TooltipInvalidCharacters = new System.Windows.Forms.Label();
            this.InvalidCharactersLabel = new System.Windows.Forms.Label();
            this.InvalidCharactersTextbox = new System.Windows.Forms.TextBox();
            this.InvalidCharactersCheckbox = new System.Windows.Forms.CheckBox();
            this.MaxLengthCheckGroupbox = new System.Windows.Forms.GroupBox();
            this.TooltipMaxLengthCheck = new System.Windows.Forms.Label();
            this.HelpLabel1 = new System.Windows.Forms.Label();
            this.HelpLabel2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TooltipResults = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.MaxLengthCheckGroupbox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaxLengthCheckbox
            // 
            this.MaxLengthCheckbox.AutoSize = true;
            this.MaxLengthCheckbox.Checked = true;
            this.MaxLengthCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaxLengthCheckbox.Location = new System.Drawing.Point(19, 44);
            this.MaxLengthCheckbox.Name = "MaxLengthCheckbox";
            this.MaxLengthCheckbox.Size = new System.Drawing.Size(118, 29);
            this.MaxLengthCheckbox.TabIndex = 6;
            this.MaxLengthCheckbox.Text = "Run check";
            this.MaxLengthCheckbox.UseVisualStyleBackColor = true;
            this.MaxLengthCheckbox.CheckedChanged += new System.EventHandler(this.MaxLengthCheckbox_CheckedChanged);
            // 
            // MaxLengthTextbox
            // 
            this.MaxLengthTextbox.Location = new System.Drawing.Point(129, 90);
            this.MaxLengthTextbox.Name = "MaxLengthTextbox";
            this.MaxLengthTextbox.Size = new System.Drawing.Size(93, 31);
            this.MaxLengthTextbox.TabIndex = 1;
            this.MaxLengthTextbox.Text = "143";
            // 
            // PathToCheckTextBox
            // 
            this.PathToCheckTextBox.Location = new System.Drawing.Point(12, 168);
            this.PathToCheckTextBox.Name = "PathToCheckTextBox";
            this.PathToCheckTextBox.PlaceholderText = "\\\\NASNameHere\\Folder";
            this.PathToCheckTextBox.Size = new System.Drawing.Size(862, 31);
            this.PathToCheckTextBox.TabIndex = 2;
            // 
            // PathToCheckLabel
            // 
            this.PathToCheckLabel.AutoSize = true;
            this.PathToCheckLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathToCheckLabel.Location = new System.Drawing.Point(12, 137);
            this.PathToCheckLabel.Name = "PathToCheckLabel";
            this.PathToCheckLabel.Size = new System.Drawing.Size(128, 28);
            this.PathToCheckLabel.TabIndex = 3;
            this.PathToCheckLabel.Text = "Path to check";
            // 
            // ChecksLabel
            // 
            this.ChecksLabel.AutoSize = true;
            this.ChecksLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChecksLabel.Location = new System.Drawing.Point(12, 219);
            this.ChecksLabel.Name = "ChecksLabel";
            this.ChecksLabel.Size = new System.Drawing.Size(172, 28);
            this.ChecksLabel.TabIndex = 4;
            this.ChecksLabel.Text = "Checks to perform";
            // 
            // MaxLengthLabel
            // 
            this.MaxLengthLabel.AutoSize = true;
            this.MaxLengthLabel.Location = new System.Drawing.Point(19, 93);
            this.MaxLengthLabel.Name = "MaxLengthLabel";
            this.MaxLengthLabel.Size = new System.Drawing.Size(104, 25);
            this.MaxLengthLabel.TabIndex = 5;
            this.MaxLengthLabel.Text = "Max length:";
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 527);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsTextBox.Size = new System.Drawing.Size(862, 359);
            this.ResultsTextBox.TabIndex = 0;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultsLabel.Location = new System.Drawing.Point(12, 496);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(72, 28);
            this.ResultsLabel.TabIndex = 7;
            this.ResultsLabel.Text = "Results";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 442);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 34);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 889);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(102, 25);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Status label";
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(149, 442);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(112, 34);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TooltipInvalidCharacters);
            this.groupBox1.Controls.Add(this.InvalidCharactersLabel);
            this.groupBox1.Controls.Add(this.InvalidCharactersTextbox);
            this.groupBox1.Controls.Add(this.InvalidCharactersCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(331, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 191);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invalid characters check";
            // 
            // TooltipInvalidCharacters
            // 
            this.TooltipInvalidCharacters.AutoSize = true;
            this.TooltipInvalidCharacters.Location = new System.Drawing.Point(484, 14);
            this.TooltipInvalidCharacters.Name = "TooltipInvalidCharacters";
            this.TooltipInvalidCharacters.Size = new System.Drawing.Size(20, 25);
            this.TooltipInvalidCharacters.TabIndex = 15;
            this.TooltipInvalidCharacters.Text = "?";
            this.toolTip1.SetToolTip(this.TooltipInvalidCharacters, "Checks for the invalid characters in the list.");
            // 
            // InvalidCharactersLabel
            // 
            this.InvalidCharactersLabel.AutoSize = true;
            this.InvalidCharactersLabel.Location = new System.Drawing.Point(16, 93);
            this.InvalidCharactersLabel.Name = "InvalidCharactersLabel";
            this.InvalidCharactersLabel.Size = new System.Drawing.Size(351, 25);
            this.InvalidCharactersLabel.TabIndex = 12;
            this.InvalidCharactersLabel.Text = "Characters to check for separated by space";
            // 
            // InvalidCharactersTextbox
            // 
            this.InvalidCharactersTextbox.Location = new System.Drawing.Point(16, 124);
            this.InvalidCharactersTextbox.Name = "InvalidCharactersTextbox";
            this.InvalidCharactersTextbox.Size = new System.Drawing.Size(468, 31);
            this.InvalidCharactersTextbox.TabIndex = 1;
            this.InvalidCharactersTextbox.Text = "< > : \\ / ? \" | *";
            // 
            // InvalidCharactersCheckbox
            // 
            this.InvalidCharactersCheckbox.AutoSize = true;
            this.InvalidCharactersCheckbox.Checked = true;
            this.InvalidCharactersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InvalidCharactersCheckbox.Location = new System.Drawing.Point(16, 44);
            this.InvalidCharactersCheckbox.Name = "InvalidCharactersCheckbox";
            this.InvalidCharactersCheckbox.Size = new System.Drawing.Size(118, 29);
            this.InvalidCharactersCheckbox.TabIndex = 0;
            this.InvalidCharactersCheckbox.Text = "Run check";
            this.InvalidCharactersCheckbox.UseVisualStyleBackColor = true;
            // 
            // MaxLengthCheckGroupbox
            // 
            this.MaxLengthCheckGroupbox.Controls.Add(this.TooltipMaxLengthCheck);
            this.MaxLengthCheckGroupbox.Controls.Add(this.MaxLengthCheckbox);
            this.MaxLengthCheckGroupbox.Controls.Add(this.MaxLengthLabel);
            this.MaxLengthCheckGroupbox.Controls.Add(this.MaxLengthTextbox);
            this.MaxLengthCheckGroupbox.Location = new System.Drawing.Point(12, 260);
            this.MaxLengthCheckGroupbox.Name = "MaxLengthCheckGroupbox";
            this.MaxLengthCheckGroupbox.Size = new System.Drawing.Size(249, 155);
            this.MaxLengthCheckGroupbox.TabIndex = 12;
            this.MaxLengthCheckGroupbox.TabStop = false;
            this.MaxLengthCheckGroupbox.Text = "Max length check";
            // 
            // TooltipMaxLengthCheck
            // 
            this.TooltipMaxLengthCheck.AutoSize = true;
            this.TooltipMaxLengthCheck.Location = new System.Drawing.Point(223, 14);
            this.TooltipMaxLengthCheck.Name = "TooltipMaxLengthCheck";
            this.TooltipMaxLengthCheck.Size = new System.Drawing.Size(20, 25);
            this.TooltipMaxLengthCheck.TabIndex = 15;
            this.TooltipMaxLengthCheck.Text = "?";
            this.toolTip1.SetToolTip(this.TooltipMaxLengthCheck, "If path is encrypted, on Synology the max length is 143 characters. Not encrypted" +
        " on Synology it\'s 256 characters.");
            // 
            // HelpLabel1
            // 
            this.HelpLabel1.AutoSize = true;
            this.HelpLabel1.Location = new System.Drawing.Point(12, 42);
            this.HelpLabel1.Name = "HelpLabel1";
            this.HelpLabel1.Size = new System.Drawing.Size(806, 25);
            this.HelpLabel1.TabIndex = 13;
            this.HelpLabel1.Text = "This program performs request checks regarding file and folder names recursively " +
    "inside each folder.";
            // 
            // HelpLabel2
            // 
            this.HelpLabel2.AutoSize = true;
            this.HelpLabel2.Location = new System.Drawing.Point(12, 67);
            this.HelpLabel2.Name = "HelpLabel2";
            this.HelpLabel2.Size = new System.Drawing.Size(829, 25);
            this.HelpLabel2.TabIndex = 14;
            this.HelpLabel2.Text = "It can help find issues with cross-compatibility which occur especially between a" +
    " NAS and other devices.";
            // 
            // TooltipResults
            // 
            this.TooltipResults.AutoSize = true;
            this.TooltipResults.Location = new System.Drawing.Point(851, 496);
            this.TooltipResults.Name = "TooltipResults";
            this.TooltipResults.Size = new System.Drawing.Size(20, 25);
            this.TooltipResults.TabIndex = 15;
            this.TooltipResults.Text = "?";
            this.toolTip1.SetToolTip(this.TooltipResults, "If the check has finished and there are no errors or warnings, you\'re pretty much" +
        " GG.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(867, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Question marks ( ? ) show the elements have a tooltip with more information which" +
    " appears on mouse over.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 33);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(78, 29);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 923);
            this.Controls.Add(this.TooltipResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HelpLabel2);
            this.Controls.Add(this.HelpLabel1);
            this.Controls.Add(this.MaxLengthCheckGroupbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.ChecksLabel);
            this.Controls.Add(this.PathToCheckLabel);
            this.Controls.Add(this.PathToCheckTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Name Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MaxLengthCheckGroupbox.ResumeLayout(false);
            this.MaxLengthCheckGroupbox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox MaxLengthCheckbox;
        private TextBox MaxLengthTextbox;
        private TextBox PathToCheckTextBox;
        private Label PathToCheckLabel;
        private Label ChecksLabel;
        private Label MaxLengthLabel;
        private TextBox ResultsTextBox;
        private Label ResultsLabel;
        private Button StartButton;
        private Label StatusLabel;
        private Button StopButton;
        private GroupBox groupBox1;
        private CheckBox InvalidCharactersCheckbox;
        private TextBox InvalidCharactersTextbox;
        private Label InvalidCharactersLabel;
        private GroupBox MaxLengthCheckGroupbox;
        private Label HelpLabel1;
        private Label HelpLabel2;
        private Label TooltipMaxLengthCheck;
        private ToolTip toolTip1;
        private Label label2;
        private Label TooltipInvalidCharacters;
        private Label TooltipResults;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuAbout;
    }
}