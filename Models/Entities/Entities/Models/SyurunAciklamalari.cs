using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SyurunAciklamalari
{
    public int UrunId { get; set; }

    public int DilId { get; set; }

    public string? UrunAdi { get; set; }

    public string? UrunAciklamasi { get; set; }

    public virtual Pdil Dil { get; set; } = null!;

    public virtual Uyurunler Urun { get; set; } = null!;
}
