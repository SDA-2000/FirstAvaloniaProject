using Avalonia.ReactiveUI;
using GetStartedApp.ViewModels;

namespace GetStartedApp.Views;

public partial class ControlPanelView : ReactiveUserControl<ControlPanelViewModel>
{
    public ControlPanelView()
    {
        InitializeComponent();
    }
}