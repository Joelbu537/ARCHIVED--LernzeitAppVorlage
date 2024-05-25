namespace LernzeitApp;

public partial class ModulOverviewPage : ContentPage
{
	public ModulOverviewPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Lösche die Navigationshistorie, um ein Zurücknavigieren zur LoginPage zu verhindern
        Navigation.RemovePage(Navigation.NavigationStack[0]);
    }
    private async void OnZurückClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}