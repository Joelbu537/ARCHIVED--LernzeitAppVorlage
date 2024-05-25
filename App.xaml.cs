namespace LernzeitApp
{
    public partial class App : Application
    {
        public static string Version = "0.3.1";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
