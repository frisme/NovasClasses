using Microsoft.Maui.Controls;

namespace NovasClasses;

public partial class CadastroCliente : ContentPage
{
    public CadastroCliente cliente { get; set; }
    Controles.ClienteControle clienteControle = new Controles.ClienteControle();
    public CadastroCliente()
    {
        InitializeComponent();
    }

    void VoltarClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new ListaClientesPage();
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (cliente != null)
        {
            NomeEntry.Text = cliente.Nome;
            EmailEntry.Text = cliente.Email;
            EnderecoEntry.Text = cliente.Endereço;
            SenhaEntry.Text = cliente.Senha;
        }
    }

    private async void OnApagarDadosClicked(object sender, EventArgs e)
    {
        NomeEntry.Text = string.Empty;
        EmailEntry.Text = string.Empty;
        EnderecoEntry.Text = string.Empty;
        SenhaEntry.Text = string.Empty;

    }

    private async void OnSalvarDadosClicked(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos())
        {
            var cliente = new Modelos.Cliente();
            if (!String.IsNullOrEmpty(NomeEntry.Text))
                cliente.Id = int.Parse(NomeEntry.Text);
            else
                cliente.Id = 0;
            cliente.Nome = NomeEntry.Text;
            cliente.Sobrenome = SobrenomeEntry.Text;
            cliente.Telefone = TelefoneEntry.Text;

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
        else if (String.IsNullOrEmpty(SobrenomeEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
            return false;
        }
        else if (String.IsNullOrEmpty(TelefoneEntry.Text))
        {
            await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
            return false;
        }
        else
            return true;
    }
}