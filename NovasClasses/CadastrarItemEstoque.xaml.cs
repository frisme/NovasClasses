using NovasClasses.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace NovasClasses;

public partial class CadastrarItemEstoque : ContentPage
{
    Item item;
    ItemControle itemControle;
    
    public CadastrarItemEstoque()
    {
        InitializeComponent();
        item = new Item();
        itemControle = new ItemControle();
    }

    void VoltarClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (item != null)
        {
            IdItem.Text        = item.Id.ToString();
            TipoEntry.Text = item.Tipo;
            QuantidadeEntry.Text = item.Quantidade;
            FornecedorEntry.Text = item.Fornecedor;
        }
    }

    private async void ApagarOsDados(object sender, EventArgs e)
    {
        TipoEntry.Text = string.Empty;
        QuantidadeEntry.Text = string.Empty;
        FornecedorEntry.Text = string.Empty;

    }

    private async void ConfirmarClicked(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos())
        {
            var item = new Item();
            if (!String.IsNullOrEmpty(TipoEntry.Text))
            {
                item.Id = int.Parse(IdItem.Text);
            }
            else
                item.Id = 0;
            item.Tipo = TipoEntry.Text;
            item.Quantidade = QuantidadeEntry.Text;
            item.Fornecedor = FornecedorEntry.Text;

            itemControle.CriarOuAtualizar(item);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }
    }
    private async Task<bool> VerificaSeDadosEstaoCorretos()
    {
        if (String.IsNullOrEmpty(TipoEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Tipo é obrigatório", "OK");
            return false;
        }
        else if (String.IsNullOrEmpty(QuantidadeEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Quantidade é obrigatório", "OK");
            return false;
        }
        else if (String.IsNullOrEmpty(FornecedorEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Fornecedor é obrigatório", "OK");
            return false;

            
        }
        else
            return true;
    }
}