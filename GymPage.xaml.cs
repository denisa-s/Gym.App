using Plugin.LocalNotification;
using Proiect1.Models;

namespace Proiect1;

public partial class GymPage : ContentPage
{
	public GymPage()
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
    async void OnShowMapButtonClicked(object sender, EventArgs e)
    {
        var shop = (GymInfo)BindingContext;
        var address = shop.GymAddress;
        var locations = await Geocoding.GetLocationsAsync(address);
        var options = new MapLaunchOptions {Name = "Sala mea preferata" };
        var location = locations?.FirstOrDefault();
        // var myLocation = await Geolocation.GetLocationAsync();
        var myLocation = new Location(46.7731796289, 23.6213886738);
        var distance = myLocation.CalculateDistance(location,DistanceUnits.Kilometers);
        if (distance < 4)
        {
            var request = new NotificationRequest
            {
                Title = "Ai de mers la sala in apropiere!",
                Description = address,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(1)
                }
            };
            _ = LocalNotificationCenter.Current.Show(request);
        }
        await Map.OpenAsync(location, options);
    }
}

 