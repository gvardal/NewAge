using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dupus.Entity.Models.ProductionManagment;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYIsEmriDurumuConfig : IEntityTypeConfiguration<WorkOrderStatus>
    {
        public void Configure(EntityTypeBuilder<WorkOrderStatus> builder)
        {
            builder.HasKey(k => k.IsEmriDurumId);
        }
    }
}
