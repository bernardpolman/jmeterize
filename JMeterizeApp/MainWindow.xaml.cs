using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static JMeteorApp.HelperMethods;

namespace JMeteorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool FileOk { get; set; }

        public string scriptFullPath = string.Empty;
        public string scriptDirectoryPath = string.Empty;
        public string scriptFilename = string.Empty;
        public string installationDirectory = string.Empty;

        public MainWindow()
        {
            InitializeComponent();

            StyleProperty.OverrideMetadata(typeof(Window), new FrameworkPropertyMetadata
            {
                DefaultValue = FindResource(typeof(Window))
            });

            FileOk = false;
            var process = new Process();
            installationDirectory = CheckInstallationPath();
            WriteToLogWindow(txtLog, "Waiting for JMeter script...");
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                // Set filter for file extension and default file extension 
                DefaultExt = ".jmx",
                Filter = "JMeter scripts (*.jmx)|*.jmx"
            };

            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                scriptFilename = System.IO.Path.GetFileNameWithoutExtension(dlg.FileName);
                scriptFullPath = dlg.FileName;
                scriptDirectoryPath = System.IO.Path.GetDirectoryName(dlg.FileName);
                labelScriptName.Content = scriptFilename;
                labelScriptName.Foreground = Brushes.ForestGreen;
                txtScriptPath.Text = scriptFullPath;
                FileOk = true;
            }
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            if (FileOk)
            {
                txtLog.Text = string.Empty;
                WriteToLogWindow(txtLog, "Script '" + scriptFilename + "' loaded!\r\n\r\n" +
                    "Script started at: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n\r\n" +
                    "Please check JMeter console window for further test progress and results");
                RunScript();
            }
            else
            {
                labelScriptName.Foreground = Brushes.Red;
                labelScriptName.Content = "Please choose a JMeter script!";
            }
        }

        private void RunScript()
        {
            string testCommandLine = "/K jmeter -n -t " + scriptFullPath;
            string timestamp = DateTime.Now.Ticks.ToString();
            string testResultsFolder = scriptFilename + "_" + timestamp;


            if (checkboxGenerateCSV.IsChecked ?? false)
            {
                testCommandLine += " -l " + scriptDirectoryPath + System.IO.Path.DirectorySeparatorChar + testResultsFolder
                    + System.IO.Path.DirectorySeparatorChar + testResultsFolder + ".csv";
            }

            if (checkboxGenerateHTML.IsChecked ?? false)
            {
                testCommandLine += " -e -o " + scriptDirectoryPath + System.IO.Path.DirectorySeparatorChar + testResultsFolder;
            }

            var process = new Process();
            var startInfo = new ProcessStartInfo
            {
                WorkingDirectory = @installationDirectory,
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                Arguments = testCommandLine,
            };

            process.StartInfo = startInfo;
            process.Start();
        }

        private void TxtScriptPath_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
