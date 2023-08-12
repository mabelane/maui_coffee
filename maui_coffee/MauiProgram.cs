using maui_coffee.Services;
using maui_coffee.View;
using maui_coffee.ViewModel;
using Microsoft.Extensions.Logging;
using Xe.AcrylicView;

namespace maui_coffee;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseAcrylicView()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("icomoon.ttf", "FontAwesome");
			});
        builder.Services.AddSingleton<CoffeeService>();
        builder.Services.AddSingleton<CoffeeViewModel>();
        builder.Services.AddTransient<DetailsViewModel>();
        builder.Services.AddSingleton<Home>();
        builder.Services.AddTransient<DetailedPage>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
