using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class CadastrarItemEstoque : ContentPage
    {
        public CadastrarItemEstoque()
        {
            InitializeComponent();
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar item cadastrar
            string tipo = TipoEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string fornecedor = FornecedorEntry.Text;

            DisplayAlert("Confirmar", $"Tipo: {tipo}\nQuantidade: {quantidade}\nFornecedor: {fornecedor}", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão voltar
            Navigation.PopAsync();
        }
    }
}
