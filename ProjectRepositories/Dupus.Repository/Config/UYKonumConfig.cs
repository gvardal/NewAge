using Models.Entities.Dupus.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYKonumConfig : IEntityTypeConfiguration<UYKonum>
    {
        public void Configure(EntityTypeBuilder<UYKonum> builder)
        {
            builder.HasKey(p => p.KonumID);
        }
    }
}
