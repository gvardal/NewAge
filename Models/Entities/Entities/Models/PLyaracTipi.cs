using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PLyaracTipi
{
    public byte AracTipId { get; set; }

    public string? AracTipi { get; set; }

    public string? Resim { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual ICollection<Lyaraclar> Lyaraclars { get; set; } = new List<Lyaraclar>();
}
