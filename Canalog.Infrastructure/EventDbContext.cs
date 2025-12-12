using Canalog.Domain;
using Canalog.Domain.Models;
using Canalog.Infrastructure.Seed;
using Microsoft.EntityFrameworkCore;

namespace Canalog.Infrastructure;

public class EventDbContext : DbContext
{
    public EventDbContext(DbContextOptions<EventDbContext> opt) : base(opt)
    {

    }

    public DbSet<Event> Events { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Options> Options { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<UiColorScheme> UiColorSchemes { get; set; }
    public DbSet<EventColorScheme> EventColorSchemes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.SeedThemes();
    }

}