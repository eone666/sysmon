using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace sysmon.Windows {
  public class Message : Window {
    private readonly MessageViewModel _vm;

    public Message() {
      DataContext = _vm = new();
      Init();
    }

    public Message(string message) {
      DataContext = _vm = new() {
        Message = message,
      };

      Init();
    }

    private void Init() {
      InitializeComponent();
#if DEBUG
      this.AttachDevTools();
#endif
    }

    private void InitializeComponent() {
      AvaloniaXamlLoader.Load(this);
    }

    public static void Show(Window parent, string message) {
      new Message(message).ShowDialog(parent);
    }

    private void Ok(object? sender, RoutedEventArgs e) {
      Close();
    }

    private void OnOpened(object? sender, EventArgs e) {
      CanResize = false;
    }
  }
}

