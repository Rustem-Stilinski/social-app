using Microsoft.EntityFrameworkCore;

namespace SocialAppService.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    // Add your DbSet properties here
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    // Example: public DbSet<ToDo> ToDos { get; set; }
}