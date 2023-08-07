using Models.Entities.Dupus.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYIsEmriRotasiConfig : IEntityTypeConfiguration<UYIsEmriRotasi>
    {
        public void Configure(EntityTypeBuilder<UYIsEmriRotasi> builder)
        {
            builder.HasKey(p => p.IsEmriRotaID);    
        }
    }
}
