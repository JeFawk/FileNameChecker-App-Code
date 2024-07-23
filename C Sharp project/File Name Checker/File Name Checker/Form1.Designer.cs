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
            this.MaxLengthCheckbox = new System.Windows.Forms.CheckBox();
            this.MaxLengthTextBox = new System.Windows.Forms.TextBox();
            this.PathToCheckTextBox = new System.Windows.Forms.TextBox();
            this.PathToCheckLabel = new System.Windows.Forms.Label();
            this.ChecksLabel = new System.Windows.Forms.Label();
            this.MaxLengthLabel = new System.Windows.Forms.Label();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaxLengthCheckbox
            // 
            this.MaxLengthCheckbox.AutoSize = true;
            this.MaxLengthCheckbox.Checked = true;
            this.MaxLengthCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaxLengthCheckbox.Enabled = false;
            this.MaxLengthCheckbox.Location = new System.Drawing.Point(12, 124);
            this.MaxLengthCheckbox.Name = "MaxLengthCheckbox";
            this.MaxLengthCheckbox.Size = new System.Drawing.Size(175, 29);
            this.MaxLengthCheckbox.TabIndex = 0;
            this.MaxLengthCheckbox.Text = "Max length check";
            this.MaxLengthCheckbox.UseVisualStyleBackColor = true;
            this.MaxLengthCheckbox.CheckedChanged += new System.EventHandler(this.MaxLengthCheckbox_CheckedChanged);
            // 
            // MaxLengthTextBox
            // 
            this.MaxLengthTextBox.Location = new System.Drawing.Point(338, 125);
            this.MaxLengthTextBox.Name = "MaxLengthTextBox";
            this.MaxLengthTextBox.Size = new System.Drawing.Size(150, 31);
            this.MaxLengthTextBox.TabIndex = 1;
            this.MaxLengthTextBox.Text = "143";
            // 
            // PathToCheckTextBox
            // 
            this.PathToCheckTextBox.Location = new System.Drawing.Point(12, 37);
            this.PathToCheckTextBox.Name = "PathToCheckTextBox";
            this.PathToCheckTextBox.Size = new System.Drawing.Size(961, 31);
            this.PathToCheckTextBox.TabIndex = 2;
            // 
            // PathToCheckLabel
            // 
            this.PathToCheckLabel.AutoSize = true;
            this.PathToCheckLabel.Location = new System.Drawing.Point(12, 9);
            this.PathToCheckLabel.Name = "PathToCheckLabel";
            this.PathToCheckLabel.Size = new System.Drawing.Size(204, 25);
            this.PathToCheckLabel.TabIndex = 3;
            this.PathToCheckLabel.Text = "Path to check recursively";
            // 
            // ChecksLabel
            // 
            this.ChecksLabel.AutoSize = true;
            this.ChecksLabel.Location = new System.Drawing.Point(12, 96);
            this.ChecksLabel.Name = "ChecksLabel";
            this.ChecksLabel.Size = new System.Drawing.Size(159, 25);
            this.ChecksLabel.TabIndex = 4;
            this.ChecksLabel.Text = "Checks to perform";
            // 
            // MaxLengthLabel
            // 
            this.MaxLengthLabel.AutoSize = true;
            this.MaxLengthLabel.Location = new System.Drawing.Point(228, 128);
            this.MaxLengthLabel.Name = "MaxLengthLabel";
            this.MaxLengthLabel.Size = new System.Drawing.Size(104, 25);
            this.MaxLengthLabel.TabIndex = 5;
            this.MaxLengthLabel.Text = "Max length:";
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 272);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsTextBox.Size = new System.Drawing.Size(961, 433);
            this.ResultsTextBox.TabIndex = 6;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(12, 244);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(67, 25);
            this.ResultsLabel.TabIndex = 7;
            this.ResultsLabel.Text = "Results";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 207);
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
            this.StatusLabel.Location = new System.Drawing.Point(12, 708);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(174, 25);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Status label disabled";
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(144, 207);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(112, 34);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 742);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.MaxLengthLabel);
            this.Controls.Add(this.ChecksLabel);
            this.Controls.Add(this.PathToCheckLabel);
            this.Controls.Add(this.PathToCheckTextBox);
            this.Controls.Add(this.MaxLengthTextBox);
            this.Controls.Add(this.MaxLengthCheckbox);
            this.Name = "Form1";
            this.Text = "File Name Checker";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox MaxLengthCheckbox;
        private TextBox MaxLengthTextBox;
        private TextBox PathToCheckTextBox;
        private Label PathToCheckLabel;
        private Label ChecksLabel;
        private Label MaxLengthLabel;
        private TextBox ResultsTextBox;
        private Label ResultsLabel;
        private Button StartButton;
        private Label StatusLabel;
        private Button StopButton;
    }
}