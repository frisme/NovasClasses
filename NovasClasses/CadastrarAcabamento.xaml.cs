using NovasClasses.Modelos;
using Microsoft.Maui.Controls;
using System;

namespace NovasClasses;

public partial class CadastrarAcabamento : ContentPage
{
    Acabamento acabamento;
    AcabamentoControle acabamentoControle;
    
    public CadastrarAcabamento()
    {
        InitializeComponent();
        acabamento = new Acabamento();
        acabamentoControle = new AcabamentoControle();
    }

    void BAACK(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (acabamento != null)
        {
            IdEntry.Text        = acabamento.Id.ToString();
            TipoEntry.Text = acabamento.Tipo;
            QuantidadeEntry.Text = acabamento.Quantidade;
            CorEntry.Text = acabamento.Cor;
        }
    }

    private async void DELETETHIS(object sender, EventArgs e)
    {
        TipoEntry.Text = string.Empty;
        QuantidadeEntry.Text = string.Empty;
        CorEntry.Text = string.Empty;

    }

    private async void CLICKHERE(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos())
        {
            var acabamento = new Acabamento();
            if (!String.IsNullOrEmpty(TipoEntry.Text))
            {
                acabamento.Id = int.Parse(IdEntry.Text);
            }
            else
                acabamento.Id = 0;
            acabamento.Tipo = TipoEntry.Text;
            acabamento.Quantidade = QuantidadeEntry.Text;
            acabamento.Cor = CorEntry.Text;

            acabamentoControle.CriarOuAtualizar(acabamento);

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
        else if (String.IsNullOrEmpty(CorEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Cor é obrigatório", "OK");
            return false;

            
        }
        else
            return true;
    }
}