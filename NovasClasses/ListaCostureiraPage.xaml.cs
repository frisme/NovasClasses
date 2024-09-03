using System.Collections;
using NovasClasses.Modelos;
using NovasClasses;
namespace NovasClasses;
public partial class ListaCostureiraPage : ContentPage
{
  NovasClasses.CostureiraControle costureiraControle = new NovasClasses.CostureiraControle();
  Modelos.Costureira costureira = new Modelos.Costureira();

  public ListaCostureiraPage()
	{
		InitializeComponent();
  
    ListaCostureira.ItemsSource = costureiraControle.LerTodos();
	}
    void SelecionarUmItemDaLista(object sender, SelectedItemChangedEventArgs e)
  {
    var page = new CadastrarCostureira();
    page.costureira = e.SelectedItem as Costureira;
    Application.Current.MainPage = page;
  }

  void NovaCostureiraClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastrarCostureira();
  }
}