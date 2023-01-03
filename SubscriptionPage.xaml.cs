using Proiect1.Models;

namespace Proiect1;

public partial class SubscriptionPage : ContentPage
{
	public SubscriptionPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Subscription)BindingContext;
        await App.Database.SaveSubscriptionAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Subscription)BindingContext;
        await App.Database.DeleteSubscriptionAsync(slist);
        await Navigation.PopAsync();
    }
}