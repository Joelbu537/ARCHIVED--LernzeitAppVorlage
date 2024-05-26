namespace LernzeitApp;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomePageViewModel();
    }
	private async void OnBtnClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new ModulOverviewPage());
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Navigation.RemovePage(Navigation.NavigationStack[0]);
    }
}