using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class ResumoEvento : ContentPage
{
    public ResumoEvento(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }

    private void OnVoltarClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}