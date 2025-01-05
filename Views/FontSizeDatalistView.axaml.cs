using Avalonia.Controls;
using Avalonia.Input;
using System.Linq;

namespace GetStartedApp.Views;

public partial class FontSizeDatalistView : UserControl
{
    public FontSizeDatalistView()
    {
        InitializeComponent();
    }
    
    private void OnTextBoxKeyDown(object? sender, KeyEventArgs e)
    {
        var allowedKeys = new[]
        {
            Key.D0, Key.D1, Key.D2, Key.D3, Key.D4,
            Key.D5, Key.D6, Key.D7, Key.D8, Key.D9,
            Key.NumPad0, Key.NumPad1, Key.NumPad2, Key.NumPad3, Key.NumPad4,
            Key.NumPad5, Key.NumPad6, Key.NumPad7, Key.NumPad8, Key.NumPad9,
            Key.Back, Key.Delete, Key.Tab, Key.Enter, Key.Escape, Key.Left, Key.Right
        };

        if (!allowedKeys.Contains(e.Key))
        {
            e.Handled = true;
        }
    }
}