using Dupus.Entity.Models.ProductionManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYIsEmriConfig : IEntityTypeConfiguration<WorkOrder>
    {
        public void Configure(EntityTypeBuilder<WorkOrder> builder)
        {
            builder.HasKey(p => p.IsEmriID);
        }
    }
}
