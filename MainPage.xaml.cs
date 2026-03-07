using Microsoft.Maui.Controls;
using System;

namespace CalculatorNotes;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(CalculatorInput.Text))
        {
            CalculatorResult.Text = "Result: ";
            return;
        }

        try
        {
            var result = new System.Data.DataTable().Compute(CalculatorInput.Text, null);
            CalculatorResult.Text = "Result: " + result;
        }
        catch
        {
            CalculatorResult.Text = "Invalid input";
        }
    }
}