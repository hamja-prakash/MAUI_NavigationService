using MAUI_NavigationServiceDemo.ViewModels;

namespace MAUI_NavigationServiceDemo.Views;

public partial class StudentListPage : ContentPage
{
	public StudentListPage(StudentListViewModel studentListViewModel)
	{
		InitializeComponent();
		this.BindingContext = studentListViewModel;
	}
}