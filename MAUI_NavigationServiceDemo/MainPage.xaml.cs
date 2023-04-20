using MAUI_NavigationServiceDemo.ViewModels;

namespace MAUI_NavigationServiceDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainPageViewModel mainPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = mainPageViewModel;
	}

}

