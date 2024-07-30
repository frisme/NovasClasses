using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class CadastrarAcabamento : ContentPage
    {
        public ICommand ConfirmarCommand { get; }
        public ICommand VoltarCommand { get; }

        public CadastrarAcabamento()
        {
            InitializeComponent();

            ConfirmarCommand = new Command(OnConfirmar);
            VoltarCommand = new Command(OnVoltar);

            BindingContext = this;
        }

        private async void OnConfirmar()
        {
            // Lógica para confirmar
            string tipo = TipoEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string cor = CorEntry.Text;
            string id = IdEntry.Text;

            // Adicione sua lógica de confirmação aqui

            await DisplayAlert("Confirmação", "Acabamento cadastrado com sucesso!", "OK");
        }

        private async void OnVoltar()
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
