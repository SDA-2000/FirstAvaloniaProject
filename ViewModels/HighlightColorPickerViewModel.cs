using Avalonia.Media;
using GetStartedApp.Models;
using ReactiveUI;

namespace GetStartedApp.ViewModels;
public class HighlightColorPickerViewModel : ReactiveObject
{
    private Color _selectedColorForPicker;
    private readonly TextFormattingModel _textFormatting;

    public HighlightColorPickerViewModel(TextFormattingModel textFormatting)
    {
        _textFormatting = textFormatting;
        
        if (textFormatting.HighlightColor is SolidColorBrush solidColorBrush)
        {
            _selectedColorForPicker = solidColorBrush.Color;
        }
        else
        {
            _selectedColorForPicker = Colors.Transparent;
        }
    }

    public Color SelectedColorForPicker
    {
        get => _selectedColorForPicker;
        set
        {
            _textFormatting.HighlightColor = new SolidColorBrush(value);
            this.RaiseAndSetIfChanged(ref _selectedColorForPicker, value);
            this.RaisePropertyChanged(nameof(HighlightColor));
        }
    }

    public IBrush HighlightColor => _textFormatting.HighlightColor;
}