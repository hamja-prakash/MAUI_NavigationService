using MAUI_NavigationServiceDemo.ViewModels;

namespace MAUI_NavigationServiceDemo.Views;

public partial class StudentDetailsPage : ContentPage
{
	public StudentDetailsPage(StudentDetailsViewModel studentDetailsViewModel)
	{
		InitializeComponent();
		this.BindingContext = studentDetailsViewModel;
    }
}