namespace LernzeitApp;

public partial class ErrorPage : ContentPage
{
	public ErrorPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Lösche die Navigationshistorie, um ein Zurücknavigieren zur LoginPage zu verhindern
        Navigation.RemovePage(Navigation.NavigationStack[0]);
    }
}