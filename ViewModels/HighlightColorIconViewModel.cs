using GetStartedApp.Models;
using Avalonia.Media;
using ReactiveUI;

namespace GetStartedApp.ViewModels;

public class HighlightColorIconViewModel : ReactiveObject
{
    private Color _selectedColor;
    private readonly TextFormattingModel _textFormatting;

    public HighlightColorIconViewModel(TextFormattingModel textFormatting)
    {
        _textFormatting = textFormatting;
        SelectedColor = _textFormatting.HighlightColor;
    }

    public Color SelectedColor
    {
        get => _selectedColor;
        set
        {
            this.RaiseAndSetIfChanged(ref _selectedColor, value);
            _textFormatting.HighlightColor = value;
        }
    }
}