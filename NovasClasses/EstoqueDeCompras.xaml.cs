using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class EstoqueDeCompras : ContentPage
    {
        public EstoqueDeCompras()
        {
            InitializeComponent();

            // Exemplo de criação de botões programaticamente
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var button = new Button { Text = $"Item {i},{j}" };
                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);
                    button.Clicked += (sender, args) =>
                    {
                        MeusPopup.IsVisible = true;
                    };
                    SucoDeAbacate.Children.Add(button);
                }
            }
        }

        private void LevarParaConfeccao(object sender, EventArgs e)
        {
            // Lógica para levar o produto para a área de confecção
            MeusPopup.IsVisible = false;
            // ...
        }

        private void Descartar(object sender, EventArgs e)
        {
            // Lógica para descartar o produto
            MeusPopup.IsVisible = false;
            // ...
        }
    }
}