using Drastic.Services;
using MauiRssSample.Core.ViewModels;
using MauiRssSample.Services;
using Microsoft.Extensions.Logging;

namespace MauiRssSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder.Services
			.AddSingleton<IAppDispatcher, MauiAppDispatcher>()
			.AddSingleton<IErrorHandlerService, MauiErrorService>()
			.AddTransient<RssItemViewModel>()
			.AddTransient<FeedListViewModel>();
		
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

		return builder.Build();
	}
}
