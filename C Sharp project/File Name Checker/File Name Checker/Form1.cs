// ctrl + m + o to collapse all

using System.Diagnostics;
using System.IO;
using System.Timers;

namespace File_Name_Checker
{
    public partial class Form1 : Form
    {
        public static class Globals
        {
            public const Int32 BUFFER_SIZE = 512; // Unmodifiable
            public static String FILE_NAME = "Output.txt"; // Modifiable
            public static readonly String CODE_PREFIX = "US-"; // Unmodifiable

            public static string[] InvalidCharacters = new string[100];

            public static bool IsWorking = false;
        }

        public Form1()
        {
            InitializeComponent();

            StatusLabelUpdate();

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;

            toolTip1.SetToolTip(MaxLengthCheckGroupbox, "If path is encrypted, on Synology the max length is 143 characters. Not encrypted on Synology it's 256 characters.");

        }

        private void StatusLabelUpdate()
        {
            if (StatusLabel.InvokeRequired)
            {
                StatusLabel.BeginInvoke(() =>
                {
                    if (Globals.IsWorking)
                    {
                        if (StatusLabel.Text == "Working")
                            StatusLabel.Text = "Working.";
                        else if (StatusLabel.Text == "Working.")
                            StatusLabel.Text = "Working..";
                        else if (StatusLabel.Text == "Working..")
                            StatusLabel.Text = "Working...";
                        else if (StatusLabel.Text == "Working...")
                            StatusLabel.Text = "Working";
                        else StatusLabel.Text = "Working";
                    }
                    else StatusLabel.Text = "Idle";

                });
            }
            else
            {
                if (Globals.IsWorking)
                {
                    if (StatusLabel.Text == "Working")
                        StatusLabel.Text = "Working.";
                    else if (StatusLabel.Text == "Working.")
                        StatusLabel.Text = "Working..";
                    else if (StatusLabel.Text == "Working..")
                        StatusLabel.Text = "Working...";
                    else if (StatusLabel.Text == "Working...")
                        StatusLabel.Text = "Working";
                    else StatusLabel.Text = "Working";
                }
                else StatusLabel.Text = "Idle";
            }
        }

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

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //foreach (string file in files) Console.WriteLine(file);
        }

        private void ForceStop()
        {
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            InvalidCharactersLabel.Enabled = true;
            ResultsAdd("Attempting to force stop.");
            Globals.IsWorking = false;
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            InvalidCharactersLabel.Enabled = false;

            ResultsTextBox.Text = "";

            Stopwatch sw = new Stopwatch();
            sw.Start();

            Globals.InvalidCharacters = InvalidCharactersTextbox.Text.Split(' ');

            Globals.IsWorking = true;
            StatusLabelUpdate();
            ResultsAdd("Starting");

            await Task.Run(() => CheckRecursive());

            sw.Stop();

            Globals.IsWorking = false;
            StatusLabelUpdate();
            ResultsAdd("Finished. It took " + sw.Elapsed);

            StartButton.Enabled = true;
            StopButton.Enabled = false;
            InvalidCharactersLabel.Enabled = true;
        }

        private void CheckRecursive()
        {
            var files = Directory.EnumerateFiles(PathToCheckTextBox.Text, "*.*", SearchOption.AllDirectories).Select(i => new FileInfo(i));
            try
            {
                foreach (var fl in files)
                {
                    if (Globals.IsWorking)
                    {
                        CheckOne(fl);
                        
                    }
                    else break;
                    
                }

                var dirs = Directory.EnumerateDirectories(PathToCheckTextBox.Text, "*.*", SearchOption.AllDirectories).Select(i => new FileInfo(i));
                foreach (var dr in dirs)
                {
                    if (Globals.IsWorking)
                    {
                        CheckOne(dr);
                        
                    }
                    else break;

                }
            }
            catch (Exception e)
            {
                ResultsAdd("Exception: " + e.Message);
            }
        }

        private void CheckOne(FileInfo FileOrFolder)
        {
            if (MaxLengthCheckbox.Checked)
            {
                if (FileOrFolder.Name.Length >= Convert.ToInt32(MaxLengthTextbox.Text))
                {
                    ResultsAdd("");
                    ResultsAdd(IsFileOrFolderPretty(FileOrFolder, true) + " name too long: " + FileOrFolder.Name);
                    ResultsAdd("Location: " + FileOrFolder.FullName);
                    ResultsAdd("");
                }
            }
            if (InvalidCharactersCheckbox.Checked)
            {
                foreach (string Character in Globals.InvalidCharacters)
                {
                    if (FileOrFolder.Name.IndexOf(Character) != -1) 
                    {
                        ResultsAdd("");
                        ResultsAdd(IsFileOrFolderPretty(FileOrFolder, true) + " contains invalid characters: " + FileOrFolder.Name);
                        ResultsAdd("Location: " + FileOrFolder.FullName);
                        ResultsAdd("");
                    }
                }
            }

        }

        // Specify what you want to happen when the Elapsed event is raised.
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            StatusLabelUpdate();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ForceStop();   
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileOrFolder"></param>
        /// <returns>0 for file, 1 for directory</returns>
        private int IsFileOrFolder(FileInfo FileOrFolder)
        {
            var attributes = File.GetAttributes(FileOrFolder.FullName);

            bool isDirectory = attributes.HasFlag(FileAttributes.Directory);

            if (isDirectory) return 1;
            else return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileOrFolder"></param>
        /// <param name="IsCapitalFirstLetter"></param>
        /// <returns>File or file / Folder or folder</returns>
        private string IsFileOrFolderPretty(FileInfo FileOrFolder, bool IsCapitalFirstLetter)
        {
            if (IsFileOrFolder(FileOrFolder) == 0)
            {
                if (IsCapitalFirstLetter) return "File";
                else return "file";
            }
            else
            {
                if (IsCapitalFirstLetter) return "Folder";
                else return "folder";
            }
        }
    }
}