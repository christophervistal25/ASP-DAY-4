using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DatabaseContext
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Motorcycle> Motorcycle { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<OwnerAddress> OwnerAddress { get; set; }
    }
}
