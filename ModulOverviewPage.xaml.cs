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

        // L�sche die Navigationshistorie, um ein Zur�cknavigieren zur LoginPage zu verhindern
        Navigation.RemovePage(Navigation.NavigationStack[0]);
    }
    private async void OnZur�ckClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}