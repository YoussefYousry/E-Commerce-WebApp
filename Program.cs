using E_Comm.Constracts;
using E_Comm.Extensions;
using E_Comm.Models;
using E_Comm.Reposiotry;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.Cors;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionStrings = builder.Configuration.GetConnectionString("sqlConnection");
builder.Services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlServer(connectionStrings));

//void ConfigureServices(IServiceCollection services)
//    => services.AddDbContext<RepositoryContext>();



//builder.Services.AddScoped<IUsresRepository, UsersRepository>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IRepositoryBase<Users>, UsersRepository>();
//builder.Services.AddScoped<IRepositoryProduct, RepositoryProduct>();
builder.Services.AddScoped<IRepositoryBase<Product>, RepositoryProduct>();
builder.Services.AddScoped<IRepositoryBase<Cart>, RepositoryCart>();
builder.Services.AddScoped<IRepositoryCart, RepositoryCart>();
builder.Services.AddScoped<IAuthenticationManager,AuthenticationManager>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.ConfigureCors(); // Using CORS Extensions
builder.Services.AddAuthentication(); // identity
builder.Services.ConfigureIdentity(); // identity

builder.Services.ConfigureJWT(builder.Configuration); // JWT TOKEN

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy"); //CORS
app.UseHttpsRedirection();

app.UseAuthentication(); // JWT and identity
app.UseAuthorization();

app.MapControllers();

app.Run();
