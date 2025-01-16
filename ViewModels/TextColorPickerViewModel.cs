using Avalonia.Media;
using GetStartedApp.Models;
using ReactiveUI;

namespace GetStartedApp.ViewModels;
public class TextColorPickerViewModel : ReactiveObject
{
    private Color _selectedColorForPicker;
    private readonly TextFormattingModel _textFormatting;

    public TextColorPickerViewModel(TextFormattingModel textFormatting)
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
            _textFormatting.TextColor = new SolidColorBrush(value);
            this.RaiseAndSetIfChanged(ref _selectedColorForPicker, value);
            this.RaisePropertyChanged(nameof(TextColor));
        }
    }

    public IBrush TextColor => _textFormatting.TextColor;
}