namespace BasketballTeam.API.Infrastructures.Extensions;

using Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

public static class ApplicationBuilderExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        var dbContext = serviceScope.ServiceProvider.GetService<BasketballTeamDbContext>();

        dbContext.Database.Migrate();
    }

    public static IApplicationBuilder UseSwaggerUI(this IApplicationBuilder app)
    {
        app.UseSwagger();

        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "RidersBook API");
            options.RoutePrefix = string.Empty;
        });

        return app;
    }
}