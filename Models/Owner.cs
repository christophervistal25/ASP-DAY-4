using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{

    public class Owner :BaseEntity
    {
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string? Suffix { get; set; }

        public int MotorcycleId { get; set; }

        [ForeignKey(nameof(MotorcycleId))]
        public Motorcycle? Motorcycle { get; set; }

        public static implicit operator Owner(HashSet<Owner> v)
        {
            throw new NotImplementedException();
        }
    }
}
