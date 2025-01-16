using Avalonia.Media;
using Avalonia.Controls;
using ReactiveUI;

namespace GetStartedApp.ViewModels;
public class ColorPickerViewModel : ReactiveObject
{
    private IBrush _selectedColor;
    private readonly Control _contentView;
    private readonly ColorPickerContentViewModelBase _contentViewModel;

    public ColorPickerViewModel(Control contentView, ColorPickerContentViewModelBase contentViewModel)
    {
        _contentView = contentView;
        _contentViewModel = contentViewModel;
        _selectedColor = contentViewModel.SelectedColor;
    }

    public IBrush SelectedColor
    {
        get => _selectedColor;
        set
        {
            this.RaiseAndSetIfChanged(ref _selectedColor, value);
            _contentViewModel.SelectedColor = value;
        }
    }
    
    public Control ContentView { get => _contentView; }
    
    public ColorPickerContentViewModelBase ContentViewModel { get => _contentViewModel; }
}