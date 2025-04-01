using System;
using Avalonia.Controls;

namespace App3.Views;

public partial class MainWindow : Window
{
    private decimal ementaValueAdults;
    private decimal ementaValueKids;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Calcular(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        try
        {
            var qntdAdults = Convert.ToDecimal(nAdults.Text);
            var qntdKids = Convert.ToDecimal(nKids.Text);

            var resAdult = qntdAdults * ementaValueAdults;
            var resKids = qntdKids * ementaValueKids;

            Result.Text = $"Total: {resAdult + resKids}€";
        }
        catch (Exception)
        {
            Result.Text = "Invalid input!";
        }
    }

    private void ementaSelection(object? sender, SelectionChangedEventArgs e)
    {
        var selectedText = "";
        if (ementa?.SelectedItem is ComboBoxItem selectedItem)
        {
            selectedText = selectedItem.Content.ToString();
        }
        switch (selectedText)
        {
            case "Deluxe":
                ementaValueAdults = 90;
                ementaValueKids = 40;
                break;
            case "Portuguesa":
                ementaValueAdults = 100;
                ementaValueKids = 70;
                break;
            case "Prestigio":
                ementaValueAdults = 75;
                ementaValueKids = 33;
                break;
            case "Rodizio":
                ementaValueAdults = 120;
                ementaValueKids = 45;
                break;
            case "Soberba":
                ementaValueAdults = 95;
                ementaValueKids = 40;
                break;
            case "Dieta":
                ementaValueAdults = 56;
                ementaValueKids = 56;
                break;
            default:
                throw new ArgumentException("Invalid ementa selection");
        }
    }

    private void Reset(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        nAdults.Text = string.Empty;
        nKids.Text = string.Empty;

        ementa.SelectedIndex = -1;

        Result.Text = string.Empty;
    }
}