using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using sysmon.Windows;

namespace sysmon.Components {
  public class FilePicker : UserControl {
    private readonly FilePickerViewModel _vm;

    public FilePicker() {
      DataContext = _vm = new FilePickerViewModel();
      InitializeComponent();
    }

    private void InitializeComponent() {
      AvaloniaXamlLoader.Load(this);
    }

    private async void OpenFileDialog(object? sender, RoutedEventArgs e) {
      OpenFileDialog dialog = new();

      string[] result = await dialog.ShowAsync(MainWindow.Instance);
      _vm.Path = result[0];
    }
  }
}
