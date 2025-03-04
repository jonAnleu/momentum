using Microsoft.EntityFrameworkCore;

public class TodoService
{
    private readonly MomentumDbContext _db;

    public TodoService(MomentumDbContext db)
    {
        _db = db;
    }

    public async Task<List<TodoItem>> GetTodosAsync()
    {
        return await _db.Todos.ToListAsync();  // Fetch all to-do items
    }

    public async Task AddTodoAsync(TodoItem todo)
    {
        _db.Todos.Add(todo);  // Add a new to-do item
        await _db.SaveChangesAsync();  // Save changes to the database
    }

    public async Task RemoveTodoAsync(TodoItem todo)
    {
        _db.Todos.Remove(todo);  // Remove the to-do item
        await _db.SaveChangesAsync();  // Save changes to the database
    }
}
