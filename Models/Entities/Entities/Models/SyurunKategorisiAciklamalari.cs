using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SyurunKategorisiAciklamalari
{
    public int UrunKategorisiId { get; set; }

    public int DilId { get; set; }

    public string? UrunKategorisiAdi { get; set; }

    public string? UrunKategorisiAciklamasi { get; set; }

    public virtual Pdil Dil { get; set; } = null!;

    public virtual UyurunKategorisi UrunKategorisi { get; set; } = null!;
}
