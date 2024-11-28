using AppHotel.Models;


namespace AppHotel.Views
{
  
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;
        public ContratacaoHospedagem()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;
            pck_quarto.ItemSource = PropriedadesApp.lista_quartos;

            try
            {
                Hospedagem h = new Hospedagem
                {
                    QuartoSelecionado = (Quartos)pck_quarto.SelectedItem,
                    QntAdultos = Convert.ToInt32(stp_adultos.Value),
                    QntCrianca = Convert.ToInt32(stp_adultos.Value)

                };

            }
            catch { }
        }
    }
}