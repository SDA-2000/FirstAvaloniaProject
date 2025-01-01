using Avalonia.ReactiveUI;
using ReactiveUI;

namespace GetStartedApp.ViewModels;

public partial class MainWindowViewModel : ReactiveObject
{   
    public ControlPanelViewModel ControlPanelViewModel { get; }
    
    public MainWindowViewModel()
    {
        ControlPanelViewModel = new ControlPanelViewModel();
    }
}
