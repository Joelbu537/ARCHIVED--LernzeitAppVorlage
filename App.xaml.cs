namespace LernzeitApp
{
    public partial class App : Application
    {
        //Stunden in diesem Projekt: 7
        public const string VERSION = "0.3.2";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
