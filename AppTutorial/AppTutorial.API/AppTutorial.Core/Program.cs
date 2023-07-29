using BasketballTeam.API.Infrastructures.Extensions;
using BasketballTeam.ViewModels.AuthViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetDefaultConnectionString();

IConfiguration configuration = builder.Configuration;

var services = builder.Services;

// configure strongly typed settings object
services.Configure<AppSettings>(builder.Configuration.GetSection("ApplicationSettings"));

var appSettings = builder.Configuration.GetAppSettings();

// All exported types from Infrastructure\Extensions\ServiceCollectionExtensions.cs
services
    .AddDatabase(configuration)
    .AddIdentity()
    .AddJwtAuthentication()
    .AddApplicationServices()
    .AddSwagger()
    .AddControllers();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline. 
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}

// global cors policy
app
    .UseSwaggerUI()
    .UseRouting()
    .UseCors(x => x
        .WithOrigins("localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader())
    .UseAuthentication()
    .UseAuthorization()
    .UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    })
    .ApplyMigrations();

app.Run();