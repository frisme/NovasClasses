using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class PerfilFornecedor : ContentPage
    {
        public ICommand EditarNomeCommand { get; }
        public ICommand EditarEmailCommand { get; }
        public ICommand EditarEnderecoCommand { get; }
        public ICommand EditarProdutosCommand { get; }
        public ICommand EditarIdCommand { get; }
        public ICommand DeletarCommand { get; }
        public ICommand VoltarCommand { get; }

        public PerfilFornecedor()
        {
            InitializeComponent();

            EditarNomeCommand = new Command(OnEditarNome);
            EditarEmailCommand = new Command(OnEditarEmail);
            EditarEnderecoCommand = new Command(OnEditarEndereco);
            EditarProdutosCommand = new Command(OnEditarProdutos);
            EditarIdCommand = new Command(OnEditarId);
            DeletarCommand = new Command(OnDeletar);
            VoltarCommand = new Command(OnVoltar);

            BindingContext = this;
        }

        private void OnEditarNome()
        {
            // Lógica para editar o nome
        }

        private void OnEditarEmail()
        {
            // Lógica para editar o email
        }

        private void OnEditarEndereco()
        {
            // Lógica para editar o endereço
        }

        private void OnEditarProdutos()
        {
            // Lógica para editar os produtos
        }

        private void OnEditarId()
        {
            // Lógica para editar o ID
        }

        private async void OnDeletar()
        {
            // Lógica para deletar o fornecedor
            await DisplayAlert("Confirmação", "Fornecedor deletado com sucesso!", "OK");
        }

        private async void OnVoltar()
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
