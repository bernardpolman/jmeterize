using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;

namespace JMeteorApp
{
    class HelperMethods
    {
        public static void WriteToLogWindow(TextBlock t, string message, int messageType = 0)
        {
            SolidColorBrush color = new SolidColorBrush();

            switch (messageType)
            {
                case 0:
                    color = Brushes.Black;
                    break;
                case 1:
                    color = Brushes.ForestGreen;
                    break;
                case 2:
                    color = Brushes.Red;
                    break;
                case 3:
                    color = Brushes.Orange;
                    break;
            }

            Run logLine = new Run(message + "\r\n");
            logLine.Foreground = color;
            t.Inlines.Add(logLine);
        }

        public static string CheckInstallationPath()
        {
            string folderPath = JMeterizeApp.Properties.Settings.Default.JMeterDirectory;

            if(folderPath == string.Empty || !File.Exists(folderPath + Path.DirectorySeparatorChar + "jmeter.bat"))
            {
                System.Windows.MessageBox.Show("Please locate your 'bin' folder inside your JMeter software location (JMeter v.1.7+ required)", "JMeterize");
                FolderBrowserDialog directory = new FolderBrowserDialog();

                using (directory)
                {
                    if (directory.ShowDialog() == DialogResult.OK)  //check for OK...they might press cancel, so don't do anything if they did.
                    {
                        string test = directory.SelectedPath + Path.DirectorySeparatorChar + "jmeter.bat";

                        if (!File.Exists(directory.SelectedPath + Path.DirectorySeparatorChar + "jmeter.bat"))
                        {
                            System.Windows.MessageBox.Show("File 'jmeter.bat' was not found. Please verify that your JMeter folder is not missing any files!", "Alert", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        {
                            folderPath = directory.SelectedPath;
                            JMeterizeApp.Properties.Settings.Default.JMeterDirectory = directory.SelectedPath;
                            JMeterizeApp.Properties.Settings.Default.Save();
                        }
                    }
                }
            }

            return folderPath;
        }
    }
}
