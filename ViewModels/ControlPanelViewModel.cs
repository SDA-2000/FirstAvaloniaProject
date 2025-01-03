using GetStartedApp.Models;
using System.Collections.ObjectModel;
using ReactiveUI;
using Avalonia.Media;

namespace GetStartedApp.ViewModels
{
    public class ControlPanelViewModel : ReactiveObject
    {
        private readonly TextFormattingModel _textFormatting = new TextFormattingModel();
    
        public ControlPanelViewModel()
        {
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
            
            FontSizes = new ObservableCollection<uint>
            {
                8,
                9,
                10,
                11,
                12,
                14,
                16,
                18,
                20,
                22,
                24,
                26,
                28,
                30,
                32,
                34,
                36
            };
            SelectedFontSize = _textFormatting.FontSize;
        }

        public ObservableCollection<FontFamily> FontFamilies { get; }
        public ObservableCollection<uint> FontSizes { get; }

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
                this.RaisePropertyChanged(nameof(SelectedFontFamily));
            }
        }
    }   
}