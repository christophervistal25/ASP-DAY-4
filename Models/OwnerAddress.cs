namespace API.Models
{
    public class OwnerAddress :BaseEntity
    {
        public int OwnerId { get; set; }
        public string Address { get; set; }
    }
}
 