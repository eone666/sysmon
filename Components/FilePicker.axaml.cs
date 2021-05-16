using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using sysmon.Views;

namespace sysmon.Components
{
    public class FilePicker : UserControl
    {
        
        private readonly FilePickerViewModel _vm;

        public FilePicker()
        {
            DataContext = _vm = new();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async void OpenFileDialog(object? sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            string[] result = await dialog.ShowAsync(MainWindow.Instance);
            _vm.Path = result[0];
        }
    }
}