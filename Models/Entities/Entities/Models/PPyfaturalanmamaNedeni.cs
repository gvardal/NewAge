using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PPyfaturalanmamaNedeni
{
    public byte FaturalanmamaNedeniId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydis { get; set; } = new List<PyprojeCalismaKaydi>();
}
