﻿using NovasClasses;

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

    private void Carne(object sender, EventArgs e)
{
		Application.Current.MainPage = new CadastrarMateriaPrima();
}
	private void SergioPasteis(object sender, EventArgs e)
{
		Application.Current.MainPage = new CadastroFornecedor();
}
	private void LanchesDoBob(object sender, EventArgs e)
{
		Application.Current.MainPage = new CadastroFornecedor();
}
	private void MasterAIDS(object sender, EventArgs e)
{
		Application.Current.MainPage = new ListaClientesPage();
}
	private void Doouglass(object sender, EventArgs e)
{
		Application.Current.MainPage = new ListaClientesPage();
}
}