using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Speedtest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_detect_Click(object sender, EventArgs e)
        {
            string path = GetFullPath("speedtest-cli.exe");
            string filePath = String.Empty;

            if (path == null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Executeable File (*.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
                lbl_cli_path.Text = filePath;
            }
            btn_start_test.Enabled = true;
            list_servers.Enabled = true;
            testResult.Enabled = true;
        }

        public static bool ExistsOnPath(string fileName)
        {
            return GetFullPath(fileName) != null;
        }

        public static string GetFullPath(string fileName)
        {
            
            if (File.Exists(fileName))
                return Path.GetFullPath(fileName);

            var values = Environment.GetEnvironmentVariable("PATH");
            foreach (var path in values.Split(Path.PathSeparator))
            {
                var fullPath = Path.Combine(path, fileName);
                if (File.Exists(fullPath))
                    return fullPath;
            }
            return null;
        }

        private void btn_start_test_Click(object sender, EventArgs e)
        {
            testResult.Text = String.Empty;
            string pattern = @"server|download|upload";

            foreach (string id in list_servers.Items)
            {
                Process runTest = new Process
                {
                    StartInfo =
                    {
                        FileName = lbl_cli_path.Text,
                        Arguments = $"-s {id}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        RedirectStandardInput = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                runTest.Start();
                string result = String.Empty;
                while (!runTest.HasExited)
                {
                    string testOutput = runTest.StandardOutput.ReadLine();
                    if (testOutput == null) continue;
                    try
                    {
                        if (Regex.IsMatch(testOutput, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline))
                        {
                            result += testOutput + Environment.NewLine;
                        }
                    } catch (RegexMatchTimeoutException ex)
                    {
                        MessageBox.Show(ex.Message, "Error dude!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                testResult.Text += result + Environment.NewLine + Environment.NewLine;

            }
        }
    }
}
