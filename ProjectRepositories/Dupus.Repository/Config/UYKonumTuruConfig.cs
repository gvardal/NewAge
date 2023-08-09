using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dupus.Entity.Models.ProductionManagment;

namespace ProjectRepositories.Dupus.Repository.Config
{
    internal class UYKonumTuruConfig : IEntityTypeConfiguration<LocationsType>
    {
        public void Configure(EntityTypeBuilder<LocationsType> builder)
        {
            builder.HasKey(p => p.KonumTuruID);
        }
    }
}
