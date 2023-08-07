using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ksswotanalizi
{
    public int SwotanaliziId { get; set; }

    public short? KurumsalStratejiId { get; set; }

    public int? UrunId { get; set; }

    public string Aciklama { get; set; } = null!;

    public string? Swotturu { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual KskurumsalStratejiler? KurumsalStrateji { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
