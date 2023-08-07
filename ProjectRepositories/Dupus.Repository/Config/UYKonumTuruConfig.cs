using Models.Entities.Dupus.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectRepositories.Dupus.Repository.Config
{
    internal class UYKonumTuruConfig : IEntityTypeConfiguration<UYKonumTuru>
    {
        public void Configure(EntityTypeBuilder<UYKonumTuru> builder)
        {
            builder.HasKey(p => p.KonumTuruID);
        }
    }
}
