using Proiect1.Models;

namespace Proiect1;

public partial class CategoryPage : ContentPage
{
	public CategoryPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (CategoryInfo)BindingContext;
        await App.Database.SaveCategoryInfoAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (CategoryInfo)BindingContext;
        await App.Database.DeleteCategoryInfoAsync(slist);
        await Navigation.PopAsync();
    }
}