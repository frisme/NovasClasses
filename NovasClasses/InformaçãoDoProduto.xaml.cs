using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class InformacoesProduto : ContentPage
    {
        public InformacoesProduto()
        {
            InitializeComponent();
        }

        private void OnComprarClicked(object sender, EventArgs e)
        {
            // Logic for buying the product
            string marca = MarcaEntry.Text;
            string tamanho = TamanhoEntry.Text;
            string preco = PrecoEntry.Text;
            string numeroProduto = NumeroProdutoEntry.Text;

            DisplayAlert("Comprar", $"Marca: {marca}\nTamanho: {tamanho}\nPreço: {preco}\nNº do Produto: {numeroProduto}", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Logic for canceling the action
            Navigation.PopAsync();
        }
    }
}
