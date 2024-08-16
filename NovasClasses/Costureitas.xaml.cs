using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class Costureiras : ContentPage
    {
        public ICommand EditarTipoCommand { get; }
        public ICommand EditarQuantidadeCommand { get; }
        public ICommand EditarFornecedorCommand { get; }
        public ICommand EditarIdCommand { get; }
        public ICommand ConfirmarCommand { get; }
        public ICommand VoltarCommand { get; }

        public Costureiras()
        {
            InitializeComponent();

            EditarTipoCommand = new Command(OnEditarTipo);
            EditarQuantidadeCommand = new Command(OnEditarQuantidade);
            EditarFornecedorCommand = new Command(OnEditarFornecedor);
            EditarIdCommand = new Command(OnEditarId);
            ConfirmarCommand = new Command(OnConfirmar);
            VoltarCommand = new Command(OnVoltar);

            BindingContext = this;
        }

        private void OnEditarTipo()
        {
            // Lógica para editar o tipo
        }

        private void OnEditarQuantidade()
        {
            // Lógica para editar a quantidade
        }

        private void OnEditarFornecedor()
        {
            // Lógica para editar o fornecedor
        }

        private void OnEditarId()
        {
            // Lógica para editar o ID
        }

        private async void OnConfirmar()
        {
            // Lógica para confirmar
            string tipo = TipoEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string fornecedor = FornecedorEntry.Text;
            string id = IdEntry.Text;

            // Adicione sua lógica de confirmação aqui

            await DisplayAlert("Confirmação", "Informações confirmadas com sucesso!", "OK");
        }

        private async void OnVoltar()
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
