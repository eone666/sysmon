using Avalonia;
using Avalonia.Controls;
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
    }
}