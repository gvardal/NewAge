using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIihaberBandiTuru
{
    public byte HaberBandiTuruId { get; set; }

    public string? HaberBandiTuru { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<IihaberBandi> IihaberBandis { get; set; } = new List<IihaberBandi>();
}
