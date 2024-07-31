using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class EstoqueDeCompras : ContentPage
    {
        public EstoqueDeCompras()
        {
            InitializeComponent();

            // Criar os botões dos quadrados
            // ...

            // Exemplo de como mostrar o popup quando um quadrado é clicado
            foreach (var child in Grid.Children)
            {
                if (child is Button button)
                {
                    button.Clicked += (sender, args) =>
                    {
                        myPopup.IsOpen = true;
                    };
                }
            }
        }

        private void LevarParaConfeccao(object sender, EventArgs e)
        {
            // Lógica para levar o produto para a área de confecção
            myPopup.IsOpen = false;
            // ...
        }

        private void Descartar(object sender, EventArgs e)
        {
            // Lógica para descartar o produto
            myPopup.IsOpen = false;
            // ...
        }
    }
}
