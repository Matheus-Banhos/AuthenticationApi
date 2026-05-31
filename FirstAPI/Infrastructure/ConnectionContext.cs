using FirstAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Infrastructure;

public class ConnectionContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=SistemaLoginDb;" +
            "User Id=postgres-login;" +
            "Password=123456;"
            );
}