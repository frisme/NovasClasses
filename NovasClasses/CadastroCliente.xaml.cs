using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace NovasClasses;

public partial class CadastroCliente : ContentPage
{
    Cliente cliente;
    ClienteControle clienteControle;
    
    public CadastroCliente()
    {
        InitializeComponent();
        cliente = new Cliente();
        clienteControle = new ClienteControle();
    }

    void VoltarClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (cliente != null)
        {
            IdLabel.Text        = cliente.Id.ToString();
            NomeEntry.Text = cliente.Nome;
            EmailEntry.Text = cliente.Email;
            EnderecoEntry.Text = cliente.Endereco;
            SenhaEntry.Text = cliente.Senha;
            ConfirmarSenhaEntry.Text = cliente.ConfirmarSenha;
        }
    }

    private async void OnApagarDadosClicked(object sender, EventArgs e)
    {
        NomeEntry.Text = string.Empty;
        EmailEntry.Text = string.Empty;
        EnderecoEntry.Text = string.Empty;
        SenhaEntry.Text = string.Empty;
        ConfirmarSenhaEntry.Text = string.Empty;

    }

    private async void OnSalvarDadosClicked(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos())
        {
            var cliente = new Cliente();
            if (!String.IsNullOrEmpty(NomeEntry.Text))
            {
                cliente.Id = int.Parse(IdLabel.Text);
            }
            else
                cliente.Id = 0;
            cliente.Nome = NomeEntry.Text;
            cliente.Email = EmailEntry.Text;
            cliente.Endereco = EnderecoEntry.Text;
            cliente.Senha = SenhaEntry.Text;

            clienteControle.CriarOuAtualizar(cliente);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }
    }
    private async Task<bool> VerificaSeDadosEstaoCorretos()
    {
        if (String.IsNullOrEmpty(NomeEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
            return false;
        }
        else if (String.IsNullOrEmpty(EmailEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
            return false;
        }
        else if (String.IsNullOrEmpty(EnderecoEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
            return false;

            
        }
        else
            return true;
    }
}