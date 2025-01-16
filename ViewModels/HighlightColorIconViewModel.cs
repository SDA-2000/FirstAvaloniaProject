using GetStartedApp.Models;
using Avalonia.Media;
using ReactiveUI;

namespace GetStartedApp.ViewModels;

public class HighlightColorIconViewModel : ColorPickerContentViewModelBase
{
    private IBrush _selectedColor;
    private readonly TextFormattingModel _textFormatting;

    public HighlightColorIconViewModel(TextFormattingModel textFormatting)
    {
        _textFormatting = textFormatting;
        SelectedColor = _textFormatting.HighlightColor;
    }

    public IBrush SelectedColor
    {
        get => _selectedColor;
        set
        {
            this.RaiseAndSetIfChanged(ref _selectedColor, value);
            _textFormatting.HighlightColor = value;
        }
    }
    
    public TextFormattingModel TextFormatting => _textFormatting;
}