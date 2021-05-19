using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace sysmon.Windows {
  public class RunWindow : Window {
    public RunWindow() {
      InitializeComponent();
#if DEBUG
      this.AttachDevTools();
#endif
    }

    private void InitializeComponent() {
      AvaloniaXamlLoader.Load(this);
    }

    private void Run(object? sender, RoutedEventArgs e) {
      try {
        Process.Start("");
      } catch (Exception exception) {
        Console.WriteLine(exception);
      }
    }

    private void OnOpened(object? sender, EventArgs e) {
      CanResize = false;
    }
  }
}
