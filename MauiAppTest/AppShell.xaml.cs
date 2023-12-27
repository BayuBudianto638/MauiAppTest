namespace MauiAppTest;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ListDetail3DetailPage), typeof(ListDetail3DetailPage));
		Routing.RegisterRoute(nameof(ListDetail2DetailPage), typeof(ListDetail2DetailPage));
		Routing.RegisterRoute(nameof(ListDetail1DetailPage), typeof(ListDetail1DetailPage));
		Routing.RegisterRoute(nameof(ListDetailDetailPage), typeof(ListDetailDetailPage));
	}
}
