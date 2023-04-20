using CommunityToolkit.Mvvm.Input;
using MAUI_NavigationServiceDemo.Models;
using MAUI_NavigationServiceDemo.Services;
using MAUI_NavigationServiceDemo.Views;
using System.Collections.ObjectModel;

namespace MAUI_NavigationServiceDemo.ViewModels
{
    public partial class StudentListViewModel : BaseviewModel
    {
        public int Add = 0;
        public ObservableCollection<Student> StudentList { get; set; } = new ObservableCollection<Student>();

        public StudentListViewModel(INavigationService navigationService) : base(navigationService)
        {
            BindStudentListData();
        }

        public StudentListViewModel()
        {

        }

        public void BindStudentListData()
        {
            StudentList.Add(new Student
            {
                Id = 1,
                Name = "Rahul Raj",
                Email = "rahul321@gmail.com",
            });

            StudentList.Add(new Student
            {
                Id = 1,
                Name = "Michal Warne",
                Email = "warne54@gmail.com",
            });

            StudentList.Add(new Student
            {
                Id = 1,
                Name = "Pankaj Patel",
                Email = "pankajpatel76@gmail.com",
            });

            StudentList.Add(new Student
            {
                Id = 1,
                Name = "Hamja Patel",
                Email = "hamja1156@gmail.com",
            });

            StudentList.Add(new Student
            {
                Id = 1,
                Name = "Kishan Rathod",
                Email = "kishan6756@gmail.com",
            });
        }

        [RelayCommand]
        public void SelectStudent(Student mStudent)
        {
            NavigationService.NavigationToAsync(nameof(StudentDetailsPage), new Dictionary<string, object> { { "StudentDetails", mStudent } });
        }

        
        [RelayCommand]
        public void RefreshStudent()
        {
            Add++;
            StudentList.Add(new Student
            {
                Id = 1,
                Name = $"Mahesh{Add} Patel",
                Email = "mahesh33354@gmail.com",
            });
        }
    }
}
