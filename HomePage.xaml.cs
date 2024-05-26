namespace LernzeitApp;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomePageViewModel();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Navigation.RemovePage(Navigation.NavigationStack[0]);
    }
    private async void OnEventTapped(object sender, EventArgs e)
    {
        var tappedEvent = (sender as VisualElement).BindingContext as Ereigniss;
        if (tappedEvent != null)
        {
            await Navigation.PushAsync(new ModulOverviewPage(tappedEvent));
        }
    }
}