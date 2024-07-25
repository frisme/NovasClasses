using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para cadastro
            string nome = NomeEntry.Text;
            string email = EmailEntry.Text;
            string endereco = EnderecoEntry.Text;
            string senha = SenhaEntry.Text;
            string confirmarSenha = ConfirmarSenhaEntry.Text;

            if (senha == confirmarSenha)
            {
                // Executar lógica de cadastro, por exemplo, enviar dados para um servidor
                await DisplayAlert("Sucesso", "Cadastro realizado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "As senhas não coincidem", "OK");
            }
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para voltar
            await Navigation.PopAsync();
        }
    }
}