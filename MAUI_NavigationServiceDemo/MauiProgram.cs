using MAUI_NavigationServiceDemo.Services;
using MAUI_NavigationServiceDemo.ViewModels;
using MAUI_NavigationServiceDemo.Views;
using Microsoft.Extensions.Logging;

namespace MAUI_NavigationServiceDemo;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<INavigationService, NavigationService>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<StudentListPage>();
        builder.Services.AddTransient<StudentDetailsPage>();

        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddTransient<StudentListViewModel>();
        builder.Services.AddTransient<StudentDetailsViewModel>();

        return builder.Build();
	}
}
