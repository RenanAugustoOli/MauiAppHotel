namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Cria a janela manualmente e define a página inicial
            var window = new Window(new NavigationPage(new Views.ContratacaoHospedagem()))
            {
                Width = 400,
                Height = 600
            };

            return window;
        }
    }
}
