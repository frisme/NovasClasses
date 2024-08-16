using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace NovasClasses;

public partial class CadastrarCostureira : ContentPage
{
    Costureira costureira;
    CostureiraControle costureiraControle;
    
    public CadastrarCostureira()
    {
        InitializeComponent();
        costureira = new Costureira();
        costureiraControle = new CostureiraControle();
    }

    void Voltar(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (costureira != null)
        {
            Id.Text        = costureira.Id.ToString();
            NameEntry.Text = costureira.Name;
            QuantidadeEntry.Text = costureira.Quantidade;
            FornecedorEntry.Text = costureira.Fornecedor;
        }
    }

    private async void Apagar(object sender, EventArgs e)
    {
        NameEntry.Text = string.Empty;
        QuantidadeEntry.Text = string.Empty;
        FornecedorEntry.Text = string.Empty;

    }

    private async void Confirmar(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos())
        {
            var costureira = new Costureira();
            if (!String.IsNullOrEmpty(NameEntry.Text))
            {
                costureira.Id = int.Parse(Id.Text);
            }
            else
                costureira.Id = 0;
            costureira.Name = NameEntry.Text;
            costureira.Quantidade = QuantidadeEntry.Text;
            costureira.Fornecedor = FornecedorEntry.Text;

            costureiraControle.CriarOuAtualizar(costureira);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }
    }
    private async Task<bool> VerificaSeDadosEstaoCorretos()
    {
        if (String.IsNullOrEmpty(NameEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
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
