namespace Proiect1;
using Proiect1.Models;
public partial class ClientEntryPage : ContentPage
{
	public ClientEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetClientInfosAsync();
    }
    async void OnClientInfoAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientPage
        {
            BindingContext = new ClientInfo()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ClientPage
            {
                BindingContext = e.SelectedItem as ClientInfo
            });
        }
    }
}