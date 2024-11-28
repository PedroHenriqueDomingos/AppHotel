
using AppHotel.Models;
namespace AppHotel
{
    public partial class App : Application
    {

        public List<Quartos> lista_quartos = new List<Quartos>();
        {
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca - 55.0
            },
            new Quarto()
            {
                Descricao = "Suite Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca - 55.0
            },
            new Quarto()
            {
                Descricao = "Suite Single",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca - 55.0

            },
            new Quarto()
            {
                Descricao = "Suite Crise",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca - 55.0
            },

        }


    public App()
         {
                InitializeComponent();

                MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
         }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;
            return window;
        }

    }
}
