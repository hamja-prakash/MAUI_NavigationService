namespace MAUI_NavigationServiceDemo.Services
{
    public class NavigationService : INavigationService
    {
        public Task NavigationToAsync(string route, IDictionary<string, object> parameters)
        {
            if (parameters != null)
                return Shell.Current.GoToAsync(route, parameters);
            else
                return Shell.Current.GoToAsync(route);
        }

        public T GetPageViewModel<T>() where T : new()
        {
            var pageDetails = Shell.Current.CurrentItem.CurrentItem.Stack.Where(x => x != null &&
                                                                                x.BindingContext.GetType() == typeof(T)).FirstOrDefault();
            if(pageDetails != null)
            {
                return (T)pageDetails.BindingContext;
            }
            return default(T);
        }
    }
}
