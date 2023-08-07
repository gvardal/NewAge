using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RymedikalMuayeneRandevulari
{
    public int MuayeneRandevuId { get; set; }

    public int? Hekim { get; set; }

    public DateTime? RandevuSaati { get; set; }

    public int? Calisan { get; set; }

    public string? TckimlikNo { get; set; }

    public string? Aciklama { get; set; }

    public short? MuayeneTipi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar? CalisanNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? HekimNavigation { get; set; }
}
