using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class ConfirmacaoCompra : ContentPage
    {
        public ConfirmacaoCompra()
        {
            InitializeComponent();
        }

        private void OnSimClicked(object sender, EventArgs e)
        {
            // Logic for confirming the purchase
            DisplayAlert("Confirmar", "A compra foi realizada com sucesso.", "OK");
            // Navigate to another page or perform any other necessary action
        }

        private void OnNaoClicked(object sender, EventArgs e)
        {
            // Logic for canceling the purchase
            Navigation.PopAsync();
        }
    }
}
