using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities.Dupus.Entity.Models;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYIsEmriConfig : IEntityTypeConfiguration<UYIsEmri>
    {
        public void Configure(EntityTypeBuilder<UYIsEmri> builder)
        {
            builder.HasKey(p => p.IsEmriID);
        }
    }
}
