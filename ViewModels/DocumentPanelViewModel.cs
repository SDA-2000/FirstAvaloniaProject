using GetStartedApp.Models;

namespace GetStartedApp.ViewModels;

public class DocumentPanelViewModel
{
    private readonly TextFormattingModel _textFormatting;

    public DocumentPanelViewModel(TextFormattingModel textFormatting)
    {
        _textFormatting = textFormatting;
    }
}