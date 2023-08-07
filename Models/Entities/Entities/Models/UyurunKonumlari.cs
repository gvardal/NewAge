using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunKonumlari
{
    public int UrunId { get; set; }

    public int KonumId { get; set; }

    public byte FirmaId { get; set; }

    public virtual PfirmaBilgisi Firma { get; set; } = null!;

    public virtual Uykonum Konum { get; set; } = null!;

    public virtual Uyurunler Urun { get; set; } = null!;
}
