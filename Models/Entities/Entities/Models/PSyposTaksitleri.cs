using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSyposTaksitleri
{
    public int PosTaksitId { get; set; }

    public int? PosId { get; set; }

    public int? TaksitSayisi { get; set; }

    public double? VadeOrani { get; set; }

    public decimal? MinimumTutar { get; set; }

    public virtual PSypo? Pos { get; set; }
}
