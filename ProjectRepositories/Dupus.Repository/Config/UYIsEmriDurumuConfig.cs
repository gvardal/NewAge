using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities.Dupus.Entity.Models;

namespace ProjectRepositories.Dupus.Repository.Config
{
    public class UYIsEmriDurumuConfig : IEntityTypeConfiguration<UYIsEmriDurumu>
    {
        public void Configure(EntityTypeBuilder<UYIsEmriDurumu> builder)
        {
            builder.HasKey(k => k.IsEmriDurumId);
        }
    }
}
