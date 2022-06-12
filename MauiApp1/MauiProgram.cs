using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.JSInterop;

namespace MauiApp1;

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

		return builder.Build();
	}

    [JSInvokable]
    public static async Task<string> CallMeFromJs(string call)
    {
        return call + " OK! " + DateTime.Now.ToString("HH:mm:ss");
    }
}
