using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class Compras : ContentPage
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void OnAdicionarAoCarrinhoClicked(object sender, EventArgs e)
        {
            // Add your logic for adding to cart here
            DisplayAlert("Adicionar", "Produto adicionado ao carrinho", "OK");
        }
    }
}
