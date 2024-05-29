using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LernzeitApp
{
    public partial class MainPage : ContentPage
    {
        //Stunden in diesem Projekt: 15

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
                //SUPPORTTICKETS SENDED!
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
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            string[] logindata = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"\", "login.dat"));
            if (logindata.Length == 2)
            {
                string username = logindata[0];
                string hashpwd = logindata[1];
                int status = Verify(username, hashpwd);
                if (status != 1 && status != 2)
                {
                    File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"\", "login.dat"), "");
                }
                if (status == 1)
                {
                    await Navigation.PushAsync(new HomePage());
                }
                else if (status == 2)
                {
                    await Navigation.PushAsync(new TeacherHomePage());
                }
                else if (status == -1)
                {
                    Exception ex = new Exception("Data integrity compromised!");
                    TriggerError(ex);
                }
            }
        }
        int Verify(string username, string password)
        {
            try
            {
                TcpClient client = new TcpClient();
                AppInfo appInfo = new AppInfo();
                client.Connect(appInfo.ServerIP, appInfo.ServerPort);
                NetworkStream stream = client.GetStream();
                byte[] verify_message = Encoding.UTF8.GetBytes($"login\r\n{username}\r\n{password}");
                stream.Write(verify_message, 0, verify_message.Length);
                //Read
                byte[] buffer = new byte[1024];
                int bytesread = 0;
                while ((bytesread = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string response_encoded = Encoding.UTF8.GetString(buffer);
                    string[] content = response_encoded.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    if (content[0] == "login")
                    {
                        if (content[1] == "0")
                        {
                            return 0;
                        }
                        else if (content[1] == "1")
                        {
                            return 1;
                        }
                        else if (content[1] == "2")
                        {
                            return 2;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        return -1;
                    }

                }

            }
            catch (Exception ex)
            {
                TriggerError(ex);
                return -1;
            }
            return -1;
        }
    }
    public class AppInfo
    {
        public string Version { get; set; }
        public string ServerIP { get; set; }
        public int ServerPort { get; set; }
        public AppInfo()
        {
            Version = "0.5.7";
            ServerIP = "127.0.0.1";
            ServerPort = 33533;
        }
    }
}
