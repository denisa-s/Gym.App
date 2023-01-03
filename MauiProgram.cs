using Microsoft.Maui.Controls;
using Proiect1.Views;
using Syncfusion.Maui.Core.Hosting;

namespace Proiect1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<Trainers>();
        builder.Services.AddSingleton<Clients>();
        builder.Services.AddSingleton<GymPage>();
        return builder.Build();
	}
}
