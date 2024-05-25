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

        // L�sche die Navigationshistorie, um ein Zur�cknavigieren zur LoginPage zu verhindern
        Navigation.RemovePage(Navigation.NavigationStack[0]);
    }
}