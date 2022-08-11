using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Index(nameof(LastName))]
    [Index(nameof(motorcycle))]
    public class Owner :BaseEntity
    {
        public Owner()
        {
            Addresses = new HashSet<OwnerAddress>();
        }
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string? Suffix { get; set; }
           
        public long ? OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public Motorcycle motorcycle { get; set; }

        public ICollection<OwnerAddress> Addresses { get; set; }

    }
}
