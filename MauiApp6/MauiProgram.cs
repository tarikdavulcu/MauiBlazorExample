using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiApp6.Data;
using System.Net.Http;
namespace MauiApp6;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();

        //builder.Services.Add("GitHub", httpClient =>
        //{
        //    httpClient.BaseAddress = new Uri("https://api.github.com/");

        //    // using Microsoft.Net.Http.Headers;
        //    // The GitHub API requires two headers.
        //    httpClient.DefaultRequestHeaders.Add(
        //        HeaderNames.Accept, "application/vnd.github.v3+json");
        //    httpClient.DefaultRequestHeaders.Add(
        //        HeaderNames.UserAgent, "HttpRequestsSample");
        //});

        return builder.Build();
	}
}
