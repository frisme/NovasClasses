using System.Collections;
using NovasClasses.Modelos;
using NovasClasses;
namespace NovasClasses;
public partial class ListaClientesPage : ContentPage
{
  NovasClasses.ClienteControle clienteControle = new NovasClasses.ClienteControle();
  Modelos.Cliente cliente = new Modelos.Cliente();

  public ListaClientesPage()
	{
		InitializeComponent();
  
    ListaClientes.ItemsSource = clienteControle.LerTodos();
	}
    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    var page = new CadastroCliente();
    page.cliente = e.SelectedItem as Cliente;
    Application.Current.MainPage = page;
  }

  void NovoClienteClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastroCliente();
  }
}