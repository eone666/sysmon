using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace sysmon.Windows
{
    public class RunWindow : Window
    {
        public RunWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async void OpenFileDialog(object? sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            string[] result = await dialog.ShowAsync(this);

            if (result != null && result.Length > 0)
            {
                try
                {
 
                        Process.Start(result[0]);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }
    }
}