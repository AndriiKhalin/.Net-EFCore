namespace LB_2;

public static class TaskInitializer
{
    public static WebApplication Seed(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            using var context = scope.ServiceProvider.GetRequiredService<ComputerDbContext>();

            SeedData.Seed(context);
        }
        return app;
    }
}