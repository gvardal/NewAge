using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PRyacilDurumKategorisi
{
    public short AcilDurumKategorisiId { get; set; }

    public string? Aciklama { get; set; }

    public bool? Aktif { get; set; }

    public virtual ICollection<RyacilDurumSenaryolari> RyacilDurumSenaryolaris { get; set; } = new List<RyacilDurumSenaryolari>();
}
