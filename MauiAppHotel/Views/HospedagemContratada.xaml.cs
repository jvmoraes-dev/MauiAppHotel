namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada()
        {
            InitializeComponent();
        }

        // Adicione este método para o evento Clicked do botão
        private void Button_Clicked(object sender, EventArgs e)
        {
            // Ação ao clicar no botão, como navegação ou retorno
            Navigation.PopAsync();
        }
    }
}