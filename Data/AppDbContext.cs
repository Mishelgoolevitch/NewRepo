using CarReduserBlazer.Data;
namespace CarReduserBlazer.Data
{
   
    using Microsoft.EntityFrameworkCore;
    using CarReduserBlazer.Data;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Reducer> Reducers { get; set; }
    }

    public class Reducer
    {
        public int Id { get; set; } // Добавьте идентификатор
        public string? Type { get; set; }
        public string? Name { get; set; }
        public int NumberOfWheels { get; set; }
        public double GearRatio { get; set; }
        public double InputTorque { get; set; }
        public double OutputTorque { get; set; }
    }
}
