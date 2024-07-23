// ctrl + m + o to collapse all

using System.Diagnostics;
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
            ResultsAdd("Attempting to force stop.");
            Globals.IsWorking = false;
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            StopButton.Enabled = true;

            ResultsTextBox.Text = "";

            Stopwatch sw = new Stopwatch();
            sw.Start();

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
                        if (MaxLengthCheckbox.Checked)
                        {
                            if (fl.Name.Length >= Convert.ToInt32(MaxLengthTextBox.Text))
                            {
                                ResultsAdd("");
                                ResultsAdd("File name too long: " + fl.Name);
                                ResultsAdd("Location: " + fl.FullName);
                                ResultsAdd("");
                            }
                        }
                    }
                    else break;
                    
                }

                var dirs = Directory.EnumerateDirectories(PathToCheckTextBox.Text, "*.*", SearchOption.AllDirectories).Select(i => new FileInfo(i));
                foreach (var dr in dirs)
                {
                    if (Globals.IsWorking)
                    {
                        if (MaxLengthCheckbox.Checked)
                        {
                            if (dr.Name.Length >= Convert.ToInt32(MaxLengthTextBox.Text))
                            {
                                ResultsAdd("");
                                ResultsAdd("Folder name too long: " + dr.Name);
                                ResultsAdd("Location: " + dr.FullName);
                                ResultsAdd("");
                            }
                        }
                    }
                    else break;

                }
            }
            catch (Exception e)
            {
                ResultsAdd("Exception: " + e.Message);
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
    }
}