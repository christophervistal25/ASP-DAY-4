using API.DatabaseContext;
using API.DatabaseSeeder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

// Inject ApplicationDatabaseContext in WebApplication
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<MotorcycleSeeder>();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if(args.Length == 1 && args[0].ToLower() == "seed")
{


    SeedData(app);
}

void SeedData(IHost app)
{
    var scopeFactory = app.Services.GetService<IServiceScopeFactory>();

    using( var scope = scopeFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<MotorcycleSeeder>();
        service.Seed();
    }
    
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{   
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
