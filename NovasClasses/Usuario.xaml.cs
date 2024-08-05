using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class Usuario : ContentPage
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private async void VoltarButton_Clicked(object sender, EventArgs e)
        {
            // Lógica para o botão VOLTAR
            await Navigation.PopAsync();
        }

        private async void ProximoButton_Clicked(object sender, EventArgs e)
        {
            // Lógica para o botão PRÓXIMO
            await Navigation.PushAsync(new Compras()); // Substitua "ProximaPagina" pelo nome da próxima página
        }
    }
}
