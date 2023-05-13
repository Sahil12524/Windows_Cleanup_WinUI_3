// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Windows_Cleanup_WinUI_3.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PowerOptionsView : Page
    {
        public PowerOptionsView()
        {
            this.InitializeComponent();
        }

        private void btnShutdown_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        private void btnAbortSR_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        private void btnLogOff_Click(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}