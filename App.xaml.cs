namespace LernzeitApp
{
    public partial class App : Application
    {
        //Stunden in diesem Projekt: 8
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
