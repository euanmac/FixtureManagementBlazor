using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FixtureManagementBlazor.Models;

namespace FixtureManagementBlazor.Data;

//Migration steps
//
//Copy from production into dev database (as security tables are required from new)
//Exprort data as SQL statements and play into non-prod DB
//Update fixture date string to remove time component (Date Only)
//Update fixture allocation start to remove date aspect (Time Only)


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
