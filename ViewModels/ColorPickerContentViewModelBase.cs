using GetStartedApp.Models;
using Avalonia.Media;
using ReactiveUI;

namespace GetStartedApp.ViewModels;

public abstract class ColorPickerContentViewModelBase : ReactiveObject
{
    private IBrush _selectedColor;
    public IBrush SelectedColor { get; set; }
    private readonly TextFormattingModel _textFormatting;
    public TextFormattingModel TextFormatting => _textFormatting;
}