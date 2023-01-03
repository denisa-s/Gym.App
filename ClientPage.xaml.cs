namespace Proiect1;
using Proiect1.Models;
public partial class ClientPage : ContentPage
{
	public ClientPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ClientInfo)BindingContext;
        await App.Database.SaveClientInfoAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (ClientInfo)BindingContext;
        await App.Database.DeleteClientInfoAsync(slist);
        await Navigation.PopAsync();
    }
}