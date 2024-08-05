using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class ApagarPedido : ContentPage
    {
        public ApagarPedido()
        {
            InitializeComponent();
        }

        private void OnSimClicked(object sender, EventArgs e)
        {
            // Logic for confirming the deletion of the order
            DisplayAlert("Confirmar", "O pedido foi apagado.", "OK");
            // Navigate to another page or perform any other necessary action
        }

        private void OnNaoClicked(object sender, EventArgs e)
        {
            // Logic for canceling the deletion of the order
            Navigation.PopAsync();
        }
    }
}
