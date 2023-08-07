using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PByarizaBakimTuru
{
    public byte ArizaBakimTuruId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();
}
