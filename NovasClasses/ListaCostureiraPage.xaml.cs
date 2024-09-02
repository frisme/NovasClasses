using System.Collections;
using NovasClasses.Modelos;
using NovasClasses;
using LiteDB;

namespace NovasClasses;
public partial class ListaCostureiraPage : ContentPage
{
  CostureiraControle costureiraControle;
  Costureira costureira;

  public ListaCostureiraPage()
	{
		InitializeComponent();

        costureira = new Costureira();
        costureiraControle = new CostureiraControle();
  
    ListaCostureira.ItemsSource = costureiraControle.LerTodos();
	}
    void SelecionarUmItemDaLista(object sender, SelectedItemChangedEventArgs e)
  {
        var pagina = new CadastrarCostureira();
    
        pagina.costureira = e.SelectedItem as Costureira;
       
        Application.Current.MainPage = pagina;
  }

  void NovaCostureiraClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastrarCostureira();
  }
}