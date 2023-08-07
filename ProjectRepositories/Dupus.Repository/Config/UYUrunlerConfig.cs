using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities.Dupus.Entity.Models;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYUrunlerConfig : IEntityTypeConfiguration<UYUrunler>
    {
        public void Configure(EntityTypeBuilder<UYUrunler> builder)
        {
            builder.HasKey("UrunID");
        }
    }
}
