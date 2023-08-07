using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PByarizaBakimCinsi
{
    public short ArizaBakimCinsiId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();

    public virtual ICollection<PByarizaBakimAciklamasi> PByarizaBakimAciklamasis { get; set; } = new List<PByarizaBakimAciklamasi>();
}
