using ReactiveUI;

namespace sysmon.Windows {
  public class RunWindowViewModel : ReactiveObject {
    private string _path = "";

    public string Path {
      get => _path;
      set => this.RaiseAndSetIfChanged(ref _path, value);
    }
  }
}
