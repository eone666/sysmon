using ReactiveUI;

namespace sysmon.Windows {
  public class MessageViewModel : ReactiveObject {
    private string _message = "";

    public string Message {
      get => _message;
      set => this.RaiseAndSetIfChanged(ref _message, value);
    }
  }
}
