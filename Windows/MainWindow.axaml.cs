using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace sysmon.Windows {
  public partial class MainWindow : Window {
    private static MainWindow? _instance;

    private readonly MainWindowViewModel _vm;

    public MainWindow() {
      DataContext = _vm = new MainWindowViewModel() {
      };
      InitializeComponent();

      _instance ??= this;

#if DEBUG
      this.AttachDevTools();
#endif
    }

    public static MainWindow Instance => _instance ??= new MainWindow();

    private void InitializeComponent() {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
