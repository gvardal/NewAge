using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PLyaracMarkasi
{
    public short MarkaId { get; set; }

    public string? MarkaAdi { get; set; }

    public virtual ICollection<Lyaraclar> Lyaraclars { get; set; } = new List<Lyaraclar>();
}
