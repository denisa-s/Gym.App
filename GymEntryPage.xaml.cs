using Proiect1.Models;
using Proiect1.Views;

namespace Proiect1;

public partial class GymEntryPage : ContentPage
{
	public GymEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetGymInfosAsync();
    }
    async void OnGymInfoAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GymPage
        {
            BindingContext = new GymInfo()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new GymPage
            {
                BindingContext = e.SelectedItem as GymInfo
            });
        }
    }
}