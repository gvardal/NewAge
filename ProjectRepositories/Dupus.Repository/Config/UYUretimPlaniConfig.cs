using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dupus.Entity.Models.ProductionManagment;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYUretimPlaniConfig : IEntityTypeConfiguration<ProductionPlan>
    {
        public void Configure(EntityTypeBuilder<ProductionPlan> builder)
        {
            builder.HasKey(p => p.UretimPlaniID);
        }
    }
}
