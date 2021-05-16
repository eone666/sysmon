using ReactiveUI;
using sysmon.ViewModels;

namespace sysmon.Components
{
    public class FilePickerViewModel: ReactiveObject
    {
        private string _path = "";
        
        public string Path
        {
            get => _path;
            set => this.RaiseAndSetIfChanged(ref _path, value);
        }
    }
}