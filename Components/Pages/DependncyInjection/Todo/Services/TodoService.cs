using BlazorApp1.Components.Pages.DependncyInjection.Todo.Model;

namespace BlazorApp1.Components.Pages.DependncyInjection.Todo.Services
{
    public class TodoService : ITodoService
    {
		List<TodoModel> TaskList = new List<TodoModel>();

		public List<TodoModel> AddToTask( string taskContent)
        {
			TaskList.Add(new TodoModel{
				Id = Guid.NewGuid(),
				Content = taskContent
			});
			return TaskList;
		}
		public List<TodoModel> Tasks { get; set; } = new();

	}
}
