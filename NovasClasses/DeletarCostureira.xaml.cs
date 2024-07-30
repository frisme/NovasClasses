using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class DeletarCostureira : ContentPage
    {
        public ICommand ConfirmarCommand { get; }
        public ICommand VoltarCommand { get; }

        public DeletarCostureira()
        {
            InitializeComponent();

            ConfirmarCommand = new Command(OnConfirmar);
            VoltarCommand = new Command(OnVoltar);

            BindingContext = this;
        }

        private async void OnConfirmar()
        {
            // Lógica para confirmar
            string costureira = CostureiraEntry.Text;
            string senha = SenhaEntry.Text;

            // Adicione sua lógica de confirmação aqui

            await DisplayAlert("Confirmação", "Costureira deletada com sucesso!", "OK");
        }

        private async void OnVoltar()
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
