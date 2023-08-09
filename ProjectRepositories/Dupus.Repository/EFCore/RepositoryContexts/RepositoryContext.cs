using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Dupus.Entity.Models.ProductionManagment;
using Dupus.Entity.Models.SalesManagment;

namespace Dupus.Repository.EFCore.RepositoryContexts
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Productions> UYUrunler { get; set; }
        public DbSet<WorkOrder> UYIsEmri { get; set; }
        public DbSet<WorkOrderRoute> UYIsEmriRotasi { get; set; }
        public DbSet<WorkOrderStatus> UYIsEmriDurumu { get; set; }
        public DbSet<LocationsType> UYKonumTuru { get; set; }
        public DbSet<Locations> UYKonum { get; set; }
        public DbSet<ProductionPlan> UYUretimPlani { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
