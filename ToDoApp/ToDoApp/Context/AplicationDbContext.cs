using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Context
{

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Todo> Todos { get; set; }
  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
}