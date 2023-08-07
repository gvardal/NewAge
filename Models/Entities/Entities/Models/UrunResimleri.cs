using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UrunResimleri
{
    public long UrunResmiId { get; set; }

    public int? UrunId { get; set; }

    public string? ResimYolu { get; set; }

    public bool? AnaResim { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
