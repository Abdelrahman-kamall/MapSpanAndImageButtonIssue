using CommunityToolkit.Maui;
using MapSpanAndImageButtonIssue.Services.Navigation;
using MapSpanAndImageButtonIssue.ViewModels;
using MapSpanAndImageButtonIssue.Views;
using Microsoft.Extensions.Logging;

namespace MapSpanAndImageButtonIssue;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
            .UseMauiMaps()
            .RegisterServices()
            .RegisterViewModels()
            .RegisterViews();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    private static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<INavigationService, NavigationService>();

        return mauiAppBuilder;
    }


    private static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddScoped<ButtonsView>();
        mauiAppBuilder.Services.AddScoped<MapView>();

        return mauiAppBuilder;

    }
    private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddScoped<ButtonsViewModel>();
        mauiAppBuilder.Services.AddScoped<MapViewModel>();

        return mauiAppBuilder;

    }
}
