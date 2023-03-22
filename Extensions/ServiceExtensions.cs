using E_Comm.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace E_Comm.Extensions
{

    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options => // properties using linq 
            {
        options.AddPolicy("CorsPolicy", builder =>
         builder.WithOrigins("http://localhost:3000" , "http://localhost:3001   ") // to be more restrictive we can use ->> WithOrigins("https://example.com")
         .AllowAnyMethod() // We can use any methods (POST/GET/UPDATE) --> WithMethods("POST","GET")
         .AllowAnyHeader()); // --> WithHeaders("accept", "content-type")
            });
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<Users>(o =>
          {
              o.Password.RequireDigit = true;
              o.Password.RequireLowercase = true;
              o.Password.RequireUppercase = true;
              o.Password.RequireNonAlphanumeric = false;
              o.Password.RequiredLength = 10;
              o.User.RequireUniqueEmail = true;
          });
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole),
                builder.Services);
            builder.AddEntityFrameworkStores<RepositoryContext>()
                .AddDefaultTokenProviders();
        }
        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var JwtSettings = configuration.GetSection("JwtSettings"); // FROM appsettings.json
            var secretKey = Environment.GetEnvironmentVariable("SECRET");

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, // Actual server is created a token
                    ValidateAudience = true, // receiver is a valid recipient
                    ValidateLifetime = true, // token not expired
                    ValidateIssuerSigningKey = true, // trusted server

                    ValidIssuer = JwtSettings.GetSection("validIssuer").Value,
                    ValidAudience = JwtSettings.GetSection("validAudience").Value,
                    IssuerSigningKey = new
                    SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });
        }
        public static IQueryable<Product> Search(this IQueryable<Product> products, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return products;
            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return products.Where(e => e.Name!.ToLower().Contains(lowerCaseTerm));
        }
    }
}
