using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class ExcluirCompra : ContentPage
    {
        private Grid gridInterno;

        public ExcluirCompra()
        {
            InitializeComponent();

            gridInterno = new Grid();
            gridInterno.ColumnDefinitions.Add(new ColumnDefinition());
            gridInterno.ColumnDefinitions.Add(new ColumnDefinition());
            gridInterno.ColumnDefinitions.Add(new ColumnDefinition());
            gridInterno.RowDefinitions.Add(new RowDefinition());
            gridInterno.RowDefinitions.Add(new RowDefinition());
            gridInterno.RowDefinitions.Add(new RowDefinition());

            // Crie quadrados brancos
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    var square = new Button
                    {
                        BackgroundColor = Colors.White,
                        BorderColor = Colors.Gray,
                        BorderWidth = 1
                    };
                    gridInterno.Children.Add(square, col, row);
                }
            }

            // Adicione gridInterno à grade principal
            Grid.SetRow(gridInterno, 0);
            Content.Children.Add(gridInterno);

            // Manipuladores de clique de botão
            JogarForaButton.Clicked += JogarForaButton_Clicked;
            ReutilizarButton.Clicked += ReutilizarButton_Clicked;
        }

        private void JogarForaButton_Clicked(object sender, EventArgs e)
        {
            // Implementar lógica para botão "Jogar Fora"
            // Por exemplo, remova todos os quadrados ou limpe a gradeInterno
        }

        private void ReutilizarButton_Clicked(object sender, EventArgs e)
        {
            // Implementar lógica para botão "Reutilizar"
            // Por exemplo, restaure a grade ao seu estado original
        }
    }
}
