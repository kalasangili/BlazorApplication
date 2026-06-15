using BlazorApp1.Components.Pages.DependncyInjection.Todo.Model;

namespace BlazorApp1.Components.Pages.DependncyInjection.Todo.Services
{
    public interface ITodoService
    {
		public List<TodoModel> AddToTask(string taskContent);

        public List<TodoModel> Tasks { get; set; }
    }
}
