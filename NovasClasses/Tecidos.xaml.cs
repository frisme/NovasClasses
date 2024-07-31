using Microsoft.Maui.Controls;

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

            gridTecidos.RowDefinitions.Add(new RowDefinition());
            gridTecidos.RowDefinitions.Add(new RowDefinition());
            gridTecidos.RowDefinitions.Add(new RowDefinition());

            gridTecidos.ColumnDefinitions.Add(new ColumnDefinition());
            gridTecidos.ColumnDefinitions.Add(new ColumnDefinition());
            gridTecidos.ColumnDefinitions.Add(new ColumnDefinition());

            // Criar os botões dos tecidos
            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    var button = new Button
                    {
                        BackgroundColor = Color.White,
                        BorderColor = Color.Gray,
                        BorderWidth = 2,
                        // Adicione aqui a imagem do tecido (se tiver)
                        // button.ImageSource = "tecido.png";
                    };
                    gridTecidos.Children.Add(button, j, i);
                    // Adicione um evento de clique para cada botão (opcional)
                    button.Clicked += (sender, args) =>
                    {
                        // Lógica para quando um tecido é clicado (ex: mostrar detalhes)
                        // ...
                    };
                }
            }
        }

        private void IrParaCompras(object sender, EventArgs e)
        {
            // Lógica para direcionar o usuário para a tela de compras
            // ...
        }
    }
}
