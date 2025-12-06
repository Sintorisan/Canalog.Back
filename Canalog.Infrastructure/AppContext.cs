using Canalog.Domain;
using Canalog.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Canalog.Infrastructure;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppContext> opt) : base(opt)
    {

    }

    public DbSet<Event> Events { get; set; }
    public DbSet<Options> Options { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<User> Users { get; set; }
}