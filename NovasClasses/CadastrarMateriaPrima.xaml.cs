using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace NovasClasses;

public partial class CadastrarMateriaPrima : ContentPage
{
    MateriaPrima materiaprima;
        MateriaprimaControle materiaprimaControle;
    
    public CadastrarMateriaPrima()
    {
        InitializeComponent();
        materiaprima = new MateriaPrima();
        materiaprimaControle = new MateriaprimaControle();
    }

    void VoltarClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (materiaprima != null)
        {
            IdItem.Text        = materiaprima.Id.ToString();
            TipoEntry.Text = materiaprima.Tipo;
            QuantidadeEntry.Text = materiaprima.Quantidade;
            FornecedorEntry.Text = materiaprima.Fornecedor;
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
            var materiaprima = new MateriaPrima();
            if (!String.IsNullOrEmpty(TipoEntry.Text))
            {
                materiaprima.Id = int.Parse(IdItem.Text);
            }
            else
                materiaprima.Id = 0;
            materiaprima.Tipo = TipoEntry.Text;
            materiaprima.Quantidade = QuantidadeEntry.Text;
            materiaprima.Fornecedor = FornecedorEntry.Text;

            materiaprimaControle.CriarOuAtualizar(materiaprima);

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