using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class Analize : ContentPage
    {
        public Analize()
        {
            InitializeComponent();
        }

        private void OnAdicionarAoEstoqueClicked(object sender, EventArgs e)
        {
            // Add your logic for adding to stock here
            DisplayAlert("Adicionar", "Produto adicionado ao estoque", "OK");
        }

        private void OnDescartarDoEstoqueClicked(object sender, EventArgs e)
        {
            // Add your logic for discarding from stock here
            DisplayAlert("Descartar", "Produto descartado do estoque", "OK");
        }
    }
}
