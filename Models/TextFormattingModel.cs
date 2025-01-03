using Avalonia.Media;
using ReactiveUI;
using System.Collections.ObjectModel;

namespace GetStartedApp.Models;

public class TextFormattingModel : ReactiveObject
{
    private FontFamily _fontFamily = new FontFamily("Calibri");

    public FontFamily FontFamily
    {
        get => _fontFamily;
        set => this.RaiseAndSetIfChanged(ref _fontFamily, value);
    }
    
    private uint _fontSize = 12;

    public uint FontSize
    {
        get => _fontSize;
        set => this.RaiseAndSetIfChanged(ref _fontSize, value);
    }
    
    private FontWeight _fontWeight = FontWeight.Regular;

    public FontWeight FontWeight
    {
        get => _fontWeight;
        set => this.RaiseAndSetIfChanged(ref _fontWeight, value);
    }
    
    private FontStyle _fontStyle = FontStyle.Normal;

    public FontStyle FontStyle
    {
        get => _fontStyle;
        set => this.RaiseAndSetIfChanged(ref _fontStyle, value);
    }
    
    private bool _isBold = false;

    public bool IsBold
    {
        get => _isBold;
        set => this.RaiseAndSetIfChanged(ref _isBold, value);
    }
    
    private bool _isItalic = false;

    public bool IsItalic
    {
        get => _isItalic;
        set => this.RaiseAndSetIfChanged(ref _isItalic, value);
    }
    
    private bool _isUnderline = false;

    public bool IsUnderline
    {
        get => _isUnderline;
        set => this.RaiseAndSetIfChanged(ref _isUnderline, value);
    }
    
    private Color _textColor = Colors.Black;

    public Color TextColor
    {
        get => _textColor;
        set => this.RaiseAndSetIfChanged(ref _textColor, value);
    }
    
    private Color _backgroundColor = Colors.Transparent;

    public Color BackgroundColor
    {
        get => _backgroundColor;
        set => this.RaiseAndSetIfChanged(ref _backgroundColor, value);
    }

    public TextFormattingModel() { }

    public TextFormattingModel(FontFamily fontFamily, uint fontSize, FontWeight fontWeight, FontStyle fontStyle,
        bool isBold, bool isItalic, Color textColor, Color backgroundColor)
    {
        FontFamily = fontFamily;
        FontSize = fontSize;
        FontWeight = fontWeight;
        FontStyle = fontStyle;
        IsBold = isBold;
        IsItalic = isItalic;
        TextColor = textColor;
        BackgroundColor = backgroundColor;
    }
}