using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UysarfMalzemeZimmet
{
    public int SarfMalzemeZimmetId { get; set; }

    public int? UrunId { get; set; }

    public int? CalisanId { get; set; }

    public DateTime? TeslimEdilmeTarihi { get; set; }

    public DateTime? TeslimAlmaTarihi { get; set; }

    public decimal? TeslimEdilenMiktar { get; set; }

    public int? TeslimEdilenKonumId { get; set; }

    public long? TeslimEdilenStokHareketId { get; set; }

    public decimal? TeslimAlinanMiktar { get; set; }

    public int? TeslimAlinanKonumId { get; set; }

    public long? TeslimAlinanStokHareketId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Uykonum? TeslimAlinanKonum { get; set; }

    public virtual UystokHareketi? TeslimAlinanStokHareket { get; set; }

    public virtual Uykonum? TeslimEdilenKonum { get; set; }

    public virtual UystokHareketi? TeslimEdilenStokHareket { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
