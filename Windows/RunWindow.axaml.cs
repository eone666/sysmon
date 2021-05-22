using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace sysmon.Windows {
  public class RunWindow : Window {

    private readonly RunWindowViewModel _vm;

    public RunWindow() {
      DataContext = _vm = new RunWindowViewModel();
      InitializeComponent();
    }

    private void InitializeComponent() {
      AvaloniaXamlLoader.Load(this);
    }

    private void RunAndCloseWindow() {
      try {
        Process.Start(_vm.Path);
      } catch (Exception exception) {
        Message.Show(this, exception.Message);
      }
      Close();
    }
    private void Run(object? sender, RoutedEventArgs e) {
      RunAndCloseWindow();
    }

    private async void OpenFileDialog(object? sender, RoutedEventArgs e) {
      OpenFileDialog dialog = new();

      string[] result = await dialog.ShowAsync(MainWindow.Instance);
      _vm.Path = result?[0] ?? String.Empty;
    }

    private void OnOpened(object? sender, EventArgs e) {
      CanResize = false;
    }

    private void OnEnterPress(object? sender, KeyEventArgs e) {
      if (e.Key.Equals(Key.Enter)) {
        RunAndCloseWindow();
      }
    }
  }
}
