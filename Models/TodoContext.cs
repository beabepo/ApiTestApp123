using Microsoft.EntityFrameworkCore;

namespace TodoApiTest.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        :base(options)
        {
        }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}