using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace LernzeitApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginPageViewModel();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        var viewModel = (LoginPageViewModel)BindingContext;
        string email = viewModel.InputEmail;
        string password = viewModel.InputPassword;
        if (true)//DEBUG CHANGE TO email.Length >= 26 && email.Contains("@lmg.schulen-lev.de") && password.Length >= 6
        {
            string salt = email.Substring(0, 4);
            SHA256 sHA256 = SHA256.Create();
            byte[] hash_bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(salt + password));
            string hash = BitConverter.ToString(hash_bytes).Replace("-", "").ToLower();
            GC.Collect();
            password = "";

            // Verbindung zu Datenbanktool aufbauen und Logindaten verifizieren

            // Navigiere zur HomePage
            await Navigation.PushAsync(new HomePage());

            // Entferne die LoginPage aus der Navigationshistorie
            Navigation.RemovePage(this);
        }
        else
        {
            viewModel.ErrorMessage = "Die eingegebenen Daten sind nicht korrekt!";
        }
    }


}