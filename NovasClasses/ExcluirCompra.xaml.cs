using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class ExcluirCompra : ContentPage
    {
        public ExcluirCompra()
        {
            InitializeComponent();

            // Criar quadrados brancos ao iniciar
            CriarQuadradosBrancos();

            // Manipuladores de clique de botão
            JogarForaButton.Clicked += JogarForaButton_Clicked;
            ReutilizarButton.Clicked += ReutilizarButton_Clicked;
        }

        private void JogarForaButton_Clicked(object sender, EventArgs e)
        {
            // Limpar a grade interna
            DenilsonSamambaia.Clear();
        }

        private void ReutilizarButton_Clicked(object sender, EventArgs e)
        {
            // Limpar e recriar quadrados brancos
            DenilsonSamambaia.Clear();
            CriarQuadradosBrancos();
        }

        private void CriarQuadradosBrancos()
        {
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
                    DenilsonSamambaia.Add(square, col, row);
                }
            }
        }
    }
}
