using API.DatabaseContext;
using API.Models;

namespace API.DatabaseSeeder
{
    public class MotorcycleSeeder : ISeeder
    {
        private readonly ApplicationDbContext _context;

        public MotorcycleSeeder(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void Seed()
        {
            DateTime now = DateTime.Now;

            if(!this._context.Motorcycle.Any())
            {
                var motorcycles = new List<Motorcycle>();
                motorcycles.Add(new Motorcycle
                {
                    Name = "XRM 125",
                    Description = "New Release Honda XRM 125",
                    Power = 250,
                    Color = "Black",
                    BrandName = Models.Enums.Brand.Kawasaki,
                    ChasisNumber = new Random().Next(0, 9999).ToString(),
                    CreatedAt = now,
                    UpdatedAt = now,
                    MotorcycleOwner = new Owner()
                    {
                        FirstName = "Christopher",
                        MiddleName = "Platino",
                        LastName = "Vistal",
                        CreatedAt = now,
                        UpdatedAt = now,
                    },

                });

                motorcycles.Add(new Motorcycle
                {
                    Name = "XRM 150",
                    Description = "New Release Honda XRM 150",
                    Power = 250,
                    Color = "Green",
                    BrandName = Models.Enums.Brand.Kawasaki,
                    ChasisNumber = new Random().Next(0, 9999).ToString(),
                    CreatedAt = now,
                    UpdatedAt = now,
                    MotorcycleOwner = new Owner()
                    {
                        FirstName = "Johnny",
                        MiddleName = "Platino",
                        LastName = "Dua",
                        CreatedAt = now,
                        UpdatedAt = now,
                    },

                });

                motorcycles.Add(new Motorcycle
                {
                    Name = "XRM 170",
                    Description = "New Release Honda XRM 170",
                    Power = 255,
                    Color = "Gold",
                    BrandName = Models.Enums.Brand.Kawasaki,
                    ChasisNumber = new Random().Next(0, 9999).ToString(),
                    CreatedAt = now,
                    UpdatedAt = now,
                    MotorcycleOwner = new Owner()
                    {
                        FirstName = "Zak",
                        MiddleName = "Platino",
                        LastName = "Monts",
                        CreatedAt = now,
                        UpdatedAt = now,
                    },
                });

                this._context.AddRangeAsync(motorcycles);
                this._context.SaveChanges();
            }
        }
    }
}
