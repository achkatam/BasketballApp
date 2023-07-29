namespace BasketballTeam.API.Infrastructures.Extensions;

using System.Text;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Services;
using Services.Contracts;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetDefaultConnectionString();

        services.AddDbContext<BasketballTeamDbContext>(options =>
            options.UseSqlServer(connectionString));

        return services;
    }

    public static IServiceCollection AddIdentity(this IServiceCollection services)
    {
        var builder = WebApplication.CreateBuilder();

        var serviceConfiguration = builder.Configuration;

        services
            .AddIdentity<User, IdentityRole>(o =>
            {
                o.Password.RequireDigit = serviceConfiguration.GetValue<bool>("Identity:Password:RequireDigit");
                o.Password.RequireLowercase = serviceConfiguration
                    .GetValue<bool>("Identity:Password:RequireLowercase");
                o.Password.RequireUppercase = serviceConfiguration
                    .GetValue<bool>("Identity:Password:RequireUppercase");
                o.Password.RequireNonAlphanumeric = serviceConfiguration
                    .GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                o.Password.RequiredLength = serviceConfiguration
                    .GetValue<int>("Identity:Password:RequiredLength");

            })
            .AddEntityFrameworkStores<BasketballTeamDbContext>();

        return services;
    }

    public static IServiceCollection AddJwtAuthentication(this IServiceCollection services)
    {
        var builder = WebApplication.CreateBuilder();

        var serviceConfiguration = builder.Configuration;

        var key = Encoding.UTF8.GetBytes(builder.Configuration["ApplicationSettings:Secret"]);

        services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = false;
                o.SaveToken = true;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey =
                        new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    RequireExpirationTime = false,
                    ClockSkew = TimeSpan.Zero
                };
            });

        return services;
    }

    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services
            .AddScoped<IIdentityService, IdentityService>()
           .AddScoped<IAdminService, AdminService>()
            .AddScoped<IJwtService, JwtService>();

        return services;
    }

    public static IServiceCollection AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "RidersBook API", Version = "v1" });
        });

        return services;
    }
}