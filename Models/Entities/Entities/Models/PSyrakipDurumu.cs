using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSyrakipDurumu
{
    public byte DurumId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Syrakipler> Syrakiplers { get; set; } = new List<Syrakipler>();
}
