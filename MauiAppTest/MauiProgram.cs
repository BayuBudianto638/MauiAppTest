namespace MauiAppTest;

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

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDetailViewModel>();
		builder.Services.AddTransient<ListDetailDetailPage>();

		builder.Services.AddSingleton<ListDetailViewModel>();

		builder.Services.AddSingleton<ListDetailPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetail1DetailViewModel>();
		builder.Services.AddTransient<ListDetail1DetailPage>();

		builder.Services.AddSingleton<ListDetail1ViewModel>();

		builder.Services.AddSingleton<ListDetail1Page>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetail2DetailViewModel>();
		builder.Services.AddTransient<ListDetail2DetailPage>();

		builder.Services.AddSingleton<ListDetail2ViewModel>();

		builder.Services.AddSingleton<ListDetail2Page>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetail3DetailViewModel>();
		builder.Services.AddTransient<ListDetail3DetailPage>();

		builder.Services.AddSingleton<ListDetail3ViewModel>();

		builder.Services.AddSingleton<ListDetail3Page>();

		return builder.Build();
	}
}
