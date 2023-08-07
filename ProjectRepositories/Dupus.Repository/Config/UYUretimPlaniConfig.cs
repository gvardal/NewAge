using Models.Entities.Dupus.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYUretimPlaniConfig : IEntityTypeConfiguration<UYUretimPlani>
    {
        public void Configure(EntityTypeBuilder<UYUretimPlani> builder)
        {
            builder.HasKey(p => p.UretimPlaniID);
        }
    }
}
