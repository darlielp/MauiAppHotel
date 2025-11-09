using System.Threading.Tasks;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        // valida o date picker do checkin
        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        // valida o date picker do checkout
        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
	}

    // Aciona a tela de sobre ao clicar no botao
    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Sobre());
        } catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    // Aciona a tela de hospedagem ao clicar em avancar
    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new HospedagemContratada());
        } catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
        
    }
    // Impede que seja seleciona uma data anterior a data do check-in
    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionado_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionado_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionado_checkin.AddMonths(6);
    }
}