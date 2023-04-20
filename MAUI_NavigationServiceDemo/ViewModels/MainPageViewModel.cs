using CommunityToolkit.Mvvm.Input;
using MAUI_NavigationServiceDemo.Services;
using MAUI_NavigationServiceDemo.Views;

namespace MAUI_NavigationServiceDemo.ViewModels
{
    public partial class MainPageViewModel : BaseviewModel
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        [RelayCommand]
        public void NavigateToStudentList()
        {
            NavigationService.NavigationToAsync(nameof(StudentListPage));
        }
    }
}
