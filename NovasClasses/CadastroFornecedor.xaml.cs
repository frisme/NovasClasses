using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace NovasClasses;

public partial class CadastroFornecedor : ContentPage
{
    Fornecedores fornecedores;
    FornecedoresControle fornecedoresControle;
    
    public CadastroFornecedor()
    {
        InitializeComponent();
        fornecedores = new Fornecedores();
        fornecedoresControle = new FornecedoresControle();
    }

    void Volte(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (fornecedores != null)
        {
            SeuIdEntry.Text        = fornecedores.Id.ToString();
            SeuNomeEntry.Text = fornecedores.Nome;
            SeuEmailEntry.Text = fornecedores.Email;
            SeuEnderecoEntry.Text = fornecedores.Endereco;
            SeusProdutosEntry.Text = fornecedores.Produtos;
        }
    }

    private async void Deletado(object sender, EventArgs e)
    {
        SeuNomeEntry.Text = string.Empty;
        SeuEmailEntry.Text = string.Empty;
        SeuEnderecoEntry.Text = string.Empty;
        SeusProdutosEntry.Text = string.Empty;

    }

    private async void ClicouConfirma(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos())
        {
            var fornecedores = new Fornecedores();
            if (!String.IsNullOrEmpty(SeuNomeEntry.Text))
            {
                fornecedores.Id = int.Parse(SeuIdEntry.Text);
            }
            else
                fornecedores.Id = 0;
            fornecedores.Nome = SeuNomeEntry.Text;
            fornecedores.Email = SeuEmailEntry.Text;
            fornecedores.Endereco = SeuEnderecoEntry.Text;
            fornecedores.Produtos = SeusProdutosEntry.Text;

            fornecedoresControle.CriarOuAtualizar(fornecedores);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }
    }
    private async Task<bool> VerificaSeDadosEstaoCorretos()
    {
        if (String.IsNullOrEmpty(SeuNomeEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
            return false;
        }
        else if (String.IsNullOrEmpty(SeuEmailEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
            return false;
        }
        else if (String.IsNullOrEmpty(SeuEnderecoEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
            return false;
        }
        else if (String.IsNullOrEmpty(SeusProdutosEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Produtos é obrigatório", "OK");
            return false;


        }
        else
            return true;
    }
}