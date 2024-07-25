using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class DeletarMateriaPrima : ContentPage
    {
        public ICommand ConfirmarCommand { get; }
        public ICommand VoltarCommand { get; }

        public DeletarMateriaPrima()
        {
            InitializeComponent();

            ConfirmarCommand = new Command(OnConfirmar);
            VoltarCommand = new Command(OnVoltar);

            BindingContext = this;
        }

        private async void OnConfirmar()
        {
            // Lógica para confirmar a exclusão
            string tipo = TipoEntry.Text;
            string id = IdEntry.Text;
            string senha = SenhaEntry.Text;

            // Adicione sua lógica de confirmação aqui

            await DisplayAlert("Confirmação", "Matéria-prima deletada com sucesso!", "OK");
        }

        private async void OnVoltar()
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
