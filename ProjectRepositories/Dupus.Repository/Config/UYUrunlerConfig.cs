using Dupus.Entity.Models.ProductionManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYUrunlerConfig : IEntityTypeConfiguration<Productions>
    {
        public void Configure(EntityTypeBuilder<Productions> builder)
        {
            builder.HasKey("UrunID");
        }
    }
}
