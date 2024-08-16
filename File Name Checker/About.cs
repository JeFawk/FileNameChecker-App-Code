using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Name_Checker
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OpenLinkInBrowser(string linkToOpen)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = linkToOpen,
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open the link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            OpenLinkInBrowser("https://github.com/JeFawk/FileNameChecker-App-Code");
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            OpenLinkInBrowser("https://jefawk.com/contact/discord.html");
        }

        private void KoFi_Click(object sender, EventArgs e)
        {
            OpenLinkInBrowser("https://ko-fi.com/jefawks_spaghettorium");
        }

        private void JeFawkLogo_Click(object sender, EventArgs e)
        {
            OpenLinkInBrowser("https://jefawk.com");
        }
    }
}
