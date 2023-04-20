using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_NavigationServiceDemo.Services;

namespace MAUI_NavigationServiceDemo.ViewModels
{
    public class BaseviewModel : ObservableObject
    {
        protected readonly INavigationService NavigationService;
        public BaseviewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public BaseviewModel()
        {

        }
    }
}
