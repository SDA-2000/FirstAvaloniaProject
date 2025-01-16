using GetStartedApp.Models;
using ReactiveUI;
using Avalonia.Media;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GetStartedApp.Views;

namespace GetStartedApp.ViewModels
{
    public class ControlPanelViewModel : ReactiveObject
    {
        private readonly TextFormattingModel _textFormatting;
        private readonly ColorPickerViewModel _highlightColorPicker;
        
        public ControlPanelViewModel(TextFormattingModel textFormatting)
        {
            _textFormatting = textFormatting;
            var highlightColorIconViewModel = new HighlightColorIconViewModel(_textFormatting);
            
            FontSizeDatalist = new FontSizeDatalistViewModel(_textFormatting);
            _highlightColorPicker = new ColorPickerViewModel
            (
                new HighlightColorIconView(highlightColorIconViewModel),
                highlightColorIconViewModel
            );
            // TextColorPicker = new ColorPickerViewModel(new TextColorIconView());
            
            FontFamilies = new ObservableCollection<FontFamily>
            {
                new FontFamily("Calibri"),
                new FontFamily("Arial"),
                new FontFamily("Times New Roman"),
                new FontFamily("Cambria"),
                new FontFamily("Verdana"),
                new FontFamily("Tahoma"),
                new FontFamily("Consolas")
            };
            SelectedFontFamily = _textFormatting.FontFamily;
            
            IsBold = _textFormatting.IsBold;
            
            ReduceFontSize = ReactiveCommand.Create(() =>
            {
                if (_textFormatting.FontSize <= 1) return;
                _textFormatting.FontSize--;
                FontSizeDatalist.SearchText = _textFormatting.FontSize.ToString();
            });
            IncreaseFontSize = ReactiveCommand.Create(() =>
            {
                if (_textFormatting.FontSize >= 99) return;
                _textFormatting.FontSize++;
                FontSizeDatalist.SearchText = _textFormatting.FontSize.ToString();
            });
        }
        
        public ICommand ReduceFontSize { get; }
        public ICommand IncreaseFontSize { get; }
        
        public FontSizeDatalistViewModel FontSizeDatalist { get; }
        public ColorPickerViewModel HighlightColorPicker => _highlightColorPicker;
        public ColorPickerViewModel TextColorPicker { get; }
        public ObservableCollection<FontFamily> FontFamilies { get; }

        public FontFamily? SelectedFontFamily
        {
            get => _textFormatting.FontFamily;
            set
            {
                if (value == null || value == _textFormatting.FontFamily) return;
                _textFormatting.FontFamily = value;
                this.RaisePropertyChanged(nameof(SelectedFontFamily));
            }
        }

        public bool IsBold
        {
            get => _textFormatting.IsBold;
            set
            {
                _textFormatting.IsBold = value;
                this.RaisePropertyChanged(nameof(IsBold));
            }
        }
        
        public bool IsItalic
        {
            get => _textFormatting.IsItalic;
            set
            {
                _textFormatting.IsItalic = value;
                this.RaisePropertyChanged(nameof(IsItalic));
            }
        }
        
        public bool IsUnderline
        {
            get => _textFormatting.IsUnderline;
            set
            {
                _textFormatting.IsUnderline = value;
                this.RaisePropertyChanged(nameof(IsUnderline));
            }
        }

        public TextFormattingModel TextFormatting => _textFormatting;
    }   
}