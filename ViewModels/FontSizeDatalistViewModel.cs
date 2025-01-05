using GetStartedApp.Models;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;

namespace GetStartedApp.ViewModels
{
    public class FontSizeDatalistViewModel : ReactiveObject
    {
        private string? _searchText;
        private uint? _selectedFontSize;
        private bool _isPopupOpen = false;
        private readonly TextFormattingModel _textFormatting;

        public FontSizeDatalistViewModel(TextFormattingModel textFormatting)
        {
            _textFormatting = textFormatting;
            SearchText = textFormatting.FontSize.ToString();
            
            FontSizes = new ObservableCollection<uint>
            {
                8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 72
            };

            ClickTogglePopup = ReactiveCommand.Create(() =>
            {
                IsPopupOpen = !IsPopupOpen;
            });
        }
        
        public ICommand ClickTogglePopup { get; }

        public ObservableCollection<uint> FontSizes { get; }

        public string? SearchText
        {
            get => _searchText;
            set
            {
                this.RaiseAndSetIfChanged(ref _searchText, value);
                if (String.IsNullOrEmpty(value)) return;
                _textFormatting.FontSize = uint.Parse(value) == 0 ? 1 : uint.Parse(value);
            }
        }

        public uint? SelectedFontSize
        {
            get => _selectedFontSize;
            set => this.RaiseAndSetIfChanged(ref _selectedFontSize, value);
        }

        public bool IsPopupOpen
        {
            get => _isPopupOpen;
            set => this.RaiseAndSetIfChanged(ref _isPopupOpen, value);
        }
    }
}