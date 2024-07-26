using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private async void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Implement your confirm logic here
            await DisplayAlert("Confirmado", "Dados do fornecedor foram confirmados", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Implement your navigation logic here
            await Navigation.PopAsync();
        }
    }
}
