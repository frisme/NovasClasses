using Microsoft.Maui.Controls;
using System;

namespace NovasClasses
{
    public partial class DeletarAcabamento : ContentPage
    {
        public DeletarAcabamento()
        {
            InitializeComponent();
        }

        private void OnConfirmClicked(object sender, EventArgs e)
        {
            string acabamento = AcabamentoEntry.Text;
            string senha = SenhaEntry.Text;

            // Lógica para confirmar a exclusão do acabamento
            // Exemplo de uso:
            if (!string.IsNullOrEmpty(acabamento) && !string.IsNullOrEmpty(senha))
            {
                // Implementar a lógica de exclusão aqui
                DisplayAlert("Confirmação", "Acabamento deletado com sucesso!", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
            }
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para voltar para a página anterior
            // Exemplo de uso:
            Navigation.PopAsync();
        }
    }
}
