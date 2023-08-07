using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFygenelGiderHesapPlani
{
    public short GenelGiderHesapPlaniId { get; set; }

    public byte? GenelGiderId { get; set; }

    public int? HesapPlaniId { get; set; }

    public virtual PFygenelGiderler? GenelGider { get; set; }

    public virtual FyhesapPlani? HesapPlani { get; set; }
}
