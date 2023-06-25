using GameLibrary.Domain;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Core.DatabaseContext;

public class GameLibraryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-BHUQKCR;Database=GameLibrary;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True", 
            b => b.MigrationsAssembly("GameLibrary.DbMigrator"));
    }
    public DbSet<Profile> Profiles { get; set; }
}
