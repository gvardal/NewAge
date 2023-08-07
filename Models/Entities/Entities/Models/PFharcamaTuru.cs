using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFharcamaTuru
{
    public short HarcamaTuruId { get; set; }

    public string? Aciklama { get; set; }

    public int? HesapPlaniId { get; set; }

    public virtual FyhesapPlani? HesapPlani { get; set; }
}
