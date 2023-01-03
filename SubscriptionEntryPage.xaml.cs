using Proiect1.Models;

namespace Proiect1;

public partial class SubscriptionEntryPage : ContentPage
{
	public SubscriptionEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetSubscriptionsAsync();
    }
    async void OnSubscriptionAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SubscriptionPage
        {
            BindingContext = new Subscription()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new SubscriptionPage
            {
                BindingContext = e.SelectedItem as Subscription
            });
        }
    }
}