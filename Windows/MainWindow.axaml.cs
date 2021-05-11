using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using sysmon.ViewModels;

namespace sysmon.Views
{

    public partial class MainWindow : Window
    {
        
        private readonly MainWindowViewModel _vm;


        public MainWindow()
        {
            DataContext = _vm = new()
            {
            };
            InitializeComponent();


#if DEBUG
            this.AttachDevTools();
#endif
        }
       

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Close(object? sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}