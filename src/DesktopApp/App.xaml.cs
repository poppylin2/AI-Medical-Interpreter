using System;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace DesktopApp
{
    public partial class MainWindow : Window
    {

        private async void InitializeWebView()
        {
            await webView.EnsureCoreWebView2Async();
            webView.Source = new Uri("file:///D:/CppProjects/AI-Medical-Interpreter/templates/index.html");
        }
    }
}
