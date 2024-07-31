using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class Estoque : ContentPage
    {
        public ObservableCollection<Produto> ListaProdutos { get; set; }

        public Estoque()
        {
            InitializeComponent();

            // Simulando dados (substitua por sua lógica de carregamento de dados)
            ListaProdutos = new ObservableCollection<Produto>
            {
                new Produto { Imagem = "imagem1.png" },
                new Produto { Imagem = "imagem2.png" },
                new Produto { Imagem = "imagem3.png" },
            };

            BindingContext = this;
        }
    }

    public class Produto
    {
        public string Imagem { get; set; }
    }
}
