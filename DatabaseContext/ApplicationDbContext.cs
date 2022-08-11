using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DatabaseContext
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }


        public DbSet<Motorcycle> Motorcycle { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<OwnerAddress> OwnerAddress { get; set; }
    }
}
