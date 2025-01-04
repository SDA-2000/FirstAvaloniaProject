using Avalonia.Controls;
using GetStartedApp.ViewModels;

namespace GetStartedApp.Views;

public partial class FontSizeDatalistView : UserControl
{
    public FontSizeDatalistView()
    {
        InitializeComponent();
        DataContext = new FontSizeDatalistViewModel();
    }
}