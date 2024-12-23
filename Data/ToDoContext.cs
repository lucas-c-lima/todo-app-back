
using Microsoft.EntityFrameworkCore;

public class ToDoContext : DbContext
{
    public DbSet<ToDoModel> ToDoList { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todo.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}