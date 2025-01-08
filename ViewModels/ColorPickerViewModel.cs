using Avalonia.Media;
using ReactiveUI;

namespace GetStartedApp.ViewModels;
public class ColorPickerViewModel : ReactiveObject
{
    private Color _selectedColor = Colors.Black;

    public Color SelectedColor
    {
        get => _selectedColor;
        set => this.RaiseAndSetIfChanged(ref _selectedColor, value);
    }
}