using Microsoft.Maui.Controls;

namespace CalculatorNotes;

public partial class App : Microsoft.Maui.Controls.Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Microsoft.Maui.Controls.Window CreateWindow(IActivationState? activationState = null)
    {
        return new Microsoft.Maui.Controls.Window(new MainPage());
    }
}