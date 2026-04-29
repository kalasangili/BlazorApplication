using BlazorApp1.Components.Pages.DependncyInjection.Todo.Model;

namespace BlazorApp1.Components.Pages.DependncyInjection.Todo.Services
{
    public class TodoNavService
    {
        public List<TodoModel> Tasks { get; set; } = new();
    }
}
