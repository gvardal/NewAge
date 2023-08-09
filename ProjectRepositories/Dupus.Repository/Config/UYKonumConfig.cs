using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dupus.Entity.Models.ProductionManagment;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYKonumConfig : IEntityTypeConfiguration<Locations>
    {
        public void Configure(EntityTypeBuilder<Locations> builder)
        {
            builder.HasKey(p => p.KonumID);
        }
    }
}
