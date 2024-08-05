using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class Embalagem : ContentPage
    {
        public Embalagem()
        {
            InitializeComponent();

            // Assuming you have a ViewModel to handle data and commands
            BindingContext = new EmbalagemViewModel();
        }
    }

    public class EmbalagemViewModel : BindableObject
    {
        private string _numeroCamisa;
        public string NumeroCamisa
        {
            get => _numeroCamisa;
            set
            {
                if (_numeroCamisa != value)
                {
                    _numeroCamisa = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _usuarioNome;
        public string UsuarioNome
        {
            get => _usuarioNome;
            set
            {
                if (_usuarioNome != value)
                {
                    _usuarioNome = value;
                    OnPropertyChanged();
                }
            }
        }

        public Command ConfirmarCommand { get; }
        public Command VoltarCommand { get; }
        public Command ProximoCommand { get; }

        public EmbalagemViewModel()
        {
            ConfirmarCommand = new Command(OnConfirmar);
            VoltarCommand = new Command(OnVoltar);
            ProximoCommand = new Command(OnProximo);

            // Simulando dados do usuário (substituir por lógica real)
            UsuarioNome = "Usuário Logado";
        }

        private async void OnConfirmar()
        {
            // Lógica para confirmar a embalagem
            // Exemplo: Enviar o número da camisa para um serviço
            await Application.Current.MainPage.DisplayAlert("Confirmado", $"Camisa número {NumeroCamisa} enviada para embalagem.", "OK");
        }

        private async void OnVoltar()
        {
            // Lógica para voltar à página anterior
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private async void OnProximo()
        {
            // Lógica para navegar para a próxima página
            await Application.Current.MainPage.Navigation.PushAsync(new EntregaDoPedido()); // Substituir por nome da próxima página
        }
    }
}
