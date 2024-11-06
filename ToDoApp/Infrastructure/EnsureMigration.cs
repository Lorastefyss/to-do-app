using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Infrastructure
{

    public static class EnsureMigration
    {
        public static void EnsureMigrationOfContext<T>(this IApplicationBuilder app) where T : DbContext
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<T>();
                context.Database.EnsureCreated();  // Ensures the database is created if it doesn't exist
                //context.Database.Migrate();        // Applies any pending migrations
            }
        }
    }

}
