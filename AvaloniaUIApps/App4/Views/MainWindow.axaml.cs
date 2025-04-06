using System;
using Avalonia.Controls;

namespace getStartedApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public  class   Candidato
    {
        public string   Nome { get; set; } = "";
        public int      notaEscrita { get; set; }
        public int      notaOral { get; set; }
        public int      notaFisica { get; set; }
    }

    private void    Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        try
        {
            nomeGrid.Text = textboxName.Text;
            provaEscritaGrid.Text = textboxNE.Text;
            provaOralGrid.Text = textboxNO.Text;
            provaFisicaGrid.Text = textboxNF.Text;
        }
        catch (Exception)
        {
            nomeGrid.Text = "Error!";
        }
    }
}