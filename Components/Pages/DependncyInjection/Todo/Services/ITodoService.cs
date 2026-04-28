using BlazorApp1.Components.Pages.DependncyInjection.Todo.Model;

namespace BlazorApp1.Components.Pages.DependncyInjection.Todo.Services
{
    public interface ITodoService
    {
		Guid ServiceId { get; }
		public List<TodoModel> AddToTask(string taskContent);
    }
}
