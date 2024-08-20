using LiteDBExample.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace NovasClasses;

public partial class CadastrarMateriaPrima : ContentPage
{
    MateriaPrima materiaprima;
        MateriaPrimaControle materiaprimaControle;
    
    public CadastrarMateriaPrima()
    {
        InitializeComponent();
        materiaprima = new MateriaPrima();
        materiaprimaControle = new MateriaPrimaControle();
    }

    void Sair(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (materiaprima != null)
        {
            IdMP.Text        = materiaprima.IdMP.ToString();
            TipoEntry.Text = materiaprima.TipoMP;
            QuantidadeEntry.Text = materiaprima.QuantidadeMP;
            FornecedorEntry.Text = materiaprima.FornecedorMP;
        }
    }

    private async void ApagarOsDados(object sender, EventArgs e)
    {
        TipoEntry.Text = string.Empty;
        QuantidadeEntry.Text = string.Empty;
        FornecedorEntry.Text = string.Empty;

    }

    private async void Certo(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos())
        {
            var materiaprima = new MateriaPrima();
            if (!String.IsNullOrEmpty(TipoEntry.Text))
            {
                materiaprima.IdMP = int.Parse(IdMP.Text);
            }
            else
                materiaprima.IdMP = 0;
            materiaprima.TipoMP = TipoEntry.Text;
            materiaprima.QuantidadeMP = QuantidadeEntry.Text;
            materiaprima.FornecedorMP = FornecedorEntry.Text;

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