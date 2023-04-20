namespace MAUI_NavigationServiceDemo.Services
{
    public interface INavigationService
    {
        Task NavigationToAsync(string route, IDictionary<string, object> parameters = null);
        T GetPageViewModel<T>() where T : new();
    }
}
