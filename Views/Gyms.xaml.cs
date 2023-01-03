using Proiect1.Models;
namespace Proiect1.Views;

public partial class Gyms : ContentPage
{
	public Gyms()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (GymInfo)BindingContext;
        await App.Database.SaveGymInfoAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (GymInfo)BindingContext;
        await App.Database.DeleteGymInfoAsync(slist);
        await Navigation.PopAsync();
    }
}