namespace File_Name_Checker
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.Discord = new System.Windows.Forms.PictureBox();
            this.GitHub = new System.Windows.Forms.PictureBox();
            this.JeFawkLogo = new System.Windows.Forms.PictureBox();
            this.KoFi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Discord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JeFawkLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoFi)).BeginInit();
            this.SuspendLayout();
            // 
            // Discord
            // 
            this.Discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Discord.Image = global::File_Name_Checker.Properties.Resources.Discord_Medium;
            this.Discord.Location = new System.Drawing.Point(365, 79);
            this.Discord.Name = "Discord";
            this.Discord.Size = new System.Drawing.Size(35, 31);
            this.Discord.TabIndex = 23;
            this.Discord.TabStop = false;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // GitHub
            // 
            this.GitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHub.Image = global::File_Name_Checker.Properties.Resources.GitHub_Medium;
            this.GitHub.Location = new System.Drawing.Point(417, 79);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(29, 32);
            this.GitHub.TabIndex = 22;
            this.GitHub.TabStop = false;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // JeFawkLogo
            // 
            this.JeFawkLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JeFawkLogo.Image = global::File_Name_Checker.Properties.Resources.JeFawkLogo_Medium2;
            this.JeFawkLogo.Location = new System.Drawing.Point(91, 81);
            this.JeFawkLogo.Name = "JeFawkLogo";
            this.JeFawkLogo.Size = new System.Drawing.Size(162, 26);
            this.JeFawkLogo.TabIndex = 21;
            this.JeFawkLogo.TabStop = false;
            this.JeFawkLogo.Click += new System.EventHandler(this.JeFawkLogo_Click);
            // 
            // KoFi
            // 
            this.KoFi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KoFi.Image = global::File_Name_Checker.Properties.Resources.KoFi_Medium;
            this.KoFi.Location = new System.Drawing.Point(265, 78);
            this.KoFi.Name = "KoFi";
            this.KoFi.Size = new System.Drawing.Size(84, 29);
            this.KoFi.TabIndex = 20;
            this.KoFi.TabStop = false;
            this.KoFi.Click += new System.EventHandler(this.KoFi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thanks for trying out my smol program 🙂. Hope it\'s helpful.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Got questions, ideas, or just want to chat? Feel free to reach out! 😁";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 124);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Discord);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.JeFawkLogo);
            this.Controls.Add(this.KoFi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.Discord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JeFawkLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoFi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Discord;
        private PictureBox GitHub;
        private PictureBox JeFawkLogo;
        private PictureBox KoFi;
        private Label label1;
        private Label label2;
    }
}