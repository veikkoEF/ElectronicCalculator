namespace ElectronicCalculator;

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
			});

		builder.Services.AddSingleton<HomeViewModel>();

		builder.Services.AddSingleton<HomePage>();

		builder.Services.AddSingleton<VoltageViewModel>();

		builder.Services.AddSingleton<VoltagePage>();

		builder.Services.AddSingleton<ConstantViewModel>();

		builder.Services.AddSingleton<ConstantPage>();

		builder.Services.AddSingleton<InfoViewModel>();

		builder.Services.AddSingleton<InfoPage>();

		return builder.Build();
	}
}
