using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DatabaseContext
{
    public interface IApplicationDbContext
    {
        DbSet<Motorcycle> Motorcycle { get; set; }
        
        DbSet<Owner> Owner { get; set; }

        DbSet<OwnerAddress> OwnerAddress { get; set; }

    }
}
