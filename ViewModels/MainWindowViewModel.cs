using GetStartedApp.Models;
using ReactiveUI;

namespace GetStartedApp.ViewModels;

public partial class MainWindowViewModel : ReactiveObject
{   
    private readonly TextFormattingModel _textFormattingModel = new TextFormattingModel();
    public ControlPanelViewModel ControlPanelViewModel { get; }
    public DocumentPanelViewModel DocumentPanelViewModel { get; }
    public StatusBarViewModel StatusBarViewModel { get; }
    
    public MainWindowViewModel()
    {
        ControlPanelViewModel = new ControlPanelViewModel(_textFormattingModel);
        DocumentPanelViewModel = new DocumentPanelViewModel(_textFormattingModel);
        StatusBarViewModel = new StatusBarViewModel(_textFormattingModel);
    }
}
