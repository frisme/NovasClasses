using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class MateriaPrima : ContentPage
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }

        private async void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Lógica para confirmação
            string tipo = TipoEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string fornecedor = FornecedorEntry.Text;
            string id = IdEntry.Text;

            // Executar lógica de confirmação, por exemplo, enviar dados para um servidor
            await DisplayAlert("Sucesso", "Dados confirmados com sucesso!", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para voltar
            await Navigation.PopAsync();
        }
    }
}