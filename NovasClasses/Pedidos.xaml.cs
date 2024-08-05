using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class Pedidos : ContentPage
    {
        public ICommand AdicionarCommand { get; }

        public Pedidos()
        {
            InitializeComponent();

            AdicionarCommand = new Command(OnAdicionar);

            BindingContext = this;
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Lógica para deletar o pedido
            Button button = sender as Button;
            Frame frame = button.Parent.Parent as Frame;
            StackLayout stack = frame.Parent as StackLayout;
            stack.Children.Remove(frame);

            DisplayAlert("Deletado", "Pedido deletado com sucesso!", "OK");
        }

        private async void OnAdicionar()
        {
            // Lógica para adicionar um novo pedido
            await DisplayAlert("Adicionar", "Novo pedido adicionado!", "OK");
        }
    }
}
