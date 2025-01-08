using Avalonia.Media;
using Avalonia.Controls;
using Avalonia.VisualTree;
using ReactiveUI;

namespace GetStartedApp.ViewModels;
public class ColorPickerViewModel : ReactiveObject
{
    private Color _selectedColor = Colors.Transparent;
    private Control _contentView;

    public ColorPickerViewModel(Control contentView)
    {
        _contentView = contentView;
    }

    public Color SelectedColor
    {
        get => _selectedColor;
        set => this.RaiseAndSetIfChanged(ref _selectedColor, value);
    }
    
    public Control ContentView
    {
        get => _contentView;
        set => this.RaiseAndSetIfChanged(ref _contentView, value);
    }
}