// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Windows_Cleanup_WinUI_3.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BasicToolsView : Page
    {
        public BasicToolsView()
        {
            this.InitializeComponent();
        }

        public void cmdExec(string? path)
        {
            try
            {
                // Get the installed location of the application package
                string appFolderPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;

                // Specify the relative path to your .bat file inside the AppX folder
                string relativeBatPath = path;

                // Combine the app folder path and the relative bat path
                string batFilePath = Path.Combine(appFolderPath, relativeBatPath);

                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = batFilePath,
                    WorkingDirectory = appFolderPath,
                    UseShellExecute = true
                };

                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during execution
            }
        }

        private void btnTempFilesRemove_Click(object sender, RoutedEventArgs e)
        {
            cmdExec(@"Scripts\\cleanscript.bat");
        }

        private void btnWindowsUpdateCacheClean_Click(object sender, RoutedEventArgs e)
        {
            cmdExec(@"Scripts\\WindowsUpdateCacheRemove.bat");
        }

        private void btnCHKDSK_Click(object sender, RoutedEventArgs e)
        {
            cmdExec(@"Scripts\\CheckDiskError.bat");
        }

        private void btnSSDTrim_Click(object sender, RoutedEventArgs e)
        {
            cmdExec(@"Scripts\\SSDOPTIMIZE.bat");
        }
    }
}
