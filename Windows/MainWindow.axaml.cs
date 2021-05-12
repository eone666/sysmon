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

        private static MainWindow? _instance;

        private readonly MainWindowViewModel _vm;


        public MainWindow()
        {
            DataContext = _vm = new()
            {
            };
            InitializeComponent();

            _instance ??= this;


#if DEBUG
            this.AttachDevTools();
#endif
        }
        
        public static MainWindow Instance => _instance ??= new MainWindow();
       

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}