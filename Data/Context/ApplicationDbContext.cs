using boilerplate_aspnet.Models;
using Microsoft.EntityFrameworkCore;

namespace boilerplate_aspnet.Data.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<User> users { get; set; }
}

