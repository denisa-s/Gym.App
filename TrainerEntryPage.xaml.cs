using Proiect1.Models;

namespace Proiect1;

public partial class TrainerEntryPage : ContentPage
{
	public TrainerEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetTrainerInfosAsync();
    }
    async void OnTrainerInfoAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TrainerPage
        {
            BindingContext = new TrainerInfo()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new TrainerPage
            {
                BindingContext = e.SelectedItem as TrainerInfo
            });
        }
    }
}