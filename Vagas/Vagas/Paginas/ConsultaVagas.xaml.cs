using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Vagas.Modelos;

namespace Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaVagas : ContentPage
    {
        public ConsultaVagas()
        {
            InitializeComponent();
        }

        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVagas());
        }

        public void GoMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new VagasCadastradas());
        }

        public void MaisDetalheAction(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]).CommandParameter as Vaga;

            Navigation.PushAsync(new DetalheVagas(vaga));
        }
    }
}