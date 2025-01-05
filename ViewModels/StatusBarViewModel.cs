using GetStartedApp.Models;

namespace GetStartedApp.ViewModels;

public class StatusBarViewModel
{
    private readonly TextFormattingModel _textFormatting;

    public StatusBarViewModel(TextFormattingModel textFormatting)
    {
        _textFormatting = textFormatting;
    }
}