using API.Models.Enums;

namespace API.Models
{
    public class Motorcycle : BaseEntity
    {
       
        public string Name { get; set; }

        public string Description { get; set; }

        public int Power { get; set; }
           
        public string Color { get; set; }

        public Brand BrandName { get; set; }

        public string ChasisNumber { get; set; }

        public Owner MotorcycleOwner { get; set; }
    }

}
