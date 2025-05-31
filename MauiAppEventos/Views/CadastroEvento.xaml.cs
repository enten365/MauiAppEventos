using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    public CadastroEvento()
    {
        InitializeComponent();

        
        dtpck_inicioEvento.MinimumDate = DateTime.Now;
        dtpck_inicioEvento.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month+3, DateTime.Now.Day);
        dtpck_terminoEvento.MinimumDate = dtpck_inicioEvento.Date.AddDays(1);

        
        dtpck_terminoEvento.MaximumDate = dtpck_inicioEvento.Date.AddMonths(6);
        
    }

    private async void OnFinalizarCadastroClicked(object sender, EventArgs e)
    {
        
        try
        {
            if (!double.TryParse(entry_custo.Text, out double custoPorParticipante))
            {
                await DisplayAlert("Erro", "Custo por participante inválido.", "OK");
                return;
            }

            Evento evento = new Evento
            {
                Nome = entry_nomeEvento.Text,
                NumeroParticipantes = (int)stp_participantes.Value,
                DataInicio = dtpck_inicioEvento.Date,
                DataTermino = dtpck_terminoEvento.Date,
                Local = entry_local.Text,
                CustoPorParticipante = custoPorParticipante
            };

            await Navigation.PushAsync(new ResumoEvento(evento)
            {
                BindingContext = evento
            });

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }

    }
}