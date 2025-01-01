using System.Collections.ObjectModel;
using ReactiveUI;
using Avalonia.Media;

namespace GetStartedApp.ViewModels
{
    public class ControlPanelViewModel : ReactiveObject
    {
        private FontFamily? _selectedFontFamily;
    
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
            SelectedFontFamily = FontFamilies[0];
        }

        public ObservableCollection<FontFamily> FontFamilies { get; }

        public FontFamily? SelectedFontFamily
        {
            get => _selectedFontFamily;
            set => this.RaiseAndSetIfChanged(ref _selectedFontFamily, value);
        }
    }   
}