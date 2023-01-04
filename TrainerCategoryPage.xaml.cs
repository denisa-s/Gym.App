using Proiect1.Models;

namespace Proiect1;

public partial class TrainerCategoryPage : ContentPage
{
	public TrainerCategoryPage()
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
    /*async void OnChooseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryPage((TrainerInfo)this.BindingContext)
        {
            BindingContext = new CategoryInfo()
        });
    }
    /*protected override async void OnAppearing()
    {
        base.OnAppearing();
        var shopl = (TrainerInfo)BindingContext;
        listView.ItemsSource = await App.Database.GetTrainerInfosAsync(shopl.ID);
    }*/
}