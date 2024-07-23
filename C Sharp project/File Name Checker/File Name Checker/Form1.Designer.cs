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
            this.InvalidCharactersLabel = new System.Windows.Forms.Label();
            this.InvalidCharactersTextbox = new System.Windows.Forms.TextBox();
            this.InvalidCharactersCheckbox = new System.Windows.Forms.CheckBox();
            this.MaxLengthCheckGroupbox = new System.Windows.Forms.GroupBox();
            this.HelpLabel3 = new System.Windows.Forms.Label();
            this.HelpLabel1 = new System.Windows.Forms.Label();
            this.HelpLabel2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.MaxLengthCheckGroupbox.SuspendLayout();
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
            this.MaxLengthCheckbox.TabIndex = 0;
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
            this.PathToCheckTextBox.Location = new System.Drawing.Point(12, 153);
            this.PathToCheckTextBox.Name = "PathToCheckTextBox";
            this.PathToCheckTextBox.PlaceholderText = "\\\\NASNameHere\\Folder";
            this.PathToCheckTextBox.Size = new System.Drawing.Size(862, 31);
            this.PathToCheckTextBox.TabIndex = 2;
            // 
            // PathToCheckLabel
            // 
            this.PathToCheckLabel.AutoSize = true;
            this.PathToCheckLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathToCheckLabel.Location = new System.Drawing.Point(12, 122);
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
            this.ResultsTextBox.TabIndex = 6;
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
            this.StatusLabel.Size = new System.Drawing.Size(174, 25);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Status label disabled";
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
            this.MaxLengthCheckGroupbox.Controls.Add(this.HelpLabel3);
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
            // HelpLabel3
            // 
            this.HelpLabel3.AutoSize = true;
            this.HelpLabel3.Location = new System.Drawing.Point(223, 14);
            this.HelpLabel3.Name = "HelpLabel3";
            this.HelpLabel3.Size = new System.Drawing.Size(20, 25);
            this.HelpLabel3.TabIndex = 15;
            this.HelpLabel3.Text = "?";
            // 
            // HelpLabel1
            // 
            this.HelpLabel1.AutoSize = true;
            this.HelpLabel1.Location = new System.Drawing.Point(12, 17);
            this.HelpLabel1.Name = "HelpLabel1";
            this.HelpLabel1.Size = new System.Drawing.Size(806, 25);
            this.HelpLabel1.TabIndex = 13;
            this.HelpLabel1.Text = "This program performs request checks regarding file and folder names recursively " +
    "inside each folder.";
            // 
            // HelpLabel2
            // 
            this.HelpLabel2.AutoSize = true;
            this.HelpLabel2.Location = new System.Drawing.Point(12, 42);
            this.HelpLabel2.Name = "HelpLabel2";
            this.HelpLabel2.Size = new System.Drawing.Size(829, 25);
            this.HelpLabel2.TabIndex = 14;
            this.HelpLabel2.Text = "It can help find issues with cross-compatibility which occur especially between a" +
    " NAS and other devices.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(859, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Question mark ( ? ) show the elements have a tooltip with more information which " +
    "appears on mouse over.";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 923);
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
            this.Name = "Form1";
            this.Text = "File Name Checker";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MaxLengthCheckGroupbox.ResumeLayout(false);
            this.MaxLengthCheckGroupbox.PerformLayout();
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
        private Label HelpLabel3;
        private ToolTip toolTip1;
        private Label label2;
    }
}