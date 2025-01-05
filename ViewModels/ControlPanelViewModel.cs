using GetStartedApp.Models;
using ReactiveUI;
using Avalonia.Media;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace GetStartedApp.ViewModels
{
    public class ControlPanelViewModel : ReactiveObject
    {
        private readonly TextFormattingModel _textFormatting;
        
        public ControlPanelViewModel(TextFormattingModel textFormatting)
        {
            _textFormatting = textFormatting;
            FontSizeDatalist = new FontSizeDatalistViewModel(_textFormatting);
            
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
        
        public uint? SelectedFontSize
        {
            get => _textFormatting.FontSize;
            set
            {
                if (value == null || value == _textFormatting.FontSize) return;
                _textFormatting.FontSize = value.Value;
                this.RaisePropertyChanged(nameof(SelectedFontSize));
            }
        }
    }   
}