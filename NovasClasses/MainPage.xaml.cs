namespace NovasClasses;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}



	private void FogoGratis(object sender, EventArgs e)
{
		Application.Current.MainPage = new CadastroCliente();
}

	private void Juliao(object sender, EventArgs e)
{
		Application.Current.MainPage = new CadastrarCostureira();
}
	
	private void Queijo(object sender, EventArgs e)
{
		Application.Current.MainPage = new CadastrarItemEstoque();
}
}