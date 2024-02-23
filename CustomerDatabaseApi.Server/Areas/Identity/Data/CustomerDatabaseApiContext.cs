using CustomerDatabaseApi.Server.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CustomerDatabaseApi.Server.Models;

namespace CustomerDatabaseApi.Server.Data;

public class CustomerDatabaseApiContext : IdentityDbContext<CustomerDatabaseUser>
{
    public DbSet<CustomerInfo> customerInfo { get; set; }
    public DbSet<CustomerCalls> customerCalls { get; set; }
    public CustomerDatabaseApiContext(DbContextOptions<CustomerDatabaseApiContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<CustomerDatabaseApi.Server.Models.CustomerInfo> CustomerInfo { get; set; } = default!;
}
