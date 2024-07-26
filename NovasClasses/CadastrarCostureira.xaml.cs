using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class CadastrarCostureira : ContentPage
    {
        public CadastrarCostureira()
        {
            InitializeComponent();
        }

        private async void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Implement your confirm logic here
            await DisplayAlert("Confirmado", "Dados da costureira foram confirmados", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Implement your navigation logic here
            await Navigation.PopAsync();
        }
    }
}
