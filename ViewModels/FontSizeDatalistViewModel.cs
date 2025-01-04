using ReactiveUI;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace GetStartedApp.ViewModels
{
    public class FontSizeDatalistViewModel : ReactiveObject
    {
        private string? _searchText;
        private uint? _selectedFontSize;
        private bool _isPopupOpen = false;

        public FontSizeDatalistViewModel()
        {
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
                this.RaisePropertyChanged(nameof(FilteredFontSizes));
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

        public ObservableCollection<uint> FilteredFontSizes =>
            string.IsNullOrWhiteSpace(SearchText)
                ? FontSizes
                : new ObservableCollection<uint>(
                    FontSizes.Where(size => size.ToString().Contains(SearchText))
                );
    }
}