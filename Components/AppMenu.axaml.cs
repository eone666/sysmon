using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using sysmon.Views;
using sysmon.Windows;

namespace sysmon.Components
{
    public class AppMenu : UserControl
    {
        public AppMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CloseWindow(object? sender, RoutedEventArgs e)
        {
            MainWindow.Instance.Close();
        }

        private void RunProcess(object? sender, RoutedEventArgs e)
        {
            new RunWindow().ShowDialog(MainWindow.Instance);
        }
    }
}