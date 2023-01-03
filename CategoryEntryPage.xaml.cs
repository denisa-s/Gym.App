using Proiect1.Models;

namespace Proiect1;

public partial class CategoryEntryPage : ContentPage
{
	public CategoryEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetCategoryInfosAsync();
    }
    async void OnCategoryInfoAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryPage
        {
            BindingContext = new CategoryInfo()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new CategoryPage
            {
                BindingContext = e.SelectedItem as CategoryInfo
            });
        }
    }
}