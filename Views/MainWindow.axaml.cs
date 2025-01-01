using Avalonia.Controls;
using GetStartedApp.ViewModels;

namespace GetStartedApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}