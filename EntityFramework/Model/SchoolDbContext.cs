using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace EntityFramework.Model
{
    public class SchoolDbContext : DbContext
    {
        public  SchoolDbContext() : base()
        {

        }
        public DbSet<customer> Customer { get; set; }
        public DbSet<orderh> Orderh { get; set; }
        public DbSet<orderid> Orderid { get; set; }
        public DbSet<product> Product { get; set; }    

        protected override void OnConfiguring(DbContextOptionsBuilder optionaBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Environment.CurrentDirectory, "appSettings.json"))
                .Build();
            optionaBuilder.UseNpgsql(config["Connectionstrings:ConStr1"])
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            AppContext.SetSwitch("Npgsql.EnableLegaryTimestampBehavior",true);
        }
        public SchoolDbContext(DbContextOptions<SchoolDbContext>options)
            : base(options)
        {
            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
