using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFyeFaturaOlcuBirimleri
{
    public string EFaturaKoduId { get; set; } = null!;

    public string? Aciklama { get; set; }

    public virtual ICollection<PolcuBirimleri> PolcuBirimleris { get; set; } = new List<PolcuBirimleri>();
}
