using Microsoft.Maui.Controls;

namespace LernzeitApp
{
    public class LoginPageViewModel : BindableObject
    {
        private string inputEmail;
        public string InputEmail
        {
            get => inputEmail;
            set
            {
                inputEmail = value;
                OnPropertyChanged();
            }
        }

        private string inputPassword;
        public string InputPassword
        {
            get => inputPassword;
            set
            {
                inputPassword = value;
                OnPropertyChanged();
            }
        }
        private string errorMessage;
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                OnPropertyChanged();
            }
        }
    }
}