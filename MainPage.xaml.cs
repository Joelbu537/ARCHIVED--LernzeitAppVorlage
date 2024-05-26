using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LernzeitApp
{
    public partial class MainPage : ContentPage
    {
        public const string VERSION = "0.4.0";

        public MainPage()
        {
            InitializeComponent();
            try
            {
                /*
                TcpClient client = new TcpClient();
                client.Connect(IPAddress.Parse("127.0.0.1"), 33533);
                NetworkStream stream = client.GetStream();
                byte[] verify_message = Encoding.UTF8.GetBytes(VERSION);
                stream.Write(verify_message, 0, verify_message.Length);
                */
                
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
            await Navigation.PushAsync(new ErrorPage(exception));
        }
    }

}
