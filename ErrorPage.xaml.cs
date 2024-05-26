namespace LernzeitApp;

public partial class ErrorPage : ContentPage
{
    public string Exception { get; set; }
	public ErrorPage(object exception)
	{
		InitializeComponent();
        Exception = exception.ToString();
        ChangeError(Exception);
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Lösche die Navigationshistorie, um ein Zurücknavigieren zur LoginPage zu verhindern
        Navigation.RemovePage(Navigation.NavigationStack[0]);
    }
    private void ChangeError(string error)
    {
        ErrorLabel.Text = error;
    }
}