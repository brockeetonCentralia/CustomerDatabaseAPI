using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CustomerDatabaseApi.Server.Areas.Identity.Data;
using CustomerDatabaseApi.Server.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CustomerDatabaseApiContextConnection") ?? throw new InvalidOperationException("Connection string 'CustomerDatabaseApiContextConnection' not found.");

builder.Services.AddDbContext<CustomerDatabaseApiContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CustomerDatabaseUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<CustomerDatabaseApiContext>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        SeedData.EnsurePopulated(services).Wait();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database.");
    }
}

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
