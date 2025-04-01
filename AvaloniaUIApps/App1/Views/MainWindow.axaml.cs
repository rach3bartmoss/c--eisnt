using System;
using Avalonia.Controls;

namespace App1.Views;

public partial class MainWindow : Window
{

    private decimal TaxRate;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnCalculate(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        try
        {
            var salary = Convert.ToDecimal(SalaryInput.Text);
            var da = Convert.ToDecimal(DAInput.Text);

            var netSalary = salary - (salary * TaxRate / 100);
            netSalary += da * 28;
            Result.Text = $"€{netSalary:F2}";
        }
        catch (Exception)
        {
            Result.Text = "Invalid input!";
        }
    }

    private void IRSTaxSelection(object? sender, SelectionChangedEventArgs e)
    {
        if (TaxRateComboBox?.SelectedItem is ComboBoxItem selectedItem)
        {
            var selectedText = selectedItem.Content.ToString();

            if (selectedText == "IRS Tax Rate 15%")
            {
                TaxRate = 15m;
            }
            else if (selectedText == "IRS Tax Rate 11%")
            {
                TaxRate = 11m;
            }
            else if (selectedText == "IRS Tax Rate 21%")
            {
                TaxRate = 21m;
            }
        }
        else
        {
            TaxRate = 0m;
        }
    }
}