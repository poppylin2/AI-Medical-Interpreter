using Microsoft.Web.WebView2.Core;
using System;
using System.Windows;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            try
            {
                await webView.EnsureCoreWebView2Async();
                
                webView.CoreWebView2.SetVirtualHostNameToFolderMapping(
                    "local.app", 
                    @"D:\CppProjects\AI-Medical-Interpreter\templates",
                    CoreWebView2HostResourceAccessKind.Allow);
                    
                webView.CoreWebView2.SetVirtualHostNameToFolderMapping(
                    "static.app", 
                    @"D:\CppProjects\AI-Medical-Interpreter\static",
                    CoreWebView2HostResourceAccessKind.Allow);

                webView.CoreWebView2.Navigate("https://local.app/index.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"WebView2 initialization failed: {ex.Message}");
            }
        }
    }
}