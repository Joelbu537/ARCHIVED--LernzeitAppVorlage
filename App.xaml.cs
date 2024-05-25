namespace LernzeitApp
{
    public partial class App : Application
    {
        //Stunden in diesem Projekt: 6
        public const string VERSION = "0.3.1";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
