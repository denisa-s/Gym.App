using Proiect1.Models;

namespace Proiect1;

public partial class TrainerPage : ContentPage
{
	public TrainerPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (TrainerInfo)BindingContext;
        await App.Database.SaveTrainerInfoAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (TrainerInfo)BindingContext;
        await App.Database.DeleteTrainerInfoAsync(slist);
        await Navigation.PopAsync();
    }
}