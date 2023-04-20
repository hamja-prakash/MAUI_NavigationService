using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_NavigationServiceDemo.Models;
using MAUI_NavigationServiceDemo.Services;
using MAUI_NavigationServiceDemo.Views;

namespace MAUI_NavigationServiceDemo.ViewModels
{
    [QueryProperty(nameof(Student), "StudentDetails")]

    public partial class StudentDetailsViewModel : BaseviewModel
    {
        public StudentDetailsViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        [ObservableProperty]
        private Student student;

        [RelayCommand]
        public void AddStudent()
        {
            var studentListViewModel = NavigationService.GetPageViewModel<StudentListViewModel>();
            studentListViewModel?.RefreshStudentCommand.Execute(null);
            Shell.Current.Navigation.PopAsync();
        }
    }
}
