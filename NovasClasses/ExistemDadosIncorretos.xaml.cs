using Microsoft.Maui.Controls;

namespace NovasClasses
{
    public partial class ExistemDadosIncorretos : ContentPage
    {
        public ExistemDadosIncorretos()
        {
            InitializeComponent();
        }

        private async void OnOkClicked(object sender, EventArgs e)
        {
            // Implement your navigation logic here
            await Navigation.PopAsync();
        }
    }
}
