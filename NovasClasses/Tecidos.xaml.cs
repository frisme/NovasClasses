using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace NovasClasses
{
    public partial class Tecidos : ContentPage
    {
        public Tecidos()
        {
            InitializeComponent();

            // Configurar a grade de tecidos (exemplo com 3 linhas e 3 colunas)
            int numLinhas = 3;
            int numColunas = 3;

            // Adicionar linhas e colunas dinamicamente
            for (int i = 0; i < numLinhas; i++)
            {
                gridTecidos.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            }

            for (int j = 0; j < numColunas; j++)
            {
                gridTecidos.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            }

            // Criar os botões dos tecidos
            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    var button = new Button
                    {
                        BackgroundColor = Colors.White,
                        BorderColor = Colors.Gray,
                        BorderWidth = 2,
                        // Adicione aqui a imagem do tecido (se tiver)
                        // ImageSource = "tecido.png"
                    };

                    GalinhaDoente.Add(button, j, i);

                    // Adicione um evento de clique para cada botão (opcional)
                    button.Clicked += (sender, args) =>
                    {
                        // Lógica para quando um tecido é clicado (ex: mostrar detalhes)
                        DisplayAlert("Tecido", "Você clicou em um tecido.", "OK");
                    };
                }
            }
        }

        private void IrParaCompras(object sender, EventArgs e)
        {
            // Lógica para direcionar o usuário para a tela de compras
            // Exemplo: Navegar para outra página
            Navigation.PushAsync(new Compras()); // Substitua "ComprasPage" pelo nome da página correta
        }
    }
}
