using GetStartedApp.ViewModels;
using Avalonia.Controls;

namespace GetStartedApp.Views;

public partial class HighlightColorIconView : UserControl
{
    public HighlightColorIconView(HighlightColorIconViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}