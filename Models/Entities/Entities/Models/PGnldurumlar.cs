using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PGnldurumlar
{
    public byte DurumId { get; set; }

    public string? DurumAciklama { get; set; }

    public string? IlgiliSurec { get; set; }

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlanis { get; set; } = new List<KyicTetkikPlani>();
}
