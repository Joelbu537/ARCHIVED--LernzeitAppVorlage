namespace LernzeitApp;

public partial class ModulOverviewPage : ContentPage
{
	public ModulOverviewPage(Ereigniss selectedEreigniss)
	{
		InitializeComponent();
        string event_name = selectedEreigniss.Name;
        string event_starttime = $"Beginn: {selectedEreigniss.StartTime}";
        string event_location = $"Ort: {selectedEreigniss.Location}";
        EventNameLabel.Text = event_name;
        EventBeginningLabel.Text = event_starttime;
        EventLocationLabel.Text = event_location;
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