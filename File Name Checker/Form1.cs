#region License
/*MIT License

Copyright (c) 2026 JeFawk from Smol Spaghettorium (Andrei Pistol)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion


// ctrl + m + o to collapse all

using System.Diagnostics;
using System.Reflection;

namespace File_Name_Checker
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer statusTimer;
        private volatile bool scanHadErrors;

        private static readonly HashSet<string> IgnoredDirectories =
            new(StringComparer.OrdinalIgnoreCase)
            {
                    "#recycle",
                    "@eaDir"
            };
        public static class Globals
        {
            public static volatile bool IsWorking;

        }

        public Form1()
        {
            InitializeComponent();

            statusTimer = new System.Windows.Forms.Timer();
            statusTimer.Interval = 1000;
            statusTimer.Tick += StatusTimer_Tick;
            statusTimer.Start();

            StatusLabelUpdate();
        }

        /// <summary>
        /// Form load: sets active component, sets form title based on version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object? sender, EventArgs e)
        {
            // Sets the active component the ResultsTextBox to avoid the input boxes to be active. This then would make the placeholder not visible and the user couldn't see the helpful information there.
            this.ActiveControl = ResultsTextBox;

            // Get the assembly that contains the form
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Retrieve the File Version
            AssemblyFileVersionAttribute? fileVersion = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>();
            string fileVersionString = fileVersion?.Version ?? "Unknown";

            // Get the title attribute from the assembly (project title)
            AssemblyTitleAttribute? titleAttribute = assembly.GetCustomAttribute<AssemblyTitleAttribute>();
            string projectTitle = titleAttribute != null ? titleAttribute.Title : "File Name Checker";


            // Set the form's title
            this.Text = $"{projectTitle} - v. {fileVersionString}";
        }

        private void StatusTimer_Tick(object? sender, EventArgs e)
        {
            StatusLabelUpdate();
        }
        private void StatusLabelUpdate()
        {
            if (!Globals.IsWorking)
            {
                StatusLabel.Text = "Idle";
                return;
            }

            switch (StatusLabel.Text)
            {
                case "Working":
                    StatusLabel.Text = "Working.";
                    break;

                case "Working.":
                    StatusLabel.Text = "Working..";
                    break;

                case "Working..":
                    StatusLabel.Text = "Working...";
                    break;

                default:
                    StatusLabel.Text = "Working";
                    break;
            }
        }

        /// <summary>
        /// Adds logs and errors to the read-only ResultBox
        /// </summary>
        /// <param name="result"></param>
        private void ResultsAdd(string result)
        {

            if (ResultsTextBox.InvokeRequired)
            {
                ResultsTextBox.BeginInvoke(() =>
                {
                    ResultsTextBox.AppendText(ResultsTextBox.Text.Length == 0 ? result : "\r\n" + result);
                });
            }
            else
            {
                ResultsTextBox.AppendText(ResultsTextBox.Text.Length == 0 ? result : "\r\n" + result);
            }
        }

        private void MaxLengthCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        #region Failed attempt to make drag drop work
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //foreach (string file in files) Console.WriteLine(file);
        }
        #endregion

        private void ForceStop()
        {
            if (!Globals.IsWorking)
                return;

            Globals.IsWorking = false;
            StopButton.Enabled = false;
            ResultsAdd("Stopping...");
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            
            string rootPath = PathToCheckTextBox.Text.Trim();

            if (!Directory.Exists(rootPath))
            {
                ResultsAdd("Folder does not exist or cannot be accessed.");
                return;
            }


            // Copy control values while still on the UI thread.
            bool checkMaxLength = MaxLengthCheckbox.Checked;
            bool checkInvalidCharacters = InvalidCharactersCheckbox.Checked;

            int maxLength = 0;

            if (checkMaxLength &&
                (!int.TryParse(MaxLengthTextbox.Text, out maxLength) ||
                 maxLength < 1))
            {
                ResultsAdd("Maximum length must be a positive whole number.");
                return;
            }

            string[] invalidCharacters = InvalidCharactersTextbox.Text.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries |
                StringSplitOptions.TrimEntries
            );

            StartButton.Enabled = false;
            StopButton.Enabled = true;
            InvalidCharactersLabel.Enabled = false;

            ResultsTextBox.Clear();

            Stopwatch stopwatch = Stopwatch.StartNew();

            scanHadErrors = false;
            Globals.IsWorking = true;

            StatusLabelUpdate();
            ResultsAdd("Starting");

            try
            {
                await Task.Run(() =>
                    CheckDirectory(
                        rootPath,
                        checkMaxLength,
                        maxLength,
                        checkInvalidCharacters,
                        invalidCharacters
                    )
                );

                bool wasStopped = !Globals.IsWorking;

                stopwatch.Stop();

                if (wasStopped)
                    ResultsAdd("Stopped. It ran for " + stopwatch.Elapsed);
                else if (scanHadErrors)
                    ResultsAdd("Finished with errors. It took " + stopwatch.Elapsed);
                else
                    ResultsAdd("Finished successfully. It took " + stopwatch.Elapsed);
            }
            catch (Exception exception)
            {
                stopwatch.Stop();
                ResultsAdd("Unexpected error: " + exception.Message);
            }
            finally
            {
                Globals.IsWorking = false;
                StatusLabelUpdate();

                StartButton.Enabled = true;
                StopButton.Enabled = false;
                InvalidCharactersLabel.Enabled = true;
            }
        }

        

     
        private void CheckDirectory(
            string path,
            bool checkMaxLength,
            int maxLength,
            bool checkInvalidCharacters,
            string[] invalidCharacters)
        {
            if (!Globals.IsWorking)
                return;

            try
            {
                foreach (string filePath in Directory.EnumerateFiles(path))
                {
                    if (!Globals.IsWorking)
                        return;

                    CheckOne(
                        new FileInfo(filePath),
                        checkMaxLength,
                        maxLength,
                        checkInvalidCharacters,
                        invalidCharacters
                    );
                }

                foreach (string directoryPath in Directory.EnumerateDirectories(path))
                {
                    if (!Globals.IsWorking)
                        return;

                    var directory = new DirectoryInfo(directoryPath);

                    // Skip Synology recycle folders.
                    if (IgnoredDirectories.Contains(directory.Name))
                    {
                        ResultsAdd("Skipped system folder: " + directory.FullName);
                        continue;
                    }

                    CheckOne(
                        directory,
                        checkMaxLength,
                        maxLength,
                        checkInvalidCharacters,
                        invalidCharacters
                    );

                    CheckDirectory(
                        directoryPath,
                        checkMaxLength,
                        maxLength,
                        checkInvalidCharacters,
                        invalidCharacters
                    );
                }
            }
            catch (UnauthorizedAccessException)
            {
                scanHadErrors = true;
                ResultsAdd("Skipped, no permission: " + path);
            }
            catch (IOException e)
            {
                scanHadErrors = true;
                ResultsAdd("Could not check: " + path + " — " + e.Message);
            }
            catch (Exception e)
            {
                scanHadErrors = true;
                ResultsAdd("Exception checking " + path + ": " + e.Message);
            }
        }
        private void CheckOne(
            FileSystemInfo fileOrFolder,
            bool checkMaxLength,
            int maxLength,
            bool checkInvalidCharacters,
            string[] invalidCharacters)
        {
            if (checkMaxLength && fileOrFolder.Name.Length > maxLength)
            {
                ResultsAdd(
                    Environment.NewLine +
                    IsFileOrFolderPretty(fileOrFolder, true) +
                    " name too long: " + fileOrFolder.Name +
                    Environment.NewLine +
                    "Location: " + fileOrFolder.FullName +
                    Environment.NewLine
                );
            }

            if (checkInvalidCharacters)
            {
                foreach (string character in invalidCharacters)
                {
                    if (fileOrFolder.Name.Contains(
                        character,
                        StringComparison.Ordinal))
                    {
                        ResultsAdd(
                            Environment.NewLine +
                            IsFileOrFolderPretty(fileOrFolder, true) +
                            " contains invalid character \"" + character + "\": " +
                            fileOrFolder.Name +
                            Environment.NewLine +
                            "Location: " + fileOrFolder.FullName +
                            Environment.NewLine
                        );
                    }
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ForceStop();   
        }

        private string IsFileOrFolderPretty(
            FileSystemInfo fileOrFolder,
            bool isCapitalFirstLetter)
        {
            bool isFolder = fileOrFolder is DirectoryInfo;

            if (isFolder)
                return isCapitalFirstLetter ? "Folder" : "folder";

            return isCapitalFirstLetter ? "File" : "file";
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            AboutForm newForm = new AboutForm();
            newForm.ShowDialog();
        }
    }
}