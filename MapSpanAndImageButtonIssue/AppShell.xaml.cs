using MapSpanAndImageButtonIssue.Views;

namespace MapSpanAndImageButtonIssue;

public partial class AppShell : Shell
{
	public AppShell()
	{
        AppShell.InitializeRouting();
        InitializeComponent();
	}

    private static void InitializeRouting()
    {
        Routing.RegisterRoute("//map", typeof(MapView));
    }
}
