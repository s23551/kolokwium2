using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using Task = WebApplication1.Models.Task;

namespace WebApplication1.Context;

public class ApbdContext : DbContext
{
    public ApbdContext()
    {
        
    }

    public ApbdContext(DbContextOptions<ApbdContext> options) : base(options)
    {
        
    }
    
    public DbSet<Access> Accesses { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Access>().HasKey(
            o => new { o.IdUser, o.IdProject });
        base.OnModelCreating(modelBuilder);
    }
}