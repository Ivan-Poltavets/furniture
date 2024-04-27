using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using TileShop.API;
using TileShop.Domain.Entities;
using TileShop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddServices(builder.Configuration);
builder.Services.AddRepositories();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdmin",
        policy => policy.RequireClaim(ClaimTypes.Role, UserRole.Admin.ToString()));
    options.AddPolicy("RequireOwner",
            policy => policy.RequireClaim(ClaimTypes.Role, UserRole.Owner.ToString()));
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => 
    { 
        options.SwaggerEndpoint("/swagger/V1/swagger.json", "ClientApp");
    });
}

using(var scope = app.Services.CreateScope())
{
    var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    if (!appContext.Database.GetService<IRelationalDatabaseCreator>().Exists())
    {
        try
        {
            appContext.Database.EnsureCreated();
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Migration has failes: {ex.Message}");
        }
    }

    var admin = appContext.User.FirstOrDefault(x => x.Id == 1);
    if (admin is null)
    {
        DatabaseSeed.SeedData(appContext);
        DatabaseSeed.AddCategories(appContext);
        DatabaseSeed.AddProducts(appContext);
    }
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();