using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PByarizaBakimAciklamasi
{
    public short ArizaBakimAciklamaId { get; set; }

    public string? ArizaBakimKodu { get; set; }

    public string? ArizaBakimAciklamasi { get; set; }

    public short? ArizaBakimCinsiId { get; set; }

    public virtual PByarizaBakimCinsi? ArizaBakimCinsi { get; set; }

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();
}
