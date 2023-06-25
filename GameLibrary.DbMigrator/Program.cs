using GameLibrary.Core.DatabaseContext;

namespace GameLibrary.DbMigrator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<GameLibraryDbContext>();

            var app = builder.Build();

            app.Run();
        }
    }
}