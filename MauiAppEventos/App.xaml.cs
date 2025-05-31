namespace MauiAppEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new NavigationPage(new Views.CadastroEvento()));
            return new Window(new NavigationPage(new Views.CadastroEvento()));
        }
    }
}