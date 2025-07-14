using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace tubeKittenDL
{
    public partial class TubeKitten : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        public TubeKitten()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string url = urlTextBox.Text;
            string selectedFormat = formatDropdown.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedFormat))
            {
                MessageBox.Show("Please select a download format.");
                return;
            }

            if (string.IsNullOrWhiteSpace(url) || url == "Enter URL")
            {
                MessageBox.Show("Please enter a valid URL.");
                return;
            }
            bool audioOnly = selectedFormat.Contains("audio");
            DownloadVideo(url, audioOnly);
            Debug.WriteLine("type: " + selectedFormat);
        }
        private void DownloadVideo(string url, bool audioOnly)
        {
            string args = audioOnly
                ? $"-x --audio-format mp3 \"{url}\""
                : $"\"{url}\"";
            Debug.WriteLine("is audio: " + audioOnly);
            Debug.WriteLine("yt-dlp args: " + args);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "yt-dlp.exe",
                Arguments = args,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                process.OutputDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        Debug.WriteLine("[OUT] " + e.Data);
                };
                process.ErrorDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        Debug.WriteLine("[ERR] " + e.Data);
                };


                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (process.ExitCode != 0)
                {
                    // Only show stderr if yt-dlp failed (non-zero exit code)
                    MessageBox.Show("Download failed:\n" + error);
                }
                else
                {
                    MessageBox.Show("Download finished!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }

        }
    }
}
