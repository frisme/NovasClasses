using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class DeletarFornecedor : ContentPage
    {
        public DeletarFornecedor()
        {
            InitializeComponent();
        }

        private async void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Implement your delete logic here
            await DisplayAlert("Confirmado", "Fornecedor foi deletado", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Implement your navigation logic here
            await Navigation.PopAsync();
        }
    }
}
