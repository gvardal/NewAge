using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyurunTuru
{
    public string UrunTuruId { get; set; } = null!;

    public string? UrunTuru { get; set; }

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();
}
