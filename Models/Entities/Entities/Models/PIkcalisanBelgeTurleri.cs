using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkcalisanBelgeTurleri
{
    public byte BelgeTuruId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<IkcalisanBelgeleri> IkcalisanBelgeleris { get; set; } = new List<IkcalisanBelgeleri>();
}
