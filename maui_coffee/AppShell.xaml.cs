using maui_coffee.View;

namespace maui_coffee;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetailedPage), typeof(DetailedPage));
	}
}
