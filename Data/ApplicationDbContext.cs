using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FixtureManagementBlazor.Models;

namespace FixtureManagementBlazor.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Person> Person { get; set; }
    public DbSet<Pitch> Pitch { get; set; }
    public DbSet<Team> Team { get; set; }

    public DbSet<Fixture> Fixture { get; set; }
    public DbSet<FixtureAllocation> FixtureAlloctation { get; set; }
    public DbSet<TeamContact> TeamContact { get; set; }
    public DbSet<Booking> Booking { get; set; }


}
