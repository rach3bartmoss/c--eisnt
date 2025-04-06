using Tmds.DBus.Protocol;

namespace getStartedApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    public string Testing { get; } = "This is a test!";
}
