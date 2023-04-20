using MAUI_NavigationServiceDemo.Views;

namespace MAUI_NavigationServiceDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(StudentListPage),typeof(StudentListPage));
		Routing.RegisterRoute(nameof(StudentDetailsPage),typeof(StudentDetailsPage));
	}
}
