using System.Net;
using System.Net.Sockets;

namespace LernzeitApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            try
            {
                TcpClient client = new TcpClient();
                //client.Connect(IPAddress.Parse("127.0.0.1"), 33533);
            }
            catch (Exception ex)
            {
                TriggerError(ex);
            }
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async void OnInfoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }
        private async void TriggerError(object exception)
        {
            await Navigation.PushAsync(new ErrorPage());
        }
    }

}
