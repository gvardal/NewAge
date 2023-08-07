using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PGnltanimlar
{
    public short TanimId { get; set; }

    public short? FirmaId { get; set; }

    public short? TanimGrubu { get; set; }

    public string? Tanim { get; set; }

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();
}
