using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        // adiciona uma lista de suites disponiveis
        public List<Quarto> lista_quartos = new List<Quarto> { 
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                valorDiariaAdulto = 110.0,
                valorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suite Luxo",
                valorDiariaAdulto = 80.0,
                valorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suite Single",
                valorDiariaAdulto = 50.0,
                valorDiariaCrianca = 25.0
            },
            new Quarto()
            {
                Descricao = "Suite Crise",
                valorDiariaAdulto = 35.0,
                valorDiariaCrianca = 12.5
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        // tamanho da janela do aplicativo
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}