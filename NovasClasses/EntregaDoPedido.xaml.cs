using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class EntregaDoPedido : ContentPage
    {
        public ICommand ConfirmarCommand { get; }
        public ICommand VoltarCommand { get; }

        public EntregaDoPedido()
        {
            InitializeComponent();

            ConfirmarCommand = new Command(OnConfirmar);
            VoltarCommand = new Command(OnVoltar);

            BindingContext = this;
        }

        private async void OnConfirmar()
        {
            // Lógica para confirmar
            string produtoPedido = ProdutoPedidoEntry.Text;
            string endereco = EnderecoEntry.Text;
            string numeroEndereco = NumeroEnderecoEntry.Text;
            string nomeUsuario = NomeUsuarioEntry.Text;

            // Adicione sua lógica de confirmação aqui

            await DisplayAlert("Confirmação", "Pedido registrado com sucesso!", "OK");
        }

        private async void OnVoltar()
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
