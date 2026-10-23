using Microsoft.EntityFrameworkCore;

namespace Tienda Sergio;

public class AppDbContext : DbContext
{
    public Dbset <Producto> Productos {get ; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectingSting = "Server=localhost;Database=Sergio;User=root;Password=tupassd;";
        Mysql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}